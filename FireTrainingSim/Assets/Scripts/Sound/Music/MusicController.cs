﻿using UnityEngine;

public class MusicController : MonoBehaviour
{
    
    public float m_intro;
    public float m_loop;
    public float m_outro;

    //If player enter in new music area, music will transition to the seted value (1 by default)
    public void SwitchMusic ()
    {

        MusicEmitter.m_musicEv.setParameterByName("Intro", m_intro);
        MusicEmitter.m_musicEv.setParameterByName("loop", m_loop);
        MusicEmitter.m_musicEv.setParameterByName("outro", m_outro);
        Debug.Log("MusicSwitch");

        //if (collision.gameObject.name == "Player")
        //{
        //}
    }
}
