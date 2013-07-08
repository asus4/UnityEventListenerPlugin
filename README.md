# UnityEventListenerPlugin


## HOW TO USE

### Unity

```C#
NativeEventDispatcher.DispatchEevnt ("UNITY_TEST_"+Time.frameCount);
```

### iOS

```Objective-C
[[NSNotificationCenter defaultCenter] addObserver:self
                                         selector:@selector(hoge:)
                                             name:@"UnityEvent"
                                           object:nil];
```


### Android

```Java
interface UnityEventListener {
  void onUnityEvent(string event);
}

UnityEventPlugin.addListener(listener);
UnityEventPlugin.removeListener(listener);
```
