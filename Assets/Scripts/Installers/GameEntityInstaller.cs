using Assets.Scripts.Logic.Interfaces;
using Assets.Scripts.Logic.Score;
using Assets.Scripts.Logic.UI;
using Assets.Scripts.Services.AssetManagment;
using Assets.Scripts.Services.Factory;
using Zenject;
using UnityEngine;
using Assets.Scripts.Configs;
using Assets.Scripts.Logic.Wall;

namespace Assets.Scripts.Installers
{
    public class GameEntityInstaller : MonoInstaller
    {
        [SerializeField] private WallSpawnerConfig _spawnerConfig;
        [SerializeField] private Transform _spawnPoint;

        private IFactoryEntity _factoryEntity;

        [Inject]
        private void Construct(IFactoryEntity factoryEntity)
        {
            _factoryEntity = factoryEntity;
        }

        public override void InstallBindings()
        {
            Container
                .BindInstance(_spawnerConfig)
                .AsSingle()
                .NonLazy();

            Container
                .Bind<ScoreBank>()
                .AsSingle()
                .NonLazy();

            Container
                .BindInterfacesTo<WallSpawner>()
                .AsSingle()
                .WithArguments(_spawnPoint);

            Container.BindInterfacesTo<ScoreFacade>().FromComponentInHierarchy().AsSingle();

            IPlayerFacade player = _factoryEntity.GetEntity<IPlayerFacade>(AssetPath.PLAYER_PATH);
            Container.BindInstance(player);
        }
    }
}