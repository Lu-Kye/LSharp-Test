namespace LuKye.Core
{
	/**
	 * LSharpManager
	 * Control and Config how many dlls should be loaded
	 */
	// some configs
	public partial class LSharpManager : Manager<LSharpManager>
	{
		public static readonly string[] DLL_CONFIGS = new string[] 
		{
			"LSharpScript"
		};
	}

	// some attributes and functions
	public partial class LSharpManager
	{
		/// <summary>
		/// Sets up.
		/// Init some data or attributes
		/// </summary>
		public override void SetUp()
		{
			// base
			base.SetUp();
		}
	}
}
