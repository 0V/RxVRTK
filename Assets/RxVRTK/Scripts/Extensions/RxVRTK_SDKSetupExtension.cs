using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_SDKSetupExtension
    {

        /// <summary>
        /// Observable Loaded event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<VRTK_SDKSetup> LoadedAsObservable(this VRTK_SDKSetup events)
        {
            return Observable.FromEvent<VRTK_SDKSetup.LoadEventHandler, VRTK_SDKSetup>(
                 h => (s, e) => h(e),
                 h => events.Loaded += h,
                 h => events.Loaded -= h);
        }

        /// <summary>
        /// Observable Unloaded event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<VRTK_SDKSetup> UnloadedAsObservable(this VRTK_SDKSetup events)
        {
            return Observable.FromEvent<VRTK_SDKSetup.LoadEventHandler, VRTK_SDKSetup>(
                 h => (s, e) => h(e),
                 h => events.Unloaded += h,
                 h => events.Unloaded -= h);
        }

    }
}