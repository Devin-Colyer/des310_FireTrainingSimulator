using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonSounds : MonoBehaviour {
    private NavMeshAgent m_NavMeshAgent;

    // Wwise event to trigger a footstep sound.
    public AK.Wwise.Event footstepSound = new AK.Wwise.Event();
 
	
	// Check if Player move to play footstep sound
	//void Update () {
 //       m_NavMeshAgent = GetComponent<NavMeshAgent>();

 //      if (m_NavMeshAgent.velocity.magnitude != 0)
 //       {
 //           //footstepSound.Post(gameObject);
 //           Debug.Log("bite");
 //       }




 //   }


    // Called each time player animation timeline pass through "Footstep" event
    private void Footstep()
    {
        footstepSound.Post(gameObject);
        Debug.Log("step");
    }


}
