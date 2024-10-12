using System;
using Zenject;

namespace Assets.Scripts.Logic.UI
{
    public class ScorePresenter : IInitializable, IDisposable
    {
        private readonly ScoreBank _scoreBank;
        private readonly ScoreViewUI _scoreView;

        public ScorePresenter(ScoreBank scoreBank, ScoreViewUI scoreView)
        {
            _scoreBank = scoreBank;
            _scoreView = scoreView;
        }

        public void Initialize()
        {
            UpdateScoreText();
            _scoreBank.OnAddSCore += UpdateScoreText;
        }

        public void Dispose()
        {
            _scoreBank.OnAddSCore -= UpdateScoreText;
        }

        private void UpdateScoreText() =>
            _scoreView.UpdateText($"Score:{_scoreBank.CurrentScore}");
    }
}