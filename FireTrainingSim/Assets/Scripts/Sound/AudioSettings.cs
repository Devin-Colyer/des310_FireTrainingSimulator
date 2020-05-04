using UnityEngine;

public class AudioSettings : MonoBehaviour {

    FMOD.Studio.Bus m_Music;
    FMOD.Studio.Bus m_GeneralSounds;
    float m_MusicVolume = .8f;
    float m_GeneralSoundsVolume = .8f;
    //If wana play a sample sound when changing volume
    FMOD.Studio.EventInstance m_GeneralSoundsTest;


    //Used to optimise the code, so the Update doesnt have to always run unuseful code
    //Check if Audio Settings is openn
    bool m_AudioSettingsActivated = false;


    public GameObject m_MusicLabelSoundOn;
    public GameObject m_MusicLabelSoundOff;
    public GameObject m_GeneralSoundsLabelSoundOn;
    public GameObject m_GeneralSoundsLabelSoundOff;

    void Awake()
    {
        m_Music = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
        m_GeneralSounds = FMODUnity.RuntimeManager.GetBus("bus:/Master/Other");
    }


    void Update()
    {
        if (m_AudioSettingsActivated)
        {
            Debug.Log("Volume");

        }
        m_Music.setVolume(m_MusicVolume);
        m_GeneralSounds.setVolume(m_GeneralSoundsVolume);
    }


    public void MusicLevel (float in_newMusicLevel)
    {
        m_MusicVolume = in_newMusicLevel;
        if (m_MusicVolume == 0)
        {
            m_MusicLabelSoundOn.gameObject.SetActive(false);
            m_MusicLabelSoundOff.gameObject.SetActive(true);
        }
        else
        {
            m_MusicLabelSoundOn.gameObject.SetActive(true);
            m_MusicLabelSoundOff.gameObject.SetActive(false);
        }
    }

    public void GeneralSoundsLevel(float in_newGeneralSoundsLevel)
    {
        m_GeneralSoundsVolume = in_newGeneralSoundsLevel;
        if (m_GeneralSoundsVolume == 0)
        {
            m_GeneralSoundsLabelSoundOn.gameObject.SetActive(false);
            m_GeneralSoundsLabelSoundOff.gameObject.SetActive(true);
        }
        else
        {
            m_GeneralSoundsLabelSoundOn.gameObject.SetActive(true);
            m_GeneralSoundsLabelSoundOff.gameObject.SetActive(false);
        }
    }
}
