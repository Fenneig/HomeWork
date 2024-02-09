using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.Spawner.DI
{
    public class SpawnPointsTrackerInstaller : MonoInstaller
    {
        [SerializeField] private SpawnPointsTracker _pointsTracker;

        public override void InstallBindings()
        {
            Container.Bind<SpawnPointsTracker>().FromInstance(_pointsTracker).AsSingle();
        }
    }
}