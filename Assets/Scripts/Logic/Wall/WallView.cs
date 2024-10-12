using UnityEngine;

namespace Assets.Scripts.Logic.Wall
{
    public class WallView : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;

        public Rigidbody2D Rigidbody => _rigidbody;
    }
}