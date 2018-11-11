using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_HeadsetFadeExtension
    {

        /// <summary>
        /// Observable HeadsetFadeStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetFadeEventArgs> HeadsetFadeStartAsObservable(this VRTK_HeadsetFade events)
        {
            return Observable.FromEvent<HeadsetFadeEventHandler, HeadsetFadeEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HeadsetFadeStart += h,
                 h => events.HeadsetFadeStart -= h);
        }

        /// <summary>
        /// Observable HeadsetFadeComplete event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetFadeEventArgs> HeadsetFadeCompleteAsObservable(this VRTK_HeadsetFade events)
        {
            return Observable.FromEvent<HeadsetFadeEventHandler, HeadsetFadeEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HeadsetFadeComplete += h,
                 h => events.HeadsetFadeComplete -= h);
        }

        /// <summary>
        /// Observable HeadsetUnfadeStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetFadeEventArgs> HeadsetUnfadeStartAsObservable(this VRTK_HeadsetFade events)
        {
            return Observable.FromEvent<HeadsetFadeEventHandler, HeadsetFadeEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HeadsetUnfadeStart += h,
                 h => events.HeadsetUnfadeStart -= h);
        }

        /// <summary>
        /// Observable HeadsetUnfadeComplete event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<HeadsetFadeEventArgs> HeadsetUnfadeCompleteAsObservable(this VRTK_HeadsetFade events)
        {
            return Observable.FromEvent<HeadsetFadeEventHandler, HeadsetFadeEventArgs>(
                 h => (s, e) => h(e),
                 h => events.HeadsetUnfadeComplete += h,
                 h => events.HeadsetUnfadeComplete -= h);
        }

    }
}