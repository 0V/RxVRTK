using VRTK;
using UniRx;
using System;
namespace RxVRTK
{
    public static class RxVRTK_BodyPhysicsExtension
    {

        /// <summary>
        /// Observable StartFalling event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StartFallingAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartFalling += h,
                 h => events.StartFalling -= h);
        }

        /// <summary>
        /// Observable StopFalling event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StopFallingAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StopFalling += h,
                 h => events.StopFalling -= h);
        }

        /// <summary>
        /// Observable StartMoving event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StartMovingAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartMoving += h,
                 h => events.StartMoving -= h);
        }

        /// <summary>
        /// Observable StopMoving event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StopMovingAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StopMoving += h,
                 h => events.StopMoving -= h);
        }

        /// <summary>
        /// Observable StartColliding event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StartCollidingAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartColliding += h,
                 h => events.StartColliding -= h);
        }

        /// <summary>
        /// Observable StopColliding event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StopCollidingAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StopColliding += h,
                 h => events.StopColliding -= h);
        }

        /// <summary>
        /// Observable StartLeaning event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StartLeaningAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartLeaning += h,
                 h => events.StartLeaning -= h);
        }

        /// <summary>
        /// Observable StopLeaning event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StopLeaningAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StopLeaning += h,
                 h => events.StopLeaning -= h);
        }

        /// <summary>
        /// Observable StartTouchingGround event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StartTouchingGroundAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StartTouchingGround += h,
                 h => events.StartTouchingGround -= h);
        }

        /// <summary>
        /// Observable StopTouchingGround event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<BodyPhysicsEventArgs> StopTouchingGroundAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<BodyPhysicsEventHandler, BodyPhysicsEventArgs>(
                 h => (s, e) => h(e),
                 h => events.StopTouchingGround += h,
                 h => events.StopTouchingGround -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerEnter event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerEnterAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerEnter += h,
                 h => events.DestinationMarkerEnter -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerExit event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerExitAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerExit += h,
                 h => events.DestinationMarkerExit -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerHover event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerHoverAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerHover += h,
                 h => events.DestinationMarkerHover -= h);
        }

        /// <summary>
        /// Observable DestinationMarkerSet event
        /// </summary>
        /// <param name="events"></param>
        /// <returns></returns>
        public static IObservable<DestinationMarkerEventArgs> DestinationMarkerSetAsObservable(this VRTK_BodyPhysics events)
        {
            return Observable.FromEvent<DestinationMarkerEventHandler, DestinationMarkerEventArgs>(
                 h => (s, e) => h(e),
                 h => events.DestinationMarkerSet += h,
                 h => events.DestinationMarkerSet -= h);
        }

    }
}