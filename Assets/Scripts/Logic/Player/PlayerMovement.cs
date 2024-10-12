using Assets.Scripts.Configs;
using Assets.Scripts.Logic.Player;
using Assets.Scripts.Services.Input;
using System;
using UnityEngine;
using Zenject;

public class PlayerMovement : ITickable, IInitializable, IDisposable
{
    private bool _isGrounded;
    private int _maxJump;

    private readonly PlayerConfig _playerConfig;
    private readonly PlayerView _playerView;
    private readonly IInputSevice _inputSevice;

    public PlayerMovement(PlayerConfig playerConfig, PlayerView playerView, IInputSevice inputSevice)
    {
        _playerConfig = playerConfig;
        _playerView = playerView;
        _inputSevice = inputSevice;
    }

    public void Initialize()
    {
        _inputSevice.OnClickMouseButton += TryJump;
        _maxJump = _playerConfig.MaxValueJump;
    }

    public void Dispose() =>
        _inputSevice.OnClickMouseButton -= TryJump;

    public void Tick()
    {
        _isGrounded = Physics2D.OverlapCircle(_playerView.GroundCheck.position, _playerConfig.CheckRadiues, _playerView.LayerMask);

        if (_isGrounded)
            _maxJump = _playerConfig.MaxValueJump;
    }

    private void TryJump()
    {
        if (_maxJump > 0)
        {
            _maxJump--;
            Jump();
        }
        else if (_maxJump == 0 && _isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        _playerView.Rigidbody.velocity = Vector2.zero;
        _playerView.Rigidbody.AddForce(new Vector2(0, _playerConfig.JumpForce));
    }

}
