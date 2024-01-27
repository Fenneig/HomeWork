using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Grounded;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.AirBorn
{
    public class FallingState : AirbornState
    {
        private readonly ObstacleDetector _groundChecker;
        
        public FallingState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data)
            => _groundChecker = character.GroundDetector;

        public override void Enter()
        {
            base.Enter();
            
            View.StartFalling();
        }

        public override void Exit()
        {
            base.Exit();
            
            View.StopFalling();
        }

        public override void Update()
        {
            base.Update();

            if (!_groundChecker.IsTouched) return;
            
            Data.YVelocity = 0;
                
            if (IsHorizontalInputZero)
                StateSwitcher.SwitchState<IdlingState>();
            else
                StateSwitcher.SwitchState<RunningState>();
        }
    }
}