using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClickPickup : MonoBehaviour
{
    GameObject g_grabbedObject;
    Vector3 g_grabOffset;

	// Use this for initialization
	void Start ()
    {
        g_grabbedObject = null;
        g_grabOffset = Vector3.zero;
    }

    // Returns true if input object is currently grabbed.
    public bool IsGrabbedObject(GameObject gameObject)
    {
        if (gameObject == g_grabbedObject)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Check if mouse has been pressed.
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
                    Debug.Log("Hit Something " + l_hit.transform.name);

                    // Check if object can be grabbed.
                    if (l_hit.transform.tag == "MoveableObject")
                    {
                        // Store grabbed object.
                        g_grabbedObject = GameObject.Find(l_hit.collider.name);

                        // Disable gravity and lock rotation.
                        g_grabbedObject.GetComponent<Rigidbody>().useGravity = false;
                        g_grabbedObject.GetComponent<Rigidbody>().freezeRotation = true;

                        // Calculate offset between grab position and object position.
                        float l_distanceFromCamera = Camera.main.WorldToScreenPoint(g_grabbedObject.transform.position).z;
                        Vector3 l_mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, l_distanceFromCamera));
                        g_grabOffset = l_mouseWorldPosition - g_grabbedObject.transform.position;

                        // Debug, output object name.
                        Debug.Log("Object Hit: " + g_grabbedObject.name);
                    }
                }
            }
        }
    }

    private void FixedUpdate()
    {
        // Check if mouse button is held down.
        if (Input.GetMouseButton(0))
        {
            // Check if object has been grabbed.
            if (g_grabbedObject)
            {
                float l_distanceFromCamera = Camera.main.WorldToScreenPoint(g_grabbedObject.transform.position).z;
                Vector3 l_mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, l_distanceFromCamera));

                Vector3 l_direction;
                float l_distance;
                float l_maxDistance = 6.0f;

                // Calculate distance and direction.
                l_direction = l_mouseWorldPosition - g_grabbedObject.transform.position - g_grabOffset;
                l_distance = l_direction.magnitude;
                l_direction.Normalize();

                // Check if grabbed object has exceeded maximum distance from mouse.
                if (l_distance > l_maxDistance)
                {
                    // Release grabbed object.
                    DropGrabbedObject();
                }
                else
                {
                    float l_speed = l_distance / Time.deltaTime;
                    float l_maxSpeed = 32.0f;

                    // Clamp maximum movement speed.
                    if (l_speed >= l_maxSpeed)
                    {
                        l_speed = l_maxSpeed;
                    }

                    // Move object towards mouse.
                    g_grabbedObject.GetComponent<Rigidbody>().velocity = l_direction * l_speed;
                }
            }
        }
        else
        {
            // Release grabbed object.
            DropGrabbedObject();
        }
    }

    void DropGrabbedObject()
    {
        // Check if object has been grabbed.
        if (g_grabbedObject)
        {
            // Re-enable gravity and unlock rotation.
            g_grabbedObject.GetComponent<Rigidbody>().useGravity = true;
            g_grabbedObject.GetComponent<Rigidbody>().freezeRotation = false;

            // Release grabbed object.
            g_grabbedObject = null;
        }
    }
}
