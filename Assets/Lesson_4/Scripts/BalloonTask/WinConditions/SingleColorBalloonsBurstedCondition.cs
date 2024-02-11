using System.Collections.Generic;

namespace Lesson_4.Scripts.BalloonTask.WinConditions
{
    public class SingleColorBalloonsBurstedCondition : IWinCondition
    {
        private BalloonColor _burstAchieveColorToAchieveWin;

        public SingleColorBalloonsBurstedCondition(BalloonColor achieveColor) =>
            _burstAchieveColorToAchieveWin = achieveColor;

        public bool Check(Dictionary<BalloonColor, int> currentBalloonsState) => currentBalloonsState[_burstAchieveColorToAchieveWin] <= 0;
    }
}