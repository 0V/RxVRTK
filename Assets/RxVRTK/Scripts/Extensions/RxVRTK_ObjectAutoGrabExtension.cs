using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ObjectAutoGrabExtension
    {

        /// <summary>
        /// Observable ObjectAutoGrabCompleted event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> ObjectAutoGrabCompletedAsObservable(this VRTK_ObjectAutoGrab events)
        {
            return Observable.FromEvent<ObjectAutoGrabEventHandler, Object>(
                 h => h.Invoke,
                 h => events.ObjectAutoGrabCompleted += h,
                 h => events.ObjectAutoGrabCompleted -= h);
        }

    }
}