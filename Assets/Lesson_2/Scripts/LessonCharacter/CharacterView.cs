using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter
{
    [RequireComponent(typeof(Animator))]
    public class CharacterView : MonoBehaviour
    {
        private Animator _animator;
     
        private static readonly int IsRunning = Animator.StringToHash("isRunning");
        private static readonly int IsIdling = Animator.StringToHash("isIdling");
        private static readonly int IsFalling = Animator.StringToHash("isFalling");
        private static readonly int IsMovement = Animator.StringToHash("isMovement");
        private static readonly int IsGrounded = Animator.StringToHash("isGrounded");
        private static readonly int IsJumping = Animator.StringToHash("isJumping");
        private static readonly int MoveSpeed = Animator.StringToHash("MoveSpeed");

        public void Initialize() => _animator = GetComponent<Animator>();

        public void StartIdling() => _animator.SetBool(IsIdling, true);
        public void StopIdling() => _animator.SetBool(IsIdling, false);

        public void StartRunning() => _animator.SetBool(IsRunning, true);
        public void StopRunning() => _animator.SetBool(IsRunning, false);
        public void StartFalling() => _animator.SetBool(IsFalling, true);
        public void StopFalling() => _animator.SetBool(IsFalling, false);
        public void StartMovement() => _animator.SetBool(IsMovement, true);
        public void StopMovement() => _animator.SetBool(IsMovement, false);
        public void StartGrounded() => _animator.SetBool(IsGrounded, true);
        public void StopGrounded() => _animator.SetBool(IsGrounded, false);
        public void StartJumping() => _animator.SetBool(IsJumping, true);
        public void StopJumping() => _animator.SetBool(IsJumping, false);
        public void SetMoveSpeed(float speed) => _animator.SetFloat(MoveSpeed, speed);
    }
}