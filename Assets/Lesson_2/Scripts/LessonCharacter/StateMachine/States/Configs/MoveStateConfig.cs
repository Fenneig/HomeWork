using System;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs
{
    [Serializable]
    public class MoveStateConfig
    {
        [SerializeField] private WalkStateConfig _walkStateConfig;
        [SerializeField] private RunningStateConfig _runningStateConfig;

        public WalkStateConfig WalkStateConfig => _walkStateConfig;
        public RunningStateConfig RunningStateConfig => _runningStateConfig;
    }
}