using Assets.Scripts.Logic.Interfaces;
using Assets.Scripts.Logic.Score;
using Assets.Scripts.Logic.UI;
using System;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Logic.Player
{
    public class PlayerCollisionHandler : IInitializable, IDisposable
    {
        public event Action OnDie;

        private readonly DetectedCollisionObjectsObserver _observer;
        private readonly ScoreBank _scoreBank;

        public PlayerCollisionHandler(DetectedCollisionObjectsObserver observer, ScoreBank scoreBank)
        {
            _observer = observer;
            _scoreBank = scoreBank;
        }

        public void Initialize()
        {
            _observer.TriggerEnter += TriggerEnter;
        }

        public void Dispose()
        {
            _observer.TriggerEnter -= TriggerEnter;
        }

        private void TriggerEnter(Collider2D obj)
        {
            TypeCollisionObjects objects = obj.GetComponentInParent<ICollisionableObjects>().TypeObject;

            switch (objects)
            {
                case TypeCollisionObjects.None:
                    throw new ArgumentException($"The type is not defined on this objects {objects}");
                case TypeCollisionObjects.Friendly:
                    IScoreFacade score = obj.GetComponentInParent<IScoreFacade>();
                    score.Collect();
                    _scoreBank.AddScore();
                    break;
                case TypeCollisionObjects.Hostile:
                    OnDie?.Invoke();
                    break;
            }
        }
    }
}