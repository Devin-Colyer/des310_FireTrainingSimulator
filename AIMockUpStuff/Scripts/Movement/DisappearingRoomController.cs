using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DisappearingRoomController : MonoBehaviour {

    // Used in another script
    bool m_RoomActive = false;
    // Used for player navigation
    public NavMeshSurface m_LevelNavMesh;
    // Used for AI
    public int m_RoomNumber;

    public bool IsRoomActive()
    {
        return m_RoomActive;
    }

    public int getRoomNumber()
    {
        return m_RoomNumber;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug
        Debug.Log("Collision Detected");

        // Check Tag
        if (other.tag == "Player")
        {
            // Debug
            Debug.Log("Render The Room");
            // Active children on trigger
            m_RoomActive = true;
            for (int a = 0; a < this.transform.childCount; a++)
            {
                //this.transform.GetChild(a).gameObject.SetActive(true);
                this.transform.GetChild(a).gameObject.GetComponent<MeshRenderer>().enabled = true;
            }
            m_LevelNavMesh.BuildNavMesh();
        }
        if (other.tag == "EvacAI")
        {
            other.GetComponent<AIPointAndClickMockUp>().SetCurrentRoomNumber(m_RoomNumber);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Debug
        Debug.Log("Stopped Colliding");

        // Check Tag
        if (other.tag == "Player")
        {
            // Debug
            Debug.Log("Stop Rendering The Room");
            //Deavtivate children on trigger
            m_RoomActive = false;
            for (int a = 0; a < this.transform.childCount; a++)
            {
                //this.transform.GetChild(a).gameObject.SetActive(false);
                this.transform.GetChild(a).gameObject.GetComponent<MeshRenderer>().enabled = false;
            }
        }
        else
            return;
    }
}
