using System;

namespace Lesson_4.Scripts.BalloonTask.Loader
{
    public class SceneLoader : ISimpleSceneLoader, ILevelLoader
    {
        private ZenjectSceneLoaderWrapper _zenjectSceneLoader;

        public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoader)
        {
            _zenjectSceneLoader = zenjectSceneLoader;
        }

        public void Load(SceneID sceneID)
        {
            if (sceneID == SceneID.Gameplay)
                throw new ArgumentOutOfRangeException($"{SceneID.Gameplay} cannont be started without configuration, use IlevelLoader");

            _zenjectSceneLoader.Load(null, (int) sceneID);
        }

        public void Load(LevelLoadingData levelLoadingData)
        {
            _zenjectSceneLoader.Load(container =>
            {
                container.BindInstance(levelLoadingData);
            }, (int) SceneID.Gameplay);
        }
    }
}