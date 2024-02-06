using System.ComponentModel;
using System.Linq;
using Lesson_3.Scripts.Decorator.Race;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator.Config
{
    [CreateAssetMenu(fileName = "Races repository", menuName = "Configs/Races/Repository")]
    public class RacesRepository : ModifierTypeRepository<RaceConfig, RaceType>
    {
        public override float GetModifier(RaceType raceType)
        {
            if (_configs.All(config => config.ConfigType != raceType))
                throw new InvalidEnumArgumentException($"Race list doesn't contain {raceType}");
                    
            float modifier = _configs.First(config => config.ConfigType == raceType).Modifier;
            return modifier;
        }
    }
}