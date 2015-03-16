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
		/// Sets up.
		/// Init some data or attributes
		/// </summary>
		public virtual void SetUp()
		{
			// should be implemented by subclass
		}
	}
}
