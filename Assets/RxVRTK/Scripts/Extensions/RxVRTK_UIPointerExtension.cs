using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_UIPointerExtension
    {

        /// <summary>
        /// Observable ActivationButtonPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ActivationButtonPressedAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ActivationButtonPressed += h,
                 h => events.ActivationButtonPressed -= h);
        }

        /// <summary>
        /// Observable ActivationButtonReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> ActivationButtonReleasedAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ActivationButtonReleased += h,
                 h => events.ActivationButtonReleased -= h);
        }

        /// <summary>
        /// Observable SelectionButtonPressed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> SelectionButtonPressedAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.SelectionButtonPressed += h,
                 h => events.SelectionButtonPressed -= h);
        }

        /// <summary>
        /// Observable SelectionButtonReleased event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerInteractionEventArgs> SelectionButtonReleasedAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<ControllerInteractionEventHandler, ControllerInteractionEventArgs>(
                 h => (s, e) => h(e),
                 h => events.SelectionButtonReleased += h,
                 h => events.SelectionButtonReleased -= h);
        }

        /// <summary>
        /// Observable UIPointerElementEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIPointerEventArgs> UIPointerElementEnterAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<UIPointerEventHandler, UIPointerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UIPointerElementEnter += h,
                 h => events.UIPointerElementEnter -= h);
        }

        /// <summary>
        /// Observable UIPointerElementExit event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIPointerEventArgs> UIPointerElementExitAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<UIPointerEventHandler, UIPointerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UIPointerElementExit += h,
                 h => events.UIPointerElementExit -= h);
        }

        /// <summary>
        /// Observable UIPointerElementClick event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIPointerEventArgs> UIPointerElementClickAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<UIPointerEventHandler, UIPointerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UIPointerElementClick += h,
                 h => events.UIPointerElementClick -= h);
        }

        /// <summary>
        /// Observable UIPointerElementDragStart event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIPointerEventArgs> UIPointerElementDragStartAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<UIPointerEventHandler, UIPointerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UIPointerElementDragStart += h,
                 h => events.UIPointerElementDragStart -= h);
        }

        /// <summary>
        /// Observable UIPointerElementDragEnd event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIPointerEventArgs> UIPointerElementDragEndAsObservable(this VRTK_UIPointer events)
        {
            return Observable.FromEvent<UIPointerEventHandler, UIPointerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.UIPointerElementDragEnd += h,
                 h => events.UIPointerElementDragEnd -= h);
        }

    }
}