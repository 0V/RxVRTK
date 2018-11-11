# RxVRTK
Extensions for converting all VRTK event to UniRx stream

Extension scripts are [here](https://github.com/0V/RxVRTK/tree/master/Assets/RxVRTK/Scripts/Extensions) .  

Release Notes, see [RxVRTK/releases](https://github.com/0V/RxVRTK/releases)

## Dependencies
* VRTK v3.2.1  
[GitHub](https://github.com/thestonefox/VRTK)  ,  [Asset Store](https://assetstore.unity.com/packages/tools/vrtk-virtual-reality-toolkit-vr-toolkit-64131)
* UniRx  
[GitHub](https://github.com/neuecc/UniRx)  ,  [unitypackage](https://github.com/neuecc/UniRx/releases)

## Usage

``` csharp
VRTK_ControllerEvents controllerEvents = GetComponent<VRTK_ControllerEvents>();

controllerEvents.TriggerPressedAsObservable()
    .Subscribe(_ =>
    {
        Debug.Log("Trigger Pressed!");
    });

```
