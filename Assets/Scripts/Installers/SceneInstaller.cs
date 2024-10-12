using Assets.Scripts.Logic.UI;
using Assets.Scripts.Services.Input;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class SceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesTo<InputService>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<ScoreBank>()
                .AsSingle()
                .NonLazy();
        }
    }
}