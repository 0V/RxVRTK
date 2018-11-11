using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_DestinationMarkerExtension
    {

        /// <summary>
        /// Observable DestinationMarkerEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerEnterAsObservable(this VRTK_DestinationMarker events)
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
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerExitAsObservable(this VRTK_DestinationMarker events)
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
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerHoverAsObservable(this VRTK_DestinationMarker events)
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
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerSetAsObservable(this VRTK_DestinationMarker events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerSet += h,
                 h => events.DestinationMarkerSet -= h);
        }

    }
}