using UnityEngine;

/**
 * SingleTonGO
 * A single GameObject base template class
 */ 
namespace LuKye.Core
{
	public class SingleTonGO<T> : UIBase
		where T : SingleTonGO<T>, new()
	{
		private static T _instance = null;
		private static readonly object _instanceLock = new object();
		public static T Instance {
			get {
				lock (_instanceLock) {
					if (_instance == null) {
						_instance = new GameObject().AddComponent<T>();
						_instance.gameObject.name = _instance.GetType().Name;
						GameObject.DontDestroyOnLoad(_instance.gameObject);
					}
				}
				return _instance;
			}
		}
	}
}

