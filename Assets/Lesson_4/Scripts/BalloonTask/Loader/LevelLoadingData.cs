using Lesson_4.Scripts.BalloonTask.WinConditions;

namespace Lesson_4.Scripts.BalloonTask.Loader
{
    public class LevelLoadingData
    {
        public IWinCondition WinCondition { get; set; }
        
        public LevelLoadingData(IWinCondition winCondition) => WinCondition = winCondition;
    }
}