using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoUI : MonoBehaviour
{
    //This is the variable that is used to calculate how mucht health the player has.
    public ShootScript _CurrentAmmo;

    //This shows the amount of Ammo the player has.
    private TMP_Text _AmmoAmount;

    // Start is called before the first frame update
    private void Start()
    {
        _AmmoAmount = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        //This links the Text in the hud to display the amount of current ammo that the player gun has and the ammount of backup ammo the player has. This depletes
        // according to the ammount of ammo the player shoots and if the player reloads.
        _AmmoAmount.text = _CurrentAmmo._CurrentAmmo.ToString() + " | " + _CurrentAmmo._BackupAmmo.ToString();
    }
}