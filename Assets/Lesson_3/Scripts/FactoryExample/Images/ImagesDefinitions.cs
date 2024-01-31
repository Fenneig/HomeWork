using System.Collections.Generic;
using UnityEngine;

namespace Lesson_3.Scripts.FactoryExample.Images
{
    [CreateAssetMenu(fileName = "Images definition", menuName = "Definitions/images")]
    public class ImagesDefinitions : ScriptableObject
    {
        [SerializeField] private List<string> _ids;

        public List<string> IDs => _ids;
        
        
        private static ImagesDefinitions _instance;
        public static ImagesDefinitions I => _instance == null ? LoadDefs() : _instance;
        private static ImagesDefinitions LoadDefs() => _instance = Resources.Load<ImagesDefinitions>("Images definition");
    }
}