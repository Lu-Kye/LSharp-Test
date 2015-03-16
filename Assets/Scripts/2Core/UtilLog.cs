using UnityEngine;
using System.Collections;

namespace LuKye.Core
{
	/**
	 * UtilLog
	 * A log class 
	 */ 
	public class UtilLog
	{
		/// <summary>
		/// Log the specified msg.
		/// </summary>
		/// <param name="msg">Message.</param>
		public static void Log(string msg)
		{
			Debug.Log("[DEBUG] " + msg);
		}

		/// <summary>
		/// Logs the error msg.
		/// </summary>
		/// <param name="msg">Message.</param>
		public static void LogE(string msg)
		{
			Debug.LogError("[ERROR] " + msg);
		}
	}
}