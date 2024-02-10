using Zenject;

namespace Lesson_4.Scripts.NPC.DI
{
    public class CharacterFactoryInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<CharacterFactory>().FromNew().AsSingle();
        }
    }
}