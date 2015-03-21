using UnityEngine;
using System.Collections;

namespace LuKye.Core
{
	/**
	 * LSharpDll
	 * LSharp scripts dlls base class
	 */ 
	public class LSharpDll
	{
		// dll
		private TextAsset _dllTextAsset;
		public TextAsset DllTextAsset {
			get {
				return this._dllTextAsset;
			}
			set {
				this._dllTextAsset = value;
			}
		}

		// pdb
		private TextAsset _pdbTextAsset;
		public TextAsset PdbTextAsset {
			get {
				return this._pdbTextAsset;
			}
			set {
				this._pdbTextAsset = value;
			}
		}
	}
}
