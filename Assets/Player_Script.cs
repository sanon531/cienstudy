using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public CharacterController controller;
    public float _speed = 0.1f;
    public Vector3 _velocity = new Vector3(1, 1, 0);
    public Vector3 _input = new Vector3(0, 0, 0);
    public float _gravityScale = 1.5f;
    public float _jumpSpeed = 1.5f;

    public bool _jumpInputed = false;
    public bool _isGrounded = false;
    public bool _GroundedBefore = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = controller.isGrounded;
        float dt = Time.deltaTime;
        _input.x = Input.GetAxis("Horizontal");

        //_input.y = Input.GetAxis("Vertical");
        _jumpInputed = Input.GetButtonDown("Jump");
        _velocity = _input * _speed;


        if (_jumpInputed && _GroundedBefore)
        {
            _velocity.y = _velocity.y + _jumpSpeed;
            _GroundedBefore = false;
        }

        if (_isGrounded)
        {
            if (!_GroundedBefore)
                _GroundedBefore = true;
        }
        else
        {
            if (!_GroundedBefore)
                _velocity.y = _velocity.y - (_gravityScale * dt * 9.8f);

        }

        //중력 구현.




        controller.Move(_velocity);
    }
}
