using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void OnGUI ()
	{
		if (GUILayout.Button ("Dispatch", GUILayout.MinHeight(300), GUILayout.MinWidth(300))) {
			NativeEventDispatcher.DispatchEevnt ("UNITY_TEST_"+Time.frameCount);
		}
	}
}
