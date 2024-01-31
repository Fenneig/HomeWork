using System;
using UnityEngine;

namespace Lesson_3.Scripts.FactoryExample.Images
{
    [Serializable]
    public class ImageWithId
    {
        [SerializeField] private Sprite _image;
        [ImageId] [SerializeField] private string _id;

        public Sprite Image => _image;
        public string ID => _id;
    }
}