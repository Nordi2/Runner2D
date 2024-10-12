using UnityEngine;

namespace Assets.Scripts.Logic.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;

        [Header("Checking the location on the ground")]
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private Transform _groundCheck;

        public Transform GroundCheck => _groundCheck;
        public LayerMask LayerMask => _layerMask;
        public Rigidbody2D Rigidbody => _rigidbody;
    }
}