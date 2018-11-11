using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_UIDraggableItemExtension
    {

        /// <summary>
        /// Observable DraggableItemDropped event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIDraggableItemEventArgs> DraggableItemDroppedAsObservable(this VRTK_UIDraggableItem events)
        {
            return Observable.FromEvent<UIDraggableItemEventHandler, UIDraggableItemEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DraggableItemDropped += h,
                 h => events.DraggableItemDropped -= h);
        }

        /// <summary>
        /// Observable DraggableItemReset event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<UIDraggableItemEventArgs> DraggableItemResetAsObservable(this VRTK_UIDraggableItem events)
        {
            return Observable.FromEvent<UIDraggableItemEventHandler, UIDraggableItemEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DraggableItemReset += h,
                 h => events.DraggableItemReset -= h);
        }

    }
}