using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_SDKManagerExtension
    {

        /// <summary>
        /// Observable LoadedSetupChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<VRTK_SDKManager.LoadedSetupChangeEventArgs> LoadedSetupChangedAsObservable(this VRTK_SDKManager events)
        {
            return Observable.FromEvent<VRTK_SDKManager.LoadedSetupChangeEventHandler, VRTK_SDKManager.LoadedSetupChangeEventArgs>(
                 h => (s, e) => h(e),
                 h => events.LoadedSetupChanged += h,
                 h => events.LoadedSetupChanged -= h);
        }

    }
}