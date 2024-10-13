using Assets.Scripts.Logic.Score;
using Assets.Scripts.Logic.UI;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class GameEntityInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ScoreFacade>().FromComponentInHierarchy().AsSingle();

            Container
                .Bind<ScoreBank>()
                .AsSingle()
                .NonLazy();
        }
    }
}