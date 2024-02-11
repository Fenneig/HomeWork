using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_4.Scripts.BalloonTask.WinConditions
{
    public class AllBalloonsBurstedCondition : IWinCondition
    {
        public bool Check(Dictionary<BalloonColor, int> currentBalloonsState)
        {
            bool isWinAchieved = Enum.GetValues(typeof(BalloonColor))
                .Cast<BalloonColor>()
                .All(balloonColor => currentBalloonsState[balloonColor] <= 0);
            
            return isWinAchieved;
        }
    }
}