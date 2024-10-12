using System;
using Zenject;

namespace Assets.Scripts.Logic.UI
{
    public class ScoreBank : IInitializable
    {
        public int CurrentScore { get; private set; }

        public event Action OnAddSCore;

        public void Initialize() =>
            CurrentScore = 0;

        public void AddScore()
        {
            CurrentScore++;
            OnAddSCore?.Invoke();
        }
    }
}