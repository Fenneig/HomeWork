using Lesson_4.Scripts.NPC.StateMachine.States;

namespace Lesson_4.Scripts.NPC.StateMachine
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}