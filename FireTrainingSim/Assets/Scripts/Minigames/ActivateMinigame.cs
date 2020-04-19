using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour
{
    public GameObject m_cameraController;
    public string m_minigame;

    private void OnTriggerStay(Collider other)
    {
        // Check if collider is the player.
        if (other.tag == "Player")
        {
            // Make sure object has a glow component.
            if (this.transform.parent.GetComponentInChildren<GlowComponent>())
            {
                // Fade in glow when near hazard.
                this.transform.parent.GetComponentInChildren<GlowComponent>().FadeIn();
            }

            if(Input.GetMouseButtonDown(0))
            {
                // Create new ray in the direct of the mouse.
                Ray l_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit l_hit;

                // Cast ray towards mouse position.
                if (Physics.Raycast(l_ray, out l_hit, 128))
                {
                    if (l_hit.collider)
                    {
                        // Debug output.
                        Debug.Log(l_hit.collider.transform.parent.name);
                        
                        // Check if object is hazard.
                        if (l_hit.collider.transform.IsChildOf(this.transform))
                        {
                            // Change to minigame camera.
                            m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
                        }
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if collider is the player.
        if (other.tag == "Player")
        {
            // Make sure object has a glow component.
            if (this.transform.parent.GetComponentInChildren<GlowComponent>())
            {
                // Fade out glow when away from hazard.
                this.transform.parent.GetComponentInChildren<GlowComponent>().FadeOut();
            }
        }
    }
}
