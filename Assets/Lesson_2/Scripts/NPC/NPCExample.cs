using Lesson_2.Scripts.NPC.Configs;
using Lesson_2.Scripts.NPC.UI;
using Lesson_2.Scripts.NPC.Units;
using UnityEngine;

namespace Lesson_2.Scripts.NPC
{
    public class NpcExample : MonoBehaviour
    {
        [SerializeField] private Transform _restPosition;
        [SerializeField] private Transform _deliveryPosition;
        [SerializeField] private Transform _workPosition;
        [SerializeField] private Character _character;
        [SerializeField] private CharacterConfig _characterConfig;
        [SerializeField] private NpcUi _ui;

        private UIMediator _mediator;

        private void Awake()
        {
            StatePositions exampleStatePositions = new StatePositions
            {
                RestPosition = _restPosition.position,
                DeliveryPosition = _deliveryPosition.position,
                WorkPosition = _workPosition.position
            };
            
            _character.Initialize(exampleStatePositions, _characterConfig);
            _ui.Initialize(_characterConfig.MaxEnergy, _characterConfig.MaxInventoryCapacity);
            
            _mediator = new UIMediator(_ui, _character);
        }
    }
}