using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void RunJumpAnimation()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");

        _animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); 
    }

    public void LaunchAnimationOfWalking(bool isGround)
    {
        _animator.SetBool("isGround", isGround);
    }
}
