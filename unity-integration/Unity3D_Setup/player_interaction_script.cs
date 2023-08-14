using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
  public float interactionRange = 5f;
  public LayerMask interactableLayer;

  void Update() {
    if (Input.GetKeyDown(KeyCode.E)) {
      Interact();
    }
  }

  void Interact() {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit, interactionRange, interactableLayer)) {
      IInteractable interactable = hit.collider.GetComponent<IInteractable>();
      if (interactable != null) {
        interactable.Interact();
      }
    }
  }
}