using UnityEngine;
using System.Collections;

namespace LuKye.Core
{
	public interface AccelerationHandler
	{

		/// <summary>
		/// LKs the on acceleration left.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		void LKOnAccelerationLeft(float value, Vector3 accelerationBefore, Vector3 accelerationNow);
	
		/// <summary>
		/// LKs the on acceleration right.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		void LKOnAccelerationRight(float value, Vector3 accelerationBefore, Vector3 accelerationNow);
	
		/// <summary>
		/// LKs the on acceleration up.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		void LKOnAccelerationUp(float value, Vector3 accelerationBefore, Vector3 accelerationNow);
	
		/// <summary>
		/// LKs the on acceleration down.
		/// </summary>
		/// <param name="value">Value.</param>
		/// <param name="accelerationBefore">Acceleration before.</param>
		/// <param name="accelerationNow">Acceleration now.</param>
		void LKOnAccelerationDown(float value, Vector3 accelerationBefore, Vector3 accelerationNow);
	}
}
