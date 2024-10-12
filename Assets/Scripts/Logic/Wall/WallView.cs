using Assets.Scripts.Logic.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Logic.Wall
{
    public class WallView : MonoBehaviour, ICollisionableObjects
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private TypeCollisionObjects _typeObject;

        public Rigidbody2D Rigidbody => _rigidbody;
        public TypeCollisionObjects TypeObject => _typeObject;
    }
}