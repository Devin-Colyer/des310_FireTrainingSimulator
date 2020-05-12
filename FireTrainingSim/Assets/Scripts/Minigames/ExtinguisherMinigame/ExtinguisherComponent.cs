using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ExtinguisherType
{
    NONE, WATER, FOAM, DRY_POWDER, CO2, WET_CHEMICAL
}

public class ExtinguisherComponent : MonoBehaviour
{
    public ExtinguisherType m_extinguisherType = ExtinguisherType.NONE;
    private MouseCursor l_mouseCursor;

    // VoiceOverPart
    public int m_DialogueValue = 1;
    public Dialogue m_DialogueScript;

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
            // Create new ray in the direct of the mouse.
            Ray l_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit l_hit;

            // Cast ray towards mouse position.
            if (Physics.Raycast(l_ray, out l_hit))
            {
                // Check if collider exists.
                if (l_hit.collider)
                {
                    // Check if collider was a child of this extinguisher.
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
                            // Debug output.
                            Debug.Log(m_extinguisherType);

                            // Check if extinguisher object has a parent that has a parent.
                            if (this.transform.parent.parent)
                            {
                                // Check if the parent is called 'Extinguishers'.
                                if (this.transform.parent.parent.name == "Extinguishers")
                                {
                                    // Enable world model for all extinguishers under parent object.
                                    foreach (Transform child in this.transform.parent.transform)
                                    {
                                        child.gameObject.SetActive(true);
                                    }

                                    // Disable world model for this extinguisher.
                                    this.gameObject.SetActive(false);

                                    // Update player, use fire extinguisher.
                                    other.GetComponent<ExtinguisherTrackerComponent>().SetExtinguisherType(m_extinguisherType);

                                    // VoiceOverPart
                                    Dialogue.m_FDialogueValue = m_DialogueValue;
                                    if (m_DialogueScript)
                                    {
                                        m_DialogueScript.PlayDialogue();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}