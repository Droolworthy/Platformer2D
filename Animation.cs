using UnityEngine;

public class PlacementRestriction : MonoBehaviour
{
    [SerializeField] private float _minBounds;
    [SerializeField] private float _maxBounds;

    private Vector3 _clampedPosition;

    private void Update()
    {
        _clampedPosition = transform.position;

        _clampedPosition.x = Mathf.Clamp(_clampedPosition.x, _minBounds, _maxBounds);

        transform.position = _clampedPosition;
    }
}
