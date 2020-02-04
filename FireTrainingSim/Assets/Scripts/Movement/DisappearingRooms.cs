using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingRooms : MonoBehaviour {
    
    MeshRenderer[] m_ChildMeshRenderers;
    // Use this for initialization
    void Start()
    {
        MeshRenderer[] l_MeshRenderers = GetComponentsInChildren<MeshRenderer>();

        if (l_MeshRenderers == null)
            Debug.Log("No Mesh Renderers Found");
        else
        {
            m_ChildMeshRenderers = l_MeshRenderers;

            Debug.Log("Found " + m_ChildMeshRenderers.Length.ToString() + " Renderers");
        }
    }

    private void OnCollisionEnter(Collision in_CollisionData)
    {
        if (in_CollisionData.collider.tag == "RenderRoomCollider")
        {
            Debug.Log("Render The Room");
            foreach (MeshRenderer i in m_ChildMeshRenderers)
            {
                i.enabled = true;
            }
        }
        else
            return;
    }
    private void OnCollisionExit(Collision in_CollisionData)
    {
        if (in_CollisionData.collider.tag == "RenderRoomCollider")
        {
            Debug.Log("Stop Rendering The Room");
            foreach (MeshRenderer i in m_ChildMeshRenderers)
            {
                i.enabled = false;
            }
        }
        else
            return;
    }
}
