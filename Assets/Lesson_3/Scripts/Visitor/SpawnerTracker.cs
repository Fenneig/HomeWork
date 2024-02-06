namespace Lesson_3.Scripts.Visitor
{
    public class SpawnerTracker
    {
        private readonly Spawner _spawner;
        private readonly int _maxWeight;

        public SpawnerTracker(Spawner spawner, int maxWeight)
        {
            _spawner = spawner;
            _maxWeight = maxWeight;
        }

        public void StartSpawn() => _spawner.StartWork();

        public void StopSpawn() => _spawner.StopWork();

        public void CheckWeight(int currentWeight)
        {
            if (currentWeight >= _maxWeight)
            {
                StopSpawn();
                return;
            }

            if (_spawner.IsSpawnerWork == false && currentWeight < _maxWeight)
            {
                StartSpawn();
            }
        }
    }
}