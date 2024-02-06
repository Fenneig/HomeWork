using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Race", menuName = "Configs/Races/Race config")]
    public class RaceConfig : TypeConfig<RaceType>
    {
        public RaceType RaceType => _type;
    }
}