using Lesson_4.Scripts.BalloonTask.Loader;
using Zenject;

namespace Lesson_4.Scripts.BalloonTask.DI
{
    public class SceneLoaderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ZenjectSceneLoaderWrapper>().AsSingle();

            Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();
        }
    }
}