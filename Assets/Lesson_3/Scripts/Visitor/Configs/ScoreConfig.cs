using UnityEngine;

namespace Lesson_3.Scripts.Visitor.Configs
{
    [CreateAssetMenu(fileName = "Score config", menuName = "Configs/Score")]
    public class ScoreConfig : ScriptableObject
    {
        [SerializeField] private int _orkPoints;
        [SerializeField] private int _humanPoints;
        [SerializeField] private int _elfPoints;
        [SerializeField] private int _robotPoints;

        public int OrkPoints => _orkPoints;
        public int HumanPoints => _humanPoints;
        public int ElfPoints => _elfPoints;
        public int RobotPoints => _robotPoints;
    }
}