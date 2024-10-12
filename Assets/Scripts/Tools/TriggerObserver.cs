using System;
using UnityEngine;

namespace Assets.Scripts.Tools
{
    public class TriggerObserver<TImplementation> : MonoBehaviour
    {
        public event Action<Collider2D> TriggerEnter;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponentInParent<TImplementation>() is not null)
                TriggerEnter?.Invoke(collision);
        }
    }
}