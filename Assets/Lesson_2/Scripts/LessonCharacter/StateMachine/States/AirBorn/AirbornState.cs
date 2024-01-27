using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.AirBorn
{
    public abstract class AirbornState : MovementState
    {
        private readonly AirbornStateConfig _config;

        protected AirbornState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data) 
            => _config = character.Config.AirbornStateConfig;
        

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.Speed;
        }

        public override void Update()
        {
            base.Update();
            
            Data.YVelocity -= _config.BaseGravity * Time.deltaTime;
        }
    }
}