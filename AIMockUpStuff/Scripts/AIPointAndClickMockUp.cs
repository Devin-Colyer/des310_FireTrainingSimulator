using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPointAndClickMockUp : MonoBehaviour
{

    // Public Objects so the script is customizable
    public GameObject[] m_RoomsInLevel;
    // NavMeshAgent - pathfinding AI
    private NavMeshAgent m_Agent;
    private int currentRoom;
    List<DisappearingRoomController> m_RoomScripts = new List<DisappearingRoomController>();

    // Use this for initialization
    void Start()
    {
        m_Agent = this.GetComponent<NavMeshAgent>();

        // Access the scripts which contain info on if the rooms are active or not
        foreach (GameObject l_CurrentRoom in m_RoomsInLevel)
        {
            m_RoomScripts.Add(l_CurrentRoom.GetComponent<DisappearingRoomController>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            // Setup Raycast
            RaycastHit l_Hit;
            Ray l_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Cast ray from the mouse
            if (Physics.Raycast(l_Ray, out l_Hit, 100))
            {
                // Set the pathfinding destination to where the ray hits
                m_Agent.destination = l_Hit.point;
            }
        }
        
        foreach(DisappearingRoomController l_RoomController in m_RoomScripts)
        {
            if(l_RoomController.getRoomNumber() == currentRoom)
            {
                if(l_RoomController.IsRoomActive() == false)
                {
                    gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
                }
                else
                {
                    gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;
                }
            }
        }
    }

    public void SetCurrentRoomNumber(int in_RoomNumber)
    {
        currentRoom = in_RoomNumber;
    }
}