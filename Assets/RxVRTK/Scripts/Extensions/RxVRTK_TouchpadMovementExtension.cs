using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_TouchpadMovementExtension
    {

        /// <summary>
        /// Observable AxisMovement event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<TouchpadMovementAxisEventArgs> AxisMovementAsObservable(this VRTK_TouchpadMovement events)
        {
            return Observable.FromEvent<TouchpadMovementAxisEventHandler, TouchpadMovementAxisEventArgs>(
                 h => (s, e) => h(e),
                 h => events.AxisMovement += h,
                 h => events.AxisMovement -= h);
        }

    }
}