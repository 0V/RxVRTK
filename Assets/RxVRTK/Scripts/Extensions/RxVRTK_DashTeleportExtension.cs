using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_DashTeleportExtension
    {

        /// <summary>
        /// Observable WillDashThruObjects event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DashTeleportEventArgs> WillDashThruObjectsAsObservable(this VRTK_DashTeleport events)
        {
            return Observable.FromEvent<DashTeleportEventHandler, DashTeleportEventArgs>(
                 h => (s, e) => h(e),
                 h => events.WillDashThruObjects += h,
                 h => events.WillDashThruObjects -= h);
        }

        /// <summary>
        /// Observable DashedThruObjects event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DashTeleportEventArgs> DashedThruObjectsAsObservable(this VRTK_DashTeleport events)
        {
            return Observable.FromEvent<DashTeleportEventHandler, DashTeleportEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DashedThruObjects += h,
                 h => events.DashedThruObjects -= h);
        }

        /// <summary>
        /// Observable Teleporting event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> TeleportingAsObservable(this VRTK_DashTeleport events)
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
        public static IObservable<DestinationMarkerEventArgs> TeleportedAsObservable(this VRTK_DashTeleport events)
        {
            return Observable.FromEvent<TeleportEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.Teleported += h,
                 h => events.Teleported -= h);
        }

    }
}