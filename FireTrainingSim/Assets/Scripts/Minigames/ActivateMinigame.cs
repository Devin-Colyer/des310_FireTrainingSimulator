using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour
{
    public GameObject m_cameraController;
    public string m_minigame;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            // Make sure object has a glow component.
            if (this.transform.parent.GetComponentInChildren<GlowComponent>())
            {
                // Fade in glow when near hazard.
                this.transform.parent.GetComponentInChildren<GlowComponent>().FadeIn();
            }
            if(Input.GetKeyDown("e"))
            {
                m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Make sure object has a glow component.
        if (this.transform.parent.GetComponentInChildren<GlowComponent>())
        {
            // Fade out glow when away from hazard.
            this.transform.parent.GetComponentInChildren<GlowComponent>().FadeOut();
        }
    }
}
