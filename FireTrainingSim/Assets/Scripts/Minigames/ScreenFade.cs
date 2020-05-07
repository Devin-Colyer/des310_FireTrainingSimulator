using UnityEngine.UI;
using UnityEngine;

public class ScreenFade : MonoBehaviour
{
    // Member variables.
    GameObject m_screenFade;
    public bool m_fading;
    float m_timeToFade;
    float m_currentFadeTime;
    public Color m_fadeColor;
    float m_currentAlpha;
    float m_targetAlpha;
    float m_startAlpha;

    // Use this for initialization
    void Start ()
    {
        // Initialise global variables.
        m_timeToFade = 1.0f;
        m_currentFadeTime = 1.0f;
        m_currentAlpha = 0.0f;
        m_targetAlpha = 0.0f;
        m_startAlpha = 0.0f;
        m_fading = false;

        // Retrieve fade image from UI.
        m_screenFade = GameObject.Find("Screen Fade");
        m_screenFade.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);
        m_screenFade.GetComponent<Image>().color = new Color(m_fadeColor.r, m_fadeColor.g, m_fadeColor.b, 0.0f);

        // Fade in on game start.
        FadeIn(0.5f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if currently fading.
        if (m_fading)
        {
            // Increment fade time.
            m_currentFadeTime += Time.deltaTime;

            // Calculate lerp factor.
            float l_lerpFactor = (m_currentFadeTime / m_timeToFade);

            // Lerp from current alpha to target.
            m_currentAlpha = Mathf.Lerp(m_startAlpha, m_targetAlpha, l_lerpFactor);
        }

        // Check if current alpha has reached target.
        if (Mathf.Approximately(m_currentAlpha, m_targetAlpha))
        {
            // Stop fading.
            m_fading = false;
        }

        // Update fade effect with current alpha.
        m_screenFade.GetComponent<Image>().color = new Color(m_fadeColor.r, m_fadeColor.g, m_fadeColor.b, m_currentAlpha);

        // Check if screen size has changed, update screen fade.
        if (this.GetComponent<RectTransform>().sizeDelta.x != Screen.width || this.GetComponent<RectTransform>().sizeDelta.y != Screen.height)
        {
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);
        }

    }

    public void FadeIn(float time)
    {
        // Begin fading.
        m_timeToFade = time;
        m_currentFadeTime = 0.0f;
        m_fading = true;

        // Set current and target alpha.
        m_startAlpha = m_fadeColor.a;
        m_currentAlpha = m_startAlpha;
        m_targetAlpha = 0.0f;
    }

    public void FadeOut(float time)
    {
        Debug.Log("Fade out.");

        // Begin fading.
        m_timeToFade = time;
        m_currentFadeTime = 0.0f;
        m_fading = true;

        // Set current and target alpha.
        m_startAlpha = 0.0f;
        m_currentAlpha = m_startAlpha;
        m_targetAlpha = m_fadeColor.a;
    }
}
