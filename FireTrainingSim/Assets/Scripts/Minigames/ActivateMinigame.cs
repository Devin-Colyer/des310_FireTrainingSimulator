using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour
{
    public GameObject m_cameraController;
    public string m_minigame;
    public bool m_isFireMinigame = false;
    [Tooltip("Leave empty if not a fire extinguishing minigame.")]
    public ExtinguisherType[] m_extinguishersForFire;

    // VoiceOverPart
    public int DialogueWrongExtinguisherValue = 3;
    public int DialogueRightExtinguisherValue = 4;
    public Dialogue DialogueScript;


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
                        ///Debug.Log(l_hit.collider.transform.parent.name);

                        // Check if object is hazard.
                        if (l_hit.collider.transform.IsChildOf(this.transform))
                        {
                            // Check if this is a fire extinguishing minigame
                            if (m_isFireMinigame)
                            {
                                // Check if player has the right extinguisher for the fire
                                foreach(ExtinguisherType t in m_extinguishersForFire)
                                {
                                    if(other.GetComponent<ExtinguisherTrackerComponent>().m_extinguisherCarried == t)
                                    {
                                        // Change to minigame camera.
                                        m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
                                        
                                        // VoiceOverPart
                                        Dialogue.F_DialogueValue = DialogueRightExtinguisherValue;
                                        DialogueScript.PlayDialogue();
                                        Debug.Log(other.GetComponent<ExtinguisherTrackerComponent>().m_extinguisherCarried + "Success");
                                    }
                                    else
                                    {
                                        if (ExtinguisherTrackerComponent.IsHoldingExtinguisher)
                                        {
                                            // VoiceOverPart
                                            Dialogue.F_DialogueValue = DialogueWrongExtinguisherValue;
                                            DialogueScript.PlayDialogue();
                                            Debug.Log(other.GetComponent<ExtinguisherTrackerComponent>().m_extinguisherCarried + "Success");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // Change to minigame camera.
                                m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
                            }
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
