using UnityEngine;

public class MusicEmitter : MonoBehaviour {

    [FMODUnity.EventRef]
    public string m_music = "event:/Music/Music";

   public static FMOD.Studio.EventInstance m_musicEv;

    public float m_Intro;
    public float m_Loop;
    public float m_Outro;

    void Start ()
    {
        m_musicEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        m_musicEv = FMODUnity.RuntimeManager.CreateInstance(m_music);

        m_musicEv.setParameterByName("Intro", m_Intro);
        m_musicEv.setParameterByName("Loop", m_Loop);
        m_musicEv.setParameterByName("Outro", m_Outro);
        m_musicEv.start();
        
        //FMODUnity.RuntimeManager.PlayOneShot(music);
    }

    public void StopMusic()
    {
        m_musicEv.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        Debug.Log("stopZik");
    }

    //public void GameStartedMusic()
    //{
    //    musicEv.setPar("Intro", 1f);
    //}

    //public void LoopMusic()
    //{
    //    musicEv.setParameterValue("Loop", 1f);
    //}

    //public void outroMusic()
    //{
    //    musicEv.setParameterValue("Outro", 1f);
    //}
}
