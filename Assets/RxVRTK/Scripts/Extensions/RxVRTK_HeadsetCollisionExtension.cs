using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_HeadsetCollisionExtension
    {

        /// <summary>
        /// Observable HeadsetCollisionDetect event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetCollisionEventArgs> HeadsetCollisionDetectAsObservable(this VRTK_HeadsetCollision events)
        {
            return Observable.FromEvent<HeadsetCollisionEventHandler, HeadsetCollisionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HeadsetCollisionDetect += h,
                 h => events.HeadsetCollisionDetect -= h);
        }

        /// <summary>
        /// Observable HeadsetCollisionEnded event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetCollisionEventArgs> HeadsetCollisionEndedAsObservable(this VRTK_HeadsetCollision events)
        {
            return Observable.FromEvent<HeadsetCollisionEventHandler, HeadsetCollisionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HeadsetCollisionEnded += h,
                 h => events.HeadsetCollisionEnded -= h);
        }

    }
}