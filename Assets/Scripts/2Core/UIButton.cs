using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

namespace LuKye.Core
{
	public class UIButton : UIBase
	{
		protected Button button;

		/// <summary>
		/// Start this instance.
		/// </summary>
		protected virtual void Start()
		{
			Button button = this.button = this.gameObject.GetComponent<Button>();
			button.onClick.AddListener(this.LKOnClick);
		}

		/// <summary>
		/// LKs the on click.
		/// </summary>
		protected virtual void LKOnClick()
		{
		}
	}
}
