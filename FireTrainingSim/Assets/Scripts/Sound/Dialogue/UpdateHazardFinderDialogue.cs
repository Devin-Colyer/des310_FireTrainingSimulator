using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHazardFinderDialogue : MonoBehaviour 
{


    public HazardFinder HazardFinderScript;
    public int NewValue;

    void Awake () {
        HazardFinder.HazardFinder_DialogueValue = NewValue;
        HazardFinder.HavePlayedDialogue = true;
	}

}
