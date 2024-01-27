using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Grounded
{
    public class RunningState : GroundedState
    {
        private RunningStateConfig _runningStateConfig;

        public RunningState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data)
            => _runningStateConfig = character.Config.RunningStateConfig;

        public override void Enter()
        {
            base.Enter();
            
            View.StartRunning();

            Data.Speed = _runningStateConfig.Speed;
        }

        public override void Exit()
        {
            base.Exit();
            
            View.StopRunning();
        }

        public override void Update()
        {
            base.Update();
            
            if (IsHorizontalInputZero)
                StateSwitcher.SwitchState<IdlingState>();
        }
    }
}