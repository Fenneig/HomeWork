using Lesson_4.Scripts.BalloonTask.Loader;
using Lesson_4.Scripts.BalloonTask.WinConditions;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Lesson_4.Scripts.BalloonTask.HUD
{
    public class GameOverHud : MonoBehaviour
    {
        [SerializeField] private Button _mainMenuButton;
        [SerializeField] private Button _restartButton;

        private SceneLoader _sceneLoader;
        private IWinCondition _winCondition;

        [Inject]
        private void Construct(SceneLoader sceneLoader) => _sceneLoader = sceneLoader;

        public void InitializePanel(IWinCondition winCondition)
        {
            _winCondition = winCondition;
            gameObject.SetActive(true);
        }

        private void LoadMainMenu() => _sceneLoader.Load(SceneID.Menu);

        private void RestartScene() => _sceneLoader.Load(new LevelLoadingData(_winCondition));

        private void OnEnable()
        {
            _mainMenuButton.onClick.AddListener(LoadMainMenu);
            _restartButton.onClick.AddListener(RestartScene);
        }

        private void OnDisable()
        {
            _mainMenuButton.onClick.RemoveListener(LoadMainMenu);
            _restartButton.onClick.RemoveListener(RestartScene);
        }
    }
}