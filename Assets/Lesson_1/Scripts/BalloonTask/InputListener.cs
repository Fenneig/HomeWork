using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace Lesson_1.Scripts.BalloonTask
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private LessonInput _lessonInput;

        private void Awake()
        {
            _lessonInput = new LessonInput();
        }

        private void OnEnable()
        {
            _lessonInput.Ballon.Enable();
        }

        private void OnDisable()
        {
            _lessonInput.Ballon.Disable();
        }

        private void Start()
        {
            SubscribeOnMerchantMethods();
        }

        private void SubscribeOnMerchantMethods()
        {
            _lessonInput.Ballon.Burst.started += OnBurst;
            _lessonInput.Ballon.ReloadScene.started += ReloadScene;
        }

        private void OnBurst(InputAction.CallbackContext _) => _player.Burst(Input.mousePosition);

        private void ReloadScene(InputAction.CallbackContext _) => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
