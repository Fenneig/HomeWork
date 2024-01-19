using UnityEngine;

namespace Lesson_1.Scripts.BalloonTask
{
    public class Player : MonoBehaviour
    {
        public void Burst(Vector2 clickPosition)
        {
            Ray ray = Camera.main.ScreenPointToRay(clickPosition);
            Physics.Raycast(ray, out var hit);
            if (hit.collider.TryGetComponent(out Balloon balloon)) balloon.Burst();
        }
    }
}