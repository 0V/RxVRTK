using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ControllerRigidbodyActivatorExtension
    {

        /// <summary>
        /// Observable ControllerRigidbodyOn event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerRigidbodyActivatorEventArgs> ControllerRigidbodyOnAsObservable(this VRTK_ControllerRigidbodyActivator events)
        {
            return Observable.FromEvent<ControllerRigidbodyActivatorEventHandler, ControllerRigidbodyActivatorEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerRigidbodyOn += h,
                 h => events.ControllerRigidbodyOn -= h);
        }

        /// <summary>
        /// Observable ControllerRigidbodyOff event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ControllerRigidbodyActivatorEventArgs> ControllerRigidbodyOffAsObservable(this VRTK_ControllerRigidbodyActivator events)
        {
            return Observable.FromEvent<ControllerRigidbodyActivatorEventHandler, ControllerRigidbodyActivatorEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ControllerRigidbodyOff += h,
                 h => events.ControllerRigidbodyOff -= h);
        }

    }
}