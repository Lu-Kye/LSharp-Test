namespace LuKye.Core
{
	/**
	 * LSharpLogger
	 */ 
	public class LSharpLogger : SingleTon<LSharpLogger>, CLRSharp.ICLRSharp_Logger
	{
		public LSharpLogger()
		{
		}

		/// <summary>
		/// Log the specified str.
		/// </summary>
		/// <param name="str">String.</param>
		public void Log(string str)
		{
			UtilLog.Log(str);
		}

		/// <summary>
		/// Log_s the error.
		/// </summary>
		/// <param name="str">String.</param>
		public void Log_Error(string str)
		{
			UtilLog.LogE(str);
		}

		/// <summary>
		/// Log_s the warning.
		/// </summary>
		/// <param name="str">String.</param>
		public void Log_Warning(string str)
		{
			UtilLog.LogW(str);
		}
	}
}
