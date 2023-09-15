using UnityEngine;

[RequireComponent (typeof(PlayerMover))]
[RequireComponent(typeof(Jump))]
[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(Rotation))]
public class Movement : MonoBehaviour
{
    private PlayerMover _mover;
    private Jump _jump;
    private Animation _animation;
    private Rotation _rotation;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
        _jump = GetComponent<Jump>();
        _animation = GetComponent<Animation>();
        _rotation = GetComponent<Rotation>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        _jump.CheckingForGrounding(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _jump.CheckingAbsenceOfGrounding(collision);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
            _mover.MoveToRight();

        if (Input.GetKey(KeyCode.A))
            _mover.MoveToLeft();

        _jump.JumpAtTouchOfKey();

        _animation.RunJumpAnimation();

        _rotation.TurnTowardsWalking();
    }
}
