using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_PointerExtension
    {

        /// <summary>
        /// Observable ActivationButtonPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ActivationButtonPressedAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ActivationButtonPressed += h,
                 h => events.ActivationButtonPressed -= h);
        }

        /// <summary>
        /// Observable ActivationButtonReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ActivationButtonReleasedAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ActivationButtonReleased += h,
                 h => events.ActivationButtonReleased -= h);
        }

        /// <summary>
        /// Observable SelectionButtonPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> SelectionButtonPressedAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.SelectionButtonPressed += h,
                 h => events.SelectionButtonPressed -= h);
        }

        /// <summary>
        /// Observable SelectionButtonReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> SelectionButtonReleasedAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.SelectionButtonReleased += h,
                 h => events.SelectionButtonReleased -= h);
        }

        /// <summary>
        /// Observable PointerStateValid event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> PointerStateValidAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PointerStateValid += h,
                 h => events.PointerStateValid -= h);
        }

        /// <summary>
        /// Observable PointerStateInvalid event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> PointerStateInvalidAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PointerStateInvalid += h,
                 h => events.PointerStateInvalid -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerEnterAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerEnter += h,
                 h => events.DestinationMarkerEnter -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerExit event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerExitAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerExit += h,
                 h => events.DestinationMarkerExit -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerHover event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerHoverAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerHover += h,
                 h => events.DestinationMarkerHover -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerSet event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerSetAsObservable(this VRTK_Pointer events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerSet += h,
                 h => events.DestinationMarkerSet -= h);
        }

    }
}