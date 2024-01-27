using System;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs
{
    [Serializable]
    public class JumpingStateConfig
    {
        [SerializeField, Range(0, 10)] private float _maxHeight;
        [SerializeField, Range(0, 10)] private float _timeToReachMaxHeight;

        public float StartYVelocity => 2 * _maxHeight / _timeToReachMaxHeight;
        public float MaxHeight => _maxHeight;
        public float TimeToReachMaxHeight => _timeToReachMaxHeight;
    }
}