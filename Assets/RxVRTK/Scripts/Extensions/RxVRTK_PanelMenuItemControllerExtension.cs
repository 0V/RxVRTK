using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_PanelMenuItemControllerExtension
    {

        /// <summary>
        /// Observable PanelMenuItemShowing event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemShowingAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemShowing += h,
                 h => events.PanelMenuItemShowing -= h);
        }

        /// <summary>
        /// Observable PanelMenuItemHiding event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemHidingAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemHiding += h,
                 h => events.PanelMenuItemHiding -= h);
        }

        /// <summary>
        /// Observable PanelMenuItemSwipeLeft event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemSwipeLeftAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemSwipeLeft += h,
                 h => events.PanelMenuItemSwipeLeft -= h);
        }

        /// <summary>
        /// Observable PanelMenuItemSwipeRight event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemSwipeRightAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemSwipeRight += h,
                 h => events.PanelMenuItemSwipeRight -= h);
        }

        /// <summary>
        /// Observable PanelMenuItemSwipeTop event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemSwipeTopAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemSwipeTop += h,
                 h => events.PanelMenuItemSwipeTop -= h);
        }

        /// <summary>
        /// Observable PanelMenuItemSwipeBottom event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemSwipeBottomAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemSwipeBottom += h,
                 h => events.PanelMenuItemSwipeBottom -= h);
        }

        /// <summary>
        /// Observable PanelMenuItemTriggerPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<PanelMenuItemControllerEventArgs> PanelMenuItemTriggerPressedAsObservable(this VRTK_PanelMenuItemController events)
        {
            return Observable.FromEvent<PanelMenuItemControllerEventHandler, PanelMenuItemControllerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.PanelMenuItemTriggerPressed += h,
                 h => events.PanelMenuItemTriggerPressed -= h);
        }

    }
}