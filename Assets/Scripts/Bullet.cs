using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // These are the variables for the bullet property.
    public int _BulletDamage;

    //this sets the speed that the enmy bullets travel with
    public float _Speed;

    //This sets the time the bullet is destroyed after an enemy has shot it.
    public float _DestroyTime;

    private void Start()
    {
        Destroy(gameObject, _DestroyTime);
    }

    private void FixedUpdate()
    {
        // This gets the component (in this case the bullet) and sets the speed and direction that the bullets has to travel towards.
        GetComponent<Rigidbody>().velocity = transform.forward * _Speed / 1;
    }

    // This triggers a system once the object collides with another object.
    private void OnTriggerEnter(Collider other)
    {
        // If the object (Bullet) hits the chosen object, In this case the player. The health will be altered.
        if (other.tag == "Player")
        {
            if (other.GetComponent<Health>()) ;
            {
                print(other.tag);
                // The Health will decrease depending on the _BulletDamage.
                other.GetComponent<Health>().Takedamage(_BulletDamage);
            }
        }
        if (other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }
    }
}