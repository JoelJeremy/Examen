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
        _EnemyCounter = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        _AmountOfEnemies = GameObject.FindObjectsOfType<EnemyShoot>().Length;
        _EnemyCounter.text = "Enemies Left: " + _AmountOfEnemies;
        _IsStarted = true;
    }
}