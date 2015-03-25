using UnityEngine;
using System.Collections;
using System.IO;

namespace LuKye.Core
{
	/**
	 * LSharpDll
	 * LSharp scripts dlls base class
	 */ 
	public class LSharpDll
	{
		private string _name;
		public string Name {
			get {return this._name;}
		}

		// dll
		private TextAsset _dllTextAsset;
		public TextAsset DllTextAsset {
			get {return this._dllTextAsset;}
		}

		// memory stream dll 
		private MemoryStream _dllMemoryStream;
		public MemoryStream DllMemoryStream {
			get {return this._dllMemoryStream;}
		}

		// pdb
		private TextAsset _pdbTextAsset;
		public TextAsset PdbTextAsset {
			get {return this._pdbTextAsset;}
		}

		// memory stream pdb 
		private MemoryStream _pdbMemoryStream;
		public MemoryStream PdbMemoryStream {
			get {return this._pdbMemoryStream;}
		}

		// ctor
		public LSharpDll(string name) 
		{
			this._name = name;

			var dllName = name + ".dll";
			var pdbName = name + ".pdb";

			var lSharpEnvironment = LSharpManager.Instance.LSharpEnviorment;
			var dll = this._dllTextAsset = Resources.Load("LSharpDlls/" + dllName) as TextAsset;
			var pdb = this._pdbTextAsset = Resources.Load("LSharpDlls/" + pdbName) as TextAsset;
			var dllMS = this._dllMemoryStream = new MemoryStream(dll.bytes);
			var pdbMS = this._pdbMemoryStream = new MemoryStream(pdb.bytes);
		}
	}
}
