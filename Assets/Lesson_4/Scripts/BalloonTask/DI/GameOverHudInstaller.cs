using Lesson_4.Scripts.BalloonTask.HUD;
using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.BalloonTask.DI
{
    public class GameOverHudInstaller : MonoInstaller
    {
        [SerializeField] private GameOverHud _gameOverHud;

        public override void InstallBindings()
        {
            Container.Bind<GameOverHud>().FromInstance(_gameOverHud).AsSingle();
        }
    }
}