using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingRooms : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
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
            for (int a = 0; a < this.transform.childCount; a++)
            {
                this.transform.GetChild(a).gameObject.SetActive(false);
            }
        }
        else
            return;
    }
}
