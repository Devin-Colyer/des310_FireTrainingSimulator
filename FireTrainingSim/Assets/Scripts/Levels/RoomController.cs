using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RoomController : MonoBehaviour
{
    [System.Serializable]
    public struct ConnectedRooms
    {
        public GameObject m_room1;
        public GameObject m_room2;
    }

    public GameObject m_roomCamera;
    public GameObject m_currentRoom;
    public List<ConnectedRooms> m_roomConnections = new List<ConnectedRooms>();
    [Range(0, 1024)] public float m_transitionSpeed = 24.0f;

    private NavMeshSurface m_navMesh;
    private Vector3 m_cameraStart;
    private Vector3 m_cameraEnd;
    private float m_lerpTime;
    private float m_timeToLerp;

    // Use this for initialization
    void Start()
    {
        m_lerpTime = 1.0f;
        m_timeToLerp = 1.0f;

        m_cameraStart = m_roomCamera.transform.position;
        m_cameraEnd = m_cameraStart;

        m_navMesh = this.GetComponentInChildren<NavMeshSurface>();
        m_navMesh.BuildNavMesh();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if lerp has reached maximum.
        if (m_lerpTime < m_timeToLerp)
        {
            // Increment lerp time.
            m_lerpTime += Time.deltaTime;
        }
        else
        {
            // Clamp lerp time to maximum value.
            m_lerpTime = m_timeToLerp;
        }

        // Check time to lerp, avoid division by zero.
        if (m_timeToLerp != 0.0f)
        {
            // Lerp camera between current position and target position.
            m_roomCamera.transform.position = Vector3.Lerp(m_cameraStart, m_cameraEnd, m_lerpTime / m_timeToLerp);
        }
	}

    public void SetCurrentRoom(GameObject room)
    {
        if (room && room != m_currentRoom)
        {
            bool l_transitionPossible = false;
            foreach (ConnectedRooms l_rooms in m_roomConnections)
            {
                if ((l_rooms.m_room1 == room && l_rooms.m_room2 == m_currentRoom) || (l_rooms.m_room2 == room && l_rooms.m_room1 == m_currentRoom))
                {
                    l_transitionPossible = true;
                    break;
                }
            }

            if (l_transitionPossible)
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
                m_navMesh.BuildNavMesh();

                // Find camera destination for new room.
                Transform l_cameraDestination = room.transform.Find("Camera Location");

                // Check if camera destination was found.
                if (l_cameraDestination)
                {
                    // Update camera.
                    m_cameraStart = m_roomCamera.transform.position;
                    m_cameraEnd = l_cameraDestination.transform.position;

                    // Reset lerp time.
                    m_lerpTime = 0.0f;

                    // Calculate distance from start to end position.
                    float l_distance = Vector3.Distance(m_cameraStart, m_cameraEnd);

                    // Calculate time to lerp using distance and speed.
                    m_timeToLerp = l_distance / m_transitionSpeed;
                }
            }
        }
    }
}
