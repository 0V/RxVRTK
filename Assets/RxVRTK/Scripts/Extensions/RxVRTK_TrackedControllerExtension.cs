using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_TrackedControllerExtension
    {

        /// <summary>
        /// Observable ControllerEnabled event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<VRTKTrackedControllerEventArgs> ControllerEnabledAsObservable(this VRTK_TrackedController events)
        {
            return Observable.FromEvent<VRTKTrackedControllerEventHandler, VRTKTrackedControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerEnabled += h,
                 h => events.ControllerEnabled -= h);
        }

        /// <summary>
        /// Observable ControllerDisabled event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<VRTKTrackedControllerEventArgs> ControllerDisabledAsObservable(this VRTK_TrackedController events)
        {
            return Observable.FromEvent<VRTKTrackedControllerEventHandler, VRTKTrackedControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerDisabled += h,
                 h => events.ControllerDisabled -= h);
        }

        /// <summary>
        /// Observable ControllerIndexChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<VRTKTrackedControllerEventArgs> ControllerIndexChangedAsObservable(this VRTK_TrackedController events)
        {
            return Observable.FromEvent<VRTKTrackedControllerEventHandler, VRTKTrackedControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerIndexChanged += h,
                 h => events.ControllerIndexChanged -= h);
        }

    }
}