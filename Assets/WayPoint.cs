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

    //This sets the enememies position t the start position of the patrol mode.
    void Start()
    {
        _StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //This if statement explains that: if the target hits a certain number. Movinf from position A to position B will be true or false.  
        //These position is used for the enmy to moven from its primairy location to the player location.

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
            //These gizmos are for the 2 patrol points that the enemy is set to patrol between. These points can vary per enemy.
            Gizmos.DrawSphere(_StartPosition+ _A, 0.2f);
            Gizmos.DrawSphere(_StartPosition + _B, 0.2f);
            
            //This makes the drawn line red to make it more visible.
            Gizmos.color = Color.red;

            //This draws a line between the Gizmos to portay the path that the enmy moves in
            Gizmos.DrawLine(_StartPosition + _A, _StartPosition + _B);
        }else

        {
        Gizmos.DrawSphere(transform.position + _A, 0.2f);
        Gizmos.DrawSphere(transform.position + _B, 0.2f);
        Gizmos.color = Color.blue;

        //This draws a line from the enemy position to the player position
        Gizmos.DrawLine(transform.position + _A, transform.position + _B);
        }

    }

    private void FixedUpdate()
    {
        //This sets the enemies movementspeed from patrol position A to position B
        _T += (_MovingFromAtoB)?_MovementSpeed / 10000:_MovementSpeed/10000*-1;
        Vector3 _TempA, _TempB;
        _TempA = _A;
        _TempA.y = 0;

        _TempB = _B;
        _TempB.y = 0;
        transform.position = Vector3.Lerp(_StartPosition+_TempA, _StartPosition+_TempB, _T);


        //*****
        Vector3 _Direction = (_MovingFromAtoB) ? transform.position+_B - transform.position : transform.position+_A - transform.position;
        transform.rotation = Quaternion.LookRotation(-_Direction.normalized);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
    }
}
