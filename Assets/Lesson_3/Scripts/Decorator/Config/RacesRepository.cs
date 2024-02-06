using System.ComponentModel;
using System.Linq;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Races repository", menuName = "Configs/Races/Repository")]
    public class RacesRepository : ModifierTypeRepository<RaceConfig, RaceType>
    {
        public override float GetModifier(RaceType raceType)
        {
            if (_configs.All(config => config.RaceType != raceType))
                throw new InvalidEnumArgumentException($"Race list doesn't contain {raceType}");
                    
            float modifier = _configs.First(config => config.RaceType == raceType).Modifier;
            return modifier;
        }
    }
}