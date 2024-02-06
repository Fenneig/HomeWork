using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [CreateAssetMenu(fileName = "Decorator configs", menuName = "Configs/decorator config")]
    public class ConfigsRepository : ScriptableObject
    {
        [SerializeField] private RacesRepository _racesRepository;
        [SerializeField] private ClassesRepository _classesRepository;
        [SerializeField] private PassivesRepository _passivesRepository;

        public float GetRaceModifier(RaceType raceType) => _racesRepository.GetModifier(raceType);

        public float GetClassModifier(ClassType classType) => _classesRepository.GetModifier(classType);

        public float GetPassiveModifier(PassiveType passiveType) => _passivesRepository.GetModifier(passiveType);
    }
}