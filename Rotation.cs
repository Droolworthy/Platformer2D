using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Rotation : MonoBehaviour
{
    private SpriteRenderer _player;
    private float _inputHorizontal;

    private void Start()
    {
        _player = GetComponent<SpriteRenderer>();
    }

    public void TurnTowardsWalking() 
    {
        _inputHorizontal = Input.GetAxis("Horizontal");

        if (_inputHorizontal > 0)
        {
            _player.flipX = false;
        }

        if (_inputHorizontal < 0)
        {
            _player.flipX = true;
        }
    }
}
