using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    //This restarts the game when activated by a button. It reloads the Scene.
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //This allows the player to navigate to the main menu when the game is paused and they select the button that redirects them to the Main Menu.
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //This is an "X" b utton. This button allows the player to close the Pause menu and keep playing the game.
    //Once the player resumes the game the cursor lockstate will be set to locked, meaning that the cursor will not be visible on the screen anymore until the pause menu is opened.
    public void CloseWindow()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Update()

    {
        //If the esc key is pressed it deactivates the cursor lockstate allowing the player to move the cursor freely.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}