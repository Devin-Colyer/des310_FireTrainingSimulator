using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Stores the area assosciated with the camera.
    public GameObject m_cameraArea;

    private void OnEnable()
    {
        if(m_cameraArea)
        {
            // Enable camera area.
            m_cameraArea.gameObject.SetActive(true);
        }
    }

    private void OnDisable()
    {
        if (m_cameraArea)
        {
            // Disable camera area.
            m_cameraArea.gameObject.SetActive(false);
        }
    }
}
