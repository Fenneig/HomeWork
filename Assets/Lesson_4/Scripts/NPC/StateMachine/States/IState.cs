namespace Lesson_4.Scripts.NPC.StateMachine.States
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}
