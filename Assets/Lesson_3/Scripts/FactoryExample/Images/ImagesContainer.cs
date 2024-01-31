using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Lesson_3.Scripts.FactoryExample.Images
{
    [CreateAssetMenu(fileName = "Images container", menuName = "Containers/Images")]
    public class ImagesContainer : ScriptableObject
    {
        [SerializeField] private List<ImageWithId> _images;

        public Sprite GetImage(string id) 
            => _images.FirstOrDefault(image => image.ID.Equals(id, StringComparison.InvariantCultureIgnoreCase))?.Image;

    }
}