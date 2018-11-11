using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_PointerDirectionIndicatorExtension
    {

        /// <summary>
        /// Observable PointerDirectionIndicatorPositionSet event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Object> PointerDirectionIndicatorPositionSetAsObservable(this VRTK_PointerDirectionIndicator events)
        {
            return Observable.FromEvent<PointerDirectionIndicatorEventHandler, Object>(
                 h => h.Invoke,
                 h => events.PointerDirectionIndicatorPositionSet += h,
                 h => events.PointerDirectionIndicatorPositionSet -= h);
        }

    }
}