using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedItem : MonoBehaviour
{
    public float _Value;

    //When a dropped item is picked up, The gameobject will be destroyed.
    public virtual void PickUp()
    {
        Destroy(gameObject);
    }
}