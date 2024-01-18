using UnityEngine;

namespace Lesson_1.Scripts.WeaponTask
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _flySpeed;
        [SerializeField] private Rigidbody _rigidbody;
        
        public void Fire() => 
            _rigidbody.AddForce(Vector3.forward * _flySpeed, ForceMode.Impulse);

        private void OnValidate()
        {
            if (_rigidbody == null) _rigidbody = GetComponent<Rigidbody>();
        }
    }
}