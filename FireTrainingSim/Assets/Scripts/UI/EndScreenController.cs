using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScreenController : MonoBehaviour
{
    enum State
    {
        IDLE, EXIT
    }

    State g_menuState = State.IDLE;
    ScreenFade g_screenFade;

    void Start()
    {
        g_screenFade = FindObjectOfType<ScreenFade>();
    }

    void Update()
    {
        if (!g_screenFade.m_fading && g_menuState == State.EXIT)
        {
            // Change scene, go back to main menu.
            SceneManager.LoadSceneAsync(0);
        }
    }

    public void ExitButtonPressed()
    {
        if (g_screenFade)
        {
            g_screenFade.FadeOut(0.5f);
        }

        g_menuState = State.EXIT;
    }
}
