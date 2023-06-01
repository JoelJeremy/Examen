using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public TMP_Text _EnemyCounter;

    private void Start()
    {
        _EnemyCounter = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        _EnemyCounter.text = "Enemies Left: " + GameObject.FindObjectsOfType<EnemyShoot>().Length;
    }
}