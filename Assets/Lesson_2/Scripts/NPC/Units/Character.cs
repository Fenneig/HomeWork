using Lesson_2.Scripts.NPC.Configs;
using Lesson_2.Scripts.NPC.StateMachine;
using UnityEngine;

namespace Lesson_2.Scripts.NPC.Units
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterView _view;
        
        private CharacterStateMachine _stateMachine;
        private CharacterController _controller;
        private CharacterStatus _characterStatus;
        private CharacterConfig _characterConfig;
        
        public CharacterController Controller => _controller;
        public Vector3 Position => transform.position;
        public StatePositions StatePositions { get; private set; }
        public CharacterView View => _view;
        public CharacterStatus Status => _characterStatus;
        public float MoveSpeed => _characterConfig.MoveSpeed;

        public void Initialize(StatePositions statePositions, CharacterConfig config)
        {
            _characterConfig = config;
            _controller = GetComponent<CharacterController>();
            _view.Initialize();
            _characterStatus = new CharacterStatus(_characterConfig);

            _view.WorkAction += OnWorkAction;
            _view.DeliverAction += OnDeliverAction;
            _view.RestAction += OnRestAction;
            
            StatePositions = new StatePositions
            {
                RestPosition = statePositions.RestPosition,
                DeliveryPosition = statePositions.DeliveryPosition,
                WorkPosition = statePositions.WorkPosition
            };
            _stateMachine = new CharacterStateMachine(this);
        }

        private void OnRestAction() => _characterStatus.RestoreEnergy();

        private void OnWorkAction()
        {
            _characterStatus.SpendEnergy(_characterConfig.WorkConfig.WorkEnergyCost);
            _characterStatus.TryAddInInventory(_characterConfig.WorkConfig.AddInInventoryAmount);
        }

        private void OnDeliverAction() => _characterStatus.FreeInventory();

        private void Update() => _stateMachine.Update();

        private void OnDestroy()
        {
            _view.WorkAction -= OnWorkAction;
            _view.DeliverAction -= OnDeliverAction;
            _view.RestAction -= OnRestAction;
        }
    }
}