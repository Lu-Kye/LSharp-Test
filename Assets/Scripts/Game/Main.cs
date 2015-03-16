using UnityEngine;
using System.Collections;
using LuKye.Core;

/**
 * Main
 * The Game Entry
 */ 
public class Main : UIBase
{
	/// <summary>
	/// Awake this instance.
	/// The initations of game should be done here
	/// </summary>
	void Awake()
	{
		// init managers
		LSharpManager.Instance.SetUp();
		AccelerationManager.Instance.SetUp();
	}
}
