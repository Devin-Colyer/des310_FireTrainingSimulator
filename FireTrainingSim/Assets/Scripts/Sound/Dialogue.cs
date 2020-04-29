using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Dialogue : MonoBehaviour {

    [SerializeField] [FMODUnity.EventRef] private string DialogueEventPath;
    public static int F_DialogueValue=1;
    public static bool MONBOULE;
    //0 = Dont need to play a "Number"      1 = Need to play a "Number"     2 = Need to play an other "Dialogue" to finish the senctence
    //private int CheckNumber = 0;
    //DONTPLAY = Dont need to play anything after      PLAYNUMBER = Need to play a "Number"     PLAYDIFFERENT = Need to play an other "Dialogue" to finish the senctence
    //private int CheckNumber = 0;
    public enum DialogueStateControl
    {
        DONTPLAY,
        PLAYNUMBER,
        PLAYDIFFERENT
    }
    public DialogueStateControl m_dialogueStateControl = DialogueStateControl.DONTPLAY;
    public int[] DialogueWhoNeedToPlayNunmber = new int[0];
    public int[] DialogueWhoNeedToPlayNextDialogue = new int[0];

    [SerializeField] [FMODUnity.EventRef] private string NumbersEventPath;
    public int F_NumbersValue;


    public static FMOD.Studio.EventInstance ThirdPersonSound;
    public static FMOD.Studio.EventInstance Numbers;









    // Use this if Collision Trigger Dialogue
    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Touchdown");
        if (collision.gameObject.name == "Player")
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
                    m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
                }
            }

            //Here is when we need a Dialogue
            foreach (int itr in DialogueWhoNeedToPlayNextDialogue)
            {
                if (F_DialogueValue == itr)
                {
                    m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
                }
            }
        }
    }

    void Start()
    {
        //Debug.Log("Test");
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
                m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
            }
        }

        //Here is when we need a Dialogue
        foreach (int itr in DialogueWhoNeedToPlayNextDialogue)
        {
            if (F_DialogueValue == itr)
            {
                m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
            }
        }

    }


    public void PlayDialogue()
    {
        Debug.Log("yes"+ F_DialogueValue);
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
                    m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
                }
            }

            //Here is when we need a Dialogue
            foreach (int itr in DialogueWhoNeedToPlayNextDialogue)
            {
                if (F_DialogueValue == itr)
                {
                    m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
                }
            }
    }



    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE playbackState;
        ThirdPersonSound.getPlaybackState(out playbackState);
        Debug.Log(playbackState);

        if (m_dialogueStateControl == DialogueStateControl.PLAYNUMBER)
        {
            //FMOD.Studio.PLAYBACK_STATE playbackState;
            //ThirdPersonSound.getPlaybackState(out playbackState);
            Debug.Log(playbackState);
            if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                ThirdPersonSound.release();
                ThirdPersonSound.clearHandle();
                Debug.Log("PlayerIntroFinished");
                m_dialogueStateControl = DialogueStateControl.DONTPLAY;
                SpeakedNumber();
            }
        }
        else if (m_dialogueStateControl == DialogueStateControl.PLAYDIFFERENT)
        {
            //FMOD.Studio.PLAYBACK_STATE playbackState;
            //ThirdPersonSound.getPlaybackState(out playbackState);
            if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                F_DialogueValue++;
                Start();
                foreach (int itr in DialogueWhoNeedToPlayNextDialogue)
                {
                    if (F_DialogueValue == itr)
                    {
                        m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
                        //Debug.Log("Yes" + playbackState);
                    }
                    else if (F_DialogueValue != itr)
                    {
                        m_dialogueStateControl = DialogueStateControl.DONTPLAY;
                        //Debug.Log("No" + playbackState);
                    }
                }
            }
        }
    }


    void SpeakedNumber()
    {
        Numbers = FMODUnity.RuntimeManager.CreateInstance(NumbersEventPath);
        Numbers.setParameterByName("Numbers", F_NumbersValue);
        Numbers.start();
        F_DialogueValue++;
        m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
    }


}
