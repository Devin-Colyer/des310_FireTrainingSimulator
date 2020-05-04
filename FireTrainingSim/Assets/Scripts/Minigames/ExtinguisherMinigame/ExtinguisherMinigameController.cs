using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherMinigameController : MonoBehaviour {

    public GameObject[] m_ListOfFires;
    public GameObject m_FireExtinguisherWorldMatrixTransform;
    public GameObject m_cameraController;
    public GameObject m_player;
    public GameObject m_worldHazard;
    public GameObject m_extinguisherPickups;

    //SoundPart
    public ExtinguisherSounds m_ExtinguisherSoundsScript;
    bool m_IsPlayingExtinguisherSound = false;
    bool m_IsPlayingStopExtinguisherSound = false;
    public static FMOD.Studio.EventInstance m_ExtinguisherEventInstance;

    public float m_sprayRadius = 5; //temp

    Vector3 m_MousePosition;
    Camera m_MinigameCamera;
    ParticleSystem m_ParticleSystem;

    private Vector3 m_PreviousPosition = new Vector3(0f, 0f, 0f);
    // Use these for initialization
    void Start()
    {
        m_MinigameCamera = Camera.main;
        m_ParticleSystem = m_FireExtinguisherWorldMatrixTransform.GetComponentInChildren<ParticleSystem>();
    }

    void OnEnable ()
    {
        m_MinigameCamera = Camera.main;
        m_ParticleSystem = m_FireExtinguisherWorldMatrixTransform.GetComponentInChildren<ParticleSystem>();

        // Find mouse cursor object in game.
        MouseCursor l_mouseCursor = FindObjectOfType<MouseCursor>();

        // Check if mouse cursor exists.
        if (l_mouseCursor)
        {
            // Change cursor to target for extinguisher minigame.
            l_mouseCursor.SetDefaultState(MouseCursor.State.TARGET);
        }
    }

    void OnDisable()
    {
        // Find mouse cursor object in game.
        MouseCursor l_mouseCursor = FindObjectOfType<MouseCursor>();

        // Check if mouse cursor exists.
        if (l_mouseCursor)
        {
            // Set cursor to pointer before going back to level.
            l_mouseCursor.SetDefaultState(MouseCursor.State.POINTER);
        }
    }

    // Update is called once per frame
    void Update () {
        m_MousePosition = Input.mousePosition;

        // Setup Raycast
        RaycastHit l_Hit;
        Ray l_Ray = m_MinigameCamera.ScreenPointToRay(m_MousePosition);

        // Cast ray from the mouse
        Physics.Raycast(l_Ray, out l_Hit, 100);
        MoveExtiguisher(l_Hit);

        ShootExtinguisher(l_Hit);

        bool beatMinigame = false;        
        foreach(GameObject l_fire in m_ListOfFires)
        {
            if (l_fire.GetComponent<FireObjective>().m_Burning)
            {
                beatMinigame = false;
                break;
            }
            else
            {
                if (m_ExtinguisherSoundsScript)
                {
                    m_ExtinguisherSoundsScript.StopExtinguisher();
                }
                beatMinigame = true;
            }
        }

        if (beatMinigame && m_cameraController)
        {
            if (m_worldHazard && m_extinguisherPickups & m_player)
            {
                // Disable world hazard.
                m_worldHazard.transform.Find("Broken").gameObject.SetActive(false);
                m_extinguisherPickups.transform.Find("Broken").gameObject.SetActive(false);

                // Enable fixed hazard.
                m_worldHazard.transform.Find("Fixed").gameObject.SetActive(true);
                m_extinguisherPickups.transform.Find("Fixed").gameObject.SetActive(true);

                m_player.GetComponent<ExtinguisherTrackerComponent>().SetExtinguisherType(ExtinguisherType.NONE);
            }

            if (m_cameraController)
            {
                // Change camera back to level camera.
                m_cameraController.GetComponent<CameraController>().ChangeCamera("Room Camera");
            }
        }
    }

    void MoveExtiguisher(RaycastHit in_hit)
    {
        
        if (m_PreviousPosition != m_MousePosition)
        {
            m_PreviousPosition = m_MousePosition;

            //Calculate direction and rotate
            Vector3 l_NewExtinguisherDirection = in_hit.point - m_FireExtinguisherWorldMatrixTransform.transform.position;
            m_FireExtinguisherWorldMatrixTransform.transform.forward = l_NewExtinguisherDirection;
        }

    }

    void ShootExtinguisher(RaycastHit in_hit)
    {
        if (Input.GetMouseButton(0))
        {
            m_ParticleSystem.Play();

            // Play Extinguisher Sound
            // FMOD give access to the plyaback state of each of its events, so here we can check when Extinguisher sound if NOT PLAYING
            FMOD.Studio.PLAYBACK_STATE l_playbackState;
            m_ExtinguisherEventInstance.getPlaybackState(out l_playbackState);
            if (l_playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                if (m_IsPlayingExtinguisherSound == false)
                {
                    Debug.Log("PLAY EXTINGUISHER SOUND");
                    m_IsPlayingStopExtinguisherSound = false;
                    if (m_ExtinguisherSoundsScript)
                    {
                        m_ExtinguisherSoundsScript.FireExtinguisher();
                    }
                    m_IsPlayingExtinguisherSound = true;
                }
            }

            foreach (GameObject l_fire in m_ListOfFires)
            {
                if (Vector3.Distance(l_fire.transform.position, in_hit.point) <= m_sprayRadius || in_hit.collider.gameObject == l_fire)
                {
                    l_fire.GetComponent<FireObjective>().ExtinguishByPercentage(1f);
                }
            }
        }
        else if (!Input.GetMouseButton(0))
        {
            m_ParticleSystem.Stop();

            // Play the Stop Extinguisher Sound
            if (m_IsPlayingStopExtinguisherSound == false)
            {
                Debug.Log("PLAY STOP EXTINGUISHER SOUND");
                m_IsPlayingExtinguisherSound = false;
                if (m_ExtinguisherSoundsScript)
                {
                    m_ExtinguisherSoundsScript.StopExtinguisher();
                }
                m_IsPlayingStopExtinguisherSound = true;
            }
        }
    }
}
