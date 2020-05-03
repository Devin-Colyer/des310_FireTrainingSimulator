using UnityEngine;
using System.Collections.Generic;

public class GlowComponent : MonoBehaviour
{
    // Global variables.
    public Color m_glowColor;
	public float m_lerpFactor = 10;
    ///private BoxClickPickup g_objectGrabber;
    private List<Material> m_materials = new List<Material>();
    private Color m_currentColor;
    private Color m_targetColor;

    public Renderer[] m_renderers
    {
		get;
		private set;
	}

    // Use this for initialization
    void Start()
	{
        // Get object grabber.
        ///g_objectGrabber = GameObject.Find("Object Grabber").GetComponent<BoxClickPickup>();

        // Get renderer.
        m_renderers = GetComponentsInChildren<Renderer>();

        // Recieve materials from renderer.
		foreach (Renderer renderer in m_renderers)
		{
            m_materials.AddRange(renderer.materials);
		}
	}

    /*private void OnMouseOver()
    {
        // Make sure object isn't grabbed.
        if (!g_objectGrabber.IsGrabbedObject(this.gameObject))
        {
            // Enable glow.
            g_targetColor = g_glowColor;
            enabled = true;
        }
    }

    private void OnMouseExit()
	{
        // Disable glow.
		g_targetColor = Color.black;
		enabled = true;
	}*/
    
	private void Update()
	{
        // Check if object is grabbed.
        /* if (g_objectGrabber.IsGrabbedObject(this.gameObject))
         {
             // Disable glow.
             g_targetColor = Color.black;
             g_currentColor = g_targetColor;
             enabled = false;
         }*/

        // Interpolate glow from current to target.
        m_currentColor = Color.Lerp(m_currentColor, m_targetColor, Time.deltaTime * m_lerpFactor);

        // Check if current colour has reached target.
        if (m_currentColor.Equals(m_targetColor))
        {
            // Disable glow.
            enabled = false;
        }

        for (int i = 0; i < m_materials.Count; i++)
		{
            // Update materials with glow colour.
            m_materials[i].SetColor("_GlowColor", m_currentColor);
		}
	}

    public void FadeIn()
    {
        m_targetColor = m_glowColor;
        enabled = true;
    }

    public void FadeOut()
    {
        m_targetColor = Color.black;
        enabled = true;
    }
}
