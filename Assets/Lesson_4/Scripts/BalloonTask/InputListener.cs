using UnityEngine;
using UnityEngine.InputSystem;

namespace Lesson_4.Scripts.BalloonTask
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private BalloonInput _lessonInput;

        private void Awake()
        {
            _lessonInput = new BalloonInput();
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
        }

        private void OnBurst(InputAction.CallbackContext _) => _player.Burst(Input.mousePosition);
    }
}
