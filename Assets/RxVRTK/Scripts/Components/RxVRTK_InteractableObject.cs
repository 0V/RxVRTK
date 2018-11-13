using UniRx;
using VRTK;

namespace RxVRTK
{
    public class RxVRTK_InteractableObject : VRTK_InteractableObject
    {
        #region StartTouching

        Subject<VRTK_InteractTouch> onStartTouching;

        public override void StartTouching(VRTK_InteractTouch currentTouchingObject = null)
        {
            base.StartTouching(currentTouchingObject);
            if (onStartTouching != null) onStartTouching.OnNext(currentTouchingObject);
        }

        /// <summary>
        /// Observable StartTouching event
        /// </summary>
        /// <returns></returns>
        public IObservable<VRTK_InteractTouch> StartTouchingAsObservable()
        {
            return onStartTouching ?? (onStartTouching = new Subject<VRTK_InteractTouch>());
        }

        #endregion


        #region StopTouching

        Subject<VRTK_InteractTouch> onStopTouching;

        public override void StopTouching(VRTK_InteractTouch currentTouchingObject = null)
        {
            base.StopTouching(currentTouchingObject);
            if (onStopTouching != null) onStopTouching.OnNext(currentTouchingObject);
        }

        /// <summary>
        /// Observable StopTouching event
        /// </summary>
        /// <returns></returns>
        public IObservable<VRTK_InteractTouch> StopTouchingAsObservable()
        {
            return onStopTouching ?? (onStopTouching = new Subject<VRTK_InteractTouch>());
        }

        #endregion


        #region Grabbed

        Subject<VRTK_InteractGrab> onGrabbed;

        public override void Grabbed(VRTK_InteractGrab currentTouchingObject = null)
        {
            base.Grabbed(currentTouchingObject);
            if (onGrabbed != null) onGrabbed.OnNext(currentTouchingObject);
        }

        /// <summary>
        /// Observable Grabbed event
        /// </summary>
        /// <returns></returns>
        public IObservable<VRTK_InteractGrab> GrabbedAsObservable()
        {
            return onGrabbed ?? (onGrabbed = new Subject<VRTK_InteractGrab>());
        }

        #endregion


        #region Ungrabbed

        Subject<VRTK_InteractGrab> onUngrabbed;

        public override void Ungrabbed(VRTK_InteractGrab currentTouchingObject = null)
        {
            base.Ungrabbed(currentTouchingObject);
            if (onUngrabbed != null) onUngrabbed.OnNext(currentTouchingObject);
        }

        /// <summary>
        /// Observable Ungrabbed event
        /// </summary>
        /// <returns></returns>
        public IObservable<VRTK_InteractGrab> UngrabbedAsObservable()
        {
            return onUngrabbed ?? (onUngrabbed = new Subject<VRTK_InteractGrab>());
        }

        #endregion


        #region StartUsing

        Subject<VRTK_InteractUse> onStartUsing;

        public override void StartUsing(VRTK_InteractUse currentTouchingObject = null)
        {
            base.StartUsing(currentTouchingObject);
            if (onStartUsing != null) onStartUsing.OnNext(currentTouchingObject);
        }

        /// <summary>
        /// Observable StartUsing event
        /// </summary>
        /// <returns></returns>
        public IObservable<VRTK_InteractUse> StartUsingAsObservable()
        {
            return onStartUsing ?? (onStartUsing = new Subject<VRTK_InteractUse>());
        }

        #endregion


        #region StopUsing

        Subject<VRTK_InteractUse> onStopUsing;

        public override void StopUsing(VRTK_InteractUse currentTouchingObject = null)
        {
            base.StopUsing(currentTouchingObject);
            if (onStopUsing != null) onStopUsing.OnNext(currentTouchingObject);
        }

        /// <summary>
        /// Observable StopUsing event
        /// </summary>
        /// <returns></returns>
        public IObservable<VRTK_InteractUse> StopUsingAsObservable()
        {
            return onStopUsing ?? (onStopUsing = new Subject<VRTK_InteractUse>());
        }

        #endregion


        void OnDestroy()
        {
            if (onStartTouching != null)
            {
                onStartTouching.OnCompleted();
            }

            if (onStopTouching != null)
            {
                onStopTouching.OnCompleted();
            }

            if (onGrabbed != null)
            {
                onGrabbed.OnCompleted();
            }

            if (onUngrabbed != null)
            {
                onUngrabbed.OnCompleted();
            }

            if (onStartUsing != null)
            {
                onStartUsing.OnCompleted();
            }

            if (onStopUsing != null)
            {
                onStopUsing.OnCompleted();
            }
        }
    }
}