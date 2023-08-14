using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractionController : XRBaseInteractable
{
    public GameObject highlightEffect;

    protected override void OnSelectEnter(XRBaseInteractor interactor)
    {
        base.OnSelectEnter(interactor);
        highlightEffect.SetActive(true); // Example: Enable highlight effect when object is selected
    }

    protected override void OnSelectExit(XRBaseInteractor interactor)
    {
        base.OnSelectExit(interactor);
        highlightEffect.SetActive(false); // Example: Disable highlight effect when object is deselected
    }
}