using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointAndClickPlayerController : MonoBehaviour {

    //ThirdPersonSounds m_Wwise;

    // NavMeshAgent - pathfinding AI
    NavMeshAgent m_Agent;

    // Use this for initialization
    void Start () {
        m_Agent = this.GetComponent<NavMeshAgent>();
        //m_Wwise = GetComponent<ThirdPersonSounds>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            // Setup Raycast
            RaycastHit l_Hit;
            Ray l_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Cast ray from the mouse
            if (Physics.Raycast(l_Ray, out l_Hit, 100))
            {
                // Set the pathfinding destination to where the ray hits
                m_Agent.destination = l_Hit.point;

                // Play walking sound
                //m_Wwise.WalkPlay();
            }
        }
    }
}
