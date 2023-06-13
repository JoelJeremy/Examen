using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    private TMP_Text _EnemyCounter;
    public int _AmountOfEnemies = 100;
    public bool _IsStarted = false;

    private void Start()
    {
        //This gets counts the amount of enemies in the map and show the amount onScreen. This makes it vidible to the player.
        _EnemyCounter = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        //This searches for every gameobject that has the enemy shootscript and labels them as an enemy. This is used to count the amount of enemies searching for the
        //Enemy shootscript.
        _AmountOfEnemies = GameObject.FindObjectsOfType<EnemyShoot>().Length;
        _EnemyCounter.text = "Enemies Left: " + _AmountOfEnemies;
        _IsStarted = true;
    }
}