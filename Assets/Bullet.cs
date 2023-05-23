using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int _BulletDamage;
    public float _Speed;
    public float _DestroyTime;

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * _Speed/1;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (other.GetComponent<Health>()) ;
            {
                print(other.tag);
                other.GetComponent<Health>().Takedamage(_BulletDamage);
            }
        }
        
    }

}
