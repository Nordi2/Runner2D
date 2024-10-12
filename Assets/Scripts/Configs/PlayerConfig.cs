using UnityEngine;

namespace Assets.Scripts.Configs
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "ScritableObjects/PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField, Min(1)] public float JumpForce { get; private set; }
        [field: SerializeField, Min(0.1f)] public float CheckRadiues { get; private set; }
        [field: SerializeField, Min(1)] public int MaxValueJump { get; private set; }
    }
}