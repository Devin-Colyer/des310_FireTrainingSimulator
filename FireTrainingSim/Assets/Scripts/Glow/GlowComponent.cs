using UnityEngine;
using System.Collections.Generic;

public class GlowComponent : MonoBehaviour
{
    enum FadeState
    {
        FADE_IN, FADE_OUT
    }
    
    public Color m_glowColor;
    private List<Material> g_materials = new List<Material>();

    private Color g_currentColor;
    private Color g_startColor;
    private Color g_targetColor;

    public bool b_isFading { get; private set; }
    private FadeState g_fadeState = FadeState.FADE_OUT;

    public float m_timeToFade = 0.4f;
    float g_currentFadeTime;

    public Renderer[] m_renderers { get; private set; }

    // Use this for initialization
    void Start()
	{
        // Initialise current frame time.
        g_currentFadeTime = m_timeToFade;

        // Initialise glow color.
        g_currentColor = Color.black;
        g_startColor = m_glowColor;
        g_targetColor = g_currentColor;

        // Get renderer.
        m_renderers = GetComponentsInChildren<Renderer>();

        // Recieve materials from renderer.
		foreach (Renderer renderer in m_renderers)
		{
            g_materials.AddRange(renderer.materials);
		}
	}
    
	private void Update()
	{
        // Check if glow is fading.
        if (b_isFading)
        {
            // Increment fade time.
            g_currentFadeTime += Time.deltaTime;

            // Calculate lerp factor.
            float l_lerpFactor = (g_currentFadeTime / m_timeToFade);

            // Lerp from current color to target.
            g_currentColor = Color.Lerp(g_startColor, g_targetColor, l_lerpFactor);
        }

        // Check if current colour has reached target.
        if (g_currentColor.Equals(g_targetColor))
        {
            // Disable glow.
            b_isFading = false;
        }

        for (int i = 0; i < g_materials.Count; i++)
		{
            // Update materials with glow colour.
            g_materials[i].SetColor("_GlowColor", g_currentColor);
		}
	}

    public void FadeIn()
    {
        // Check if glow is already fading in.
        if (g_fadeState != FadeState.FADE_IN)
        {
            // Begin fade.
            b_isFading = true;
            g_fadeState = FadeState.FADE_IN;

            // Fade from current position.
            g_startColor = Color.black;
            g_targetColor = m_glowColor;
            g_currentFadeTime = m_timeToFade - g_currentFadeTime;
        }
    }

    public void FadeOut()
    {
        // Check if glow is already fading out.
        if (g_fadeState != FadeState.FADE_OUT)
        {
            // Begin fade.
            b_isFading = true;
            g_fadeState = FadeState.FADE_OUT;

            // Fade from current position.
            g_startColor = m_glowColor;
            g_targetColor = Color.black;
            g_currentFadeTime = m_timeToFade - g_currentFadeTime;
        }
    }
}
