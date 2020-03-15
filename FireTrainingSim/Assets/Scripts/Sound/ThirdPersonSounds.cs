using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonSounds : MonoBehaviour {
    private NavMeshAgent m_NavMeshAgent;

    // FMOD event to trigger a footstep sound.

    [FMODUnity.EventRef]
    public string FootStepsSound;

    private void Start()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FootStepsSound);
    }


    // Called each time player animation timeline pass through "Footstep" event
    private void Footstep()
    {
        FMODUnity.RuntimeManager.PlayOneShot(FootStepsSound);
        Debug.Log("step");
    }


}
