using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter
{
    public class ObstacleDetector : MonoBehaviour
    {
        [SerializeField] private LayerMask _obstacle;
        [SerializeField, Range(.01f, 1f)] private float _distanceToCheck;
        
        public bool IsTouched { get; private set; }

        private void Update() => IsTouched = Physics.CheckSphere(transform.position, _distanceToCheck, _obstacle);
    }
}