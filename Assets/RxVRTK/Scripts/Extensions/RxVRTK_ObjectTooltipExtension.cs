using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ObjectTooltipExtension
    {

        /// <summary>
        /// Observable ObjectTooltipReset event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectTooltipEventArgs> ObjectTooltipResetAsObservable(this VRTK_ObjectTooltip events)
        {
            return Observable.FromEvent<ObjectTooltipEventHandler, ObjectTooltipEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ObjectTooltipReset += h,
                 h => events.ObjectTooltipReset -= h);
        }

        /// <summary>
        /// Observable ObjectTooltipTextUpdated event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectTooltipEventArgs> ObjectTooltipTextUpdatedAsObservable(this VRTK_ObjectTooltip events)
        {
            return Observable.FromEvent<ObjectTooltipEventHandler, ObjectTooltipEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ObjectTooltipTextUpdated += h,
                 h => events.ObjectTooltipTextUpdated -= h);
        }

    }
}