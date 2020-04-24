using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEmitter : MonoBehaviour {

    [FMODUnity.EventRef]
    public string music = "event:/Music/Music";

   public static FMOD.Studio.EventInstance musicEv;

    public float Intro;
    public float Loop;
    public float Outro;

    void Start ()
    {
        musicEv = FMODUnity.RuntimeManager.CreateInstance(music);

        musicEv.setParameterByName("Intro", Intro);
        musicEv.setParameterByName("Loop", Loop);
        musicEv.setParameterByName("Outro", Outro);
        musicEv.start();
        
        //FMODUnity.RuntimeManager.PlayOneShot(music);
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
