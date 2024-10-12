using Assets.Scripts.Logic.Score;
using System;
using Zenject;

namespace Assets.Scripts.Logic.UI
{
    public class ScoreBank : IInitializable, IDisposable
    {
        public int CurrentScore { get; private set; }

        public event Action OnAddSCore;

        private readonly IScoreFacade _scoreFacade;

        public ScoreBank(IScoreFacade scoreFacade)
        {
            _scoreFacade = scoreFacade;
        }

        public void Initialize()
        {
            _scoreFacade.OnCollect += AddScore;
            CurrentScore = 0;
        }

        public void Dispose()
        {
            _scoreFacade.OnCollect -= AddScore;
        }

        public void AddScore()
        {
            CurrentScore++;
            OnAddSCore?.Invoke();
        }

    }
}