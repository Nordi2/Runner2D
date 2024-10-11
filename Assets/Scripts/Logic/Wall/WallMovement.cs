using UnityEngine;

namespace Assets.Scripts.Logic.Wall
{
    public class WallMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;

        private void Update()
        {
            transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
        }
    }
}