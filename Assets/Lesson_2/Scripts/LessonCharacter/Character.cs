using Lesson_2.Scripts.LessonCharacter.StateMachine;
using UnityEngine;

namespace Lesson_2.Scripts.LessonCharacter
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour
    {
        [SerializeField] private CharacterConfig _config;
        [SerializeField] private CharacterView _characterView;
        [SerializeField] private ObstacleDetector _groundDetector;
        
        private PlayerInput _input;
        private CharacterStateMachine _stateMachine;
        private CharacterController _controller;
        
        public PlayerInput Input => _input;
        public CharacterController Controller => _controller;
        public CharacterConfig Config => _config;
        public CharacterView View => _characterView;
        public ObstacleDetector GroundDetector => _groundDetector;

        private void Awake()
        {
            _characterView.Initialize();
            _controller = GetComponent<CharacterController>();
            _input = new PlayerInput();
            _stateMachine = new CharacterStateMachine(this);
        }

        private void Update()
        {
            _stateMachine.HandleInput();
            _stateMachine.Update();
        }

        private void OnEnable() => _input.Enable();
        
        private void OnDisable() => _input.Disable();
    }
}