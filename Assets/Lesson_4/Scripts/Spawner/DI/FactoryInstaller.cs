using Zenject;

namespace Lesson_4.Scripts.Spawner.DI
{
    public class FactoryInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CoinFactory>().FromNew().AsSingle();
        }
    }
}