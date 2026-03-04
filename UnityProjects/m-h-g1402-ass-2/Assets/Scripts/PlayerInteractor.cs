using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractor : MonoBehaviour
{
    
    //Input
    [SerializeField] private InputActionReference interactionInput;
    
    private IInteractable _interactable;
    

    private void OnEnable()
    {
        interactionInput.action.performed += Interact;
    }

    private void OnDisable()
    {
        interactionInput.action.performed -= Interact;
    }

    private void OnTriggerEnter(Collider other)
    {
        _interactable = other.gameObject.GetComponent<IInteractable>();
        _interactable?.OnHoverIn();
    }

    private void OnTriggerExit(Collider other)
    {
        _interactable?.OnHoverOff();
        _interactable = null;
    }

    private void Interact(InputAction.CallbackContext context)
    {
      _interactable.OnInteract();  
    }
    
}
