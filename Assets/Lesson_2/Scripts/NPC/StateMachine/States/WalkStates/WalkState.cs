using UnityEngine;

namespace Lesson_2.Scripts.NPC.StateMachine.States.WalkStates
{
    public class WalkState : State
    {
        private const float REACH_DESTINATION_TOLERANCE = .1f;
        
        private Vector3 _walkDestination;
        
        protected bool IsDestinationReached;

        protected WalkState(CharacterStateMachine stateMachine, Character character) : base(stateMachine, character)
        { }
        
        public override void Enter()
        {
            base.Enter();
            
            IsDestinationReached = false;
            CharacterView.StartWalking();
        }

        public override void Exit()
        {
            base.Exit();
            
            CharacterView.StopWalking();
        }

        public override void Update()
        {
            base.Update();

            Vector3 motion = (_walkDestination - CharacterPosition).normalized;
            CharacterController.Move(motion * CharacterMoveSpeed * Time.deltaTime);
            
            if (Vector3.Magnitude(CharacterPosition - _walkDestination) <= REACH_DESTINATION_TOLERANCE) 
                IsDestinationReached = true;
        }

        protected void SetWalkDestination(Vector3 destination) => 
            _walkDestination = destination;
    }
}