using UnityEngine;

public class Dialogue : MonoBehaviour {

    [SerializeField] [FMODUnity.EventRef] private string m_DialogueEventPath;
    public static int m_FDialogueValue = 0;
    public int m_DefaultFDialogueValue;
    public static bool m_Monboule;
    bool m_HavePlayedNumber = false;

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
    public int[] m_DialogueWhoNeedToPlayNunmber = new int[0];
    public int[] m_DialogueWhoNeedToPlayNextDialogue = new int[0];

    [SerializeField] [FMODUnity.EventRef] private string m_NumbersEventPath;
    public static int m_FNumbersValue;
    public int m_NumbersValue;


    public static FMOD.Studio.EventInstance m_ThirdPersonSound;
    public static FMOD.Studio.EventInstance m_Numbers;

    void Start()
    {
        m_FDialogueValue = m_DefaultFDialogueValue;
        m_FNumbersValue = m_NumbersValue;

        m_ThirdPersonSound = FMODUnity.RuntimeManager.CreateInstance(m_DialogueEventPath);
        m_ThirdPersonSound.setParameterByName("Dialogue", m_FDialogueValue);
        m_ThirdPersonSound.start();
        Debug.Log("Dialogue played is D" + m_FDialogueValue);

        //Used to optimise the code, so the Update doesnt have to always run unuseful code
        // The values are the Dialogue FMOD values who need the next one to be played straight after

        //Here is when we need a NUMBER
        foreach (int itr in m_DialogueWhoNeedToPlayNunmber)
        {
            if (m_FDialogueValue == itr)
            {
                m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
            }
        }

        //Here is when we need a Dialogue
        foreach (int itr in m_DialogueWhoNeedToPlayNextDialogue)
        {
            if (m_FDialogueValue == itr)
            {
                //Debug.Log("tu joueras dialogue");
                m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
            }
        }
        //PlayDialogue();
    }


    public void PlayDialogue()
    {


        m_ThirdPersonSound = FMODUnity.RuntimeManager.CreateInstance(m_DialogueEventPath);
        m_ThirdPersonSound.setParameterByName("Dialogue", m_FDialogueValue);
        m_ThirdPersonSound.start();
        Debug.Log("Dialogue played is D" + m_FDialogueValue);

        //Used to optimise the code, so the Update doesnt have to always run unuseful code
        // The values are the Dialogue FMOD values who need the next one to be played straight after

        //Here is when we need a NUMBER
        foreach (int itr in m_DialogueWhoNeedToPlayNunmber)
            {
                if (m_FDialogueValue == itr)
                {
                    m_dialogueStateControl = DialogueStateControl.PLAYNUMBER;
                }
            }

            //Here is when we need a Dialogue
            foreach (int itr in m_DialogueWhoNeedToPlayNextDialogue)
            {
                if (m_FDialogueValue == itr)
                {
                //Debug.Log("tu joueras dialogue");
                    m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
                }
            }

        //Here is when we need Nothing After
        foreach (int itr in m_DialogueWhoNeedToPlayNextDialogue)
        {
            if (m_FDialogueValue != itr)
            {
                //Debug.Log("tu joueras pas dialogue");
                m_dialogueStateControl = DialogueStateControl.DONTPLAY;
            }
        }
    }



    void Update()
    {
        //FMOD.Studio.PLAYBACK_STATE playbackState;
        //ThirdPersonSound.getPlaybackState(out playbackState);
        //debug.log(playbackstate);
        //Debug.Log(m_dialogueStateControl);

        if (m_dialogueStateControl == DialogueStateControl.PLAYNUMBER)
        {
            Debug.Log(m_dialogueStateControl);
            FMOD.Studio.PLAYBACK_STATE l_playbackState;
            m_ThirdPersonSound.getPlaybackState(out l_playbackState);
            if (l_playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                FMOD.Studio.PLAYBACK_STATE l_playbackStateNumber;
                m_Numbers.getPlaybackState(out l_playbackStateNumber);
                if (l_playbackStateNumber == FMOD.Studio.PLAYBACK_STATE.STOPPED & m_HavePlayedNumber==false)
                {
                    SpeakNumber();
                    Debug.Log(l_playbackStateNumber);
                    m_HavePlayedNumber = true;
                }
                else if (l_playbackStateNumber == FMOD.Studio.PLAYBACK_STATE.STOPPED & m_HavePlayedNumber)
                {

                    m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;
                }
            }

        }
        else if (m_dialogueStateControl == DialogueStateControl.PLAYDIFFERENT)
        {
            FMOD.Studio.PLAYBACK_STATE l_playbackState;
            m_ThirdPersonSound.getPlaybackState(out l_playbackState);
            if (l_playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                m_FDialogueValue++;
                PlayDialogue();
                //Here is when we need a Dialogue
                foreach (int itr in m_DialogueWhoNeedToPlayNextDialogue)
                {
                    if (m_FDialogueValue == itr)
                    {
                        //Debug.Log("tu joueras dialogue");
                        m_dialogueStateControl = DialogueStateControl.PLAYDIFFERENT;                    
                    }
                }

                //Here is when we need Nothing After
                foreach (int itr in m_DialogueWhoNeedToPlayNextDialogue)
                {
                    if (m_FDialogueValue != itr)
                    {
                        //Debug.Log("tu joueras pas dialogue");
                        m_dialogueStateControl = DialogueStateControl.DONTPLAY;
                    }
                }
            }
        }
    }


    void SpeakNumber()
    {
        m_Numbers = FMODUnity.RuntimeManager.CreateInstance(m_NumbersEventPath);
        m_Numbers.setParameterByName("Numbers", m_FNumbersValue);
        m_Numbers.start();
        Debug.Log("Dialogue played is D" + m_FDialogueValue);
    }


}
