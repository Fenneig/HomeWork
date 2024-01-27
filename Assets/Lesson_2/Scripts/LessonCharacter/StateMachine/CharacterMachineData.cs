using System;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine
{
    public class CharacterMachineData
    {
        public float XVelocity;
        public float YVelocity;

        private float _speed;
        private float _xInput;

        public float Speed
        {
            get => _speed;
            set
            {
                if (_speed < 0)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _speed = value;
            }
        }

        public float XInput
        {
            get => _xInput;
            set
            {
                if (value is < -1 or > 1)
                    throw new ArgumentOutOfRangeException(nameof(value));

                _xInput = value;
            }
        }
    }
}