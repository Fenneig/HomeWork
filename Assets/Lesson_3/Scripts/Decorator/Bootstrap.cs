using Lesson_3.Scripts.Decorator.Class;
using Lesson_3.Scripts.Decorator.Config;
using Lesson_3.Scripts.Decorator.Passive;
using Lesson_3.Scripts.Decorator.Race;
using UnityEngine;

namespace Lesson_3.Scripts.Decorator
{
    public class Bootstrap : MonoBehaviour
    {
        [Header("Scene dependencies")]
        [SerializeField] private Player _player;
        [Header("Setup")]
        [SerializeField] private Stats _basePlayerStats;
        [SerializeField] private ConfigsRepository _configs;
        [SerializeField] private ClassType _debugAddClassType;
        [SerializeField] private RaceType _debugAddRaceType;
        [SerializeField] private PassiveType _debugAddPassiveType;

        private StatProvider _statProvider;
        
        private void Awake()
        {
            _statProvider = new StatProvider(_configs);

            _player.Initialize(_basePlayerStats, _statProvider);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                _player.AddClass(_debugAddClassType);
            
            if (Input.GetKeyDown(KeyCode.W))
                _player.AddRace(_debugAddRaceType);
            
            if (Input.GetKeyDown(KeyCode.E))
                _player.AddPassive(_debugAddPassiveType);
        }
    }
}