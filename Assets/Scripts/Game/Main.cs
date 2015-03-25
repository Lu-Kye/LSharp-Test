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
		LSharpManager.Instance.SetUp();

		var dll = LSharpManager.Instance.GetDllByName(LSharpManager.DLLS.LSharpScripts);
		var className = "LSharpScripts.Test";
		var cls = new LSharpClass(dll, className);
		var obj = cls.CallMethodCtor();
	}
}
