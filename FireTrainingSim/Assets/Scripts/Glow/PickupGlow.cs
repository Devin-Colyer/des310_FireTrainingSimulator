using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGlow : MonoBehaviour
{
    BoxClickPickup g_objectGrabber;

    // Use this for initialization
    void Start()
    {
        g_objectGrabber = GameObject.Find("Object Grabber").GetComponent<BoxClickPickup>();
    }

    // Called each frame mouse is over object.
    private void OnMouseOver()
    {
        // Check if objecty is currently grabbed
        if (g_objectGrabber.IsGrabbedObject(this.gameObject))
        {
            // Object is grabbed, fade out glow.
            this.GetComponent<GlowComponent>().FadeOut();
        }
        else
        {
            // Object isn't grabbed, fade in glow.
            this.GetComponent<GlowComponent>().FadeIn();
        }
    }

    // Called once mouse leaves object.
    private void OnMouseExit()
    {
        // Fade out glow.
        this.GetComponent<GlowComponent>().FadeOut();
    }
}
