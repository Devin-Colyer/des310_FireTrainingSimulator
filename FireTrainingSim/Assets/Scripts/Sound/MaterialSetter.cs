//Attach this script as a component to every surface the player will be able to walk ontop of.

using UnityEngine;

public class MaterialSetter : MonoBehaviour
{
    public int MaterialValue; // This value will represent that Material Type you set. It will be read by the 'FMODStudioFirstPersonFootsteps' script and set by us using a dropdown menu inside the inspector tab when interacting with this script attached to a surface. The dropdown menu will be created by the 'FMODStudioFootstepsEditor' script.
    public int DefinerF_MaterialValue;

    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Touchdown");
        if (collision.gameObject.name == "Player")
        {
            
            ThirdPersonSounds.F_MaterialValue = DefinerF_MaterialValue;
            
            //Debug.Log("TouchdownPlayer");
            
        }
    }


}
