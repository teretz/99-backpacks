using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionController : XRBaseInteractable
{
    public GameObject highlightEffect;

    protected override void OnSelectEnteringing(XRBaseInteractor interactor)
    {
        base.OnSelectEntering(interactor);
        highlightEffect.SetActive(true); // Example: Enable highlight effect when object is selected
    }

    protected override void OnSelectExiting(XRBaseInteractor interactor)
    {
        base.OnSelectExiting(interactor);
        highlightEffect.SetActive(false); // Example: Disable highlight effect when object is deselected
    }
}