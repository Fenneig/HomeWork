using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    public class TypeConfig<T> : ScriptableObject
    {
        [SerializeField] private protected T _type;
        [SerializeField] private float _modifier;

        public float Modifier => _modifier;

        public T Type => _type;
    }
}