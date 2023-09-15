using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private SpriteRenderer _player;
    private Transform[] _points;
    private int _currentPoint;   

    private void Start()
    {
        _player = GetComponent<SpriteRenderer>();

        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(transform.position == target.position)
        {
            _player.flipX = false;

            _currentPoint++;

            if(_currentPoint >= _points.Length)
            {
                _currentPoint = 0;

                _player.flipX = true;
            }
        }
    }
}
