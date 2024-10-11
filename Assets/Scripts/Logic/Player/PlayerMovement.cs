using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce;

    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private float _checkRadius;
    [SerializeField] private Transform _groundCheck;

    private bool _isGrounded;
    public int MaxJumpValue;
    int maxjump;

    private void Start()
    {
        maxjump = MaxJumpValue;
    }

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _layerMask);

        if (Input.GetMouseButtonDown(0) && maxjump > 0)
        {
            maxjump--;
            Jump();
        }
        else if (Input.GetMouseButtonDown(0) && maxjump == 0 && _isGrounded)
        {
            Jump();
        }

        if (_isGrounded)
        {
            maxjump = MaxJumpValue;
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(new Vector2(0, _jumpForce));
    }
}
