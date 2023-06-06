using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedItem : MonoBehaviour
{
    public float _Value;

    public void PickUp()
    {
        Destroy(gameObject);
    }
}