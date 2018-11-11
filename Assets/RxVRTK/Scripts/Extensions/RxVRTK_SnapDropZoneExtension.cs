using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_SnapDropZoneExtension
    {

        /// <summary>
        /// Observable ObjectEnteredSnapDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<SnapDropZoneEventArgs> ObjectEnteredSnapDropZoneAsObservable(this VRTK_SnapDropZone events)
        {
            return Observable.FromEvent<SnapDropZoneEventHandler, SnapDropZoneEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ObjectEnteredSnapDropZone += h,
                 h => events.ObjectEnteredSnapDropZone -= h);
        }

        /// <summary>
        /// Observable ObjectExitedSnapDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<SnapDropZoneEventArgs> ObjectExitedSnapDropZoneAsObservable(this VRTK_SnapDropZone events)
        {
            return Observable.FromEvent<SnapDropZoneEventHandler, SnapDropZoneEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ObjectExitedSnapDropZone += h,
                 h => events.ObjectExitedSnapDropZone -= h);
        }

        /// <summary>
        /// Observable ObjectSnappedToDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<SnapDropZoneEventArgs> ObjectSnappedToDropZoneAsObservable(this VRTK_SnapDropZone events)
        {
            return Observable.FromEvent<SnapDropZoneEventHandler, SnapDropZoneEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ObjectSnappedToDropZone += h,
                 h => events.ObjectSnappedToDropZone -= h);
        }

        /// <summary>
        /// Observable ObjectUnsnappedFromDropZone event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<SnapDropZoneEventArgs> ObjectUnsnappedFromDropZoneAsObservable(this VRTK_SnapDropZone events)
        {
            return Observable.FromEvent<SnapDropZoneEventHandler, SnapDropZoneEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ObjectUnsnappedFromDropZone += h,
                 h => events.ObjectUnsnappedFromDropZone -= h);
        }

    }
}