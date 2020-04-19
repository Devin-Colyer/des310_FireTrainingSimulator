using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClickTrigger : MonoBehaviour
{
    public Vector3 m_offset = new Vector3(0.0f, 0.0f, 0.0f);

    public Vector3 GetDestination()
    {
        return transform.position + m_offset;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0.0f, 1.0f, 0.0f);
        Gizmos.DrawWireSphere(GetDestination(), 0.1f);
    }
}
