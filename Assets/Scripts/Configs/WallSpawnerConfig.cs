using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Configs
{
    [CreateAssetMenu(
        fileName = "SpawnerSettings",
        menuName = "ScritableObjects/SpawnerSettings")]
    public class WallSpawnerConfig : ScriptableObject
    {
        [field: SerializeField] public float MaxHeightPosition { get; private set; }
        [field: SerializeField] public float MinHeightPosition { get; private set; }
        [field: SerializeField] public Vector2 TimeSpawnObstale { get; private set; }
        [field: SerializeField] public List<ObstacleConfig> ListObstacle { get; private set; }
    }
}