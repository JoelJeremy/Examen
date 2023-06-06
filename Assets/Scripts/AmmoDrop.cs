using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoDrop : DropableItems
{
    public int _AmmoCount = 50;

    public override GameObject DropItem()
    {
        // deze fuctie pakt het gespawnde object.
        GameObject _SpawnedObject = base.DropItem();
        _SpawnedObject.GetComponent<DroppedItem>()._Value = _AmmoCount;
        return _SpawnedObject;
    }
}