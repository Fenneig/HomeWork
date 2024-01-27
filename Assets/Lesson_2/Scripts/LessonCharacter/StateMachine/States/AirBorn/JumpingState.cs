using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.AirBorn
{
    public class JumpingState : AirbornState
    {
        private readonly JumpingStateConfig _config;
        
        public JumpingState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data)
        {
            _config = character.Config.AirbornStateConfig.JumpingStateConfig;
        }

        public override void Enter()
        {
            base.Enter();

            Data.YVelocity = _config.StartYVelocity;
        }

        public override void Update()
        {
            base.Update();

            if (Data.YVelocity <= 0)
                StateSwitcher.SwitchState<FallingState>();
        }
    }
}