using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lesson_4.Scripts.Spawner
{
    public class CoinSpawner
    {
        private float _spawnCooldown; 
        private GameObject _coinPrefab;
        private SpawnPointsTracker _pointsTracker;
        private CoroutineInvoker _coroutineInvoker;
        private CoinFactory _coinFactory;
        
        private List<GameObject> _coins = new ();

        private const string SPAWN_ROUTINE_NAME = "SpawnCoin";

        public CoinSpawner(CoinSpawnerConfig config, CoroutineInvoker coroutineInvoker, SpawnPointsTracker pointsTracker, CoinFactory coinFactory)
        {
            _spawnCooldown = config.SpawnCooldown;
            _coinPrefab = config.CoinPrefab;
            _pointsTracker = pointsTracker;
            _coroutineInvoker = coroutineInvoker;
            _coinFactory = coinFactory;
        }

        public void StartSpawn() => _coroutineInvoker.StartRoutine(SPAWN_ROUTINE_NAME, StartSpawnRoutine());

        public void DestroyRandomCoin()
        {
            if (_coins.Count <= 0) 
                return;
            
            int randomIndex = Random.Range(0, _coins.Count);
            _pointsTracker.ReleasePoint(_coins[randomIndex].transform.position);
            GameObject.Destroy(_coins[randomIndex]);
            _coins.RemoveAt(randomIndex);

            StartSpawn();
        }

        public void DestroyAllCoins()
        {
            if (_coins.Count <= 0) 
                return;
            
            _coins.ForEach(coin =>
            {
                _pointsTracker.ReleasePoint(coin.transform.position);
                GameObject.Destroy(coin);
            });

            _coins = new List<GameObject>();
            StartSpawn();
        }

        private IEnumerator StartSpawnRoutine()
        {
            while (_pointsTracker.TryGetRandomPoint(out Vector3 spawnPosition))
            {
                yield return new WaitForSeconds(_spawnCooldown);

                SpawnCoin(spawnPosition);
            }
            
            _coroutineInvoker.ReleaseRoutine(SPAWN_ROUTINE_NAME);
        }

        private void SpawnCoin(Vector3 spawnPosition)
        {
            GameObject coin = _coinFactory.Get(_coinPrefab, spawnPosition, Quaternion.identity);
            _coins.Add(coin);
        }
    }
}
