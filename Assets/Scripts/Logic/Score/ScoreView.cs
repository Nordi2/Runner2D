using Assets.Scripts.Logic.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Logic.Score
{
    public class ScoreView : MonoBehaviour, ICollisionableObjects
    {
        [SerializeField] private TypeCollisionObjects _typeObject;

        public TypeCollisionObjects TypeObject => _typeObject;
    }
}