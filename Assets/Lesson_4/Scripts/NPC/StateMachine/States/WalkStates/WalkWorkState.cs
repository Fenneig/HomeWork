using Lesson_4.Scripts.NPC.Units;
using Lesson_4.Scripts.NPC.StateMachine.States.WalkStates;

namespace Lesson_4.Scripts.NPC.StateMachine.States.WalkStates
{
    public class WalkWorkState : WalkState
    {
        public WalkWorkState(CharacterStateMachine stateMachine, Character character) : base(stateMachine, character)
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