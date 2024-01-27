namespace Lesson_2.Scripts.LessonCharacter.StateMachine.States
{
    public interface IState 
    {
        void Enter();
        void Exit();
        void HandleInput();
        void Update();
    }
}
