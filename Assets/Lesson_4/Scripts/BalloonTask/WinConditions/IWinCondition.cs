using System.Collections.Generic;

namespace Lesson_4.Scripts.BalloonTask.WinConditions
{
    public interface IWinCondition
    {
        public bool Check(Dictionary<BalloonColor, int> currentBalloonsState);
    }
}