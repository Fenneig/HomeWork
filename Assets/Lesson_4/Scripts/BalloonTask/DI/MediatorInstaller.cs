using Lesson_4.Scripts.BalloonTask.HUD;
using Zenject;

namespace Lesson_4.Scripts.BalloonTask.DI
{
    public class MediatorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<GameOverHudMediator>().FromNew().AsSingle();
        }
    }
}