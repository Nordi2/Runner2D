using Assets.Scripts.Configs;
using Assets.Scripts.Logic.Wall;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers.GameObjectInstallers
{
    public class ObstacleInstaller : MonoInstaller
    {
        [SerializeField] private ObstacleConfig _config;
        [SerializeField] private WallView _view;

        public override void InstallBindings()
        {
            Container
                .BindInstance(_config)
                .AsSingle();

            Container
                .BindInstance(_view)
                .AsSingle();

            Container
                .BindInterfacesTo<WallMovement>()
                .AsSingle()
                .NonLazy();
        }
    }
}