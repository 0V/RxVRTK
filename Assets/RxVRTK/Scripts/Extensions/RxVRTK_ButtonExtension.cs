using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_ButtonExtension
    {

        /// <summary>
        /// Observable Pushed event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Control3DEventArgs> PushedAsObservable(this VRTK_Button events)
        {
            return Observable.FromEvent<Button3DEventHandler, Control3DEventArgs>(
                 h => (s, e) => h(e),
                 h => events.Pushed += h,
                 h => events.Pushed -= h);
        }

        /// <summary>
        /// Observable Released event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Control3DEventArgs> ReleasedAsObservable(this VRTK_Button events)
        {
            return Observable.FromEvent<Button3DEventHandler, Control3DEventArgs>(
                 h => (s, e) => h(e),
                 h => events.Released += h,
                 h => events.Released -= h);
        }

        /// <summary>
        /// Observable ValueChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Control3DEventArgs> ValueChangedAsObservable(this VRTK_Button events)
        {
            return Observable.FromEvent<Control3DEventHandler, Control3DEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ValueChanged += h,
                 h => events.ValueChanged -= h);
        }

    }
}