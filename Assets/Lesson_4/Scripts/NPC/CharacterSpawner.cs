using Cinemachine;
using Lesson_4.Scripts.NPC.Units;
using UnityEngine;
using Zenject;

namespace Lesson_4.Scripts.NPC
{
    public class CharacterSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Character _characterPrefab;
        [SerializeField] private CinemachineVirtualCamera _camera;

        private CharacterFactory _characterFactory;
        private UIMediator _uiMediator;

        [Inject]
        private void Construct(CharacterFactory characterFactory, UIMediator uiMediator)
        {
            _characterFactory = characterFactory;
            _uiMediator = uiMediator;
        }

        private void Awake()
        {
            CreateAndRegisterCharacter();
        }

        private void CreateAndRegisterCharacter()
        {
            Character character = _characterFactory.Get(_characterPrefab, _spawnPoint.position);

            _uiMediator.RegisterCharacter(character);

            _camera.Follow = character.transform;
            _camera.LookAt = character.transform;
        }
    }
}