#if !UNITY_WSA
using UnityEngine;

namespace VrGrabber
{

    public class VrgNvrDevice : IDevice
    {

        private NewtonVR.NVRHand GetOVRController(ControllerSide side)
        {

            return (side == ControllerSide.Left) ?
                NewtonVR.NVRPlayer.Instance.LeftHand :
                NewtonVR.NVRPlayer.Instance.RightHand;
        }

        public Vector3 GetLocalPosition(ControllerSide side)
        {
            return GetOVRController(side).transform.localPosition;
        }

        public Quaternion GetLocalRotation(ControllerSide side)
        {
            return Quaternion.LookRotation(GetOVRController(side).CurrentForward);
            //return GetOVRController(side).transform.localRotation;
        }

        public float GetHold(ControllerSide side)
        {
            // Using grip button, not trigger
            return GetOVRController(side).HoldButtonAxis;
        }

        public bool GetHover(ControllerSide side)
        {
            return GetOVRController(side).IsHovering;
        }

        public bool GetClick(ControllerSide side)
        {
            return GetOVRController(side).UseButtonPressed;
        }

        public Vector2 GetCoord(ControllerSide side)
        {
            return GetOVRController(side).TouchAxis;
        }
    }

}
#endif
