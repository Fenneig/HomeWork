using Lesson_2.Scripts.NPC.StateMachine.States;

namespace Lesson_2.Scripts.NPC.StateMachine
{
    public interface IStateSwitcher
    {
        void SwitchState<T>() where T : IState;
    }
}