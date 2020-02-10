using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionLipController : MonoBehaviour {

    // Public Objects so the script is customizable
    public GameObject m_Room1;
    public GameObject m_Room2;
    public GameObject m_RoomLip;

    // Update is called once per frame
    void Update () {
        // Access the scripts which contain info on if the rooms are active or not
        DisappearingRoomController l_RoomScript1 = m_Room1.GetComponent<DisappearingRoomController>();
        DisappearingRoomController l_RoomScript2 = m_Room2.GetComponent<DisappearingRoomController>();

        // If both rooms are inactive, deactivate the lip, otherwise active it
        if (!l_RoomScript1.IsRoomActive() && !l_RoomScript2.IsRoomActive())
        {
            if (m_RoomLip.activeInHierarchy)
            {
                m_RoomLip.SetActive(false);
            }
        }
        else
        {
            if (!m_RoomLip.activeInHierarchy)
            {
                m_RoomLip.SetActive(true);
            }
        }
	}
}
