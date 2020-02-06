using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour {

    // Camera transform info
    Vector3 m_CamStartPosition;
    Vector3 m_CamDestintaion;
    
    // Used for interpolation
    float m_DistanceToCover;

    // Camera speed, can be set in editor
    public float m_CamSpeed = 1.0f;

    // Time the camera starts moving
    float m_MoveStartTime;

    private void OnTriggerEnter(Collider other)
    {
        // Prepare to move
        m_CamStartPosition = Camera.main.transform.position;
        m_CamDestintaion = new Vector3(this.transform.position.x + 22, Camera.main.transform.position.y, this.transform.position.z + 22);
        m_MoveStartTime = Time.time;
        m_DistanceToCover = Vector3.Distance(m_CamStartPosition, m_CamDestintaion);
    }

    private void OnTriggerStay(Collider other)
    {
        // Get the distance travelled, Displacement = DeltaTime * Velocity
        float l_DistanceTravelled = (Time.time - m_MoveStartTime) * m_CamSpeed;

        float l_FractionOfJourney = 0;
        // Can't divide by 0
        if (m_DistanceToCover != 0)
            // Fraction of journey needed to interpolate
            l_FractionOfJourney = l_DistanceTravelled / m_DistanceToCover;

        // Move the camera
        Camera.main.transform.position = Vector3.Lerp(m_CamStartPosition, m_CamDestintaion, l_FractionOfJourney);
    }
}
