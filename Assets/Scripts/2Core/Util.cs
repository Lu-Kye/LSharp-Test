using UnityEngine;
using System.Collections;

namespace LuKye.Core
{
	/**
	 * Util
	 * A tool class which is used to deal with some common operations
	 */ 
	public class Util
	{
		/// <summary>
		/// Randoms the array.
		/// Get a random element from array
		/// </summary>
		/// <returns>The array.</returns>
		/// <param name="array">Array.</param>
		public static object RandomArray(object[] array)
		{
			int length = array.Length;
			int index = Random.Range(0, length - 1);
			return array[index];
		}
	}
}