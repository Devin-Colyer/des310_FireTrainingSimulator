using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour {

    public GameObject m_MinigameToActivate;
    public Camera m_RoomCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            m_MinigameToActivate.SetActive(true);
            m_RoomCamera.enabled = false;
            gameObject.SetActive(false);
        }
    }
}
