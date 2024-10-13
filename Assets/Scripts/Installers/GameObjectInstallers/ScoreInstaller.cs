using Assets.Scripts.Logic.Score;
using Zenject;
using UnityEngine;

namespace Assets.Scripts.Installers.GameObjectInstallers
{
    public class ScoreInstaller : MonoInstaller
    {
        [SerializeField] private ScoreFacade _facade;
        [SerializeField] private ScoreView _view;

        public override void InstallBindings()
        {
            Container
                .BindInterfacesTo<ScoreFacade>()
                .FromInstance(_facade)
                .AsSingle();

            Container
                .Bind<ScoreView>()
                .FromInstance(_view)
                .AsSingle();

            Container
                .BindInterfacesTo<ScoreDeactivate>()
                .AsSingle()
                .NonLazy();
        }
    }
}