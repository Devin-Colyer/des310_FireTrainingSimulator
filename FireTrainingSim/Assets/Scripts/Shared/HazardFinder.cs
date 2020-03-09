using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardFinder : MonoBehaviour
{
    public GameObject m_player;
    public GameObject m_hazardPopup;
    public GameObject m_levelExit;
    public GameObject[] m_hazards;
    [Range(0, 100)] public float m_maxDistance = 10;
	
	// Update is called once per frame
	void Update ()
    {
        // Get hazards from scene.
        //GameObject[] l_hazards = GameObject.FindGameObjectsWithTag("Hazard");

       // m_level.transform.find

        if (m_hazards.Length <= 0)
        {
            // Safety check, makes sure there are hazards in the scene.
            m_hazardPopup.GetComponent<TextMesh>().text = "";
            return;
        }

        // Initialise min distance, default to maximum range.
        float l_minDistance = m_maxDistance;
        
        int l_numHazards = 0;

        foreach (GameObject hazard in m_hazards)
        {
            if (hazard.transform.Find("Broken").gameObject.activeSelf)
            {
                // Increment number of hazards.
                l_numHazards++;

                // Calculate distance to player.
                float l_distance = Vector3.Distance(hazard.transform.position, m_player.transform.position);

                // Check if hazard is closer than current closest hazard.
                if (l_distance < l_minDistance)
                {
                    // Update min distance and closest hazard.
                    l_minDistance = l_distance;
                }
            }
        }

        // Debug output.
        ///Debug.Log(l_numHazards + "/" + m_hazards.Length);

        if (l_numHazards == 0)
        {
            // All hazards have been dealt with.
            m_hazardPopup.GetComponent<TextMesh>().text = "";
            
            if (m_levelExit)
            {
                // Open level exit.
                m_levelExit.transform.Find("Open").gameObject.SetActive(true);
                m_levelExit.transform.Find("Closed").gameObject.SetActive(false);
            }
        }
        else
        {
            // Calculate percentage distance from hazard.
            float l_percentageDistance = (l_minDistance / m_maxDistance) * 100.0f;

            // Update hazard popup using closest hazard.
            if (l_percentageDistance < 33)
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "!!!";
            }
            else if (l_percentageDistance < 66)
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "!!";
            }
            else if (l_percentageDistance < 99)
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "!";
            }
            else
            {
                m_hazardPopup.GetComponent<TextMesh>().text = "";
            }
        }
    }
}
