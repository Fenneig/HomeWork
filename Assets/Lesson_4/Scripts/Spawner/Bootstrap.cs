using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.Spawner
{
    public class Bootstrap : MonoBehaviour
    {
        private CoinSpawner _coinSpawner;

        [Inject]
        private void Construct(CoinSpawner coinSpawner) => _coinSpawner = coinSpawner;
        
        private void Start() => _coinSpawner.StartSpawn();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                _coinSpawner.DestroyRandomCoin();
            
            if (Input.GetKeyDown(KeyCode.E))
                _coinSpawner.DestroyAllCoins();
        }
    }
}