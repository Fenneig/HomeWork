using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lesson_3.Scripts.Spawner
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField, Range(.2f, 2f)] private float _spawnCooldown; 
        [SerializeField] private GameObject _coinPrefab;
        [SerializeField] private SpawnPointsTracker _pointsTracker;

        private List<GameObject> _coins = new ();

        private Coroutine _routine;

        private void Start()
        {
            _routine = StartCoroutine(StartSpawnRoutine());
        }

        private IEnumerator StartSpawnRoutine()
        {
            while (_pointsTracker.TryGetRandomPoint(out Vector3 spawnPosition))
            {
                yield return new WaitForSeconds(_spawnCooldown);
                
                GameObject coin = Instantiate(_coinPrefab, spawnPosition, Quaternion.identity);
                _coins.Add(coin);
            }

            _routine = null;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (_coins.Count > 0)
                {
                    int randomIndex = Random.Range(0, _coins.Count);
                    _pointsTracker.ReleasePoint(_coins[randomIndex].transform.position);
                    Destroy(_coins[randomIndex]);
                    _coins.RemoveAt(randomIndex);
                    _routine ??= StartCoroutine(StartSpawnRoutine());
                }
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                _coins.ForEach(coin =>
                {
                    _pointsTracker.ReleasePoint(coin.transform.position);
                    Destroy(coin);
                });

                _coins = new List<GameObject>();
                _routine ??= StartCoroutine(StartSpawnRoutine());
            }
        }
    }
}
