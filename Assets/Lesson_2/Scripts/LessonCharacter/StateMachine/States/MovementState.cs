using UnityEngine;
using UnityEngine.InputSystem;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States
{
    public abstract class MovementState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly CharacterMachineData Data;

        private readonly Character _character;
        private bool _isRunning;

        private Quaternion TurnRight => new(0, 0, 0, 0);
        private Quaternion TurnLeft => Quaternion.Euler(0, 180, 0);

        protected PlayerInput Input => _character.Input;
        protected CharacterView View => _character.View;
        protected bool IsHorizontalInputZero => Data.XInput == 0;
        protected bool IsRunning => _isRunning;

        protected MovementState(IStateSwitcher stateSwitcher, Character character, CharacterMachineData data)
        {
            StateSwitcher = stateSwitcher;
            _character = character;
            Data = data;
        }

        public virtual void Enter()
        {
            Debug.Log($"Enter {GetType().ToString().Split(".")[^1]}");
            
            View.StartMovement();

            AddInputActionCallback();
        }

        public virtual void Exit()
        {
            View.StopMovement();
            
            RemoveInputActionCallback();
        }

        public virtual void HandleInput()
        {
            Data.XInput = ReadHorizontalInput();
            Data.XVelocity = Data.XInput * Data.Speed;
        }

        public virtual void Update()
        {
            Vector3 velocity = GetConvertedVelocity();

            _character.Controller.Move(velocity * Time.deltaTime);
            _character.transform.rotation = GetRotationFrom(velocity);
        }

        protected virtual void AddInputActionCallback() 
            => Input.Movement.SwitchRun.started += OnJumpKeyPressed;

        protected virtual void RemoveInputActionCallback() { }

        private Quaternion GetRotationFrom(Vector3 velocity)
        {
            return velocity.x switch
            {
                > 0 => TurnRight,
                < 0 => TurnLeft,
                _ => _character.transform.rotation
            };
        }

        private Vector3 GetConvertedVelocity() => new(0, Data.YVelocity, Data.XVelocity);

        private float ReadHorizontalInput() => Input.Movement.Move.ReadValue<float>();
        private void OnJumpKeyPressed(InputAction.CallbackContext context) => _isRunning = !_isRunning;
    }
}