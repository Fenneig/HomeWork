using System;
using System.Collections.Generic;
using Lesson_4.Scripts.BalloonTask.HUD;
using Lesson_4.Scripts.BalloonTask.Loader;
using Lesson_4.Scripts.BalloonTask.WinConditions;
using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.BalloonTask
{
    public class Gameloop : MonoBehaviour, IWinAchievedChecker
    {
        [SerializeField] private List<Balloon> _balloons;
        
        private Dictionary<BalloonColor, int> _balloonsCounter;
        private GameOverHudMediator _mediator;
        private IWinCondition _winCondition;

        public event Action<IWinCondition> WinAchieved;

        [Inject]
        private void Construct(GameOverHudMediator mediator, LevelLoadingData levelLoadingData)
        {
            _mediator = mediator;
            _winCondition = levelLoadingData.WinCondition;
        }

        private void Awake() => InitializeGameplay();

        private void InitializeGameplay()
        { 
            _balloonsCounter = new Dictionary<BalloonColor, int>();

            foreach (BalloonColor balloonColor in Enum.GetValues(typeof(BalloonColor)))
                _balloonsCounter[balloonColor] = 0;

            _balloons.ForEach(balloon =>
            {
                _balloonsCounter[balloon.Color]++;
                balloon.OnBalloonBursted += BalloonBursted;
            });
        }

        private void OnEnable() => _mediator.RegisterWinAchievedChecker(this);

        private void OnDisable() => _mediator.UnregisterWinAchievedChecker(this);

        private void BalloonBursted(BalloonColor balloonColor)
        {
            _balloonsCounter[balloonColor]--;
            CheckWinCondition();
        }

        private void CheckWinCondition()
        {
            if (_winCondition.Check(_balloonsCounter))
                WinAchieved?.Invoke(_winCondition);
        }
    }
}