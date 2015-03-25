using System.Reflection;
using System.Collections.Generic;

namespace LuKye.Core
{
	/**
	 * LSharpManager
	 * Control and Config how many dlls should be loaded
	 */
	public class LSharpManager : Manager<LSharpManager>
	{
		public static class DLLS
		{
			public static string LSharpScripts = "LSharpScripts";
			public static string HotFixCode = "HotFixCode";
		};

		private List<LSharpDll> _dlls = new List<LSharpDll>();
		private LSharpEnviorment _lSharpEnviorment;
		public LSharpEnviorment LSharpEnviorment {
			get {return this._lSharpEnviorment;}
		}
		private LSharpThreadContext _lSharpThreadContext;
		public LSharpThreadContext LSharpThreadContext {
			get {return this._lSharpThreadContext;}
		}

		/// <summary>
		/// LoadDlls
		/// load all dll from config
		/// </summary>
		private void LoadDlls()
		{
			var fields = typeof(DLLS).GetFields();
			foreach (var field in fields) {
				this.LoadDll(field.Name);
			}
		}
		
		// load dll by name
		public void LoadDll(string name) 
		{
			var dll = new LSharpDll(name);
			this._lSharpEnviorment.LoadModule(
				dll.DllMemoryStream, 
				dll.PdbMemoryStream, 
				new Mono.Cecil.Pdb.PdbReaderProvider()
			);
			this._dlls.Add(dll);
		}
		
		/// <summary>
		/// Sets up.
		/// Init some data or attributes
		/// </summary>
		public override void SetUp()
		{
			// base
			base.SetUp();
			
			// init
			this._lSharpEnviorment = new LSharpEnviorment(LSharpLogger.Instance);
			this._lSharpThreadContext = new LSharpThreadContext(this._lSharpEnviorment);
			
			// load
			this.LoadDlls();
		}
		
		// get lsharp dll by dll name
		public LSharpDll GetDllByName(string name) 
		{
			foreach (var dll in this._dlls) {
				if (dll.Name == name)
					return dll;
			}
			return null;
		}
	}
}
