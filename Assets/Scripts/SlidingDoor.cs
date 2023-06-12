using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public float _Open;
    public float _Closed;
    public bool _DoorStatus;
    public float _Speed;
    public float _StartX;

    public void Start()
    {
        //This calls the Toggle function making the door slide on the Z-Axis when the game is started.
        _StartX = transform.localPosition.z;
        Toggle();
    }

    public void Toggle()
    {
        // When this the Toggle function is called. The object will will get the toggle between open and closed.
        _DoorStatus = !_DoorStatus;
        StopAllCoroutines();
        StartCoroutine(MoveDoor());
    }

    public void Set(bool _IsClosing)
    {
        //This creates a new Variable (IsClosing) This is called to see if the door is moving.
        _DoorStatus = _IsClosing;
        StopAllCoroutines();
        StartCoroutine(MoveDoor());
    }

    private IEnumerator MoveDoor()
    {
        float _T = _DoorStatus ? _Closed : _Open;
        // Here the open and close speed is determined.
        for (int i = 0; i < _Speed * 60; i++)
        {
            _T += _DoorStatus ? i / (_Speed * 60) : -i / (_Speed * 60);
            Vector3 relativePos = transform.localPosition;
            relativePos.z = Mathf.Lerp(_StartX + _Closed, _StartX + _Open, _T);
            transform.localPosition = relativePos;
            yield return new WaitForFixedUpdate();
        }

        yield return 0;
    }
}