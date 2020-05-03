using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTriggerScript : MonoBehaviour
{
    private int m_colliderCount;

    // Use this for initialization
    void Start()
    {
        m_colliderCount = 0;
    }

    // Called when an object enters the trigger volume.
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent)
        {
            if (other.transform.parent.name == "Door Blockables")
            {
                // Increment collider count.
                m_colliderCount++;

                // Debug output.
                ///Debug.Log("An object is blocking the door.");
            }
        }
    }

    // Called when an object exits the trigger volume.
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.parent)
        {
            if (other.transform.parent.name == "Door Blockables")
            {
                // Decrease collider count.
                m_colliderCount--;
                
                if (m_colliderCount == 0)
                {
                    // Find overlay.
                    GameObject l_overlay = GameObject.Find("Overlay");

                    if (l_overlay)
                    {
                        // Render text display.
                        GameObject text = l_overlay.transform.Find("Game Complete Text").gameObject;
                        text.SetActive(true);
                    }

                    // Debug output.
                    Debug.Log("All object have been moved from the door.");
                }
                else
                {
                    // Debug output.
                   /// Debug.Log("An object have been moved from the door.");
                }
            }
        }
    }
}
