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
    public int m_DialogueWrongExtinguisherValue = 3;
    public int m_DialogueRightExtinguisherValue = 4;
    public Dialogue m_DialogueScript;



    private MouseCursor l_mouseCursor;

    void Start()
    {
        // Find mouse cursor object.
        l_mouseCursor = FindObjectOfType<MouseCursor>();
    }


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

            // Create new ray in the direct of the mouse.
            Ray l_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit l_hit;

            // Cast ray towards mouse position.
            if (Physics.Raycast(l_ray, out l_hit))
            {
                if (l_hit.collider)
                {
                    // Debug output.
                    Debug.Log(l_hit.collider.name);
                    
                    // Check if object is hazard.
                    if (l_hit.collider.transform.IsChildOf(this.transform))
                    {
                        // Check if mouse cursor object was found.
                        if (l_mouseCursor)
                        {
                            // Set mouse state to 'clickable'.
                            l_mouseCursor.SetState(MouseCursor.State.CLICKABLE);
                        }

                        if (Input.GetMouseButtonDown(0))
                        {
                            // Check if this is a fire extinguishing minigame
                            if (m_isFireMinigame)
                            {
                                bool l_correctExtinguisher = false;
                                // Check if player has the right extinguisher for the fire
                                foreach (ExtinguisherType t in m_extinguishersForFire)
                                {
                                    if (other.GetComponent<ExtinguisherTrackerComponent>().m_extinguisherCarried == t)
                                    {
                                        // Change to minigame camera.
                                        m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
                                        l_correctExtinguisher = true;

                                        // VoiceOverPart
                                        Dialogue.m_FDialogueValue = m_DialogueRightExtinguisherValue;
                                        m_DialogueScript.PlayDialogue();
                                        Debug.Log(other.GetComponent<ExtinguisherTrackerComponent>().m_extinguisherCarried + "Success");
                                        //Music
                                        MusicEmitter.m_musicEv.setParameterByName("Intro", 0);
                                        MusicEmitter.m_musicEv.setParameterByName("loop", 1);
                                        MusicEmitter.m_musicEv.setParameterByName("outro", 0);
                                        Debug.Log("MusicSwitch");
                                    }
                                }

                                if (!l_correctExtinguisher)
                                {
                                    // VoiceOverPart
                                    Dialogue.m_FDialogueValue = m_DialogueWrongExtinguisherValue;
                                    m_DialogueScript.PlayDialogue();
                                    Debug.Log(other.GetComponent<ExtinguisherTrackerComponent>().m_extinguisherCarried + "Fail");
                                }
                            }
                            else
                            {
                                // Change to minigame camera.
                                m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
                                //Music
                                MusicEmitter.m_musicEv.setParameterByName("Intro", 0);
                                MusicEmitter.m_musicEv.setParameterByName("loop", 1);
                                MusicEmitter.m_musicEv.setParameterByName("outro", 0);
                                Debug.Log("MusicSwitch");
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
