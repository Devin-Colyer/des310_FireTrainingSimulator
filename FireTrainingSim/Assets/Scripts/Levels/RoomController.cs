using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RoomController : MonoBehaviour
{
    public GameObject m_roomCamera;
    public GameObject m_currentRoom;
    [Range(0, 1024)] public float m_transitionSpeed = 24.0f;

    private NavMeshSurface g_navMesh;
    private Vector3 g_cameraStart;
    private Vector3 g_cameraEnd;
    private float g_lerpTime;
    private float g_timeToLerp;

    // Use this for initialization
    void Start ()
    {
        g_lerpTime = 1.0f;
        g_timeToLerp = 1.0f;

        g_cameraStart = m_roomCamera.transform.position;
        g_cameraEnd = g_cameraStart;

        g_navMesh = this.GetComponentInChildren<NavMeshSurface>();
        g_navMesh.BuildNavMesh();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if lerp has reached maximum.
        if (g_lerpTime < g_timeToLerp)
        {
            // Increment lerp time.
            g_lerpTime += Time.deltaTime;
        }
        else
        {
            // Clamp lerp time to maximum value.
            g_lerpTime = g_timeToLerp;
        }

        // Check time to lerp, avoid division by zero.
        if (g_timeToLerp != 0.0f)
        {
            // Lerp camera between current position and target position.
            m_roomCamera.transform.position = Vector3.Lerp(g_cameraStart, g_cameraEnd, g_lerpTime / g_timeToLerp);
        }
	}

    public void SetCurrentRoom(GameObject room)
    {
        if (room && room != m_currentRoom)
        {
            // Check if current room exists
            if (m_currentRoom)
            {
                // Disable current room.
                foreach (Transform child in m_currentRoom.transform)
                {
                    child.gameObject.SetActive(false);
                }
            }

            // Set current room to new room
            m_currentRoom = room;

            // Enable new room.
            foreach (Transform child in m_currentRoom.transform)
            {
                child.gameObject.SetActive(true);
            }

            // Rebuild navmesh for new room.
            g_navMesh.BuildNavMesh();

            // Find camera destination for new room.
            Transform l_cameraDestination = room.transform.Find("Camera Location");

            // Check if camera destination was found.
            if (l_cameraDestination)
            {
                // Update camera.
                g_cameraStart = m_roomCamera.transform.position;
                g_cameraEnd = l_cameraDestination.transform.position;

                // Reset lerp time.
                g_lerpTime = 0.0f;

                // Calculate distance from start to end position.
                float l_distance = Vector3.Distance(g_cameraStart, g_cameraEnd);

                // Calculate time to lerp using distance and speed.
                g_timeToLerp = l_distance / m_transitionSpeed;
            }
        }
    }
}
