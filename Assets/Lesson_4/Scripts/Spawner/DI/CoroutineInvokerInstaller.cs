using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.Spawner.DI
{
    public class CoroutineInvokerInstaller : MonoInstaller
    {
        [SerializeField] private CoroutineInvoker _coroutineInvoker;

        public override void InstallBindings()
        {
            Container.Bind<CoroutineInvoker>().FromInstance(_coroutineInvoker).AsSingle();
        }
    }
}