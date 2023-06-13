using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ShootScript _ShootScript;

    private void OnTriggerEnter(Collider other)
    {
        //When the player collides/picks up dropped ammo, The amount of dropped ammo will be added to the amount of backup ammo that the player had when picking
        //up the dropped ammo.
        if (other.GetComponent<DroppedItem>())
        {
            DroppedItem _Item = other.GetComponent<DroppedItem>();

            if (_Item.GetType() == typeof(DroppedAmmo))
            {
                _ShootScript.AddAmmo((int)_Item._Value);
                _Item.PickUp();
                print(" Touch");
            }
        }
    }
}