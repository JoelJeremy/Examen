using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUI : MonoBehaviour
{
    public GameObject _RestartPanel;

    //Thius shows sets the Death screen to true once the player dies.
    public void ShowDeathScreen()
    {
        _RestartPanel.SetActive(true);
    }

    //This restarts the game when activated by a button. It reloads the Scene.
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}