using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace LuKye.Core
{
	/**
	 * AccelerationManager
	 * A manager of acceleration 
	 * 
	 * Notes
	 * Unity3D中重量的取值范围是 -1.0 到 +1.0.
	 * X轴：home按键在下手机面朝天向右旋转90度重力分量为+1.0 向左旋转90度重力分量为-1.0
	 * Y轴：home按键在上手机背朝自己重力分量为+1.0 home按键在下手机面朝自己重力分量为-1.0
	 * Z轴：手机面朝地面重力分量为+1.0 手机面朝天空重力分量为-1.0	
	 */	
	public class AccelerationManager : ManagerGO<AccelerationManager>
	{
		ArrayList delegates;
		Vector3 accelerationBefore;
		Vector3 accelerationNow;
		public float checkInterval = 0.3f;

		/// <summary>
		/// Update this instance.
		/// </summary>
		void Update()
		{
			// check
			this.LKCheck();			
		}

		#region custom functions
		/// <summary>
		/// LKs the start.
		/// </summary>
		public void LKStart()
		{
			this.delegates = new ArrayList();
			this.accelerationBefore = new Vector3();
			this.accelerationNow = new Vector3();
		}

		/// <summary>
		/// LKs the register.
		/// </summary>
		/// <param name="accelerationDelegate">Acceleration delegate.</param>
		public void LKRegister(UIBase accelerationDelegate)
		{
			this.delegates.Add(accelerationDelegate);
		}

		/// <summary>
		/// LKs the un register.
		/// </summary>
		/// <param name="accelerationDelegate">Acceleration delegate.</param>
		public void LKUnRegister(UIBase accelerationDelegate)
		{
			this.delegates.Remove(accelerationDelegate);
		}

		/// <summary>
		/// LKs the check.
		/// </summary>
		void LKCheck()
		{
			// delegates
			if (!(this.delegates.Count > 0))
				return;
		
			// before acceleration
			this.accelerationBefore = this.accelerationNow;
		
			// now acceleration
			this.accelerationNow = Input.acceleration;

			// dispatch
			this.LKDispatch();
		}

		/// <summary>
		/// LKs the dispatch.
		/// </summary>
		void LKDispatch()
		{
			Vector3 accelerationBefore = this.accelerationBefore;
			Vector3 accelerationNow = this.accelerationNow;
			Vector3 accelerationOff = accelerationNow - accelerationBefore;

			// if equal
			if (accelerationOff.Equals(Vector3.zero))
				return;				

			// data
			//		float x = accelerationOff.x;
			//		float y = accelerationOff.y;
			float zero = 0.0f;
			float z = accelerationNow.z;
			float x = z > zero ? -accelerationNow.x : accelerationNow.x;
			float y = z > zero ? -accelerationNow.y : accelerationNow.y;

			// do
			ArrayList delegates = this.delegates;
			foreach (UIBase accelerationDelegate in delegates) {		
				// left
				if (x < zero)
					accelerationDelegate.LKOnAccelerationLeft(Mathf.Abs(x), accelerationBefore, accelerationNow);

				// right
				if (x > zero)
					accelerationDelegate.LKOnAccelerationRight(Mathf.Abs(x), accelerationBefore, accelerationNow);

				// up
				if (y > zero)
					accelerationDelegate.LKOnAccelerationUp(Mathf.Abs(y), accelerationBefore, accelerationNow);

				// down
				if (y < zero)
					accelerationDelegate.LKOnAccelerationDown(Mathf.Abs(y), accelerationBefore, accelerationNow);
			}
		}
		#endregion
	}
}
