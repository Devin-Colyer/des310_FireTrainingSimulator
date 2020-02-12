using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour {

    // Camera transform info
    Vector3 m_CamStartPosition;
    Vector3 m_CamDestintaion;
    private Camera m_CurrentCamera;
    
    // Used for interpolation
    float m_DistanceToCover;

    // Camera speed, can be set in editor
    public float m_CamSpeed = 1.0f;

    // Time the camera starts moving
    float m_MoveStartTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Prepare to move
            m_CurrentCamera = Camera.main;
            m_CamStartPosition = m_CurrentCamera.transform.position;
            m_CamDestintaion = new Vector3(this.transform.position.x + 22, m_CurrentCamera.transform.position.y, this.transform.position.z + 22);
            m_MoveStartTime = Time.time;
            m_DistanceToCover = Vector3.Distance(m_CamStartPosition, m_CamDestintaion);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            // Get the distance travelled, Displacement = DeltaTime * Velocity
            float l_DistanceTravelled = (Time.time - m_MoveStartTime) * m_CamSpeed;

            float l_FractionOfJourney = 0;
            // Can't divide by 0
            if (m_DistanceToCover != 0)
                // Fraction of journey needed to interpolate
                l_FractionOfJourney = l_DistanceTravelled / m_DistanceToCover;

            // Move the camera
            m_CurrentCamera.transform.position = Vector3.Lerp(m_CamStartPosition, m_CamDestintaion, l_FractionOfJourney);
        }
    }
}
