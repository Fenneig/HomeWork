using Lesson_3.Scripts.Visitor.Configs;
using Lesson_3.Scripts.Visitor.Modules;
using UnityEngine;

namespace Lesson_3.Scripts.Visitor
{
    public class VisitorBootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private ScoreConfig _scoreConfig;
        [SerializeField] private WeightConfig _weightConfig;
        [SerializeField] private int _maxWeight;
        
        private Score _score;
        private Weight _weight;
        private SpawnerTracker _spawnerTracker;

        private void Start()
        {
            _score = new Score(_spawner, _scoreConfig);
            _weight = new Weight(_spawner, _weightConfig);
            _spawnerTracker = new SpawnerTracker(_spawner, _maxWeight);

            _weight.WeightChanged += DebugHolder.DebugWeight;
            _weight.WeightChanged += _spawnerTracker.CheckWeight;
            _score.ScoreChanged += DebugHolder.DebugScore;
            
            _spawnerTracker.StartSpawn();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                _spawner.KillRandomEnemy();
        }

        private void OnDestroy()
        {
            _weight.WeightChanged -= DebugHolder.DebugWeight;
            _weight.WeightChanged -= _spawnerTracker.CheckWeight;
            _score.ScoreChanged -= DebugHolder.DebugScore;
        }
    }
}