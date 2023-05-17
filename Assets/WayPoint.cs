using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Vector3 _A, _B, _StartPosition;
    public float _MovementSpeed = 10f;
    public float _T;
    bool _MovingFromAtoB = true;
    // Start is called before the first frame update
    void Start()
    {
        _StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_T > 1)
        {
            _T = 1;
            _MovingFromAtoB = false;

        }else if (_T < 0) {
            _T = 0;
            _MovingFromAtoB = true;
        }
    }

    // These are the waypoints that the enemies patrol in between.
    private void OnDrawGizmos()
    {
       
        if (Application.isPlaying)
        {
            Gizmos.DrawSphere(_StartPosition+ _A, 0.2f);
            Gizmos.DrawSphere(_StartPosition + _B, 0.2f);
            Gizmos.color = Color.red;
            Gizmos.DrawLine(_StartPosition + _A, _StartPosition + _B);
        }else
        {
 Gizmos.DrawSphere(transform.position + _A, 0.2f);
        Gizmos.DrawSphere(transform.position + _B, 0.2f);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + _A, transform.position + _B);
        }

    }

    private void FixedUpdate()
    {
        _T += (_MovingFromAtoB)?_MovementSpeed / 10000:_MovementSpeed/10000*-1;
        Vector3 _TempA, _TempB;
        _TempA = _A;
        _TempA.y = 0;

        _TempB = _B;
        _TempB.y = 0;
        transform.position = Vector3.Lerp(_StartPosition+_TempA, _StartPosition+_TempB, _T);



        Vector3 _Direction = (_MovingFromAtoB) ? transform.position+_B - transform.position : transform.position+_A - transform.position;
        transform.rotation = Quaternion.LookRotation(-_Direction.normalized);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
    }
}
