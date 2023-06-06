using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// This health script is for the UI also known as the player HUD.
public class HealthUI : MonoBehaviour
{
    //This is the variable that is used to calculate how mucht health the player has.
    public Health _Health;

    //This shows the amount of Health the player has.
    private TMP_Text _Text;

    // Start is called before the first frame update
    private void Start()
    {
        _Text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        //This links the Text in the hud to display the amount of Health that the player has.
        _Text.text = _Health._CurrentHealth.ToString();
    }
}