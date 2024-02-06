using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Class", menuName = "Configs/Class/Class config")]
    public class ClassConfig : TypeConfig<ClassType>
    {
        public ClassType ClassType => _type;
    }
}