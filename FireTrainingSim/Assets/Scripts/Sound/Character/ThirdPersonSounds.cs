using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonSounds : MonoBehaviour {

    [Header("FMOD Settings")]

    [SerializeField] [FMODUnity.EventRef] private string DialogueEventPath;
    public int F_DialogueValue;
    [SerializeField] [FMODUnity.EventRef] private string NumbersEventPath;
    public int F_NumbersValue;

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string FootstepsEventPath;
    [SerializeField] private string Material;
    public string[] MaterialTypes;
    //[SerializeField] private float RayDistance = 1.2f;
    public int DefaultMaterialValue;                           // This will be told by the 'FMODStudioFootstepsEditor' script which Material has been set as the defualt. It will then store the value of that Material for outhis script to use. This cannot be changed in the Editor, but a drop down menu created by the 'FMODStudioFootstepsEditor' script can.

    public static FMOD.Studio.EventInstance ThirdPersonSound;
    public static FMOD.Studio.EventInstance Numbers;

    private RaycastHit hit;
    public static int F_MaterialValue;

    //DONTPLAY = Dont need to play anything after      PLAYNUMBER = Need to play a "Number"     PLAYDIFFERENT = Need to play an other "Dialogue" to finish the senctence
    private int CheckNumber = 0;
    public enum DialogueStateControl
    {
        DONTPLAY,
        PLAYNUMBER,
        PLAYDIFFERENT
    }

    public int[] DialogueWhoNeedToPlayNunmber = new int[10];



    //Use to play the initial dialogue
    void Start()
    {
        ThirdPersonSound = FMODUnity.RuntimeManager.CreateInstance(DialogueEventPath);
        ThirdPersonSound.setParameterByName("Dialogue", F_DialogueValue);
        ThirdPersonSound.start();



        //Used to optimise the code, so the Update doesnt have to always run unuseful code
        // The values are the Dialogue FMOD values who need the next one to be played straight after

        //Here is when we need a NUMBER
        foreach (int itr in DialogueWhoNeedToPlayNunmber)
        {
            if (F_DialogueValue == itr)
            {
                Debug.Log("Success");
                DialogueStateControl _DialogueStateControl = DialogueStateControl.PLAYNUMBER;
                if (_DialogueStateControl == DialogueStateControl.PLAYNUMBER)
                {
                    
                }
            }
        }


        if (F_DialogueValue == 300 || F_DialogueValue == 360)
        {
            CheckNumber = 1;
        }

        //Here is when we need a Dialogue
        if (F_DialogueValue == 300 || F_DialogueValue == 360)
        {
            CheckNumber = 2;
        }

    }



    //void Update()
    //{
    //    if (DialogueStateControl == DialogueStateControl.PLAYNUMBER)
    //    {
    //        FMOD.Studio.PLAYBACK_STATE playbackState;
    //        ThirdPersonSound.getPlaybackState(out playbackState);
    //        if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
    //        {
    //            ThirdPersonSound.release();
    //            ThirdPersonSound.clearHandle();
    //            Debug.Log("PlayerIntroFinished");
    //            CheckNumber = 0;
    //            SpeakedNumber();
    //        }
    //    }
    //    else if (CheckNumber == 2)
    //    {
    //        FMOD.Studio.PLAYBACK_STATE playbackState;
    //        Numbers.getPlaybackState(out playbackState);
    //        if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
    //        {
    //            Start();
    //            CheckNumber = 0;
    //        }
    //    }
    //}
    


    void SpeakedNumber()
    {
        Numbers = FMODUnity.RuntimeManager.CreateInstance(NumbersEventPath);
        Numbers.setParameterByName("Numbers", F_NumbersValue);
        Numbers.start();
        F_DialogueValue++;
        CheckNumber = 2;
    }



    private void Footstep()
    {
        //MaterialCheck();
        FMOD.Studio.EventInstance Footsteps = FMODUnity.RuntimeManager.CreateInstance(FootstepsEventPath);        // If they are, we create an FMOD event instance. We use the event path inside the 'FootstepsEventPath' variable to find the event we want to play.
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Footsteps, transform, GetComponent<Rigidbody>());     // Next that event instance is told to play at the location that our player is currently at.
        Footsteps.setParameterByName("Material", F_MaterialValue);                                                 // Before the event is played, we set the Material Parameter to match the value of the 'F_MaterialValue' variable.
        Footsteps.start();                                                                                        // We then play a footstep!.
        /*Footsteps.release();    */                                                                                  // We also set our event instance to release straight after we tell it to play, so that the instance is released once the event had finished playing.
    }





















    //Old Script

    // FMOD event to trigger a footstep sound.
    //[FMODUnity.EventRef]
    //public string footStepsSound;

    //public static FMOD.Studio.EventInstance footstepsEv;

    ////Surface variables btwn 0.0f-1.0f to change volume of each sound material
    //public float m_Concrete;
    //public float m_Metal;
    //public float m_Vinyl;
    //public float m_Carpet;

    //private void Start()
    //{
    //    footstepsEv = FMODUnity.RuntimeManager.CreateInstance(footStepsSound);

    //    footstepsEv.setParameterByName("Concrete", m_Concrete);
    //    footstepsEv.setParameterByName("Metal", m_Metal);
    //    footstepsEv.setParameterByName("Vinyl", m_Vinyl);
    //    footstepsEv.setParameterByName("Carpet", m_Carpet);

    //    FMODUnity.RuntimeManager.PlayOneShot(footStepsSound);
    //}


    //// Called each time player animation timeline pass through "Footstep" event
    //private void Footstep()
    //{
    //    footstepsEv.setParameterByName("Concrete", m_Concrete);
    //    footstepsEv.setParameterByName("Metal", m_Metal);
    //    footstepsEv.setParameterByName("Vinyl", m_Vinyl);
    //    footstepsEv.setParameterByName("Carpet", m_Carpet);

    //    FMODUnity.RuntimeManager.PlayOneShot(footStepsSound);
    //    Debug.Log("step");
    //}


}
