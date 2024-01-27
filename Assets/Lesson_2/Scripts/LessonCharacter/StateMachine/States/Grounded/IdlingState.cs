namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Grounded
{
    public class IdlingState : GroundedState
    {
        public IdlingState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data)
        { }

        public override void Enter()
        {
            base.Enter();
            
            View.StartIdling();
            
            Data.Speed = 0;
        }

        public override void Exit()
        {
            base.Exit();
            
            View.StopIdling();
        }

        public override void Update()
        {
            base.Update();
            
            if (IsHorizontalInputZero) 
                return;

            StateSwitcher.SwitchState<RunningState>();
        }
    }
}