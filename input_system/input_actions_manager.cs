using UnityEngine;
using UnityEngine.XR;

public class InputActionsManager : MonoBehaviour
{
    public XRController leftController;
    public XRController rightController;
    public XRBaseInteractable leftHandGrabbable;
    public XRBaseInteractable rightHandGrabbable;

    private void Update()
    {
        HandleGrabAction(leftController, leftHandGrabbable);
        HandleGrabAction(rightController, rightHandGrabbable);
    }

    private void HandleGrabAction(XRController controller, XRBaseInteractable grabbable)
    {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out bool isGrabbing) && isGrabbing)
        {
            grabbable.BeginInteraction(controller);
        }
        else
        {
            grabbable.EndInteraction(controller);
        }
    }
}