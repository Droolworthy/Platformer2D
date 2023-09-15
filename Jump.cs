using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animation))]
public class Jump : MonoBehaviour
{
    [SerializeField] private float _jumpPower;

    private Animation _animator;
    private Rigidbody2D _player;
    private bool _isGround;

    private void Start()
    {
        _player = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animation>();
    }

    public void CheckingForGrounding(Collider2D collision)
    {
        bool isGround = true;

        CheckGrounding(collision, isGround);
    }

    public void CheckingAbsenceOfGrounding(Collider2D collision)
    {
        bool isGround = false;

        CheckGrounding(collision, isGround);
    }

    public void JumpAtTouchOfKey()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _player.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }

    private void CheckGrounding(Collider2D collision, bool isGround)
    {
        if (collision.TryGetComponent<Ground>(out Ground ground))
        {
            _isGround = isGround;

            _animator.LaunchAnimationOfWalking(isGround);
        }
    }
}
