using Lesson_3.Scripts.FactoryExample.Images;
using UnityEngine;
using Zenject;

namespace Lesson_3.Scripts.FactoryExample
{
    public class FactoryInstaller : MonoInstaller
    {
        [SerializeField] private ImagesContainer _gameplayImages, _menuImages;

        private ImagesFactory _factory;

        public override void InstallBindings()
        {
            _factory = new ImagesFactory(_gameplayImages, _menuImages);
            
            Container
                .Bind<ImagesFactory>()
                .FromInstance(_factory)
                .AsSingle();
        }
    }
}