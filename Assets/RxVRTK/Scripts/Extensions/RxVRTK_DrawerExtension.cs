using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_DrawerExtension
    {

        /// <summary>
        /// Observable ValueChanged event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<Control3DEventArgs> ValueChangedAsObservable(this VRTK_Drawer events)
        {
            return Observable.FromEvent<Control3DEventHandler, Control3DEventArgs>(
                 h => (s, e) => h(e),
                 h => events.ValueChanged += h,
                 h => events.ValueChanged -= h);
        }

    }
}