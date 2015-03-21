using UnityEngine;
using System.Collections;

namespace LuKye.Core
{
	/**
	 * LSharpEnviorment
	 */ 
	public class LSharpEnviorment : CLRSharp.CLRSharp_Environment
	{
		public LSharpEnviorment(LSharpLogger logger)
			: base(logger)
		{
		}
	}
}
