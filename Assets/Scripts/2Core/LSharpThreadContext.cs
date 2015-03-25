namespace LuKye.Core
{
	/**
	 * LSharpThreadContext
	 */ 
	public class LSharpThreadContext : CLRSharp.ThreadContext
	{
		// ctor
		public LSharpThreadContext(LSharpEnviorment lSharpEnviorment)
			: base(lSharpEnviorment)
		{
		}
	}
}