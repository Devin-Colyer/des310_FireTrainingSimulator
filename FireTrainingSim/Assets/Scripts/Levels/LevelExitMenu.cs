using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExitMenu : MonoBehaviour
{
    bool m_isExiting = false;
    ScreenFade m_screenFade;

    // Use this for initialization
    void Start()
    {
        GameObject l_fadeObject = GameObject.Find("Screen Fade");

        if (l_fadeObject)
        {
            m_screenFade = l_fadeObject.GetComponent<ScreenFade>();
        }

    }

    // Update is called once per frame
    void Update ()
    {
        // Check if player is exiting the level.
        if (m_isExiting)
        {
            // Check if screen fade exists.
            if (m_screenFade)
            {
                // Wait for screen to fade out before changing level.
                if (!m_screenFade.m_fading)
                {
                    // Screen has finished fading, change scene.
                    SceneManager.LoadScene(0);
                }
            }
            else
            {
                // Screen fade does not exist, change level immediately.
                SceneManager.LoadScene(0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Change level to main menu.
            m_isExiting = true;

            // Check if screen fade exists.
            if (m_screenFade)
            {
                // Begin fading out.
                m_screenFade.FadeOut(0.5f);
            }
        }
	}
}
