/**
 * SingleTon
 * A single base template class
 */ 
namespace LuKye.Core
{
	public class SingleTon<T> 
		where T : SingleTon<T>, new()
	{
		private static T _instance = null;
		private static readonly object _instanceLock = new object();
		public static T Instance {
			get {
				lock (_instanceLock) {
					if (_instance == null) {
						_instance = new T();
					}
				}
				return _instance;
			}
		}
	}
}

