using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonSounds : MonoBehaviour {
    private NavMeshAgent m_NavMeshAgent;

    // Wwise event to trigger a footstep sound.
    public AK.Wwise.Event footstepSound = new AK.Wwise.Event();
    public AK.Wwise.Switch MusicSwitch= new AK.Wwise.Switch();

    // Wwise music, will be called on start
    public AK.Wwise.Event Music;
    private void Start()
    {
        Music.Post(gameObject);
    }




    // Called each time player animation timeline pass through "Footstep" event
    private void Footstep()
    {
        footstepSound.Post(gameObject);
        Debug.Log("step");
        //MusicSwitch.SetValue(gameObject);
    }


}
