using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator m_PlayerAnimator;
    private NavMeshAgent m_NavMeshAgent;
    public bool m_HoldingExtiguisher { get; private set; }

    // Use this for initialization
    void Start()
    {
        m_PlayerAnimator = this.GetComponent<Animator>();
        m_HoldingExtiguisher = false;
    }

    // Update is called once per frame
    void Update()
    {
        m_NavMeshAgent = GetComponent<NavMeshAgent>();
        m_PlayerAnimator.SetBool("b_HoldingExtiguisher", m_HoldingExtiguisher);

        if (m_NavMeshAgent.velocity.magnitude == 0)
        {
            m_PlayerAnimator.SetInteger("i_Forward", 0);
        }
        else
        {
            m_PlayerAnimator.SetInteger("i_Forward", 1);
        }
    }

    public void SetHoldingExtinguisher(bool in_truefalse)
    {
        m_HoldingExtiguisher = in_truefalse;
    }
}
