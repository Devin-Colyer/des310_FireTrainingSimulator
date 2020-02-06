using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingRoomController : MonoBehaviour {

    // Used in another script
    bool m_RoomActive = false;
    
    public bool IsRoomActive()
    {
        return m_RoomActive;
    }
    private void OnTriggerEnter(Collider other)
    {
        // Debug
        Debug.Log("Collision Detected");

        // Check Tag
        if (other.tag == "Player" || other.tag == "RenderRoomCollider")
        {
            // Debug
            Debug.Log("Render The Room");
            // Active children on trigger
            m_RoomActive = true;
            for (int a = 0; a < this.transform.childCount; a++)
            {
                this.transform.GetChild(a).gameObject.SetActive(true);
            }
        }
        else
            return;
    }
    private void OnTriggerExit(Collider other)
    {
        // Debug
        Debug.Log("Stopped Colliding");

        // Check Tag
        if (other.tag == "Player" || other.tag == "RenderRoomCollider")
        {
            // Debug
            Debug.Log("Stop Rendering The Room");
            //Deavtivate children on trigger
            m_RoomActive = false;
            for (int a = 0; a < this.transform.childCount; a++)
            {
                this.transform.GetChild(a).gameObject.SetActive(false);
            }
        }
        else
            return;
    }
}
