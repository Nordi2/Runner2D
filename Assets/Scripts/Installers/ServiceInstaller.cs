using Assets.Scripts.Services.AssetManagment;
using Assets.Scripts.Services.Factory;
using Assets.Scripts.Services.Input;
using Zenject;

namespace Assets.Scripts.Installers
{
    public class ServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesTo<AssetProvider>()
                .AsSingle()
                .NonLazy();

            Container
                .BindInterfacesTo<FactoryEntity>()
                .AsSingle()
                .NonLazy();

            Container
                .BindInterfacesTo<InputService>()
                .AsSingle()
                .NonLazy();
        }
    }
}