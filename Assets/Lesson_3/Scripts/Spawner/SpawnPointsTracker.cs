using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Lesson_3.Scripts.Spawner
{
    public class SpawnPointsTracker : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawnPointsTransforms;
        private List<SpawnPoint> _spawnPoints;

        private void Awake()
        {
            _spawnPoints = new List<SpawnPoint>();
            _spawnPointsTransforms.ForEach(spawnPointTransform => _spawnPoints.Add(new SpawnPoint(spawnPointTransform.position)));
        }

        public bool TryGetRandomPoint(out Vector3 spawnPosition)
        {
            spawnPosition = Vector3.zero;
            if (_spawnPoints.All(point => point.IsOccupied)) 
                return false;

            List<SpawnPoint> freeSpawnPointsArray = _spawnPoints.FindAll(point => point.IsOccupied == false);

            int randomIndex = Random.Range(0, freeSpawnPointsArray.Count);
            spawnPosition = freeSpawnPointsArray[randomIndex].GetPoint();
            return true;
        }

        public void ReleasePoint(Vector3 spawnPosition) =>
            _spawnPoints.Find(point => point.SpawnPosition == spawnPosition)?.ReleasePoint();

        private class SpawnPoint
        {
            private readonly Vector3 _spawnPosition;
            private bool _isOccupied;

            public SpawnPoint(Vector3 spawnPosition) => _spawnPosition = spawnPosition;

            public Vector3 SpawnPosition => _spawnPosition;
            public bool IsOccupied => _isOccupied;

            public Vector3 GetPoint()
            {
                _isOccupied = true;
                return _spawnPosition;
            }

            public void ReleasePoint() => _isOccupied = false;
        } 
    }
}