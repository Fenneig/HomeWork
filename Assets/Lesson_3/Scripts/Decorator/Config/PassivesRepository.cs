using System.ComponentModel;
using System.Linq;
using Lesson_3.Scripts.Decorator.Passive;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator.Config
{
    [CreateAssetMenu(fileName = "Passives repository", menuName = "Configs/Passive/Repository")]
    public class PassivesRepository : ModifierTypeRepository<PassiveConfig, PassiveType>
    {
        public override float GetModifier(PassiveType passiveType)
        {
            if (_configs.All(config => config.ConfigType != passiveType))
                throw new InvalidEnumArgumentException($"Class list doesn't contain {passiveType}");
                    
            float modifier = _configs.First(config => config.ConfigType == passiveType).Modifier;
            return modifier;
        }
    }
}