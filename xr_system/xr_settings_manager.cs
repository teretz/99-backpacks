using UnityEngine.XR;

public class XRSettingsManager : MonoBehaviour
{
    public bool enableStereoRendering = true;

    public void EnableVR()
    {
        XRSettings.enabled = true;
        XRSettings.useSinglePass = enableStereoRendering; // Example: Enable or disable stereo rendering
        // Additional XR settings configuration can be added here
    }

    public void DisableVR()
    {
        XRSettings.enabled = false;
    }
}