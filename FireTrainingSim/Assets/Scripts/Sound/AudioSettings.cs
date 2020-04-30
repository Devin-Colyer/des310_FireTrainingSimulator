using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour {

    FMOD.Studio.Bus Music;
    FMOD.Studio.Bus GeneralSounds;
    float MusicVolume = .8f;
    float GeneralSoundsVolume = .8f;
    //If wana play a sample sound when changing volume
    FMOD.Studio.EventInstance GeneralSoundsTest;


    //Used to optimise the code, so the Update doesnt have to always run unuseful code
    //Check if Audio Settings is openn
    bool AudioSettingsActivated = false;


    public GameObject MusicLabelSoundOn;
    public GameObject MusicLabelSoundOff;
    public GameObject GeneralSoundsLabelSoundOn;
    public GameObject GeneralSoundsLabelSoundOff;

    void Awake()
    {
        Music = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
        GeneralSounds = FMODUnity.RuntimeManager.GetBus("bus:/Master/Other");
    }


    void Update()
    {
        if (AudioSettingsActivated)
        {
            Debug.Log("Volume");

        }
        Music.setVolume(MusicVolume);
        GeneralSounds.setVolume(GeneralSoundsVolume);
    }


    public void MusicLevel (float newMusicLevel)
    {
        MusicVolume = newMusicLevel;
        if (MusicVolume == 0)
        {
            MusicLabelSoundOn.gameObject.SetActive(false);
            MusicLabelSoundOff.gameObject.SetActive(true);
        }
        else
        {
            MusicLabelSoundOn.gameObject.SetActive(true);
            MusicLabelSoundOff.gameObject.SetActive(false);
        }
    }

    public void GeneralSoundsLevel(float newGeneralSoundsLevel)
    {
        GeneralSoundsVolume = newGeneralSoundsLevel;
        if (GeneralSoundsVolume == 0)
        {
            GeneralSoundsLabelSoundOn.gameObject.SetActive(false);
            GeneralSoundsLabelSoundOff.gameObject.SetActive(true);
        }
        else
        {
            GeneralSoundsLabelSoundOn.gameObject.SetActive(true);
            GeneralSoundsLabelSoundOff.gameObject.SetActive(false);
        }
    }

}
