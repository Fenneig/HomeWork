using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.Spawner
{
    public class CoinFactory
    {
        private DiContainer _diContainer;

        public CoinFactory(DiContainer diContainer) => _diContainer = diContainer;

        public GameObject Get(GameObject prefab, Vector3 spawnPosition, Quaternion identity) =>
            _diContainer.InstantiatePrefab(prefab, spawnPosition, identity, null);
    }
}