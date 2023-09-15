using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _speed;

    private Coroutine _coroutine;

    private void Start()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(Play());
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }   

    private IEnumerator Play()
    {
        bool isWork = true;

        int delay = 2;

        while (isWork)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            Instantiate(_enemy, _spawnPoints[spawnPointNumber]);

            yield return new WaitForSeconds(delay);
        }
    }
}
