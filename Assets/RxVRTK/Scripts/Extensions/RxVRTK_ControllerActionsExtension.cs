using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ControllerActionsExtension
    {
        [Obsolete("`VRTK_ControllerActions.ControllerModelVisible` has been replaced with `VRTK_ControllerEvents.ControllerVisible`. This method will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable ControllerModelVisible event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerActionsEventArgs> ControllerModelVisibleAsObservable(this VRTK_ControllerActions events)
        {
            return Observable.FromEvent<ControllerActionsEventHandler, ControllerActionsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerModelVisible += h,
                 h => events.ControllerModelVisible -= h);
        }
        [Obsolete("`VRTK_ControllerActions.ControllerModelInvisible` has been replaced with `VRTK_ControllerEvents.ControllerHidden`. This method will be removed in a future version of VRTK.")]
        /// <summary>
        /// Observable ControllerModelInvisible event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerActionsEventArgs> ControllerModelInvisibleAsObservable(this VRTK_ControllerActions events)
        {
            return Observable.FromEvent<ControllerActionsEventHandler, ControllerActionsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerModelInvisible += h,
                 h => events.ControllerModelInvisible -= h);
        }

    }
}