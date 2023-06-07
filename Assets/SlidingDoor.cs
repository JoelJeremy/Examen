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
        _StartX = transform.localPosition.z;
        Toggle();
    }

    public void Toggle()
    {
        _DoorStatus = !_DoorStatus;
        StopAllCoroutines();
        StartCoroutine(MoveDoor());
    }

    public void Set(bool _IsClosing)
    {
        _DoorStatus = _IsClosing;
        StopAllCoroutines();
        StartCoroutine(MoveDoor());
    }

    private IEnumerator MoveDoor()
    {
        float _T = _DoorStatus ? _Closed : _Open;
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