using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMinigame : MonoBehaviour
{
    public GameObject m_cameraController;
    public string m_minigame;

    public AK.Wwise.Switch MusicScitch = new AK.Wwise.Switch();
    public AK.Wwise.Event Music = new AK.Wwise.Event();

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            // Make sure object has a glow component.
            if (this.transform.parent.GetComponentInChildren<GlowComponent>())
            {
                // Fade in glow when near hazard.
                this.transform.parent.GetComponentInChildren<GlowComponent>().FadeIn();
            }
            if(Input.GetKeyDown("e"))
            {
                Invoke("test", 2);
                //Music.Post(gameObject);
                //MusicScitch.SetValue(gameObject);

               
            }
           
        }
    }

    public void test()
    {
        m_cameraController.GetComponent<CameraController>().ChangeCamera(m_minigame);
    }

    private void OnTriggerExit(Collider other)
    {
        // Make sure object has a glow component.
        if (this.transform.parent.GetComponentInChildren<GlowComponent>())
        {
            // Fade out glow when away from hazard.
            this.transform.parent.GetComponentInChildren<GlowComponent>().FadeOut();
        }
    }
}
