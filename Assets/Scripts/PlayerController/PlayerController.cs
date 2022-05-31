using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Config")]
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _speed, _jumpForce;
    [SerializeField] Rigidbody _rigidbody;
    MoveController _moveController;
    bool _isJump;
    [SerializeField] Animator _animator;
    // Start is called before the first frame update
    void Awake()
    {
        _moveController = new MoveController();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJump = true;
            _animator.SetBool("__Jump", true);
        }
        else
        {
            _isJump = false;
            _animator.SetBool("__Jump", false);
        }
        Flip();
    }
    private void FixedUpdate()
    {
        Jump();
        Walk();
    }
    void Walk()
    {
        _moveController.Horizontal(_playerTransform, _speed);
        _moveController.Vertical(_playerTransform, _speed);
        _animator.SetFloat("__isWalk", Mathf.Abs(_moveController.HorizontalAxis));
        _animator.SetFloat("__isWalk", Mathf.Abs(_moveController.VerticalAxis));

    }
    void Jump()
    {
        if (_isJump)
        {
            _moveController.Jump(_rigidbody, _jumpForce);
            
        }
        

    }
    void Flip()
    {
        //if (Input.GetKey(KeyCode.A)&& Input.GetKey(KeyCode.LeftShift))
        //{
        //    _playerTransform.rotation = new Quaternion(0, -90, 0, 0);
        //}
        //if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        //{
        //    _playerTransform.rotation = new Quaternion(0, -270, 0, 0);
        //}
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            _playerTransform.rotation = new Quaternion(0, 0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            _playerTransform.rotation = new Quaternion(0, -180, 0, 0);
        }
    }
}
