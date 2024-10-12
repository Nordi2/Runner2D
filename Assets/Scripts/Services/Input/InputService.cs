using System;
using Zenject;

namespace Assets.Scripts.Services.Input
{
    public class InputService : IInputSevice, ITickable
    {
        public event Action OnClickMouseButton;

        public void Tick()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
                OnClickMouseButton();
        }
    }
}