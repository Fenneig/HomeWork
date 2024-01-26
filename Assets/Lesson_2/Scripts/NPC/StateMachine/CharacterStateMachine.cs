using System;
using System.Collections.Generic;
using System.Linq;
using Lesson_2.Scripts.NPC.StateMachine.States;
using Lesson_2.Scripts.NPC.StateMachine.States.WalkStates;
using UnityEngine;

namespace Lesson_2.Scripts.NPC.StateMachine
{
    public class CharacterStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public CharacterStateMachine(Character character)
        {
            _states = new List<IState>
            {
                new WalkWorkState(this, character),
                new WalkDeliverState(this, character),
                new WalkRestState(this, character),
                new DeliverState(this, character),
                new RestState(this, character),
                new WorkState(this, character)
            };

            _currentState = _states[0];
            _currentState.Enter();
        }
        
        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);
            
            try
            {
                _currentState.Exit();
                _currentState = state;
                _currentState.Enter();
            }
            catch (Exception e)
            {
                Debug.LogError($"can't find state {typeof(T)}");
            }
        }

        public void Update() => 
            _currentState.Update();
    }
}