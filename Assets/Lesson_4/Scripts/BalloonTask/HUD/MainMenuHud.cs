using Lesson_4.Scripts.BalloonTask.Loader;
using Lesson_4.Scripts.BalloonTask.WinConditions;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Lesson_4.Scripts.BalloonTask.HUD
{
    public class MainMenuHud : MonoBehaviour
    {
        [SerializeField] private Button _allBalloonsButton;
        [SerializeField] private Button _redBalloonsButton;
        [SerializeField] private Button _whiteBalloonsButton;
        [SerializeField] private Button _greenBalloonsButton;
        
        private SceneLoader _sceneLoader;

        [Inject]
        private void Construct(SceneLoader sceneLoader) => _sceneLoader = sceneLoader;

        private void OnEnable()
        {
            _allBalloonsButton.onClick.AddListener(LoadAllBalloonsLevel);
            _redBalloonsButton.onClick.AddListener(LoadRedBalloonsLevel);
            _whiteBalloonsButton.onClick.AddListener(LoadWhiteBalloonsLevel);
            _greenBalloonsButton.onClick.AddListener(LoadGreenBalloonsLevel);
        }

        private void OnDisable()
        {
            _allBalloonsButton.onClick.RemoveListener(LoadAllBalloonsLevel);
            _redBalloonsButton.onClick.RemoveListener(LoadRedBalloonsLevel);
            _whiteBalloonsButton.onClick.RemoveListener(LoadWhiteBalloonsLevel);
            _greenBalloonsButton.onClick.RemoveListener(LoadGreenBalloonsLevel);
        }

        private void LoadAllBalloonsLevel() =>
            _sceneLoader.Load(new LevelLoadingData(new AllBalloonsBurstedCondition()));

        private void LoadRedBalloonsLevel() => LoadColorBalloonsLevel(BalloonColor.Red);

        private void LoadWhiteBalloonsLevel() => LoadColorBalloonsLevel(BalloonColor.White);

        private void LoadGreenBalloonsLevel() => LoadColorBalloonsLevel(BalloonColor.Green);

        private void LoadColorBalloonsLevel(BalloonColor balloonColor) =>
            _sceneLoader.Load(new LevelLoadingData(new SingleColorBalloonsBurstedCondition(balloonColor)));
    }
}