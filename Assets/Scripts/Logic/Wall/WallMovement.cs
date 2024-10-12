using Assets.Scripts.Configs;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Logic.Wall
{
    public class WallMovement : IFixedTickable
    {
        private readonly WallView _view;
        private readonly ObstacleConfig _config;

        public WallMovement(WallView view, ObstacleConfig config)
        {
            _view = view;
            _config = config;
        }

        public void FixedTick()
        {
            _view.Rigidbody.velocity = Vector3.left * _config.MoveSpeed * Time.deltaTime;
        }
    }
}