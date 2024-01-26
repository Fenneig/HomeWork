using Lesson_2.Scripts.NPC.StateMachine;
using UnityEngine;

namespace Lesson_2.Scripts.NPC
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _characterConfig;
        [SerializeField] private CharacterView _view;
        
        private CharacterStateMachine _stateMachine;
        private CharacterController _controller;
        [SerializeField] private CharacterStatus _characterStatus;

        public CharacterController Controller => _controller;
        public Vector3 Position => transform.position;
        public StatePositions StatePositions { get; private set; }
        public CharacterView View => _view;
        public CharacterStatus Status => _characterStatus;
        public float MoveSpeed => _characterConfig.MoveSpeed;

        public void Initialize(Vector3 restPosition, Vector3 deliveryPosition, Vector3 workPosition)
        {
            _controller = GetComponent<CharacterController>();
            _view.Initialize();
            _characterStatus = new CharacterStatus(_characterConfig);

            _view.WorkAction += OnWorkAction;
            _view.DeliverAction += OnDeliverAction;
            _view.RestAction += OnRestAction;
            
            StatePositions = new StatePositions
            {
                RestPosition = restPosition,
                DeliveryPosition = deliveryPosition,
                WorkPosition = workPosition
            };
            _stateMachine = new CharacterStateMachine(this);
        }

        private void OnRestAction()
        {
            _characterStatus.RestoreEnergy();
        }

        private void OnWorkAction()
        {
            _characterStatus.SpendEnergy(_characterConfig.WorkConfig.WorkEnergyCost);
            _characterStatus.TryAddInInventory(_characterConfig.WorkConfig.AddInInventoryAmount);
        }

        private void OnDeliverAction()
        {
            _characterStatus.FreeInventory();
        }

        private void Update()
        {
            _stateMachine.Update();
        }

        private void OnDestroy()
        {
            _view.WorkAction -= OnWorkAction;
            _view.DeliverAction -= OnDeliverAction;
            _view.RestAction -= OnRestAction;
        }
    }
}