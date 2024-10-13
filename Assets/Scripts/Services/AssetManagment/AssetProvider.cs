using UnityEngine;

namespace Assets.Scripts.Services.AssetManagment
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject LoadObjet(string path)
        {
            GameObject obj = Resources.Load<GameObject>(path);
            return obj;
        }
    }
}