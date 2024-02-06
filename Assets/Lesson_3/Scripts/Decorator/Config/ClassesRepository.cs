using System.ComponentModel;
using System.Linq;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Classes repository", menuName = "Configs/Class/Repository")]
    public class ClassesRepository : ModifierTypeRepository<ClassConfig, ClassType>
    {
        public override float GetModifier(ClassType classType)
        {
            if (_configs.All(config => config.ClassType != classType))
                throw new InvalidEnumArgumentException($"Class list doesn't contain {classType}");
                    
            float modifier = _configs.First(config => config.ClassType == classType).Modifier;
            return modifier;
        }
    }
}