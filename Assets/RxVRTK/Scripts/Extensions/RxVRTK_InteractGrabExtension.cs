using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_InteractGrabExtension
    {

        /// <summary>
        /// Observable GrabButtonPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GrabButtonPressedAsObservable(this VRTK_InteractGrab events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GrabButtonPressed += h,
                 h => events.GrabButtonPressed -= h);
        }

        /// <summary>
        /// Observable GrabButtonReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> GrabButtonReleasedAsObservable(this VRTK_InteractGrab events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.GrabButtonReleased += h,
                 h => events.GrabButtonReleased -= h);
        }

        /// <summary>
        /// Observable ControllerStartGrabInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerStartGrabInteractableObjectAsObservable(this VRTK_InteractGrab events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerStartGrabInteractableObject += h,
                 h => events.ControllerStartGrabInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerGrabInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerGrabInteractableObjectAsObservable(this VRTK_InteractGrab events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerGrabInteractableObject += h,
                 h => events.ControllerGrabInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerStartUngrabInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerStartUngrabInteractableObjectAsObservable(this VRTK_InteractGrab events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerStartUngrabInteractableObject += h,
                 h => events.ControllerStartUngrabInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerUngrabInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerUngrabInteractableObjectAsObservable(this VRTK_InteractGrab events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerUngrabInteractableObject += h,
                 h => events.ControllerUngrabInteractableObject -= h);
        }

    }
}