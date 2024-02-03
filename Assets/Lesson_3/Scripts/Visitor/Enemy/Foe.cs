using System;
using UnityEngine;

namespace Lesson_3.Scripts.Visitor.Enemy
{
    public abstract class Foe : MonoBehaviour
    {
        public event Action<Foe> Died;

        public void MoveTo(Vector3 position) => transform.position = position;

        public void Kill()
        {
            Died?.Invoke(this);
            Destroy(gameObject);
        }
    }
}