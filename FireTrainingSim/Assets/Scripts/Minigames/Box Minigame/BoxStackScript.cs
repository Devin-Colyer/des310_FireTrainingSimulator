using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxStackScript : MonoBehaviour
{
    public GameObject m_worldHazard;
    public GameObject m_cameraController;
    private ArrayList g_colliderObjects;
    private int g_numBlockers;

    // Use this for initialization
    void Start ()
    {
        g_colliderObjects = new ArrayList();

        GameObject l_doorBlockers = GameObject.Find("Door Blockables");

        if (l_doorBlockers)
        {
            g_numBlockers = l_doorBlockers.transform.childCount;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Check if collider has a parent object.
        if (other.transform.parent)
        {
            // Check if object is a door blocker.
            if (other.transform.parent.name == "Door Blockables")
            {
                // Check if object is already collided.
                if (!g_colliderObjects.Contains(other.gameObject))
                {
                    BoxClickPickup l_objectGrabber = GameObject.Find("Object Grabber").GetComponent<BoxClickPickup>();

                    // Check if object is grabbed.
                    if (!l_objectGrabber.IsGrabbedObject(other.gameObject))
                    {
                        // Add object to collection.
                        g_colliderObjects.Add(other.gameObject);

                        // Debug output.
                        ///Debug.Log("An object has been moved to the table.");

                        // Check if all boxes have been moved into the trigger zone.
                        if (g_colliderObjects.Count == g_numBlockers)
                        {
                            // Find overlay.
                            /*GameObject l_overlay = GameObject.Find("Overlay");

                            if (l_overlay)
                            {
                                // Render text to display.
                                GameObject text = l_overlay.transform.Find("Game Complete Text").gameObject;
                                text.SetActive(true);
                            }*/
                            
                            if (m_worldHazard)
                            {
                                // Disable world hazard.
                                m_worldHazard.transform.Find("Broken").gameObject.SetActive(false);

                                // Enable fixed hazard.
                                m_worldHazard.transform.Find("Fixed").gameObject.SetActive(true);
                            }

                            if (m_cameraController)
                            {
                                // Disable world hazard.
                                m_cameraController.GetComponent<CameraController>().ChangeCamera("Room Camera");
                            }

                            // Debug output.
                            ///Debug.Log("All objects have been moved to the table.");
                        }
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Remove object from collection.
        g_colliderObjects.Remove(other.gameObject);
    }
}
