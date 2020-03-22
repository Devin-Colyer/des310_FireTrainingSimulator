using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherMinigameController : MonoBehaviour {

    public GameObject[] m_ListOfFires;
    public GameObject m_FireExtinguisherWorldMatrixTransform;

    public float sprayRadius = 5; //temp

    Vector3 m_MousePosition;
    Camera m_MinigameCamera;
    ParticleSystem m_ParticleSystem;

    private Vector3 m_PreviousPosition = new Vector3(0f, 0f, 0f);
    // Use these for initialization
    void Start()
    {
        m_MinigameCamera = Camera.main;

        m_ParticleSystem = m_FireExtinguisherWorldMatrixTransform.GetComponentInChildren<ParticleSystem>();
    }
    void OnEnable ()
    {
        m_MinigameCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        m_MousePosition = Input.mousePosition;

        // Setup Raycast
        RaycastHit l_Hit;
        Ray l_Ray = m_MinigameCamera.ScreenPointToRay(m_MousePosition);

        // Cast ray from the mouse
        Physics.Raycast(l_Ray, out l_Hit, 100);
        MoveExtiguisher(l_Hit);

        ShootExtinguisher(l_Hit);
    }

    void MoveExtiguisher(RaycastHit in_hit)
    {
        
        if (m_PreviousPosition != m_MousePosition)
        {
            m_PreviousPosition = m_MousePosition;

            //Calculate direction and rotate
            Vector3 l_NewExtinguisherDirection = in_hit.point - m_FireExtinguisherWorldMatrixTransform.transform.position;
            m_FireExtinguisherWorldMatrixTransform.transform.forward = l_NewExtinguisherDirection;
        }

    }

    void ShootExtinguisher(RaycastHit in_hit)
    {
        if (Input.GetMouseButton(0))
        {
            m_ParticleSystem.Play();

            foreach (GameObject l_fire in m_ListOfFires)
            {
                if(Vector3.Distance(l_fire.transform.position, in_hit.point) <= sprayRadius)
                {
                    l_fire.GetComponent<FireObjective>().ExtinguishByPercentage(1f);
                }
            }
        }
        else if (!Input.GetMouseButton(0))
        {
            m_ParticleSystem.Stop();
        }
    }
}
