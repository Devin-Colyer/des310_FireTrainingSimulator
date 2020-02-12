using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject g_cameras;
    private GameObject g_screenFade;
    private Camera g_currentCamera;
    private Camera g_newCamera;

    // Use this for initialization
    void Start ()
    {
        g_cameras = GameObject.Find("Cameras");
        g_screenFade = GameObject.Find("Screen Fade");

        g_newCamera = null;
        g_currentCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Camera change test.
        if(Input.GetKeyDown("1"))
        {
            ChangeCamera("Box Minigame");
        }
        else if (Input.GetKeyDown("2"))
        {
            ChangeCamera("Socket Minigame");
        }
        else if (Input.GetKeyDown("3"))
        {
            ChangeCamera("Room Camera");
        }

        // Check if camera has been changed
        if (g_newCamera && (g_newCamera != g_currentCamera))
        {
            // Wait for screen to finish fading out.
            if (g_screenFade.GetComponent<ScreenFade>().g_fading == false)
            {
                // Change camera.
                Camera.main.gameObject.SetActive(false);
                g_newCamera.gameObject.SetActive(true);

                // Update current camera, set new camera to null.
                g_currentCamera = g_newCamera;
                g_newCamera = null;

                // Begin fading in.
                g_screenFade.GetComponent<ScreenFade>().FadeIn(0.1f);
            }
        }
	}

    public void ChangeCamera(string name)
    {
        // Check if camera group was found.
        if(g_cameras)
        {
            // Make sure new camera isn't the same as current camera.
            if (name != g_currentCamera.name)
            {
                // Find new camera from camera group.
                Transform l_newCamera = g_cameras.transform.Find(name);

                // Check if new camera was found.
                if (l_newCamera)
                {
                    // Get camera component from camera object.
                    g_newCamera = l_newCamera.GetComponent<Camera>();

                    // Check if camera object was found.
                    if (g_newCamera)
                    {
                        // Camera was changed, begin fading out.
                        g_screenFade.GetComponent<ScreenFade>().FadeOut(0.1f);
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
