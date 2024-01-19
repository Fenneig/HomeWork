using System.Collections.Generic;

namespace Lesson_1.Scripts.BalloonTask.WinConditions
{
    public interface IWinCondition
    {
        public bool Check(Dictionary<BalloonColor, int> currentBalloonsState);
    }
}