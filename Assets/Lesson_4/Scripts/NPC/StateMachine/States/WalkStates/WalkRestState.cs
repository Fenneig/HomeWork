using Lesson_4.Scripts.NPC.Units;

namespace Lesson_4.Scripts.NPC.StateMachine.States.WalkStates
{
    public class WalkRestState : WalkState
    {
        public WalkRestState(CharacterStateMachine stateMachine, Character character) : base(stateMachine, character)
        { }

        public override void Enter()
        {
            SetWalkDestination(CharacterStatePositions.RestPosition);
            
            base.Enter();
        }
        
        public override void Update()
        {
            base.Update();

            if (IsDestinationReached)
                StateSwitcher.SwitchState<RestState>();
        }
    }
}