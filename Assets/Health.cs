using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int _MaxHealth = 100;
    public int _CurrentHealth;
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

        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
