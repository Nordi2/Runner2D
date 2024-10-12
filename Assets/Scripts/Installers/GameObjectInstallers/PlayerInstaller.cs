using Zenject;
using UnityEngine;
using Assets.Scripts.Configs;
using Assets.Scripts.Logic.Player;

namespace Assets.Scripts.Installers.GameObjectInstallers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private PlayerConfig _config;
        [SerializeField] private PlayerView _view;

        public override void InstallBindings()
        {
            Container
                .BindInstance(_config)
                .AsSingle()
                .NonLazy();

            Container
                .Bind<PlayerView>()
                .FromInstance(_view)
                .AsSingle();

            Container
                .BindInterfacesTo<PlayerMovement>()
                .AsSingle();
        }
    }
}