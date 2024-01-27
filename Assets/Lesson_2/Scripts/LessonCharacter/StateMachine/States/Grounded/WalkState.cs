using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Grounded
{
    public class WalkState : GroundedState
    {
        private WalkStateConfig _walkStateConfig;

        public WalkState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data)
            => _walkStateConfig = character.Config.MoveStateConfig.WalkStateConfig;

        public override void Enter()
        {
            base.Enter();
            
            View.StartRunning();
            Data.Speed = _walkStateConfig.Speed;
            View.SetMoveSpeed(Data.Speed);
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

            if (IsRunning)
                StateSwitcher.SwitchState<RunningState>();
        }
    }
}