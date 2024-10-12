using Zenject;
using UnityEngine;
using Assets.Scripts.Logic.UI;

namespace Assets.Scripts.Installers
{
    public class UIInstaller : MonoInstaller
    {
        [SerializeField] private ScoreView _scoreView;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ScorePresenter>().AsSingle().WithArguments(_scoreView).NonLazy();
        }
    }
}