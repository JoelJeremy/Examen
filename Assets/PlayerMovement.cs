using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _MovementSpeed = 2;
    public float _JumpHeight = 2;
    public float _Gravity = 1;
    public Vector3 _Delta;
    public float _Xinput;
    public float _Yinput;
    Rigidbody _Rb;
    public Floorcheck _Checker;
    bool _CanJump = false;
    // Start is called before the first frame update
    void Start()
    {
        _Rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        _Xinput = Input.GetAxis("Horizontal");
        _Yinput = Input.GetAxis("Vertical");
      
        _CanJump = _Checker._Grounded;
        if (_Checker._Grounded&& _Rb.velocity.y<0)
        {
            _Delta.y = 0;
        }
        if (_CanJump && Input.GetKeyDown(KeyCode.Space))
        {
            _Delta.y = _JumpHeight;
            print(" Jummp");
        }
        _Delta.x = _Xinput * _MovementSpeed ;
        _Delta.z = _Yinput * _MovementSpeed ;










        _Delta.y -= _Gravity;
        _Rb.velocity = _Delta;
        print(_Checker._Grounded);
        
    }
    private void FixedUpdate()
    {
        
    }

}
