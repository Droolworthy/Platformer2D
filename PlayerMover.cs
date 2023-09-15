using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _direction;

    public void MoveToRight()
    {
        SetNextPosition(_direction);       
    }

    public void MoveToLeft()
    {
        float coordinate = -1;

        _direction *= coordinate;

        SetNextPosition(_direction);
    }

    private void SetNextPosition(float coordinate) 
    {
        _direction = _speed * Time.deltaTime;

        transform.Translate(coordinate, 0, 0);
    }
}
