using System;
using Lesson_3.Scripts.Visitor.Configs;
using Lesson_3.Scripts.Visitor.Enemy;
using Lesson_3.Scripts.Visitor.Interfaces;

namespace Lesson_3.Scripts.Visitor.Modules
{
    public class Weight : IDisposable
    {
        private ReferenceInt _weightReference;
        private IFoeEventNotifier _foeEventNotifier;
        private FoeAddWeightVisitor _foeAddVisitor;
        private FoeRemoveWeightVisitor _foeRemoveVisitor;
        
        public event Action<int> WeightChanged; 

        public Weight(IFoeEventNotifier foeEventNotifier, WeightConfig weightConfig)
        {
            _weightReference = new ReferenceInt();
            _foeEventNotifier = foeEventNotifier;
            _foeEventNotifier.SpawnNotified += OnFoeSpawned;
            _foeEventNotifier.DeathNotified += OnFoeKilled;
            _weightReference.ValueChanged += OnWeightValueChanged;

            _foeAddVisitor = new FoeAddWeightVisitor(weightConfig, _weightReference);
            _foeRemoveVisitor = new FoeRemoveWeightVisitor(weightConfig, _weightReference);
        }

        public void Dispose() => RemoveLinks();

        private void RemoveLinks()
        {
            _foeEventNotifier.SpawnNotified -= OnFoeSpawned;
            _foeEventNotifier.DeathNotified -= OnFoeKilled;
            _weightReference.ValueChanged -= OnWeightValueChanged;
        }

        private void OnFoeSpawned(Foe foe) => _foeAddVisitor.Visit(foe);
        
        private void OnFoeKilled(Foe foe) => _foeRemoveVisitor.Visit(foe);

        private void OnWeightValueChanged(int value) => WeightChanged?.Invoke(value);

        private class ReferenceInt
        {
            public event Action<int> ValueChanged;
            private int _value;
            public int Value
            {
                get => _value;
                set
                {
                    _value = value;
                    ValueChanged?.Invoke(_value);
                }
            }
        }
        
        private class FoeAddWeightVisitor : IFoeVisitor
        {
            private WeightConfig _weightConfig;
            private ReferenceInt _weight;
            
            public FoeAddWeightVisitor(WeightConfig weightConfig, ReferenceInt weight)
            {
                _weightConfig = weightConfig;
                _weight = weight;
            }

            public void Visit(Ork ork) => _weight.Value += _weightConfig.OrkWeight;

            public void Visit(Human human) => _weight.Value += _weightConfig.HumanWeight;

            public void Visit(Elf elf) => _weight.Value += _weightConfig.ElfWeight;

            public void Visit(Robot robot) => _weight.Value += _weightConfig.RobotWeight;

            public void Visit(Foe foe) => Visit((dynamic) foe);
        }   
        
        private class FoeRemoveWeightVisitor : IFoeVisitor
        {
            private WeightConfig _weightConfig;
            private ReferenceInt _weight;
            
            public FoeRemoveWeightVisitor(WeightConfig weightConfig, ReferenceInt weight)
            {
                _weightConfig = weightConfig;
                _weight = weight;
            }

            public void Visit(Ork ork) => _weight.Value -= _weightConfig.OrkWeight;

            public void Visit(Human human) => _weight.Value -= _weightConfig.HumanWeight;

            public void Visit(Elf elf) => _weight.Value -= _weightConfig.ElfWeight;

            public void Visit(Robot robot) => _weight.Value -= _weightConfig.RobotWeight;

            public void Visit(Foe foe) => Visit((dynamic) foe);
        }
    }
}