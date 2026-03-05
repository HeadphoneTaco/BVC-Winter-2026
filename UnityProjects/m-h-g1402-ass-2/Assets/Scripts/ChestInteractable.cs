using UnityEngine;

public class ChestInteractable : MonoBehaviour, IInteractable
{
   private static readonly int IsOpen = Animator.StringToHash("IsOpen");
   [SerializeField] private Animator anim;
   
   public void OnHoverIn()
   {
      Debug.Log("Interactor In");
      anim?.SetBool(IsOpen, true);
      
      //TODO - Show UI
      Toast.Instance.ShowToast("Press \"E\" to Interact");
   }
   
   public void OnHoverOff()
   {
      Debug.Log("Interactor Off");
      anim?.SetBool(IsOpen, false);
      //TODO - Hide UI
      Toast.Instance.HideToast();
   }
   
   public void OnInteract()
   {
      Debug.Log($"Interacted with {gameObject.name}");
      Destroy(gameObject);
   }
}
