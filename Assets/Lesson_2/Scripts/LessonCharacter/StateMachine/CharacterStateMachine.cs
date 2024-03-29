﻿using System;
using System.Collections.Generic;
using System.Linq;
using Lesson_2.Scripts.LessonCharacter.StateMachine.States;
using Lesson_2.Scripts.LessonCharacter.StateMachine.States.AirBorn;
using Lesson_2.Scripts.LessonCharacter.StateMachine.States.Grounded;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine
{
    public class CharacterStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public CharacterStateMachine(Character character)
        {
            CharacterMachineData data = new CharacterMachineData();
            
            _states = new List<IState>
            {
                new IdlingState(this, character, data),
                new RunningState(this, character, data),
                new WalkState(this, character, data),
                new JumpingState(this, character, data),
                new FallingState(this, character, data)
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
            catch (NullReferenceException e)
            {
                Debug.LogError($"can't find state {typeof(T)}");
            }
        }

        public void HandleInput() => _currentState.HandleInput();
        public void Update() => _currentState.Update();
    }
}