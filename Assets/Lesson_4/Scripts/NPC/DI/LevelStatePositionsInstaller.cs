using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.NPC.DI
{
    public class LevelStatePositionsInstaller : MonoInstaller
    {
        [SerializeField] private Transform _restPosition;
        [SerializeField] private Transform _deliveryPosition;
        [SerializeField] private Transform _workPosition;

        public override void InstallBindings()
        {
            StatePositions statePositions = new StatePositions
            {
                RestPosition = _restPosition.position,
                DeliveryPosition = _deliveryPosition.position,
                WorkPosition = _workPosition.position
            };

            Container.Bind<StatePositions>().FromInstance(statePositions).AsSingle();
        }
    }
}