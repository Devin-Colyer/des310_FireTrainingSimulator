using System;
using UnityEngine;

[Obsolete("I'm for testing.")]
public class SpaceToWin : MonoBehaviour {

    public Camera m_RoomCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_RoomCamera.enabled = true;
            gameObject.SetActive(false);
        }
	}
}
