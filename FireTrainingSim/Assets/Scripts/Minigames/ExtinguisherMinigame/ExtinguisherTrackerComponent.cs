using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherTrackerComponent : MonoBehaviour {

    public ExtinguisherType m_extinguisherCarried { get; private set; }

    //For Dialogue Usage //not needed
    //public static bool m_IsHoldingExtinguisher = false;

    private void Start()
    {
        m_extinguisherCarried = ExtinguisherType.NONE;
    }

    // Update is called once per frame
    void Update ()
    {
		if(m_extinguisherCarried!= ExtinguisherType.NONE && !this.GetComponent<PlayerAnimationController>().m_HoldingExtiguisher)
        {
            this.GetComponent<PlayerAnimationController>().SetHoldingExtinguisher(true);
            Debug.Log(m_extinguisherCarried);

            //For Dialogue Usage // not needed if m_extinguisherCarried != ExtinguisherType.NONE, player is holding extinguisher
            //m_IsHoldingExtinguisher = true;
        }
        else if (m_extinguisherCarried == ExtinguisherType.NONE && this.GetComponent<PlayerAnimationController>().m_HoldingExtiguisher)
        {
            this.GetComponent<PlayerAnimationController>().SetHoldingExtinguisher(false);
            Debug.Log(m_extinguisherCarried);

            //For Dialogue Usage // not needed if m_extinguisherCarried == ExtinguisherType.NONE, player isn't holding extinguisher
            //m_IsHoldingExtinguisher = false;
        }
    }

    public void SetExtinguisherType(ExtinguisherType in_type)
    {
        m_extinguisherCarried = in_type;
    }
}
