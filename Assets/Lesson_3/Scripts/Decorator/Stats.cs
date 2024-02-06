using System;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    [Serializable]
    public class Stats : IStats
    {
        [SerializeField] private int _strength, _intellect, _agility;

        public int Strength => _strength;
        public int Intellect => _intellect;
        public int Agility => _agility;

        public Stats(int strength, int intellect, int agility)
        {
            _strength = strength;
            _intellect = intellect;
            _agility = agility;
        }
    }
}