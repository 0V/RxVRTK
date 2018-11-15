# RxVRTK

Extensions for converting all the VRTK events to UniRx stream


Scripts are [here](https://github.com/0V/RxVRTK/tree/master/Assets/RxVRTK/Scripts).  

For Release Notes and unitypackage, see [RxVRTK/releases](https://github.com/0V/RxVRTK/releases).

## Dependencies
* VRTK v3.2.1  
[GitHub](https://github.com/thestonefox/VRTK),  [Asset Store](https://assetstore.unity.com/packages/tools/vrtk-virtual-reality-toolkit-vr-toolkit-64131)
* UniRx  
[GitHub](https://github.com/neuecc/UniRx),  [Asset Store](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)


## What is RxVRTK?

RxVRTK mediates VRTK (VR Toolkit) and UniRx.  

RxVRTK consists of two components: **Event extensions** and **RxVRTK components**.

### 1. Event extensions
**Event extensions** provide extension methods to convert an exposed VRTK event such as ```VRTK_ControllerEvents.TriggerPressed``` to an Rx stream.

You can observe ```{EVENT NAME}``` by using ```{EVENT NAME}AsObservable()``` method.


### Example: Event Extensions

``` csharp
// Add using directive
// using RxVRTK;

VRTK_ControllerEvents controllerEvents = GetComponent<VRTK_ControllerEvents>();

controllerEvents.TriggerPressedAsObservable()
    .Subscribe(_ =>
    {
        Debug.Log("Trigger Pressed!");
    });

```

Event extensions have a prefix "RxVRTK_" and a suffix "Extension".

  
### 2. RxVRTK components

**RxVRTK components** provide an event system that registers a callback by its method name and the registered callbacks are automatically called by the event system of VRTK.

An RxVRTK component inherits from VRTK classes and overrides the aforementioned methods so that it converts a VRTK event to Rx stream. When you use these components, you **must not** override such methods and **must** only use observable methods instead.


### Note

Let's say you want to register a callback for "StartUsing". In this case, VRTK calls "StartUsing" of an VRTK_InteractableObject instance if it implements a method that matches the following signature:

```csharp
void StartUsing(VRTK_InteractUse currentUsingObject);
```

As these methods are already overridden in RxVRTK_InteractableObject, which inherits VRTK_InteractableObject to fire UniRx events and RxVRTK utilizes this technique to register an event callback, ensure that you **do not** use neither "StartUsing" nor `new` to hide this method.


### Example: RxVRTK components
The base class of RxVRTK_InteractableObject is **VRTK_InteractableObject**. This class provides interactive events: StartUsing, StartTouching, Grabbed,  etc.

``` csharp
using RxVRTK;
using UniRx;
using UnityEngine;

public class SomeObject : RxVRTK_InteractableObject
{
    protected void Start()
    {
        this.StartUsingAsObservable()
            .Subscribe(user =>
            {
                Debug.Log(user.name + " is using this object!");
            });
    }
}

```

RxVRTK components have a prefix "RxVRTK_" but no suffix.


### 3. VRTK_UnityEvents\<T\>
VRTK_UnityEvents\<T\> uses UnityEvent\<T\>. UniRx has UnityEventExtensions which convert UnityEvent to Observable, so RxVRTK doesn't support UnityEvent. Please use UniRx.UnityEventExtensions.

### Example: VRTK_UnityEvents\<T\>
**AsObservable()** is an extension method to convert UnityEvent to Observable.
```csharp
// Add using directive
// using UniRx;

var controlEvents = GetComponent<VRTK_Control_UnityEvents>();
controlEvents.OnValueChanged.AsObservable()
    .Subscribe(e =>
    {
        Debug.Log("Changed: "+ e.Item2.value.ToString());
    });

```

## License
This library is released under the [MIT License](https://github.com/0V/RxVRTK/blob/master/LICENSE).
