using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Dialogue : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string DialogueEventPath;
    public int F_DialogueValue;


	// Use this for initialization
	void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Touchdown");
        if (collision.gameObject.name == "Player")
        {

            FMOD.Studio.EventInstance ThirdPersonSounds = FMODUnity.RuntimeManager.CreateInstance(DialogueEventPath);
            ThirdPersonSounds.setParameterByName("Dialogue", F_DialogueValue);
            ThirdPersonSounds.start();

            Debug.Log("Speak" + "Yo" + F_DialogueValue);
            if (F_DialogueValue == 0)
            {
                Debug.Log("BiteDe0+");
            }
            else if (F_DialogueValue == 1)
            {
                Debug.Log("BiteDe1+");
            }

            Destroy(gameObject);

        }
    }
	

}
