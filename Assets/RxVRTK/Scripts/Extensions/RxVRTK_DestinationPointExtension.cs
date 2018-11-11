using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_DestinationPointExtension
    {

        /// <summary>
        /// Observable DestinationPointEnabled event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> DestinationPointEnabledAsObservable(this VRTK_DestinationPoint events)
        {
            return Observable.FromEvent<DestinationPointEventHandler, Object>(
                 h => h.Invoke,
                 h => events.DestinationPointEnabled += h,
                 h => events.DestinationPointEnabled -= h);
        }

        /// <summary>
        /// Observable DestinationPointDisabled event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> DestinationPointDisabledAsObservable(this VRTK_DestinationPoint events)
        {
            return Observable.FromEvent<DestinationPointEventHandler, Object>(
                 h => h.Invoke,
                 h => events.DestinationPointDisabled += h,
                 h => events.DestinationPointDisabled -= h);
        }

        /// <summary>
        /// Observable DestinationPointLocked event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> DestinationPointLockedAsObservable(this VRTK_DestinationPoint events)
        {
            return Observable.FromEvent<DestinationPointEventHandler, Object>(
                 h => h.Invoke,
                 h => events.DestinationPointLocked += h,
                 h => events.DestinationPointLocked -= h);
        }

        /// <summary>
        /// Observable DestinationPointUnlocked event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> DestinationPointUnlockedAsObservable(this VRTK_DestinationPoint events)
        {
            return Observable.FromEvent<DestinationPointEventHandler, Object>(
                 h => h.Invoke,
                 h => events.DestinationPointUnlocked += h,
                 h => events.DestinationPointUnlocked -= h);
        }

        /// <summary>
        /// Observable DestinationPointReset event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> DestinationPointResetAsObservable(this VRTK_DestinationPoint events)
        {
            return Observable.FromEvent<DestinationPointEventHandler, Object>(
                 h => h.Invoke,
                 h => events.DestinationPointReset += h,
                 h => events.DestinationPointReset -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerEnterAsObservable(this VRTK_DestinationPoint events)
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
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerExitAsObservable(this VRTK_DestinationPoint events)
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
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerHoverAsObservable(this VRTK_DestinationPoint events)
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
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerSetAsObservable(this VRTK_DestinationPoint events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerSet += h,
                 h => events.DestinationMarkerSet -= h);
        }

    }
}