using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_CollisionTrackerExtension
    {

        /// <summary>
        /// Observable CollisionEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<CollisionTrackerEventArgs> CollisionEnterAsObservable(this VRTK_CollisionTracker events)
        {
            return Observable.FromEvent<CollisionTrackerEventHandler, CollisionTrackerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.CollisionEnter += h,
                 h => events.CollisionEnter -= h);
        }

        /// <summary>
        /// Observable CollisionStay event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<CollisionTrackerEventArgs> CollisionStayAsObservable(this VRTK_CollisionTracker events)
        {
            return Observable.FromEvent<CollisionTrackerEventHandler, CollisionTrackerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.CollisionStay += h,
                 h => events.CollisionStay -= h);
        }

        /// <summary>
        /// Observable CollisionExit event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<CollisionTrackerEventArgs> CollisionExitAsObservable(this VRTK_CollisionTracker events)
        {
            return Observable.FromEvent<CollisionTrackerEventHandler, CollisionTrackerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.CollisionExit += h,
                 h => events.CollisionExit -= h);
        }

        /// <summary>
        /// Observable TriggerEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<CollisionTrackerEventArgs> TriggerEnterAsObservable(this VRTK_CollisionTracker events)
        {
            return Observable.FromEvent<CollisionTrackerEventHandler, CollisionTrackerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerEnter += h,
                 h => events.TriggerEnter -= h);
        }

        /// <summary>
        /// Observable TriggerStay event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<CollisionTrackerEventArgs> TriggerStayAsObservable(this VRTK_CollisionTracker events)
        {
            return Observable.FromEvent<CollisionTrackerEventHandler, CollisionTrackerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerStay += h,
                 h => events.TriggerStay -= h);
        }

        /// <summary>
        /// Observable TriggerExit event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<CollisionTrackerEventArgs> TriggerExitAsObservable(this VRTK_CollisionTracker events)
        {
            return Observable.FromEvent<CollisionTrackerEventHandler, CollisionTrackerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.TriggerExit += h,
                 h => events.TriggerExit -= h);
        }

    }
}