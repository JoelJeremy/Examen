using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropableItems : MonoBehaviour
{
    //*************************
    [SerializeField]
    public GameObject _DropItem;

    public virtual GameObject DropItem()
    {
        return Instantiate(_DropItem, transform.position, Quaternion.identity);
    }
}