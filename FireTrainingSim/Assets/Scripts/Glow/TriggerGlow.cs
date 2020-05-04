using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGlow : MonoBehaviour
{
    private void OnEnable()
    {
        this.transform.GetComponentInChildren<GlowComponent>().FadeOut();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if collider is the player.
        if (other.tag == "Player")
        {
            // Make sure object has a glow component.
            if (this.transform.GetComponentInChildren<GlowComponent>())
            {
                // Fade in glow when near hazard.
                this.transform.GetComponentInChildren<GlowComponent>().FadeIn();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if collider is the player.
        if (other.tag == "Player")
        {
            // Make sure object has a glow component.
            if (this.transform.GetComponentInChildren<GlowComponent>())
            {
                // Fade out glow when away from hazard.
                this.transform.GetComponentInChildren<GlowComponent>().FadeOut();
            }
        }
    }
}
