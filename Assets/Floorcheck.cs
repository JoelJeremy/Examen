using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floorcheck : MonoBehaviour
{
    public LayerMask _Ground;
    public bool _Grounded = false;
     void OnTriggerStay(Collider other)
    {
        if ((_Ground & (1 << other.gameObject.layer)) != 0)
        {
            _Grounded = true;
            print("collission");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        _Grounded = false;
    }
    
}
