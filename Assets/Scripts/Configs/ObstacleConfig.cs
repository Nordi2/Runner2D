using Assets.Scripts.Logic.Wall;
using UnityEngine;

namespace Assets.Scripts.Configs
{
    [CreateAssetMenu(
        fileName = "ObstacleConfig",
        menuName = "ScritableObjects/ObstacleConfig")]
    public class ObstacleConfig : ScriptableObject
    {
        [field: SerializeField] public float MoveSpeed { get; private set; }
        [field: SerializeField] public WallView PrefabObstacle { get; private set; }
    }
}