using System;
using Lesson_4.Scripts.BalloonTask.WinConditions;

namespace Lesson_4.Scripts.BalloonTask
{
    public interface IWinAchievedChecker
    {
        public event Action<IWinCondition> WinAchieved;
    }
}