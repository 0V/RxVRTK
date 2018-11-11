using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_InteractControllerAppearanceExtension
    {

        /// <summary>
        /// Observable ControllerHidden event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> ControllerHiddenAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerHidden += h,
                 h => events.ControllerHidden -= h);
        }

        /// <summary>
        /// Observable ControllerVisible event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> ControllerVisibleAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerVisible += h,
                 h => events.ControllerVisible -= h);
        }

        /// <summary>
        /// Observable HiddenOnTouch event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> HiddenOnTouchAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HiddenOnTouch += h,
                 h => events.HiddenOnTouch -= h);
        }

        /// <summary>
        /// Observable VisibleOnTouch event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> VisibleOnTouchAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.VisibleOnTouch += h,
                 h => events.VisibleOnTouch -= h);
        }

        /// <summary>
        /// Observable HiddenOnGrab event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> HiddenOnGrabAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HiddenOnGrab += h,
                 h => events.HiddenOnGrab -= h);
        }

        /// <summary>
        /// Observable VisibleOnGrab event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> VisibleOnGrabAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.VisibleOnGrab += h,
                 h => events.VisibleOnGrab -= h);
        }

        /// <summary>
        /// Observable HiddenOnUse event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> HiddenOnUseAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HiddenOnUse += h,
                 h => events.HiddenOnUse -= h);
        }

        /// <summary>
        /// Observable VisibleOnUse event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractControllerAppearanceEventArgs> VisibleOnUseAsObservable(this VRTK_InteractControllerAppearance events)
        {
            return Observable.FromEvent<InteractControllerAppearanceEventHandler, InteractControllerAppearanceEventArgs>(
                 h => (s, e) => h(e),
                 h => events.VisibleOnUse += h,
                 h => events.VisibleOnUse -= h);
        }

    }
}