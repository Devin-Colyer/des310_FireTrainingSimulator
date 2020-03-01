using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAreaTrigger : MonoBehaviour
{
    void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player")
        {
            // Check if player center is inside this room.
            if (this.GetComponent<BoxCollider>().bounds.Contains(collider.bounds.center))
            {
                // Get room controller.
                RoomController l_roomController = GetComponentInParent<RoomController>();

                if (l_roomController)
                {
                    // Update current room in room controller.
                    l_roomController.SetCurrentRoom(this.gameObject);
                }
            }
        }
    }

    /*void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            // Enable children of room on enter.
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            // Disable children of room on enter.
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }*/
}
