using UnityEngine;

namespace Lesson_2.Scripts.NPC
{
    public class NpcExample : MonoBehaviour
    {
        [SerializeField] private Transform _restPosition;
        [SerializeField] private Transform _deliveryPosition;
        [SerializeField] private Transform _workPosition;
        [SerializeField] private Character _character;

        private void Awake()
        {
            _character.Initialize(_restPosition.position, _deliveryPosition.position, _workPosition.position);
        }
    }
}