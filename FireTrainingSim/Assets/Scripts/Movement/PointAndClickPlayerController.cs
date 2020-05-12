using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class PointAndClickPlayerController : MonoBehaviour
{
    NavMeshAgent m_Agent;
    List<GameObject> g_markers = new List<GameObject>();

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
                    PointAndClickTrigger l_clickTrigger = l_Hit.collider.GetComponent<PointAndClickTrigger>();

                    // Check if collider is a click trigger.
                    if (l_clickTrigger)
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

    // Fixed update, called at specific intervals.
    void FixedUpdate()
    {
        // Update path markers.
        UpdatePathMarkers();
    }

    // Call to update visible path markers. Creates markers at even intervals across the player agent's path.
    private void UpdatePathMarkers()
    {
        // Destroy path markers from previous frame.
        foreach (GameObject marker in g_markers)
        {
            Destroy(marker);
        }

        // Clear all references from marker list.
        g_markers.Clear();

        // Check if agent has a path.
        if (m_Agent.hasPath)
        {
            // Get corner vectors from agent path. Reverse array, giving corners beginning from destination.
            Vector3[] l_corners = m_Agent.path.corners;
            System.Array.Reverse(l_corners);

            float l_markerDistance = 1.0f;
            float l_remainderDistance = 0.0f;

            // Loop through each corner in the path.
            for (int i = 0; i < l_corners.Length - 1; i++)
            {
                // Calculate direction and distance between two corners.
                Vector3 l_direction = l_corners[i + 1] - l_corners[i];
                float l_distance = l_direction.magnitude - l_remainderDistance;
                l_direction.Normalize();

                // Calculate number of markers to place along corner.
                float l_numDivisions = l_distance / l_markerDistance;

                // Loop for number of markers, rounding down.
                for (int j = 0; j <= (int)l_numDivisions; j++)
                {
                    // Create marker object at a intervals along between the corners.
                    GameObject l_marker = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    l_marker.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                    l_marker.transform.position = l_corners[i] + (l_direction * l_markerDistance * j) + (l_remainderDistance * l_direction);

                    // Add markers to markers list, these will be destroyed next frame.
                    g_markers.Add(l_marker);
                }

                // Calculate remainer from current interval, this will be added to the next corner.
                l_remainderDistance = (1.0f - (l_numDivisions % 1)) * l_markerDistance;
            }
        }
    }
}
