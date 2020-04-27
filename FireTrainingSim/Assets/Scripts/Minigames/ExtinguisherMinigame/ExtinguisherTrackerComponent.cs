using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherTrackerComponent : MonoBehaviour {

    public ExtinguisherType m_extinguisherCarried { get; private set; }

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
        }
        else if (m_extinguisherCarried == ExtinguisherType.NONE && this.GetComponent<PlayerAnimationController>().m_HoldingExtiguisher)
        {
            this.GetComponent<PlayerAnimationController>().SetHoldingExtinguisher(false);
        }
    }

    public void SetExtinguisherType(ExtinguisherType in_type)
    {
        m_extinguisherCarried = in_type;
    }
}
