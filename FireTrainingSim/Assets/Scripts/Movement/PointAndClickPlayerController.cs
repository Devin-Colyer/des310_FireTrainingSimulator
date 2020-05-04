using UnityEngine;
using UnityEngine.AI;

public class PointAndClickPlayerController : MonoBehaviour
{
    NavMeshAgent m_Agent;

    // Use this for initialization
    void Start ()
    {
        m_Agent = this.GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            // Setup Raycast
            RaycastHit l_Hit;
            Ray l_Ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Cast ray from the mouse
            if (Physics.Raycast(l_Ray, out l_Hit, 100))
            {
                // Check if collider exists.
                if (l_Hit.collider)
                {
                    PointAndClickTrigger l_clickTrigger;

                    // Check if collider is a click trigger.
                    if (l_clickTrigger = l_Hit.collider.GetComponent<PointAndClickTrigger>())
                    {
                        // Move to trigger destination.
                        m_Agent.destination = l_clickTrigger.GetDestination();
                    }
                    else
                    {
                        NavMeshHit l_navMeshHit;

                        if (NavMesh.SamplePosition(l_Hit.point, out l_navMeshHit, 1.0f, NavMesh.AllAreas))
                        {
                            // Set agent destination to closest location on the navmesh.
                            m_Agent.destination = l_navMeshHit.position;
                        }
                    }
                }
            }
        }
    }
}
