using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This activates the 1st level when the "Start Campaing" is selected.
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //This allows the player to quit the game when the "Quit" button is selected.
    public void Quit()
    {
        Application.Quit();
    }
}