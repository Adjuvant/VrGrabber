using UnityEngine;
using UnityEditor;

public class PackageTool
{
    [MenuItem("Package/Update Package")]
    static void UpdatePackage()
    {
        AssetDatabase.ExportPackage(new string[] { "Assets/VrGrabber" , "Assets/Settings", "Assets/NewtonVR" }, "VrGrabber.unitypackage", ExportPackageOptions.Recurse);
    }
}
