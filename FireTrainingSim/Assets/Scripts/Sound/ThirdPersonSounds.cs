using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThirdPersonSounds : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string FootstepsEventPath;
    [SerializeField] private string Material;
    public string[] MaterialTypes;
    [SerializeField] private float RayDistance = 1.2f;
    public int DefaultMaterialValue;                           // This will be told by the 'FMODStudioFootstepsEditor' script which Material has been set as the defualt. It will then store the value of that Material for outhis script to use. This cannot be changed in the Editor, but a drop down menu created by the 'FMODStudioFootstepsEditor' script can.



    private RaycastHit hit;
    private int F_MaterialValue;
    public int Yo = 1;



    void MaterialCheck() // This method when performed will find out what material our player is currenly on top of and will update the value of 'F_MaterialValue' accordingly, to represent that value.
    {
        Debug.Log("1");
        if (Physics.Raycast(transform.position, Vector3.down, out hit, RayDistance))                                 // A raycast is fired down, from the position that the player is curenntly standing at, traveling as far as we decide to set the 'RayDistance' variable to. Infomration about the object it comes into contact with will then be stored inside the 'hit' variable for us to access.
        {
            Debug.Log("2");
            if (hit.collider.gameObject.GetComponent<MaterialSetter>())                                    // Using the 'hit' varibale, we check to see if the raycast has hit a collider attached to a gameobject, that also has the 'FMODStudioMaterialSetter' script attached to it as a component...
            {
                Debug.Log("3");
                F_MaterialValue = hit.collider.gameObject.GetComponent<MaterialSetter>().MaterialValue;    // ...and if it did, we then set our 'F_MaterialValue' varibale to match whatever value the 'MaterialValue' variable (which is inside the 'F_MaterialValue' varibale) is currently set to.
            }
            else                                                                                                     // Else if however, the player is standing on an object that doesn't have a 'FMODStudioMaterialSetter' script component for our raycast to find...
                Debug.Log("4");
            F_MaterialValue = DefaultMaterialValue;                                                              // ...we then set 'F_MaterialValue' to match the value of 'DefulatMaterialValue'. 'DefulatMaterialValue' is given a value by the 'FMODStudioFootstepsEditor' script. This value represents whatever material we have selected as our 'DefulatMaterial' in the Unity Inspector tab.
        }
        else                                                                                                         // Else if however, the raycast can't find a collider attached to the object at all...
            Debug.Log("5");
        F_MaterialValue = DefaultMaterialValue;                                                                  // Then again, we set 'F_MaterialValue' to match the value of 'DefulatMaterialValue'.
    }

    private void Footstep()
    {
        MaterialCheck();
        FMOD.Studio.EventInstance Footsteps = FMODUnity.RuntimeManager.CreateInstance(FootstepsEventPath);        // If they are, we create an FMOD event instance. We use the event path inside the 'FootstepsEventPath' variable to find the event we want to play.
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Footsteps, transform, GetComponent<Rigidbody>());     // Next that event instance is told to play at the location that our player is currently at.
        Footsteps.setParameterByName("Material", F_MaterialValue);                                                 // Before the event is played, we set the Material Parameter to match the value of the 'F_MaterialValue' variable.
        Footsteps.start();                                                                                        // We then play a footstep!.
        /*Footsteps.release();    */                                                                                  // We also set our event instance to release straight after we tell it to play, so that the instance is released once the event had finished playing.
    Debug.Log("step"+"yo"+Yo+F_MaterialValue);
    }





    //Old Script

    // FMOD event to trigger a footstep sound.
    //[FMODUnity.EventRef]
    //public string footStepsSound;

    //public static FMOD.Studio.EventInstance footstepsEv;

    ////Surface variables btwn 0.0f-1.0f to change volume of each sound material
    //public float m_Concrete;
    //public float m_Metal;
    //public float m_Vinyl;
    //public float m_Carpet;

    //private void Start()
    //{
    //    footstepsEv = FMODUnity.RuntimeManager.CreateInstance(footStepsSound);

    //    footstepsEv.setParameterByName("Concrete", m_Concrete);
    //    footstepsEv.setParameterByName("Metal", m_Metal);
    //    footstepsEv.setParameterByName("Vinyl", m_Vinyl);
    //    footstepsEv.setParameterByName("Carpet", m_Carpet);

    //    FMODUnity.RuntimeManager.PlayOneShot(footStepsSound);
    //}


    //// Called each time player animation timeline pass through "Footstep" event
    //private void Footstep()
    //{
    //    footstepsEv.setParameterByName("Concrete", m_Concrete);
    //    footstepsEv.setParameterByName("Metal", m_Metal);
    //    footstepsEv.setParameterByName("Vinyl", m_Vinyl);
    //    footstepsEv.setParameterByName("Carpet", m_Carpet);

    //    FMODUnity.RuntimeManager.PlayOneShot(footStepsSound);
    //    Debug.Log("step");
    //}


}
