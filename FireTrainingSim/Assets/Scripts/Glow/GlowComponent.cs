using UnityEngine;
using System.Collections.Generic;

public class GlowComponent : MonoBehaviour
{
    // Global variables.
    public Color g_glowColor;
	public float g_lerpFactor = 10;
    ///private BoxClickPickup g_objectGrabber;
    private List<Material> g_materials = new List<Material>();
    private Color g_currentColor;
    private Color g_targetColor;

    public Renderer[] g_renderers
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
        g_renderers = GetComponentsInChildren<Renderer>();

        // Recieve materials from renderer.
		foreach (Renderer renderer in g_renderers)
		{	
			g_materials.AddRange(renderer.materials);
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
		g_currentColor = Color.Lerp(g_currentColor, g_targetColor, Time.deltaTime * g_lerpFactor);

        // Check if current colour has reached target.
        if (g_currentColor.Equals(g_targetColor))
        {
            // Disable glow.
            enabled = false;
        }

        for (int i = 0; i < g_materials.Count; i++)
		{
            // Update materials with glow colour.
			g_materials[i].SetColor("_GlowColor", g_currentColor);
		}
	}

    public void FadeIn()
    {
        g_targetColor = g_glowColor;
        enabled = true;
    }

    public void FadeOut()
    {
        g_targetColor = Color.black;
        enabled = true;
    }
}
