using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private bool b_isExitting = false;
    ScreenFade g_screenFade;

    void Start()
    {
        g_screenFade = FindObjectOfType<ScreenFade>();
    }

    void Update()
    {
        // Check if fade object exists.
        if (g_screenFade)
        {
            // Check if menu should exit and is finished fading.
            if (!g_screenFade.m_fading && b_isExitting)
            {
                // Change scene, go back to next level.
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else
        {
            // No fade object, check if menu should exit.
            if (b_isExitting)
            {
                // Change scene, go back to next level.
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    // When play button is pressed call this function
    public void PlayButtonPressed()
    {
        b_isExitting = true;

        // Check if fade object exists.
        if (g_screenFade)
        {
            // Begin fading out.
            g_screenFade.FadeOut(0.5f);
        }
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
