using System.ComponentModel;
using System.Linq;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Passives repository", menuName = "Configs/Passive/Repository")]
    public class PassivesRepository : ModifierTypeRepository<PassiveConfig, PassiveType>
    {
        public override float GetModifier(PassiveType passiveType)
        {
            if (_configs.All(config => config.PassiveType != passiveType))
                throw new InvalidEnumArgumentException($"Class list doesn't contain {passiveType}");
                    
            float modifier = _configs.First(config => config.PassiveType == passiveType).Modifier;
            return modifier;
        }
    }
}