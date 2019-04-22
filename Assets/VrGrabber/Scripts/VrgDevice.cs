using UnityEngine;

namespace VrGrabber
{
    public class Device
    {
        static IDevice _instance;
        public static IDevice instance
        {
            get
            {
                if (_instance == null)
                {
                    switch (AppSetting.Instance.applicationType)
                    {
                        case AppSetting.XRSDK.NVR:
                            _instance = new VrgNvrDevice();
                            break;
                        case AppSetting.XRSDK.Oculus:
                            _instance = new VrgOculusTouchDevice();
                            break;
                        case AppSetting.XRSDK.WindowsMR:
#if UNITY_WSA
                    _instance = new VrgWinMRMotionControllerDevice();
#elif !UNITY_WSA
                            Debug.LogError("WindowsMR Not implemented/Setup.");
#endif
                            break;
                    }
                }
                return _instance;
            }
        }

        public Vector3 GetLocalPosition(ControllerSide side)
        {
            return _instance.GetLocalPosition(side);
        }

        public Quaternion GetLocalRotation(ControllerSide side)
        {
            return _instance.GetLocalRotation(side);
        }

        public float GetHold(ControllerSide side)
        {
            return _instance.GetHold(side);
        }

        public bool GetHover(ControllerSide side)
        {
            return _instance.GetHover(side);
        }

        public bool GetClick(ControllerSide side)
        {
            return _instance.GetClick(side);
        }

        public Vector2 GetCoord(ControllerSide side)
        {
            return _instance.GetCoord(side);
        }
    }
}