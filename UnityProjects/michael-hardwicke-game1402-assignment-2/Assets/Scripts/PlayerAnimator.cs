using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private static readonly int IsGrounded = Animator.StringToHash("IsGrounded");
    private static readonly int Velocity = Animator.StringToHash("Velocity");
    private static readonly int Jump = Animator.StringToHash("Jump");
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Animator anim;

    void Update()
    {
        anim.SetBool(IsGrounded, playerController.IsGrounded());
        anim.SetFloat(Velocity, playerController.GetPlayerVelocity().sqrMagnitude);
    }

    void OnEnable()
    {
        playerController.OnJumpEvent += OnJump;
    }

    void OnDisable()
    {
        playerController.OnJumpEvent -= OnJump;
    }

    private void OnJump()
    {
        anim.SetTrigger(Jump);
    }
}