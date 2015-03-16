namespace LuKye.Core
{
	/**
	 *	Manager
	 *	A base SingleTon class manager
	 */
	public class Manager<T> : SingleTon<T>
		where T : Manager<T>, new()
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LuKye.Core.Manager"/> class.
		/// </summary>
		public Manager ()
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
