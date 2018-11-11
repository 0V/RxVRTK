using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_PositionRewindExtension
    {

        /// <summary>
        /// Observable PositionRewindToSafe event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PositionRewindEventArgs> PositionRewindToSafeAsObservable(this VRTK_PositionRewind events)
        {
            return Observable.FromEvent<PositionRewindEventHandler, PositionRewindEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PositionRewindToSafe += h,
                 h => events.PositionRewindToSafe -= h);
        }

    }
}