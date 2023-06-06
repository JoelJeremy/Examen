using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floorcheck : MonoBehaviour
{
    public LayerMask _Ground;
    //This varable is activated when a game objrc
    public bool _Grounded = false;


     void OnTriggerStay(Collider other)
    {

        // If The Player (or  other gameObject is touching the ground, _Grounded will remain true.
        if ((_Ground & (1 << other.gameObject.layer)) != 0)
        {
            _Grounded = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        //If the Player isnt touching the Ground (Selected Area) _Grounded will be set to false.
        _Grounded = false;
    }
    
}
