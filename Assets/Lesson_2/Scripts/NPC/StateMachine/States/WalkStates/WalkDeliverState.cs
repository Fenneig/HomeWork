using Lesson_2.Scripts.NPC.Units;

namespace Lesson_2.Scripts.NPC.StateMachine.States.WalkStates
{
    public class WalkDeliverState : WalkState
    {
        public WalkDeliverState(CharacterStateMachine stateMachine, Character character) : base(stateMachine, character)
        { }

        public override void Enter()
        {
            SetWalkDestination(CharacterStatePositions.DeliveryPosition);
            
            base.Enter();
        }


        public override void Update()
        {
            base.Update();

            if (IsDestinationReached)
                StateSwitcher.SwitchState<DeliverState>();
        }
    }
}