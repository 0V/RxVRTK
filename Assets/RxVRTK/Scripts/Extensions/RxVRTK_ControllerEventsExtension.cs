using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ControllerEventsExtension
    {

        /// <summary>
        /// Observable TriggerPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerPressedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerPressed += h,
                 h => events.TriggerPressed -= h);
        }

        /// <summary>
        /// Observable TriggerReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerReleasedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerReleased += h,
                 h => events.TriggerReleased -= h);
        }

        /// <summary>
        /// Observable TriggerTouchStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerTouchStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerTouchStart += h,
                 h => events.TriggerTouchStart -= h);
        }

        /// <summary>
        /// Observable TriggerTouchEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerTouchEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerTouchEnd += h,
                 h => events.TriggerTouchEnd -= h);
        }

        /// <summary>
        /// Observable TriggerHairlineStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerHairlineStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerHairlineStart += h,
                 h => events.TriggerHairlineStart -= h);
        }

        /// <summary>
        /// Observable TriggerHairlineEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerHairlineEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerHairlineEnd += h,
                 h => events.TriggerHairlineEnd -= h);
        }

        /// <summary>
        /// Observable TriggerClicked event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerClickedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerClicked += h,
                 h => events.TriggerClicked -= h);
        }

        /// <summary>
        /// Observable TriggerUnclicked event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerUnclickedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerUnclicked += h,
                 h => events.TriggerUnclicked -= h);
        }

        /// <summary>
        /// Observable TriggerAxisChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TriggerAxisChangedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerAxisChanged += h,
                 h => events.TriggerAxisChanged -= h);
        }

        /// <summary>
        /// Observable GripPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripPressedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripPressed += h,
                 h => events.GripPressed -= h);
        }

        /// <summary>
        /// Observable GripReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripReleasedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripReleased += h,
                 h => events.GripReleased -= h);
        }

        /// <summary>
        /// Observable GripTouchStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripTouchStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripTouchStart += h,
                 h => events.GripTouchStart -= h);
        }

        /// <summary>
        /// Observable GripTouchEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripTouchEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripTouchEnd += h,
                 h => events.GripTouchEnd -= h);
        }

        /// <summary>
        /// Observable GripHairlineStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripHairlineStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripHairlineStart += h,
                 h => events.GripHairlineStart -= h);
        }

        /// <summary>
        /// Observable GripHairlineEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripHairlineEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripHairlineEnd += h,
                 h => events.GripHairlineEnd -= h);
        }

        /// <summary>
        /// Observable GripClicked event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripClickedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripClicked += h,
                 h => events.GripClicked -= h);
        }

        /// <summary>
        /// Observable GripUnclicked event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripUnclickedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripUnclicked += h,
                 h => events.GripUnclicked -= h);
        }

        /// <summary>
        /// Observable GripAxisChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GripAxisChangedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GripAxisChanged += h,
                 h => events.GripAxisChanged -= h);
        }

        /// <summary>
        /// Observable TouchpadPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TouchpadPressedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TouchpadPressed += h,
                 h => events.TouchpadPressed -= h);
        }

        /// <summary>
        /// Observable TouchpadReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TouchpadReleasedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TouchpadReleased += h,
                 h => events.TouchpadReleased -= h);
        }

        /// <summary>
        /// Observable TouchpadTouchStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TouchpadTouchStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TouchpadTouchStart += h,
                 h => events.TouchpadTouchStart -= h);
        }

        /// <summary>
        /// Observable TouchpadTouchEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TouchpadTouchEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TouchpadTouchEnd += h,
                 h => events.TouchpadTouchEnd -= h);
        }

        /// <summary>
        /// Observable TouchpadAxisChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> TouchpadAxisChangedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TouchpadAxisChanged += h,
                 h => events.TouchpadAxisChanged -= h);
        }

        /// <summary>
        /// Observable ButtonOneTouchStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonOneTouchStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonOneTouchStart += h,
                 h => events.ButtonOneTouchStart -= h);
        }

        /// <summary>
        /// Observable ButtonOneTouchEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonOneTouchEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonOneTouchEnd += h,
                 h => events.ButtonOneTouchEnd -= h);
        }

        /// <summary>
        /// Observable ButtonOnePressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonOnePressedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonOnePressed += h,
                 h => events.ButtonOnePressed -= h);
        }

        /// <summary>
        /// Observable ButtonOneReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonOneReleasedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonOneReleased += h,
                 h => events.ButtonOneReleased -= h);
        }

        /// <summary>
        /// Observable ButtonTwoTouchStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonTwoTouchStartAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonTwoTouchStart += h,
                 h => events.ButtonTwoTouchStart -= h);
        }

        /// <summary>
        /// Observable ButtonTwoTouchEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonTwoTouchEndAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonTwoTouchEnd += h,
                 h => events.ButtonTwoTouchEnd -= h);
        }

        /// <summary>
        /// Observable ButtonTwoPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonTwoPressedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonTwoPressed += h,
                 h => events.ButtonTwoPressed -= h);
        }

        /// <summary>
        /// Observable ButtonTwoReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ButtonTwoReleasedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ButtonTwoReleased += h,
                 h => events.ButtonTwoReleased -= h);
        }

        /// <summary>
        /// Observable StartMenuPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> StartMenuPressedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartMenuPressed += h,
                 h => events.StartMenuPressed -= h);
        }

        /// <summary>
        /// Observable StartMenuReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> StartMenuReleasedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartMenuReleased += h,
                 h => events.StartMenuReleased -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasPointerOn` has been replaced with `VRTK_Pointer.ActivationButtonPressed`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasPointerOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasPointerOnAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasPointerOn += h,
                 h => events.AliasPointerOn -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasPointerOff` has been replaced with `VRTK_Pointer.ActivationButtonReleased`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasPointerOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasPointerOffAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasPointerOff += h,
                 h => events.AliasPointerOff -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasPointerSet` has been replaced with `VRTK_Pointer.SelectionButtonReleased`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasPointerSet event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasPointerSetAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasPointerSet += h,
                 h => events.AliasPointerSet -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasGrabOn` has been replaced with `VRTK_InteractGrab.GrabButtonPressed`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasGrabOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasGrabOnAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasGrabOn += h,
                 h => events.AliasGrabOn -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasGrabOff` has been replaced with `VRTK_InteractGrab.GrabButtonReleased`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasGrabOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasGrabOffAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasGrabOff += h,
                 h => events.AliasGrabOff -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasUseOn` has been replaced with `VRTK_InteractUse.UseButtonPressed`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasUseOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasUseOnAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasUseOn += h,
                 h => events.AliasUseOn -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasUseOff` has been replaced with `VRTK_InteractUse.UseButtonReleased`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasUseOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasUseOffAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasUseOff += h,
                 h => events.AliasUseOff -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasMenuOn` is no longer used, use `VRTK_ControllerEvents.ButtonTwoPressed` instead. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasMenuOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasMenuOnAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasMenuOn += h,
                 h => events.AliasMenuOn -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasMenuOff` is no longer used, use `VRTK_ControllerEvents.ButtonTwoReleased` instead. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasMenuOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasMenuOffAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasMenuOff += h,
                 h => events.AliasMenuOff -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasUIClickOn` has been replaced with `VRTK_UIPointer.SelectionButtonPressed`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasUIClickOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasUIClickOnAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasUIClickOn += h,
                 h => events.AliasUIClickOn -= h);
        }
        [Obsolete("`VRTK_ControllerEvents.AliasUIClickOff` has been replaced with `VRTK_UIPointer.SelectionButtonReleased`. This parameter will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable AliasUIClickOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> AliasUIClickOffAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AliasUIClickOff += h,
                 h => events.AliasUIClickOff -= h);
        }

        /// <summary>
        /// Observable ControllerEnabled event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ControllerEnabledAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerEnabled += h,
                 h => events.ControllerEnabled -= h);
        }

        /// <summary>
        /// Observable ControllerDisabled event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ControllerDisabledAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerDisabled += h,
                 h => events.ControllerDisabled -= h);
        }

        /// <summary>
        /// Observable ControllerIndexChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ControllerIndexChangedAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerIndexChanged += h,
                 h => events.ControllerIndexChanged -= h);
        }

        /// <summary>
        /// Observable ControllerVisible event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ControllerVisibleAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerVisible += h,
                 h => events.ControllerVisible -= h);
        }

        /// <summary>
        /// Observable ControllerHidden event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ControllerHiddenAsObservable(this VRTK_ControllerEvents events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerHidden += h,
                 h => events.ControllerHidden -= h);
        }

    }
}