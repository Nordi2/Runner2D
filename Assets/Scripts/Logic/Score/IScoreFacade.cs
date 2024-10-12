using System;

namespace Assets.Scripts.Logic.Score
{
    public interface IScoreFacade
    {
        event Action OnCollect;
        void Collect();
    }
}