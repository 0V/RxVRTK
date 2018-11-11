using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_InteractUseExtension
    {

        /// <summary>
        /// Observable UseButtonPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> UseButtonPressedAsObservable(this VRTK_InteractUse events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UseButtonPressed += h,
                 h => events.UseButtonPressed -= h);
        }

        /// <summary>
        /// Observable UseButtonReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> UseButtonReleasedAsObservable(this VRTK_InteractUse events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UseButtonReleased += h,
                 h => events.UseButtonReleased -= h);
        }

        /// <summary>
        /// Observable ControllerStartUseInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerStartUseInteractableObjectAsObservable(this VRTK_InteractUse events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerStartUseInteractableObject += h,
                 h => events.ControllerStartUseInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerUseInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerUseInteractableObjectAsObservable(this VRTK_InteractUse events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerUseInteractableObject += h,
                 h => events.ControllerUseInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerStartUnuseInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerStartUnuseInteractableObjectAsObservable(this VRTK_InteractUse events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerStartUnuseInteractableObject += h,
                 h => events.ControllerStartUnuseInteractableObject -= h);
        }

        /// <summary>
        /// Observable ControllerUnuseInteractableObject event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectInteractEventArgs> ControllerUnuseInteractableObjectAsObservable(this VRTK_InteractUse events)
        {
            return Observable.FromEvent<ObjectInteractEventHandler, ObjectInteractEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerUnuseInteractableObject += h,
                 h => events.ControllerUnuseInteractableObject -= h);
        }

    }
}