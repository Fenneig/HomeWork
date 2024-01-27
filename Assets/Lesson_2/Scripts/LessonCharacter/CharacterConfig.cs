using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter
{
    [CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private RunningStateConfig _runningStateConfig;
        [SerializeField] private AirbornStateConfig _airbornStateConfig;
        public RunningStateConfig RunningStateConfig => _runningStateConfig;
        public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
    }
}