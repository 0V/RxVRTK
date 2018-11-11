using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ControllerTooltipsExtension
    {

        /// <summary>
        /// Observable ControllerTooltipOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerTooltipsEventArgs> ControllerTooltipOnAsObservable(this VRTK_ControllerTooltips events)
        {
            return Observable.FromEvent<ControllerTooltipsEventHandler, ControllerTooltipsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerTooltipOn += h,
                 h => events.ControllerTooltipOn -= h);
        }

        /// <summary>
        /// Observable ControllerTooltipOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerTooltipsEventArgs> ControllerTooltipOffAsObservable(this VRTK_ControllerTooltips events)
        {
            return Observable.FromEvent<ControllerTooltipsEventHandler, ControllerTooltipsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerTooltipOff += h,
                 h => events.ControllerTooltipOff -= h);
        }

    }
}