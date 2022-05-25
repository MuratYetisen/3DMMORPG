using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : IPlayerController
{
   public float HorizontalAxis => Input.GetAxis("Horizontal")*Time.deltaTime;

   public float VerticalAxis => Input.GetAxis("Vertical") * Time.deltaTime;

   public float JumpAxis => Input.GetAxis("Jump");

    public void Horizontal(Transform _transform,float _horizontalSpeed)
    {
        _transform.position += new Vector3(HorizontalAxis*_horizontalSpeed, 0);
    }
    public void Vertical(Transform _transform, float _verticalSpeed)
    {
        _transform.position += new Vector3(0, 0, VerticalAxis * _verticalSpeed);
    }
    public void Jump(Rigidbody _rigidbody, float _jumpForce)
    {
        
        //_rigidbody.AddForce(Vector3.up*JumpAxis*_jumpForce);
        _rigidbody.AddForce(new Vector3(0, 0, _jumpForce*JumpAxis));
    }
}
