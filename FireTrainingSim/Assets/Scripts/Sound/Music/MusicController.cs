using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    public float m_intro;
    public float m_loop;
    public float m_outro;

    //Unticked: Music switch when BoxCollider is triggered / Ticked: Music switch when Camera, scene or other is awake
    public bool CollideOrStart;
    

    //If player enter in new music area, music will transition to the seted value (1 by default)
    void OnTriggerEnter(Collider collision)
    {
        if (CollideOrStart == false)
        {
            if (collision.gameObject.name == "Player")
            {

                MusicEmitter.musicEv.setParameterByName("Intro", m_intro);
                MusicEmitter.musicEv.setParameterByName("loop", m_loop);
                MusicEmitter.musicEv.setParameterByName("outro", m_outro);
                Debug.Log("bite");
            }
        }

    }


    void Awake()
    {
        if (CollideOrStart)
        {
            MusicEmitter.musicEv.setParameterByName("Intro", m_intro);
            MusicEmitter.musicEv.setParameterByName("loop", m_loop);
            MusicEmitter.musicEv.setParameterByName("outro", m_outro);
            Debug.Log("awake");
        }
    }



}
