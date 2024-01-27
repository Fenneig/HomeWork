namespace Lesson_2.Scripts.NPC.StateMachine.States.WalkStates
{
    public class WalkWorkState : WalkState
    {
        public WalkWorkState(CharacterStateMachine stateMachine, Units.Character character) : base(stateMachine, character)
        { }

        public override void Enter()
        {
            SetWalkDestination(CharacterStatePositions.WorkPosition);
            
            base.Enter();
        }

        public override void Update()
        {
            base.Update();

            if (IsDestinationReached)
                StateSwitcher.SwitchState<WorkState>();
        }
    }
}