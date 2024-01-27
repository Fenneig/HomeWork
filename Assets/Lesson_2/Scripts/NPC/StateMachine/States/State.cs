using Lesson_2.Scripts.NPC.Units;
using UnityEngine;

namespace Lesson_2.Scripts.NPC.StateMachine.States
{
    public class State : IState
    {
        private readonly Units.Character _character;
        
        protected readonly IStateSwitcher StateSwitcher;
        
        protected Vector3 CharacterPosition => _character.Position;
        protected CharacterView CharacterView => _character.View;
        protected StatePositions CharacterStatePositions => _character.StatePositions;
        protected CharacterStatus CharacterStatus => _character.Status;
        protected CharacterController CharacterController => _character.Controller;
        protected float CharacterMoveSpeed => _character.MoveSpeed;

        protected State(IStateSwitcher stateSwitcher, Units.Character character)
        {
            StateSwitcher = stateSwitcher;
            _character = character;
        }

        public virtual void Enter()
        {
            Debug.Log($"Enter state {GetType().ToString().Split(".")[^1]}");
        }

        public virtual void Exit()
        {
            Debug.Log($"Exit state {GetType().ToString().Split(".")[^1]}");
        }

        public virtual void Update()
        { }
    }
}