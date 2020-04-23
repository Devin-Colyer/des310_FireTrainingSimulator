using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Dialogue : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string DialogueEventPath;
    public int F_DialogueValue;
    [SerializeField] [FMODUnity.EventRef] private string NumbersEventPath;
    public int F_NumbersValue;


    public static FMOD.Studio.EventInstance ThirdPersonSound;
    public static FMOD.Studio.EventInstance Numbers;


    //0 = Dont need to play a "Number"      1 = Need to play a "Number"     2 = Need to play an other "Dialogue" to finish the senctence
    private int CheckNumber = 0;






    // Use this for initialization
    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Touchdown");
        if (collision.gameObject.name == "Player")
        {

            ThirdPersonSound = FMODUnity.RuntimeManager.CreateInstance(DialogueEventPath);
            ThirdPersonSound.setParameterByName("Dialogue", F_DialogueValue);
            ThirdPersonSound.start();

        

            //Used to optimise the code, so the Update doesnt have to always run unuseful code
            if (F_DialogueValue == 35 || F_DialogueValue == 360)
            {
                CheckNumber = 1;
            }


            else if (F_DialogueValue != 35 || F_DialogueValue != 360)
            {
                Destroy(gameObject);
            }
            

            
        }
    }


    void SubstituteOfOTE()
    {
        ThirdPersonSound = FMODUnity.RuntimeManager.CreateInstance(DialogueEventPath);
        ThirdPersonSound.setParameterByName("Dialogue", F_DialogueValue);
        ThirdPersonSound.start();

        Destroy(gameObject);
    }



    void Update()
    {
        if (CheckNumber == 1)
        {
            Debug.Log("YO");
            FMOD.Studio.PLAYBACK_STATE playbackState;
            ThirdPersonSound.getPlaybackState(out playbackState);
            if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                ThirdPersonSound.release();
                ThirdPersonSound.clearHandle();
                Debug.Log("PlayerIntroFinished");
                CheckNumber = 0;
                SpeakedNumber();
            }
        }
        else if (CheckNumber == 2)
        {
            FMOD.Studio.PLAYBACK_STATE playbackState;
            Numbers.getPlaybackState(out playbackState);
            if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                SubstituteOfOTE();
                CheckNumber = 0;
            }
        }
    }


    void SpeakedNumber()
    {
        Numbers = FMODUnity.RuntimeManager.CreateInstance(NumbersEventPath);
        Numbers.setParameterByName("Numbers", F_NumbersValue);
        Numbers.start();
        F_DialogueValue++;
        CheckNumber = 2;
    }


}
