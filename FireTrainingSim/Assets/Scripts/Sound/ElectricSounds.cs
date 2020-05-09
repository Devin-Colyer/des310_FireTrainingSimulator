using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricSounds : MonoBehaviour
{
    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string m_ElectricEventPath;

    public static float m_DistanceFromElectric = 1;
    public float m_DistanceFromElectricDefiner;

    public FMOD.Studio.EventInstance m_Electric;

    //Play the electric sound, set as a loop in FMOD
    private void Start()
    {
        m_DistanceFromElectric = m_DistanceFromElectricDefiner;
        m_Electric = FMODUnity.RuntimeManager.CreateInstance(m_ElectricEventPath);
        m_Electric.setParameterByName("Distance", m_DistanceFromElectric);

    }
    private void Update()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(m_Electric, GetComponent<Transform>(), GetComponent<Rigidbody>());
        FMOD.Studio.PLAYBACK_STATE l_playbackState;
        m_Electric.getPlaybackState(out l_playbackState);
        Debug.Log(l_playbackState);
        PlaySound();
    }

    void PlaySound()
    {
        FMOD.Studio.PLAYBACK_STATE l_playbackState;
        m_Electric.getPlaybackState(out l_playbackState);
        if (l_playbackState != FMOD.Studio.PLAYBACK_STATE.PLAYING)
        {

            m_Electric.start();
        }

    }
}
