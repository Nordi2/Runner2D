using System;

namespace Assets.Scripts.Services.Input
{
    public interface IInputSevice
    {
        event Action OnClickMouseButton;
    }
}