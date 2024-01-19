using Lesson_1.Scripts.BalloonTask.WinConditions;
using UnityEngine;

namespace Lesson_1.Scripts.BalloonTask
{
    public class BalloonExample : MonoBehaviour
    {
        [SerializeField] private FinishTracker _finishTracker;

        public void InitAllBalloonsWinCondition() => _finishTracker.Initialize(new AllBalloonsBurstedCondition());
        
        public void InitGreenBalloonsWinCondition() => _finishTracker.Initialize(new SingleColorBalloonsBurstedCondition(BalloonColor.Green));
        
        public void InitWhiteBalloonsWinCondition() => _finishTracker.Initialize(new SingleColorBalloonsBurstedCondition(BalloonColor.White));
        
        public void InitRedBalloonsWinCondition() => _finishTracker.Initialize(new SingleColorBalloonsBurstedCondition(BalloonColor.Red));
    }
}