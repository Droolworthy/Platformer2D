using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay;

    private Coroutine _coroutine;

    private void Start()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(Play());
    }

    private IEnumerator Play()
    {
        bool isWork = true;

        while (isWork)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            Instantiate(_coin, _spawnPoints[spawnPointNumber].position, Quaternion.identity);

            yield return new WaitForSeconds(_delay);
        }
    }
}
