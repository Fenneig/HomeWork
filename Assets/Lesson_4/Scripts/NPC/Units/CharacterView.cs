using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Lesson_4.Scripts.NPC.Units
{
    [RequireComponent(typeof(Animator))]
    public class CharacterView : MonoBehaviour
    {
        private Animator _animator;
        
        private static readonly int IsWalking = Animator.StringToHash("IsWalking");
        private static readonly int IsWorking = Animator.StringToHash("IsWorking");
        private static readonly int IsResting = Animator.StringToHash("IsResting");
        private static readonly int IsDelivering = Animator.StringToHash("IsDelivering");

        public event Action WorkAction;
        public event Action RestAction;
        public event Action DeliverAction;
        public event Action CheckStatus;

        public void Initialize() => _animator = GetComponent<Animator>();

        public void StartWalking() => _animator.SetBool(IsWalking, true);
        
        public void StopWalking() => _animator.SetBool(IsWalking, false);

        public void StartDelivering() => _animator.SetBool(IsDelivering, true);
        
        public void StopDelivering() => _animator.SetBool(IsDelivering, false);
        
        public void StartWorking() => _animator.SetBool(IsWorking, true);
        
        public void StopWorking() => _animator.SetBool(IsWorking, false);
        
        public void StartRest() => _animator.SetBool(IsResting, true);
        
        public void StopRest() => _animator.SetBool(IsResting, false);

        [UsedImplicitly]
        public void OnWork()
        {
            WorkAction?.Invoke();
            CheckStatus?.Invoke();
        }

        [UsedImplicitly]
        public void OnRest()
        {
            RestAction?.Invoke();
            CheckStatus?.Invoke();
        }

        [UsedImplicitly]
        public void OnDeliver()
        {
            DeliverAction?.Invoke();
            CheckStatus?.Invoke();
        }
    }
}