using Assets.Scripts.Configs;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Logic.Wall
{
    public class WallSpawner : ITickable, IInitializable
    {
        private float _currentTime;
        private float _timeSpawnObstacle;
        private Transform _spawnPoint;

        private readonly WallSpawnerConfig _config;
        private readonly IInstantiator _instantiator;

        public WallSpawner(WallSpawnerConfig config, IInstantiator instantiator, Transform spawnPoint)
        {
            _config = config;
            _spawnPoint = spawnPoint;
            _instantiator = instantiator;
        }

        public void Initialize() =>
            ChangeTheSpawnTime();

        public void Tick()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= _timeSpawnObstacle)
            {
                SpawnObstacle();
                _currentTime = 0;
            }
        }

        private void SpawnObstacle()
        {
            ChangeTheSpawnTime();
            float randomOffsetY = Random.Range(_config.MinHeightPosition, _config.MaxHeightPosition);
            Vector3 spawPosition = new Vector3(_spawnPoint.position.x, _spawnPoint.position.y + randomOffsetY, _spawnPoint.position.z);
            _instantiator.InstantiatePrefab(_config.ListObstacle[0].PrefabObstacle, spawPosition, Quaternion.identity, null);
        }

        private void ChangeTheSpawnTime() =>
            _timeSpawnObstacle = Random.Range(_config.TimeSpawnObstale.x, _config.TimeSpawnObstale.y);
    }
}