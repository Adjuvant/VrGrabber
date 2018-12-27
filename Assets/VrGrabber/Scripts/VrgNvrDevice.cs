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
            var holdLeft = Input.GetAxis("Axis1D_PrimaryHandTrigger");
            var holdRight = Input.GetAxis("Axis1D_SecondaryHandTrigger");
            
            return side == ControllerSide.Left ? holdLeft : holdRight;
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
            var xLeft = Input.GetAxis("Axis2D_PrimaryThumbstick_Horizontal");
            var yLeft = Input.GetAxis("Axis2D_PrimaryThumbstick_Vertical");
            var xRight = Input.GetAxis("Axis2D_SecondaryThumbstick_Horizontal");
            var yRight = Input.GetAxis("Axis2D_SecondaryThumbstick_Vertical");
            return (side == ControllerSide.Left) ?
                 new Vector2(xLeft, yLeft) :
                 new Vector2(xRight, yRight);
        }
    }

}
#endif
