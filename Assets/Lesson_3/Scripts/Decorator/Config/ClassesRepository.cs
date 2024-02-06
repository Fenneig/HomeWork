using System.ComponentModel;
using System.Linq;
using Lesson_3.Scripts.Decorator.Class;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator.Config
{
    [CreateAssetMenu(fileName = "Classes repository", menuName = "Configs/Class/Repository")]
    public class ClassesRepository : ModifierTypeRepository<ClassConfig, ClassType>
    {
        public override float GetModifier(ClassType classType)
        {
            if (_configs.All(config => config.ConfigType != classType))
                throw new InvalidEnumArgumentException($"Class list doesn't contain {classType}");
                    
            float modifier = _configs.First(config => config.ConfigType == classType).Modifier;
            return modifier;
        }
    }
}