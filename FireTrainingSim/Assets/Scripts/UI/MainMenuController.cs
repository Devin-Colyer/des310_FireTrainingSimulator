using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    // When play button is pressed call this function
    public void PlayButtonPressed()
    {
        // Move onto the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // When play button is pressed call this function
    public void QuitButtonPressed()
    {
        // Debug
        Debug.Log("Game has exited");

        // Move onto the next scene
        Application.Quit();
    }
}
