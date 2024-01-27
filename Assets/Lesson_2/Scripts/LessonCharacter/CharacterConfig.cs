using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter
{
    [CreateAssetMenu(menuName = "Configs/CharacterConfig", fileName = "CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private MoveStateConfig _moveStateConfig;
        [SerializeField] private AirbornStateConfig _airbornStateConfig;

        public MoveStateConfig MoveStateConfig => _moveStateConfig;
        public AirbornStateConfig AirbornStateConfig => _airbornStateConfig;
    }
}