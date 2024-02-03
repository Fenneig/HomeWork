using System;
using Lesson_3.Scripts.Visitor.Enemy;

namespace Lesson_3.Scripts.Visitor.Interfaces
{
    public interface IFoeEventNotifier
    {
        event Action<Foe> SpawnNotified;
        event Action<Foe> DeathNotified;
    }
}