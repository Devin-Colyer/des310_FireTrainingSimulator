using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClickPickup : MonoBehaviour
{
    GameObject m_GrabbedObject = null;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Create new ray in the direct of the mouse.
            Ray l_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit l_hit;

            // Cast ray towards mouse position.
            if (Physics.Raycast(l_ray, out l_hit))
            {
                if(l_hit.collider)
                {
                    // Debug, check if hit.
                    Debug.Log("Hit Something");

                    // Check if object can be grabbed.
                    if (l_hit.transform.tag == "MoveableObject")
                    {
                        // Store grabbed object.
                        m_GrabbedObject = GameObject.Find(l_hit.collider.name);

                        // Debug, output object name.
                        Debug.Log("Object Hit: " + m_GrabbedObject.name);
                    }
                }
            }

        }

        // Check if mouse button is held down.
        if (Input.GetMouseButton(0))
        {
            // Check if object has been grabbed.
            if (m_GrabbedObject)
            {
                float l_distanceFromCamera = Camera.main.WorldToScreenPoint(m_GrabbedObject.transform.position).z;
                Vector3 l_mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, l_distanceFromCamera));

                // Pull object towards mouse position.
                m_GrabbedObject.transform.position = l_mouseWorldPosition;
                m_GrabbedObject.GetComponent<Rigidbody>().isKinematic = true;

            }
        }
        else
        {
            // Check if object has been grabbed.
            if(m_GrabbedObject)
            {
                // Release grabbed object.
                m_GrabbedObject.GetComponent<Rigidbody>().isKinematic = false;
                m_GrabbedObject = null;
            }
        }
    }
}
