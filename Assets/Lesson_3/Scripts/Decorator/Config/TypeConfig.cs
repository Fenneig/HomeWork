using UnityEngine;

namespace Lesson_3.Scripts.Decorator.Config
{
    public class TypeConfig<T> : ScriptableObject
    {
        [SerializeField] private protected T _configType;
        [SerializeField] private float _modifier;

        public float Modifier => _modifier;

        public T ConfigType => _configType;
    }
}