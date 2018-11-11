using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ObjectControlExtension
    {

        /// <summary>
        /// Observable XAxisChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectControlEventArgs> XAxisChangedAsObservable(this VRTK_ObjectControl events)
        {
            return Observable.FromEvent<ObjectControlEventHandler, ObjectControlEventArgs>(
                 h => (s, e) => h(e),
                 h => events.XAxisChanged += h,
                 h => events.XAxisChanged -= h);
        }

        /// <summary>
        /// Observable YAxisChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<ObjectControlEventArgs> YAxisChangedAsObservable(this VRTK_ObjectControl events)
        {
            return Observable.FromEvent<ObjectControlEventHandler, ObjectControlEventArgs>(
                 h => (s, e) => h(e),
                 h => events.YAxisChanged += h,
                 h => events.YAxisChanged -= h);
        }

    }
}