using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedItem : MonoBehaviour
{
    public float _Value;

    public virtual void PickUp()
    {
        Destroy(gameObject);
    }
}