using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionDetector : MonoBehaviour
{
    private IInteractable interactableInRange = null;
    public GameObject interactionIcon;
   
    void Start()
    {
        interactionIcon.SetActive(false); //interaction icon is hidden when the game starts
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            interactableInRange?.Interact(); //detects an interaction within interactable range

            //Title: Add an Interaction System to your Game - Top Down Unity 2D #16
            //Author: YouTube- Game Code Library
            //Date: 03 May 2025
            //Code Version: 6000.0.49f1 (LTS)
            //Availibility: https://www.youtube.com/watch?v=eSH9mzcMRqw


        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //if an interaction is sensed in an interactable range, the interaction icon will pop up
    {
        if(collision.TryGetComponent(out IInteractable interactable) && interactable.CanInteract())
        {
            interactableInRange = interactable;
            interactionIcon.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)// if no interaction is sensed, or character is out of an interactable range, the icon will go away
    {
        if (collision.TryGetComponent(out IInteractable interactable) && interactable == interactableInRange)
        {
            interactableInRange = null;
            interactionIcon.SetActive(false);
        }
    }


}
