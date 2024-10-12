using System;
using UnityEngine;

namespace Assets.Scripts.Logic.Score
{
    public class ScoreFacade : MonoBehaviour, IScoreFacade
    {
        public event Action OnCollect;

        public void Collect() =>
            OnCollect?.Invoke();
    }
}