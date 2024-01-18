using UnityEngine;

namespace Lesson_1.Scripts.MerchantTask
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private CharacterController _controller;
        public Vector2 Direction { get; set; }

        private void Update()
        {
            Vector3 fixedMoveDirection = transform.right * Direction.x + transform.forward * Direction.y;
            _controller.Move(fixedMoveDirection * _speed * Time.deltaTime);
        }

        private void OnValidate()
        {
            if (_controller == null) _controller = GetComponent<CharacterController>();
        }
    }
}