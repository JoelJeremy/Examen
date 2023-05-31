using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int _MaxHealth = 100;
    public int _CurrentHealth;
    public Button _Restart;
    // Start is called before the first frame update
    void Start()
    {
        _CurrentHealth = _MaxHealth;
    }

    //This function allows the player to take damage from enemy bullets
    public void Takedamage(int amount)
    {
        _CurrentHealth -= amount;

        //If the players current health hits 0, The player dies.
        if (_CurrentHealth <= 0)
        {
            //This calls the death function.
            Death();

        }
    }

    // This function allows the player to die.
    public void Death()
    {
        // if a gameobject with the Player Tag dies, the death UI will show up on te screen and the player will not be able to move.
        if (gameObject.tag == "Player")
        {
            //This shows the player death UI on the screen when the player dies.
            GameObject.FindObjectOfType<DeathUI>().ShowDeathScreen();
            //This gets the playerMovement component and sets it to fale, making it that the player wil not be able to move anymore.
            GetComponent<PlayerMovement>().enabled = false;

            //When the player dies the cursor will be locked making it that the player will not be able to look around.
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
