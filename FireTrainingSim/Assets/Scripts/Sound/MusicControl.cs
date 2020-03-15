using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour {

    [FMODUnity.EventRef]
    public string music = "event:/Music/Music";

    FMOD.Studio.EventInstance musicEv;

    void Start ()
    {
        musicEv = FMODUnity.RuntimeManager.CreateInstance(music);

        musicEv.start();
    }

    public void GameStartedMusic()
    {
        musicEv.setParameterValue("Intro", 1f);
    }

    public void LoopMusic()
    {
        musicEv.setparameterValue("Loop", 1f);
    }

    public void outroMusic()
    {
        musicEv.setParameterValue("Outro", 1f);
    }
}
