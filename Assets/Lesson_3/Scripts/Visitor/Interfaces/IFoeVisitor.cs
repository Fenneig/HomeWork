using Lesson_3.Scripts.Visitor.Enemy;

namespace Lesson_3.Scripts.Visitor.Interfaces
{
    public interface IFoeVisitor
    {
        void Visit(Foe foe);
        void Visit(Ork ork);
        void Visit(Human human);
        void Visit(Elf elf);
        void Visit(Robot robot);
    }
}
