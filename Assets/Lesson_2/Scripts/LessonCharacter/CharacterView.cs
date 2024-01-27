using UnityEngine;

namespace Character
{
    [RequireComponent(typeof(Animator))]
    public class CharacterView : MonoBehaviour
    {
        private Animator _animator;
     
        private static readonly int IsRunning = Animator.StringToHash("isRunning");
        private static readonly int IsIdling = Animator.StringToHash("isIdling");

        public void Initialize() => _animator = GetComponent<Animator>();

        public void StartIdling() => _animator.SetBool(IsIdling, true);
        public void StopIdling() => _animator.SetBool(IsIdling, false);

        public void StartRunning() => _animator.SetBool(IsRunning, true);
        public void StopRunning() => _animator.SetBool(IsRunning, false);
    }
}