using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEmitterLevel2 : MonoBehaviour
{
    public GameObject m_HubCamera;
    public GameObject[] m_MinigameRoomCamera;
    public GameObject[] m_MinigameCamera;

    [SerializeField] [FMODUnity.EventRef] private string m_DialogueEventPath;


    [FMODUnity.EventRef]
    public string m_music = "event:/Music/MusicLevel2";
    public static FMOD.Studio.EventInstance m_musicEv;

    // m_FireIntensityDefiner will be difined by: 0= FireSomewhere  1= StillFireOnOtherRoom 2= NoFireLeft
    public static int m_FireIntensityDefiner;

    public int m_FireIntensity;

    // Start is called before the first frame update
    void Start()
    {
        m_FireIntensityDefiner = 0;
        m_musicEv = FMODUnity.RuntimeManager.CreateInstance(m_music);
        m_musicEv.setParameterByName("Fire Intensity", m_FireIntensity);
        m_musicEv.start();
    }

    // Update is called once per frame
    void Update()
    {
        FMOD.Studio.PLAYBACK_STATE l_playbackState;
        Dialogue.m_ThirdPersonSound.getPlaybackState(out l_playbackState);
        if (l_playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            m_musicEv.setParameterByName("LowerVolumeWhenSpeak", 0);
        }
        if (l_playbackState != FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            m_musicEv.setParameterByName("LowerVolumeWhenSpeak", 1);
        }

        if (m_FireIntensityDefiner == 0)
        {
            if (m_HubCamera.activeSelf)
            {
                Debug.Log("Hub");
                m_FireIntensity = 0;
                m_musicEv.setParameterByName("Fire Intensity", m_FireIntensity);
            }

            foreach (GameObject l_MinigameRoom in m_MinigameRoomCamera)
            {
                if (l_MinigameRoom.activeSelf)
                {
                    Debug.Log("MinigameRoom");
                    m_FireIntensity = 1;

                    m_musicEv.setParameterByName("Fire Intensity", m_FireIntensity);
                }
            }

            foreach (GameObject l_Minigame in m_MinigameCamera)
            {
                if (l_Minigame.activeSelf)
                {
                    Debug.Log("Minigame");
                    m_FireIntensity = 2;
                    m_musicEv.setParameterByName("Fire Intensity", m_FireIntensity);
                }
            }
        }

        if (m_FireIntensityDefiner == 1)
        {
            Debug.Log("BeatOneFire");
            m_FireIntensity = 4;
            m_musicEv.setParameterByName("Fire Intensity", m_FireIntensity);

            if (m_HubCamera.activeSelf)
            {
                m_FireIntensityDefiner = 0;
                Debug.Log("Hub");

            }
        }

        if (m_FireIntensityDefiner == 2)
        {
            Debug.Log("BeatOneFire");
            m_FireIntensity = 3;
            m_musicEv.setParameterByName("Fire Intensity", m_FireIntensity);
        }

    }
}
