using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_InteractTouchExtension
    {

        /// <summary>
        /// Observable ControllerStartTouchInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerStartTouchInteractableObjectAsObservable(this VRTK_InteractTouch events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerStartTouchInteractableObject += h,
                 h => events.ControllerStartTouchInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerTouchInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerTouchInteractableObjectAsObservable(this VRTK_InteractTouch events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerTouchInteractableObject += h,
                 h => events.ControllerTouchInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerStartUntouchInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerStartUntouchInteractableObjectAsObservable(this VRTK_InteractTouch events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerStartUntouchInteractableObject += h,
                 h => events.ControllerStartUntouchInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerUntouchInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerUntouchInteractableObjectAsObservable(this VRTK_InteractTouch events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerUntouchInteractableObject += h,
                 h => events.ControllerUntouchInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerRigidbodyActivated event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerRigidbodyActivatedAsObservable(this VRTK_InteractTouch events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerRigidbodyActivated += h,
                 h => events.ControllerRigidbodyActivated -= h);
        }

        /// <summary>
        /// Observable ControllerRigidbodyDeactivated event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerRigidbodyDeactivatedAsObservable(this VRTK_InteractTouch events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerRigidbodyDeactivated += h,
                 h => events.ControllerRigidbodyDeactivated -= h);
        }

    }
}