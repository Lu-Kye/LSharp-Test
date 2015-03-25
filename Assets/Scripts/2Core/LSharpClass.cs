namespace LuKye.Core
{
	/**
	 * LSharpClass
	 * The LSharp class which is loaded from dlls
	 */ 
	public class LSharpClass
	{
		private LSharpDll _dll;
		private string _name;
		private CLRSharp.ICLRType _iCLRType;

		// ctor
		public LSharpClass(LSharpDll dll, string name)
		{
			this._dll = dll;
			this._name = name;

			var lSharpEnviorment = LSharpManager.Instance.LSharpEnviorment;
			var lSharpThreadContext = LSharpManager.Instance.LSharpThreadContext;

			this._iCLRType = lSharpEnviorment.GetType(name);
		}

		// call ctor
		public object CallMethodCtor()
		{
			CLRSharp.IMethod methodctor = this._iCLRType.GetMethod(".ctor", CLRSharp.MethodParamList.constEmpty());
			return methodctor.Invoke(LSharpManager.Instance.LSharpThreadContext, null, null);
		}
	}
}
