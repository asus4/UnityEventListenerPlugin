package unity.plugins.event;

import java.util.ArrayList;

import android.app.Activity;

import com.unity3d.player.UnityPlayer;


public class UnityEventPlugin {
	private static ArrayList<IUnityEventListener> listeners = new ArrayList<IUnityEventListener>(); 
	
	public static void addListener(IUnityEventListener listener) {
		listeners.add(listener);
	}
	
	public static void removeListener(IUnityEventListener listener) {
		listeners.remove(listener);
	}
	
	public static void dispatch(final String msg) {
		// wait for ui thread
		Activity a = UnityPlayer.currentActivity;
		a.runOnUiThread(new Runnable() {
			public void run() {
				for(IUnityEventListener listener : listeners) {
					listener.onUnityEvent(msg);
				}
			}
		});
	}
}