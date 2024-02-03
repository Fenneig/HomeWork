using System;
using Lesson_3.Scripts.Visitor.Enemy;
using UnityEngine;

namespace Lesson_3.Scripts.Visitor
{
    [CreateAssetMenu(fileName = "FoeFactory", menuName = "Factories/enemy factory")]
    public class FoeFactory: ScriptableObject
    {
        [SerializeField] private Human _humanPrefab;
        [SerializeField] private Ork _orkPrefab;
        [SerializeField] private Elf _elfPrefab;
        [SerializeField] private Robot _robotPrefab;

        public Foe Get(FoeType type) =>
            type switch
            {
                FoeType.Elf => Instantiate(_elfPrefab),
                FoeType.Human => Instantiate(_humanPrefab),
                FoeType.Ork => Instantiate(_orkPrefab),
                FoeType.Robot => Instantiate(_robotPrefab),
                _ => throw new ArgumentException(nameof(type))
            };
    }
}
