using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExitTrigger : MonoBehaviour
{
    bool b_isExiting;
    ScreenFade g_screenFade;

	// Use this for initialization
	void Start ()
    {
        GameObject l_fadeObject = GameObject.Find("Screen Fade");
        
        if (l_fadeObject)
        {
            g_screenFade = l_fadeObject.GetComponent<ScreenFade>();
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if player is exiting the level.
		if (b_isExiting)
        {
            // Check if screen fade exists.
            if (g_screenFade)
            {
                // Wait for screen to fade out before changing level.
                if (!g_screenFade.g_fading)
                {
                    // Screen has finished fading, change scene.
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
            b_isExiting = true;

            // Check if screen fade exists.
            if (g_screenFade)
            {
                // Begin fading out.
                g_screenFade.FadeOut(0.5f);
            }
        }
    }
}
