using Lesson_1.Scripts.MerchantTask.TradePatterns;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Lesson_1.Scripts.MerchantTask
{
    public class InputListener : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Merchant _merchant;
        
        private LessonInput _lessonInput;

        private void Awake()
        {
            _lessonInput = new LessonInput();
        }

        private void OnEnable()
        {
            _lessonInput.Merchant.Enable();
        }

        private void OnDisable()
        {
            _lessonInput.Merchant.Disable();
        }

        private void Start()
        {
            SubscribeOnMerchantMethods();
            _merchant.SwitchTradePattern(new NoTrade());
        }

        private void SubscribeOnMerchantMethods()
        {
            _lessonInput.Merchant.Move.performed += OnMove;
            _lessonInput.Merchant.Move.canceled += OnMove;
            _lessonInput.Merchant.Trade.started += OnTrade;
            _lessonInput.Merchant.Switch_behaviour_1.started += OnSwitchBehaviour1;
            _lessonInput.Merchant.Switch_behaviour_2.started += OnSwitchBehaviour2;
            _lessonInput.Merchant.Switch_behaviour_3.started += OnSwitchBehaviour3;
        }

        private void OnMove(InputAction.CallbackContext context) => _player.Direction = context.ReadValue<Vector2>();

        private void OnTrade(InputAction.CallbackContext _) => _merchant.Trade();

        private void OnSwitchBehaviour1(InputAction.CallbackContext _) => _merchant.SwitchTradePattern(new NoTrade());

        private void OnSwitchBehaviour2(InputAction.CallbackContext _) => _merchant.SwitchTradePattern(new FruitTrade());

        private void OnSwitchBehaviour3(InputAction.CallbackContext _) => _merchant.SwitchTradePattern(new ArmorTrade());
    }
}
