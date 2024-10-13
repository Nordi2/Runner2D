using UnityEngine;

namespace Assets.Scripts.Services.AssetManagment
{
    public interface IAssetProvider
    {
        GameObject LoadObjet(string path);
    }
}