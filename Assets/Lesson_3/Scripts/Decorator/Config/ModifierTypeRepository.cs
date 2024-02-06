using System.Collections.Generic;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator.Config
{
    public abstract class ModifierTypeRepository<TConfig, TType> : ScriptableObject where TConfig : TypeConfig<TType>
    {
        [SerializeField] private protected List<TConfig> _configs;

        public abstract float GetModifier(TType type);
    }
}