using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherMinigameController : MonoBehaviour {

    public GameObject m_ListOfFires;
    public GameObject m_FireExtinguisherWorldMatrixTransform;

    Camera m_MinigameCamera;

    private Vector3 m_PreviousPosition = new Vector3(0f, 0f, 0f);
	// Use this for initialization
	void OnEnable () {
        m_MinigameCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        MoveExtiguisher();

        ShootExtinguisher();
    }

    void MoveExtiguisher()
    {
        
        if (m_PreviousPosition != Input.mousePosition)
        {
            m_PreviousPosition = Input.mousePosition;
            
            // Setup Raycast
            RaycastHit l_Hit;
            Ray l_Ray = Camera.main.ScreenPointToRay(m_PreviousPosition);

            // Cast ray from the mouse
            Physics.Raycast(l_Ray, out l_Hit, 100);

            //Calculate direction and rotate
            Vector3 l_NewExtinguisherDirection = m_PreviousPosition - m_FireExtinguisherWorldMatrixTransform.transform.position;
            m_FireExtinguisherWorldMatrixTransform.transform.forward = l_NewExtinguisherDirection;
        }

    }
    void ShootExtinguisher()
    {

    }
}
