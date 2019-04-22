#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class AppSetting : Setting<AppSetting>
{
#if UNITY_EDITOR
    #region Setup
    [MenuItem("Settings/AppSetting")]
    public static void Edit()
    {
        Selection.activeObject = Instance;
    }

    protected override void OnCreated()
    {
    }
    #endregion
#endif

    #region Varibles
    public XRSDK applicationType = XRSDK.NVR;
    #endregion

    #region DataTypes
    public enum XRSDK
    {
        Oculus,
        Steam,
        NVR,
        VRTK,
        WindowsMR
    }
    #endregion

}
