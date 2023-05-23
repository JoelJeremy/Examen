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
_Rigidbody = GetComponent<Rigidbody>();
        _ShootScript = GetComponent<EnemyShoot>();
        _ShootScript.ShootTimer();

    }
    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 _Direction = Vector3.Normalize(_Target.transform.position - transform.position);
        _Rigidbody.MovePosition(transform.position + _Direction * _Speed/1000);
        transform.rotation = Quaternion.LookRotation(-_Direction.normalized);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);

    }
}
