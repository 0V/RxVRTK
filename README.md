# RxVRTK
Extensions for converting all VRTK event to UniRx stream

Extension scripts are [here](https://github.com/0V/RxVRTK/tree/master/Assets/RxVRTK/Scripts/Extensions) .  

## Dependencies
* VRTK v3.2.1
* UniRx

## Usage

```
VRTK_ControllerEvents controllerEvents = GetComponent<VRTK_ControllerEvents>();

controllerEvents.TriggerPressedAsObservable()
    .Subscribe(_ =>
    {
        Debug.Log("Trigger Pressed!");
    });

```
