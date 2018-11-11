# RxVRTK
Extensions for converting all VRTK event to UniRx stream

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
