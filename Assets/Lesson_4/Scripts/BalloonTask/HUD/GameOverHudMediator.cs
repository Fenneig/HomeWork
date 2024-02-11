using System.Collections.Generic;
using Lesson_4.Scripts.BalloonTask.WinConditions;
using UnityEngine;

namespace Lesson_4.Scripts.BalloonTask.HUD
{
    public class GameOverHudMediator
    {
        private GameOverHud _gameOverHud;
        private List<IWinAchievedChecker> _winAchievedCheckers;

        public GameOverHudMediator(GameOverHud gameOverHud)
        {
            _gameOverHud = gameOverHud;
            _winAchievedCheckers = new List<IWinAchievedChecker>();
        }

        public void RegisterWinAchievedChecker(IWinAchievedChecker winAchievedChecker)
        {
            if (_winAchievedCheckers.Contains(winAchievedChecker))
            {
                Debug.LogError($"Try to register interface {winAchievedChecker.GetType()} but it already registered!");
                return;
            }

            _winAchievedCheckers.Add(winAchievedChecker);
            winAchievedChecker.WinAchieved += ShowGameOver;
        }

        public void UnregisterWinAchievedChecker(IWinAchievedChecker winAchievedChecker)
        {
            if (_winAchievedCheckers.Contains(winAchievedChecker) == false)
            {
                Debug.LogError($"Try to unregister interface {winAchievedChecker.GetType()} but it already not registered!");
                return;
            }

            _winAchievedCheckers.Remove(winAchievedChecker);
            winAchievedChecker.WinAchieved -= ShowGameOver;
        }

        private void ShowGameOver(IWinCondition winCondition) => _gameOverHud.InitializePanel(winCondition);
    }
}