using UnityEngine;

public class ChestInteractable : MonoBehaviour, IInteractable
{
   public void OnHoverIn()
   {
      Debug.Log("Interactor In");
   }
   
   public void OnHoverOff()
   {
      Debug.Log("Interactor Off");
   }
   
   public void OnInteract()
   {
      Destroy(gameObject);
   }
}
