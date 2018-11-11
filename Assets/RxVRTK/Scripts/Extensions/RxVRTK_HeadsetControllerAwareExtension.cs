using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_HeadsetControllerAwareExtension
    {

        /// <summary>
        /// Observable ControllerObscured event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetControllerAwareEventArgs> ControllerObscuredAsObservable(this VRTK_HeadsetControllerAware events)
        {
            return Observable.FromEvent<HeadsetControllerAwareEventHandler, HeadsetControllerAwareEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerObscured += h,
                 h => events.ControllerObscured -= h);
        }

        /// <summary>
        /// Observable ControllerUnobscured event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetControllerAwareEventArgs> ControllerUnobscuredAsObservable(this VRTK_HeadsetControllerAware events)
        {
            return Observable.FromEvent<HeadsetControllerAwareEventHandler, HeadsetControllerAwareEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerUnobscured += h,
                 h => events.ControllerUnobscured -= h);
        }

        /// <summary>
        /// Observable ControllerGlanceEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetControllerAwareEventArgs> ControllerGlanceEnterAsObservable(this VRTK_HeadsetControllerAware events)
        {
            return Observable.FromEvent<HeadsetControllerAwareEventHandler, HeadsetControllerAwareEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerGlanceEnter += h,
                 h => events.ControllerGlanceEnter -= h);
        }

        /// <summary>
        /// Observable ControllerGlanceExit event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetControllerAwareEventArgs> ControllerGlanceExitAsObservable(this VRTK_HeadsetControllerAware events)
        {
            return Observable.FromEvent<HeadsetControllerAwareEventHandler, HeadsetControllerAwareEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerGlanceExit += h,
                 h => events.ControllerGlanceExit -= h);
        }

    }
}