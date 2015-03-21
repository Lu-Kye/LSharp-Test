using System.Reflection;

namespace LuKye.Core
{
	/**
	 * LSharpManager
	 * Control and Config how many dlls should be loaded
	 */
	// some configs
	public partial class LSharpManager : Manager<LSharpManager>
	{
		public class DLLS
		{
			public const string LSharpScripts = "LSharpScript";
		};
		private LSharpEnviorment _lSharpEnvoirment;
	}

	// some attributes and functions
	public partial class LSharpManager
	{
		/// <summary>
		/// LoadDlls
		/// load all dll from config
		/// </summary>
		private void LoadDlls()
		{
			PropertyInfo[] propertyInfos = typeof(DLLS).GetProperties();
			foreach (PropertyInfo propertyInfo in propertyInfos) {

			}
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
			this._lSharpEnvoirment = new LSharpEnviorment(LSharpLogger.Instance);

			// load

		}
	}
}
