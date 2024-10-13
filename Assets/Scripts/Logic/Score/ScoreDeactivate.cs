using System;
using Zenject;

namespace Assets.Scripts.Logic.Score
{
    public class ScoreDeactivate : IInitializable, IDisposable
    {
        private readonly IScoreFacade _facade;
        private readonly ScoreView _view;

        public ScoreDeactivate(IScoreFacade facade, ScoreView view)
        {
            _facade = facade;
            _view = view;
        }

        public void Initialize() =>
            _facade.OnCollect += Deactive;

        public void Dispose() =>
            _facade.OnCollect -= Deactive;

        private void Deactive()
        {
            _view.gameObject.SetActive(false);
        }
    }
}