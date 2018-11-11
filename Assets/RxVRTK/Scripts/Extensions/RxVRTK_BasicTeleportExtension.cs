using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_BasicTeleportExtension
    {

        /// <summary>
        /// Observable Teleporting event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> TeleportingAsObservable(this VRTK_BasicTeleport events)
        {
            return Observable.FromEvent<TeleportEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.Teleporting += h,
                 h => events.Teleporting -= h);
        }

        /// <summary>
        /// Observable Teleported event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> TeleportedAsObservable(this VRTK_BasicTeleport events)
        {
            return Observable.FromEvent<TeleportEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.Teleported += h,
                 h => events.Teleported -= h);
        }

    }
}