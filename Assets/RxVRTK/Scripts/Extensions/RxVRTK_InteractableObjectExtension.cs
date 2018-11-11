using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_InteractableObjectExtension
    {

        /// <summary>
        /// Observable InteractableObjectTouched event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectTouchedAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectTouched += h,
                 h => events.InteractableObjectTouched -= h);
        }

        /// <summary>
        /// Observable InteractableObjectUntouched event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectUntouchedAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectUntouched += h,
                 h => events.InteractableObjectUntouched -= h);
        }

        /// <summary>
        /// Observable InteractableObjectGrabbed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectGrabbedAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectGrabbed += h,
                 h => events.InteractableObjectGrabbed -= h);
        }

        /// <summary>
        /// Observable InteractableObjectUngrabbed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectUngrabbedAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectUngrabbed += h,
                 h => events.InteractableObjectUngrabbed -= h);
        }

        /// <summary>
        /// Observable InteractableObjectUsed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectUsedAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectUsed += h,
                 h => events.InteractableObjectUsed -= h);
        }

        /// <summary>
        /// Observable InteractableObjectUnused event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectUnusedAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectUnused += h,
                 h => events.InteractableObjectUnused -= h);
        }

        /// <summary>
        /// Observable InteractableObjectEnteredSnapDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectEnteredSnapDropZoneAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectEnteredSnapDropZone += h,
                 h => events.InteractableObjectEnteredSnapDropZone -= h);
        }

        /// <summary>
        /// Observable InteractableObjectExitedSnapDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectExitedSnapDropZoneAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectExitedSnapDropZone += h,
                 h => events.InteractableObjectExitedSnapDropZone -= h);
        }

        /// <summary>
        /// Observable InteractableObjectSnappedToDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectSnappedToDropZoneAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectSnappedToDropZone += h,
                 h => events.InteractableObjectSnappedToDropZone -= h);
        }

        /// <summary>
        /// Observable InteractableObjectUnsnappedFromDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractableObjectEventArgs> InteractableObjectUnsnappedFromDropZoneAsObservable(this VRTK_InteractableObject events)
        {
            return Observable.FromEvent<InteractableObjectEventHandler, InteractableObjectEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractableObjectUnsnappedFromDropZone += h,
                 h => events.InteractableObjectUnsnappedFromDropZone -= h);
        }

    }
}