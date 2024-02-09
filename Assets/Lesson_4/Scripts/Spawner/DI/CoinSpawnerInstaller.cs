using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.Spawner.DI
{
    public class CoinSpawnerInstaller : MonoInstaller
    {
        [SerializeField] private CoinSpawnerConfig _config;

        public override void InstallBindings()
        {
            Container.Bind<CoinSpawnerConfig>().FromInstance(_config).AsSingle();

            Container.Bind<CoinSpawner>().AsSingle();
        }
    }
}