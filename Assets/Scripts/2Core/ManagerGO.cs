namespace LuKye.Core
{
	/**
	 *	Manager
	 *	A base SingleTon class manager
	 */
	public class ManagerGO<T> : SingleTon<T>
		where T : ManagerGO<T>, new()
	{
		/// <summary>
		/// Awake this instance.
		/// </summary>
		protected virtual void Awake ()
		{
			this.SetUp ();
		}
		
		/// <summary>
		/// Sets up.
		/// Init some data or attributes
		/// </summary>
		protected virtual void SetUp ()
		{
			// should be implemented by subclass
		}
	}
}
