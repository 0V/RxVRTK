using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_InteractHapticsExtension
    {

        /// <summary>
        /// Observable InteractHapticsTouched event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractHapticsEventArgs> InteractHapticsTouchedAsObservable(this VRTK_InteractHaptics events)
        {
            return Observable.FromEvent<InteractHapticsEventHandler, InteractHapticsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractHapticsTouched += h,
                 h => events.InteractHapticsTouched -= h);
        }

        /// <summary>
        /// Observable InteractHapticsGrabbed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractHapticsEventArgs> InteractHapticsGrabbedAsObservable(this VRTK_InteractHaptics events)
        {
            return Observable.FromEvent<InteractHapticsEventHandler, InteractHapticsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractHapticsGrabbed += h,
                 h => events.InteractHapticsGrabbed -= h);
        }

        /// <summary>
        /// Observable InteractHapticsUsed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<InteractHapticsEventArgs> InteractHapticsUsedAsObservable(this VRTK_InteractHaptics events)
        {
            return Observable.FromEvent<InteractHapticsEventHandler, InteractHapticsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.InteractHapticsUsed += h,
                 h => events.InteractHapticsUsed -= h);
        }

    }
}