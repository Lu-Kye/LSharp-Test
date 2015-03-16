using UnityEngine;
using System.Collections;

namespace LuKye.Core
{
	/**
	 * UIBase
	 * The base class of all ui (such as buttons, images, etc)
	 */ 
	public class UIBase : MonoBehaviour
	{
		#region acceleration functions
		/// <summary>
		/// LKs the on acceleration left.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		public virtual void LKOnAccelerationLeft(float value, Vector3 accelerationBefore, Vector3 accelerationNow)
		{
		}
		
		/// <summary>
		/// LKs the on acceleration right.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		public virtual void LKOnAccelerationRight(float value, Vector3 accelerationBefore, Vector3 accelerationNow)
		{
		}
		
		/// <summary>
		/// LKs the on acceleration up.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		public virtual void LKOnAccelerationUp(float value, Vector3 accelerationBefore, Vector3 accelerationNow)
		{
		}
		
		/// <summary>
		/// LKs the on acceleration down.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		public virtual void LKOnAccelerationDown(float value, Vector3 accelerationBefore, Vector3 accelerationNow)
		{
		}
		#endregion
	}
}
