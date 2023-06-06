using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationY = 0f;
    public float rotationX = 0f;
    public float sensitivity = 3f;

    public float _MovementSpeed = 2;
    public float _JumpHeight = 2;
    public float _Gravity = 1;
    public Vector3 _Delta;
    public float _Xinput;
    public float _Yinput;
    private Rigidbody _Rb;
    public Floorcheck _Checker;
    private bool _CanJump = false;
    public AudioSource _Source;
    // Start is called before the first frame update

    //At the start the component RigidBody is fetched.
    private void Start()
    {
        _Rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _Delta.x = 0;
        _Delta.z = 0;

        _Xinput = Input.GetAxis("Horizontal");
        _Yinput = Input.GetAxis("Vertical");

        //This allows the player to Jump, but only if _Grounded is true.
        _CanJump = _Checker._Grounded;
        if (_Checker._Grounded && _Rb.velocity.y < 0)
        {
            _Delta.y = 0;
        }

        if (_CanJump && Input.GetKeyDown(KeyCode.Space))
        {
            _Delta.y = _JumpHeight;
            print(" Jump");
        }
        _Delta += _Xinput * _MovementSpeed * transform.right + _Yinput * _MovementSpeed * transform.forward;

        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        transform.localEulerAngles = new Vector3(0, rotationY, 0);

        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -85f, 85f);
        Camera.main.transform.localEulerAngles = new Vector3(rotationX, 0, 0);

        // geruik: Input.getaxis muis X waarde
        //LocalEulerAxis van de transform aanpassen

        // Math.clamp
        if ((_Delta.x != 0 || _Delta.z != 0) && !_Source.isPlaying && _Checker._Grounded)
        {
            _Source.Play();
        }
        else if ((_Delta.x == 0 && _Delta.z == 0) || !_Checker._Grounded)
        {
            _Source.Pause();
        }
        _Delta.y -= _Gravity;
        _Rb.velocity = _Delta;
    }

    private void FixedUpdate()
    {
    }
}