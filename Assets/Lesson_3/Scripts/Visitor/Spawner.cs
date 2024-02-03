using System;
using System.Collections;
using System.Collections.Generic;
using Lesson_3.Scripts.Visitor.Enemy;
using Lesson_3.Scripts.Visitor.Interfaces;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lesson_3.Scripts.Visitor
{
    public class Spawner: MonoBehaviour, IFoeEventNotifier
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private FoeFactory _foeFactory;

        private bool _isSpawnerWork;
        private List<Foe> _spawnedEnemies = new();

        public event Action<Foe> SpawnNotified;
        public event Action<Foe> DeathNotified;
        
        public bool IsSpawnerWork => _isSpawnerWork;

        public void StartWork()
        {
            _isSpawnerWork = true;
            StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            _isSpawnerWork = false;
        }

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count == 0)
                return;

            _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        private IEnumerator Spawn()
        {
            while (_isSpawnerWork)
            {
                yield return new WaitForSeconds(_spawnCooldown);
                
                Foe foe = _foeFactory.Get((FoeType)Random.Range(0, Enum.GetValues(typeof(FoeType)).Length));
                foe.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                foe.Died += OnEnemyDied;
                SpawnNotified?.Invoke(foe);
                _spawnedEnemies.Add(foe);
            }
        }

        private void OnEnemyDied(Foe foe)
        {
            foe.Died -= OnEnemyDied;
            DeathNotified?.Invoke(foe);
            _spawnedEnemies.Remove(foe);
        }
    }
}
