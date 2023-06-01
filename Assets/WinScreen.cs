using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public EnemyCounter _EnemyCounter;
    public GameObject _WinPanel;

    public void Update()

    {
        /* Debug.Log(_EnemyCounter._AmountOfEnemies);*/
        if (_EnemyCounter._AmountOfEnemies == 0 && _EnemyCounter._IsStarted)
        {
            _WinPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}