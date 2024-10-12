using Assets.Scripts.Configs;
using Assets.Scripts.Logic.Player;
using UnityEngine;
using Zenject;

public class PlayerMovement : ITickable, IInitializable
{
    private bool _isGrounded;
    private int _maxJump;

    private readonly PlayerConfig _playerConfig;
    private readonly PlayerView _playerView;

    public PlayerMovement(PlayerConfig playerConfig, PlayerView playerView)
    {
        _playerConfig = playerConfig;
        _playerView = playerView;
    }

    public void Initialize() =>
        _maxJump = _playerConfig.MaxValueJump;

    public void Tick()
    {
        _isGrounded = Physics2D.OverlapCircle(_playerView.GroundCheck.position, _playerConfig.CheckRadiues, _playerView.LayerMask);

        if (Input.GetMouseButtonDown(0) && _maxJump > 0)
        {
            _maxJump--;
            Jump();
        }
        else if (Input.GetMouseButtonDown(0) && _maxJump == 0 && _isGrounded)
        {
            Jump();
        }

        if (_isGrounded)
            _maxJump = _playerConfig.MaxValueJump;
    }

    private void Jump()
    {
        _playerView.Rigidbody.velocity = Vector2.zero;
        _playerView.Rigidbody.AddForce(new Vector2(0, _playerConfig.JumpForce));
    }
}
