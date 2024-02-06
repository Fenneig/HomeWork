using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Passive", menuName = "Configs/Passive/Passive config")]
    public class PassiveConfig : TypeConfig<PassiveType>
    {
        public PassiveType PassiveType => _type;
    }
}