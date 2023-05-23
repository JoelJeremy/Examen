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

    public void Takedamage(int amount)
    {
        _CurrentHealth -= amount;

        if (_CurrentHealth <= 0)
        {
            Death();

        }
    }

    public void Death()
    {
        if (gameObject.tag == "Player")
        {
            GameObject.FindObjectOfType<DeathUI>().ShowDeathScreen();
            GetComponent<PlayerMovement>().enabled = false;
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
