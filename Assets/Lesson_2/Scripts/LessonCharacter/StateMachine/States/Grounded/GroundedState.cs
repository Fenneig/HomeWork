using Lesson_2.Scripts.LessonCharacter.StateMachine.States.AirBorn;
using UnityEngine.InputSystem;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Grounded
{
    public abstract class GroundedState : MovementState
    {
        private readonly ObstacleDetector _groundDetector;
        
        public GroundedState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data) : base(stateSwitcher, character, data)
        {
            _groundDetector = character.GroundDetector;
        }

        public override void Enter()
        {
            base.Enter();
            
            View.StartGrounded();
        }

        public override void Exit()
        {
            base.Exit();
            
            View.StopGrounded();
        }

        public override void Update()
        {
            base.Update();
            
            if (_groundDetector.IsTouched == false) 
                StateSwitcher.SwitchState<FallingState>();
        }

        protected override void AddInputActionCallback()
        {
            base.AddInputActionCallback();

            Input.Movement.Jump.started += OnJumpKeyPressed;
        }

        protected override void RemoveInputActionCallback()
        {
            base.RemoveInputActionCallback();
            
            Input.Movement.Jump.started -= OnJumpKeyPressed;
        }

        private void OnJumpKeyPressed(InputAction.CallbackContext obj)
        {
            StateSwitcher.SwitchState<JumpingState>();
        }
    }
}