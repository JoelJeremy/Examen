using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoDrop : DropableItems
{
    //this is set for the amount of ammo an enemy drops when the enemy is killed.
    public int _AmmoCount = 50;

    public override GameObject DropItem()
    {
        //This function gets the spawned gameObject.
        GameObject _SpawnedObject = base.DropItem();
        _SpawnedObject.GetComponent<DroppedItem>()._Value = _AmmoCount;
        return _SpawnedObject;
    }
}