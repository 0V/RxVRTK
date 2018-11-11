using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_PlayAreaCursorExtension
    {

        /// <summary>
        /// Observable PlayAreaCursorStartCollision event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PlayAreaCursorEventArgs> PlayAreaCursorStartCollisionAsObservable(this VRTK_PlayAreaCursor events)
        {
            return Observable.FromEvent<PlayAreaCursorEventHandler, PlayAreaCursorEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PlayAreaCursorStartCollision += h,
                 h => events.PlayAreaCursorStartCollision -= h);
        }

        /// <summary>
        /// Observable PlayAreaCursorEndCollision event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PlayAreaCursorEventArgs> PlayAreaCursorEndCollisionAsObservable(this VRTK_PlayAreaCursor events)
        {
            return Observable.FromEvent<PlayAreaCursorEventHandler, PlayAreaCursorEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PlayAreaCursorEndCollision += h,
                 h => events.PlayAreaCursorEndCollision -= h);
        }

    }
}