using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExitTrigger : MonoBehaviour
{
    bool m_isExiting;
    ScreenFade m_screenFade;

    // Sound Part
    public MusicEmitter m_MusicEmitterScript;


	// Use this for initialization
	void Start ()
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
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    m_MusicEmitterScript.StopMusic();
                }
            }
            else
            {
                // Screen fade does not exist, change level immediately.
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
	}

    void OnTriggerEnter(Collider collider)
    {
        // Check if collider is player.
        if (collider.tag == "Player")
        {
            // Begin exiting level.
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
