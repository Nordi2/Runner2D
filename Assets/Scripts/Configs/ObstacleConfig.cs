using UnityEngine;

namespace Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "ObstacleConfig", menuName = "ScritableObjects/ObstacleConfig")]
    public class ObstacleConfig : ScriptableObject
    {
        [field: SerializeField] public float MoveSpeed { get; private set; }
    }
}