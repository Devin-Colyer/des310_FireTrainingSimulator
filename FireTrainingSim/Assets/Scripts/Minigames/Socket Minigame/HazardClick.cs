﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardClick : MonoBehaviour
{
    public GameObject m_worldHazard;
    public GameObject m_cameraController;

    private int m_numHazards;
    private int m_hazardsSolved;
    
    void Start()
    {
        m_numHazards = this.transform.childCount;
        m_hazardsSolved = 0;

        // Debug output.
        Debug.Log("Hazards solved: " + m_hazardsSolved + "/" + m_numHazards);
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
                            m_hazardsSolved++;

                            // Debug output.
                            Debug.Log("Hazards solved: " + m_hazardsSolved + "/" + m_numHazards);

                            // Check if all hazards have been solved.
                            if (m_hazardsSolved == m_numHazards)
                            {
                                if (m_worldHazard)
                                {
                                    // Disable world hazard.
                                    m_worldHazard.transform.Find("Broken").gameObject.SetActive(false);

                                    // Enable fixed hazard.
                                    m_worldHazard.transform.Find("Fixed").gameObject.SetActive(true);
                                    //Music
                                    MusicEmitter.m_musicEv.setParameterByName("Intro", 1);
                                    MusicEmitter.m_musicEv.setParameterByName("loop", 0);
                                    MusicEmitter.m_musicEv.setParameterByName("outro", 0);
                                    Debug.Log("MusicSwitch");
                                }

                                if (m_cameraController)
                                {
                                    // Change camera back to level camera.
                                    m_cameraController.GetComponent<CameraController>().ChangeCamera("Room Camera");
                                }

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
