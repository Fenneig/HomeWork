using System;
using System.Collections.Generic;
using Lesson_1.Scripts.BalloonTask.WinConditions;
using UnityEngine;

namespace Lesson_1.Scripts.BalloonTask
{
    public class FinishTracker : MonoBehaviour
    {
        [SerializeField] private List<Balloon> _balloons;
        
        private Dictionary<BalloonColor, int> _balloonsCounter;
        private IWinCondition _winCondition;

        public void Initialize(IWinCondition winCondition)
        {
            _balloonsCounter = new Dictionary<BalloonColor, int>();

            foreach (BalloonColor balloonColor in Enum.GetValues(typeof(BalloonColor)))
                _balloonsCounter[balloonColor] = 0;

            _balloons.ForEach(balloon =>
            {
                _balloonsCounter[balloon.Color]++;
                balloon.OnBalloonBursted += BalloonBursted;
            });
         
            _winCondition = winCondition;
        }

        private void BalloonBursted(BalloonColor balloonColor)
        {
            _balloonsCounter[balloonColor]--;
            CheckWinCondition();
        }

        private void CheckWinCondition()
        {
            if (_winCondition.Check(_balloonsCounter)) Debug.Log("Win!");
        }
    }
}