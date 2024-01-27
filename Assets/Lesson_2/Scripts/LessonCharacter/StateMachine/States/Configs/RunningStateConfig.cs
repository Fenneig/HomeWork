using System;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States.Configs
{
    [Serializable]
    public class RunningStateConfig
    {
        [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
    }
}