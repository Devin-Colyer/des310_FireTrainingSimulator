using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHazardFinderDialogue : MonoBehaviour 
{


    public HazardFinder m_HazardFinderScript;
    public int m_NewValue;

    void Awake () {
        HazardFinder.m_HazardFinderDialogueValue = m_NewValue;
        HazardFinder.m_HavePlayedDialogue = true;
	}

}
