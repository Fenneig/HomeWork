using Lesson_3.Scripts.Decorator.Class;
using Lesson_3.Scripts.Decorator.Passive;
using Lesson_3.Scripts.Decorator.Race;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    public class Player : MonoBehaviour
    {
        private IStats _baseStats;
        private IStats _currentStats;
        private StatProvider _statProvider;

        public void Initialize(IStats baseStats, StatProvider statProvider)
        {
            _baseStats = baseStats;
            _currentStats = baseStats;
            _statProvider = statProvider;
            ShowStats();
        }

        public void AddClass(ClassType classType)
        {
            _currentStats = _statProvider.SetClass(_currentStats, classType);
            Debug.Log($"Add class: {classType}");
            ShowStats();
        }
        
        public void AddRace(RaceType raceType)
        {
            _currentStats = _statProvider.SetRace(_currentStats, raceType);;
            Debug.Log($"Add race: {raceType}");
            ShowStats();
        }
        
        public void AddPassive(PassiveType passiveType)
        {
            _currentStats = _statProvider.SetPassive(_currentStats, passiveType);;
            Debug.Log($"Add passive: {passiveType}");
            ShowStats();
        }
        
        private void ShowStats() =>
            Debug.Log($"Current stats: Strength = {_currentStats.Strength}, Intellect = {_currentStats.Intellect}, agility = {_currentStats.Agility}");
    }
}
