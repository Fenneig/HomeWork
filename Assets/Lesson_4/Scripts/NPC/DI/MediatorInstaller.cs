using Zenject;

namespace Lesson_4.Scripts.NPC.DI
{
    public class MediatorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<UIMediator>().FromNew().AsSingle();
        }
    }
}