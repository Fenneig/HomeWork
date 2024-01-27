using Lesson_2.Scripts.LessonCharacter.StateMachine.States;

namespace Lesson_2.Scripts.LessonCharacter.StateMachine
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}