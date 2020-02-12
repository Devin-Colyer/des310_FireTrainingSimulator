using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimationController : MonoBehaviour {

    private Animator m_PlayerAnimator;
    private NavMeshAgent m_NavMeshAgent;
    private bool temp_HoldingExtiguisher;

	// Use this for initialization
	void Start () {
        m_PlayerAnimator = this.GetComponent<Animator>();
        temp_HoldingExtiguisher = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        m_NavMeshAgent = GetComponent<NavMeshAgent>();
        if(Input.GetKeyDown(KeyCode.Space) && !temp_HoldingExtiguisher)
        {
            temp_HoldingExtiguisher = true;
            m_PlayerAnimator.SetBool("b_HoldingExtiguisher", true);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && temp_HoldingExtiguisher)
        {
            temp_HoldingExtiguisher = false;
            m_PlayerAnimator.SetBool("b_HoldingExtiguisher", false);
        }
        if (m_NavMeshAgent.velocity.magnitude == 0)
        {
            m_PlayerAnimator.SetInteger("i_Forward", 0);
        }
        else
        {
            m_PlayerAnimator.SetInteger("i_Forward", 1);
        }
    }
}
