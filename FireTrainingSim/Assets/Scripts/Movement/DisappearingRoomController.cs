using System;
using UnityEngine;
using UnityEngine.AI;

[Obsolete("Check if I need deleted.")]
public class DisappearingRoomController : MonoBehaviour {

    // Used in another script
    bool m_RoomActive = false;
    // Used for player navigation
    public NavMeshSurface m_LevelNavMesh;

    public bool IsRoomActive()
    {
        return m_RoomActive;
    }
    private void OnTriggerEnter(Collider other)
    {
        // Debug
        //Debug.Log("Collision Detected");

        // Check Tag
        if (other.tag == "Player")
        {
            // Debug
            //Debug.Log("Render The Room");
            // Active children on trigger
            m_RoomActive = true;
            for (int a = 0; a < this.transform.childCount; a++)
            {
                this.transform.GetChild(a).gameObject.SetActive(true);
            }
            m_LevelNavMesh.BuildNavMesh();
        }
        else
            return;
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
                this.transform.GetChild(a).gameObject.SetActive(false);
            }
        }
        else
            return;
    }
}
