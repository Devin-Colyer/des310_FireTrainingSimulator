using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardClick : MonoBehaviour
{
    private int g_numHazards;
    private int g_hazardsSolved;
    
    void Start()
    {
        g_numHazards = this.transform.childCount;
        g_hazardsSolved = 0;

        // Debug output.
        Debug.Log("Hazards solved: " + g_hazardsSolved + "/" + g_numHazards);
    }

    // Update is called once per frame
    void Update()
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
                if (l_hit.collider)
                {
                    if (l_hit.collider.transform.parent)
                    {
                        if (l_hit.collider.transform.parent.name == "Broken")
                        {
                            // Disable game object.
                            l_hit.collider.transform.parent.gameObject.SetActive(false);

                            // Enable fixed version.
                            Transform l_fixed = l_hit.collider.transform.parent.parent.Find("Fixed");
                            l_fixed.gameObject.SetActive(true);

                            // Increment hazards solved.
                            g_hazardsSolved++;

                            // Debug output.
                            Debug.Log("Hazards solved: " + g_hazardsSolved + "/" + g_numHazards);

                            // Check if all hazards have been solved.
                            if (g_hazardsSolved == g_numHazards)
                            {
                                // Debug output.
                                Debug.Log("All hazards have been solved");
                            }
                        }
                    }
                }
            }
        }
    }
}
