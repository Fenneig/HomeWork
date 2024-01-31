using System;
using Lesson_3.Scripts.FactoryExample.Images;
using UnityEngine;

namespace Lesson_3.Scripts.FactoryExample
{
    public class ImagesFactory
    {
        private readonly ImagesContainer _gameplayImages, _menuImages;

        public ImagesFactory(ImagesContainer gameplayImages, ImagesContainer menuImages)
        {
            _gameplayImages = gameplayImages;
            _menuImages = menuImages;
        }

        public Sprite Get(string imageId, InterfaceType imageType) =>
            imageType switch
            {
                InterfaceType.Gameplay => _gameplayImages.GetImage(imageId),
                InterfaceType.Menu => _menuImages.GetImage(imageId),
                _ => throw new ArgumentOutOfRangeException(nameof(imageType), imageType, null)
            };
    }
}