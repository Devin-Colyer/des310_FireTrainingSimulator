using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour
{

    //public GameObject m_MinigameToActivate;
    //public Camera m_RoomCamera;
    public GameObject m_cameraController;
    public string m_minigame;

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_MinigameToActivate.SetActive(true);
            m_RoomCamera.enabled = false;
            gameObject.SetActive(false);
            //m_CameraController.GetComponent<CameraController>().ChangeCamera(m_Minigame);
        }
    }*/

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            /*m_MinigameToActivate.SetActive(true);
            m_RoomCamera.enabled = false;
            gameObject.SetActive(false);*/
            //m_CameraController.GetComponent<CameraController>().ChangeCamera(m_Minigame);

            // Fade in glow when near hazard.
            this.transform.parent.GetComponentInChildren<GlowComponent>().FadeIn();

            if(Input.GetKeyDown("e"))
            {
                m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        this.transform.parent.GetComponentInChildren<GlowComponent>().FadeOut();
    }
}
