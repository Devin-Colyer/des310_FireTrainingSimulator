using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject m_cameras;
    private GameObject m_screenFade;
    private Camera m_currentCamera;
    private Camera m_newCamera;

    // Use this for initialization
    void Start ()
    {
        m_cameras = GameObject.Find("Cameras");
        m_screenFade = GameObject.Find("Screen Fade");

        m_newCamera = null;
        m_currentCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //// Camera change test.
        //if(Input.GetKeyDown("1"))
        //{
        //    ChangeCamera("Box Minigame");
        //}
        //else if (Input.GetKeyDown("2"))
        //{
        //    ChangeCamera("Socket Minigame");
        //}
        //else if (Input.GetKeyDown("3"))
        //{
        //    ChangeCamera("Room Camera");
        //}

        // Check if camera has been changed
        if (m_newCamera && (m_newCamera != m_currentCamera))
        {
            // Wait for screen to finish fading out.
            if (m_screenFade.GetComponent<ScreenFade>().m_fading == false)
            {
                // Change camera.
                Camera.main.gameObject.SetActive(false);
                m_newCamera.gameObject.SetActive(true);

                // Update current camera, set new camera to null.
                m_currentCamera = m_newCamera;
                m_newCamera = null;

                // Begin fading in.
                m_screenFade.GetComponent<ScreenFade>().FadeIn(0.1f);
            }
        }
	}

    public void ChangeCamera(string name)
    {
        // Check if camera group was found.
        if(m_cameras)
        {
            // Check if camera is already changing (new camera already exists).
            if (!m_newCamera)
            {
                // Make sure new camera isn't the same as current camera.
                if (name != m_currentCamera.name)
                {
                    // Find new camera from camera group.
                    Transform l_newCamera = m_cameras.transform.Find(name);

                    // Check if new camera was found.
                    if (l_newCamera)
                    {
                        // Get camera component from camera object.
                        m_newCamera = l_newCamera.GetComponent<Camera>();

                        // Check if camera object was found.
                        if (m_newCamera)
                        {
                            // Camera was changed, begin fading out.
                            m_screenFade.GetComponent<ScreenFade>().FadeOut(0.1f);
                        }
                    }
                }
            }
        }
        else
        {
            // Debug output.
            Debug.LogError("Error changing camera. Failed to find camera objects.");
        }
    }

    public void SetCamera(Camera camera)
    {

    }
}
