using Assets.Scripts.Services.AssetManagment;
using System;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Services.Factory
{
    public class FactoryEntity : IFactoryEntity
    {
        private readonly IAssetProvider _assetProvider;
        private readonly IInstantiator _instantiator;

        public FactoryEntity(IAssetProvider assetProvider, IInstantiator instantiator)
        {
            _assetProvider = assetProvider;
            _instantiator = instantiator;
        }

        public TImplementation GetEntity<TImplementation>(string path)
        {
            GameObject gameObjectEntity = InstantiateRegister(path);
            TImplementation implemetation = gameObjectEntity.GetComponent<TImplementation>();

            if (implemetation is not null)
                return implemetation;
            else
                throw new ArgumentException($"This component was not found on the object {gameObjectEntity.name}.");
        }

        private GameObject InstantiateRegister(string path)
        {
            GameObject gameObject = _instantiator.InstantiatePrefab(_assetProvider.LoadObjet(path));
            return gameObject;
        }
    }
}