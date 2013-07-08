using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class NativeEventDispatcher {

	public static void DispatchEevnt (string msg)
	{
	#if UNITY_EDITOR
		Debug.Log(string.Format("[Native Event] : "+ msg));
	#elif UNITY_ANDROID
		using (AndroidJavaObject cls = new AndroidJavaClass("unity.plugins.event.UnityEventPlugin")) {
			cls.CallStatic("dispatch", msg);
		}
	#elif UNITY_IPHONE
		dispatchNativeUnityEvent(msg);
	#endif
	}
	
	
	
	#region iOS Native Methods
#if UNITY_IPHONE
	[DllImport("__Internal")]
	private static extern void dispatchNativeUnityEvent(string msg);
#endif
#endregion
}
