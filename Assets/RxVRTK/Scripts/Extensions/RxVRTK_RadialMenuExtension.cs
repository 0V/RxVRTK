using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_RadialMenuExtension
    {

        /// <summary>
        /// Observable FireHapticPulse event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Single> FireHapticPulseAsObservable(this VRTK_RadialMenu events)
        {
            return Observable.FromEvent<HapticPulseEventHandler, Single>(
                 h => h.Invoke,
                 h => events.FireHapticPulse += h,
                 h => events.FireHapticPulse -= h);
        }

    }
}