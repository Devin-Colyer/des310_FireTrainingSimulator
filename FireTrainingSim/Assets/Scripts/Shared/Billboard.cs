using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
        if (Camera.main.orthographic)
        {
            // Force object to face parallel to the camera.
            this.transform.forward = -Camera.main.transform.forward;
        }
        else
        {
            // Force object to look at camera.
            this.transform.LookAt(Camera.main.transform);
        }
    }
}
