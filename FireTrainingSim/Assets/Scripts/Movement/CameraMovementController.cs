using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementController : MonoBehaviour {

    Vector3 m_CamDestintaion;

    // Use this for initialization
    private void Start()
    {
        m_CamDestintaion = new Vector3(this.transform.position.x + 22, this.transform.position.y, this.transform.position.z + 22);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
