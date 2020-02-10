using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScreenFade : MonoBehaviour
{
    // Global variables.
    GameObject g_screenFade;
    public bool g_fading;
    float g_timeToFade;
    float g_currentFadeTime;
    public Color g_fadeColor;
    float g_currentAlpha;
    float g_targetAlpha;
    float g_startAlpha;

    // Use this for initialization
    void Start ()
    {
        // Initialise global variables.
        g_timeToFade = 1.0f;
        g_currentFadeTime = 1.0f;
        g_currentAlpha = 0.0f;
        g_targetAlpha = 0.0f;
        g_startAlpha = 0.0f;
        g_fading = false;

        // Retrieve fade image from UI.
        g_screenFade = GameObject.Find("Screen Fade");
        g_screenFade.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);
        g_screenFade.GetComponent<Image>().color = new Color(g_fadeColor.r, g_fadeColor.g, g_fadeColor.b, 0.0f);

        // Fade in on game start.
        FadeIn(0.5f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if currently fading.
        if (g_fading)
        {
            // Increment fade time.
            g_currentFadeTime += Time.deltaTime;

            // Calculate lerp factor.
            float l_lerpFactor = (g_currentFadeTime / g_timeToFade);

            // Lerp from current alpha to target.
            g_currentAlpha = Mathf.Lerp(g_startAlpha, g_targetAlpha, l_lerpFactor);
        }

        // Check if current alpha has reached target.
        if (Mathf.Approximately(g_currentAlpha, g_targetAlpha))
        {
            // Stop fading.
            g_fading = false;
        }

        // Update fade effect with current alpha.
        g_screenFade.GetComponent<Image>().color = new Color(g_fadeColor.r, g_fadeColor.g, g_fadeColor.b, g_currentAlpha);

    }

    public void FadeIn(float time)
    {
        // Begin fading.
        g_timeToFade = time;
        g_currentFadeTime = 0.0f;
        g_fading = true;

        // Set current and target alpha.
        g_startAlpha = g_fadeColor.a;
        g_currentAlpha = g_startAlpha;
        g_targetAlpha = 0.0f;
    }

    public void FadeOut(float time)
    {
        // Begin fading.
        g_timeToFade = time;
        g_currentFadeTime = 0.0f;
        g_fading = true;

        // Set current and target alpha.
        g_startAlpha = 0.0f;
        g_currentAlpha = g_startAlpha;
        g_targetAlpha = g_fadeColor.a;
    }
}
