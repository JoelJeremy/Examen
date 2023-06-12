using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    //This script activates the WinScreen after the Player has eliminated all the enemies
    public EnemyCounter _EnemyCounter;

    public GameObject _WinPanel;

    public void Update()

    {
        /* Debug.Log(_EnemyCounter._AmountOfEnemies);*/
        //This if statement checks if the _AmountOfEnemies = 0. If its 0, then the winpanel is set to true and will display on the sceen.
        //When set active the CursorLockmode will deactivate letting the player move the mouse cursor freely.
        if (_EnemyCounter._AmountOfEnemies == 0 && _EnemyCounter._IsStarted)
        {
            _WinPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}