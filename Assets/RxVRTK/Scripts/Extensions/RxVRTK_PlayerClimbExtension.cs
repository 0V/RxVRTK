using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_PlayerClimbExtension
    {

        /// <summary>
        /// Observable PlayerClimbStarted event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PlayerClimbEventArgs> PlayerClimbStartedAsObservable(this VRTK_PlayerClimb events)
        {
            return Observable.FromEvent<PlayerClimbEventHandler, PlayerClimbEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PlayerClimbStarted += h,
                 h => events.PlayerClimbStarted -= h);
        }

        /// <summary>
        /// Observable PlayerClimbEnded event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PlayerClimbEventArgs> PlayerClimbEndedAsObservable(this VRTK_PlayerClimb events)
        {
            return Observable.FromEvent<PlayerClimbEventHandler, PlayerClimbEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PlayerClimbEnded += h,
                 h => events.PlayerClimbEnded -= h);
        }

    }
}