using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointAndClickPlayerController : MonoBehaviour {

    // Camera set in editor
    public Camera m_camera;
    NavMeshAgent m_Agent;

    // Use this for initialization
    void Start () {
        m_Agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            // Setup Raycast
            RaycastHit l_Hit;
            Ray l_Ray = m_camera.ScreenPointToRay(Input.mousePosition);

            // Cast ray from the mouse
            if (Physics.Raycast(l_Ray, out l_Hit, 100))
            {
                // Set the pathfinding destination to where the ray hits
                m_Agent.destination = l_Hit.point;
            }
        }
    }
}
