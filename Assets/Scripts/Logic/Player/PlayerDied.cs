using System;
using Zenject;

namespace Assets.Scripts.Logic.Player
{
    public class PlayerDied : IInitializable, IDisposable
    {
        private readonly PlayerCollisionHandler _collisionHandler;
        private readonly PlayerView _view;

        public PlayerDied(PlayerCollisionHandler collisionHandler, PlayerView view)
        {
            _collisionHandler = collisionHandler;
            _view = view;
        }

        public void Initialize()
        {
            _collisionHandler.OnDie += Die;
        }

        public void Dispose()
        {
            _collisionHandler.OnDie -= Die;
        }

        private void Die()
        {
            _view.gameObject.SetActive(false);
        }
    }
}