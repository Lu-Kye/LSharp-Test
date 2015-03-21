using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler
{

    public int MovementRange = 100;
    public Image TargetImage = null;
    public Image BackgroundImage = null;

    public enum AxisOption
    {                                                    // Options for which axes to use                                                     
        Both,                                                                   // Use both
        OnlyHorizontal,                                                         // Only horizontal
        OnlyVertical                                                            // Only vertical
    }

    public AxisOption axesToUse = AxisOption.Both;   // The options for the axes that the still will use
    public string horizontalAxisName = "Horizontal";// The name given to the horizontal axis for the cross platform input
    public string verticalAxisName = "Vertical";    // The name given to the vertical axis for the cross platform input 

    private Vector3 startPos;
    private bool useX;                                                          // Toggle for using the x axis
    private bool useY;                                                          // Toggle for using the Y axis
    private CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis;               // Reference to the joystick in the cross platform input
    private CrossPlatformInputManager.VirtualAxis verticalVirtualAxis;                 // Reference to the joystick in the cross platform input

    private Vector2 pointBegin = new Vector2();

    void OnEnable()
    {
        startPos = TargetImage.transform.position;
        CreateVirtualAxes();
    }

    private void UpdateVirtualAxes(Vector3 value)
    {
        //var delta = startPos - value;
        var begin = new Vector3(pointBegin.x, pointBegin.y);
        var delta = begin - value;
        delta.y = -delta.y;
        delta /= MovementRange;
        if (useX)
            horizontalVirtualAxis.Update(-delta.x);

        if (useY)
            verticalVirtualAxis.Update(delta.y);

    }

    private void CreateVirtualAxes()
    {
        // set axes to use
        useX = (axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal);
        useY = (axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical);

        // create new axes based on axes to use
        if (useX)
            horizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
        if (useY)
            verticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
    }


    public void OnDrag(PointerEventData data)
    {

        /*
        Vector3 newPos = Vector3.zero;

        if (useX) {
            int delta = (int) (data.position.x - startPos.x);
            delta = Mathf.Clamp(delta,  - MovementRange,  MovementRange);
            newPos.x = delta;
        }

        if (useY)
        {
            int delta = (int)(data.position.y - startPos.y);
            delta = Mathf.Clamp(delta, -MovementRange, MovementRange);
            newPos.y = delta;
        }
        */

        Vector2 offsetPos = data.position;
        if(Vector2.Distance(offsetPos,pointBegin) > MovementRange)
        {
            var direct = offsetPos - pointBegin;
            offsetPos = pointBegin + direct.normalized * MovementRange;
        }

        Vector3 offset = new Vector3(offsetPos.x, offsetPos.y);

        TargetImage.transform.position = offset;
        UpdateVirtualAxes(offset);
    }


    public void OnPointerUp(PointerEventData data)
    {
        //transform.position = startPos;
        //UpdateVirtualAxes(startPos);

        iTween.MoveTo(TargetImage.gameObject, startPos, 0.1f);
        iTween.MoveTo(BackgroundImage.gameObject, startPos, 0.1f);

        if (useX)
            horizontalVirtualAxis.Update(0);

        if (useY)
            verticalVirtualAxis.Update(0);
    }


    public void OnPointerDown(PointerEventData data)
    {
        pointBegin = data.position;
        TargetImage.transform.position = pointBegin;
        BackgroundImage.transform.position = pointBegin;
    }

    void OnDisable()
    {
        // remove the joysticks from the cross platform input
        if (useX)
        {
            horizontalVirtualAxis.Remove();
        }
        if (useY)
        {
            verticalVirtualAxis.Remove();
        }
    }
}
