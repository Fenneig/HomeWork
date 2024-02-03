using UnityEngine;

namespace Lesson_3.Scripts.Visitor.Configs
{
    [CreateAssetMenu(fileName = "Weight Config", menuName = "Configs/Weight")]
    public class WeightConfig : ScriptableObject
    {
        [SerializeField] private int _orkWeight;
        [SerializeField] private int _humanWeight;
        [SerializeField] private int _elfWeight;
        [SerializeField] private int _robotWeight;

        public int OrkWeight => _orkWeight;
        public int HumanWeight => _humanWeight;
        public int ElfWeight => _elfWeight;
        public int RobotWeight => _robotWeight;
    }
}