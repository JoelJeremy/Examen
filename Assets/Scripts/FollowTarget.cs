using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
    
{
    public float _Speed;
    public GameObject _Target;
    public Rigidbody _Rigidbody;
    EnemyShoot _ShootScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    public void StartFollowing()
    {
        //This gets printed when the enemy starts following the PLayer. For testing purposes mostly.
        print(" Starting to follow");
        //This gets  the Rigidbody Component from the object that this script has been assigned to.
        _Rigidbody = GetComponent<Rigidbody>();
        _ShootScript = GetComponent<EnemyShoot>();
        _ShootScript._Target = _Target;
        _ShootScript.ShootTimer();

    }
    void FixedUpdate()
    {
        //This activates the Follow function everytime the _Target is seen by an Enemy
        Follow();
    }

    // This function makes the enemy follow the _Target (Player) When the _Target is in its Field of View.
    void Follow()
    {
        // This creates the direction that the Enemy has to move in. In this case its from the enmies location to the Targets (Players) location
        Vector3 _Direction = Vector3.Normalize(_Target.transform.position - transform.position);
        _Rigidbody.MovePosition(transform.position + _Direction * _Speed/1000);
        transform.rotation = Quaternion.LookRotation(-_Direction.normalized);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);

    }
}
