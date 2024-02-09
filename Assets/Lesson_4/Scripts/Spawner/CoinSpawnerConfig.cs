using UnityEngine;

namespace Lesson_4.Scripts.Spawner
{
    [CreateAssetMenu(fileName = "Coin spawner config", menuName = "Configs/Coin spawner")]
    public class CoinSpawnerConfig : ScriptableObject
    {
        [SerializeField, Range(.2f, 3f)] private float _spawnCooldown;
        [SerializeField] private GameObject _coinPrefab;

        public float SpawnCooldown => _spawnCooldown;
        public GameObject CoinPrefab => _coinPrefab;
    }
}