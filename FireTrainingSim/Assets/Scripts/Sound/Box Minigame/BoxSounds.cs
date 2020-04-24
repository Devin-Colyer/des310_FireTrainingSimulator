using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSounds : MonoBehaviour 
{
    [Header("FMOD Settings")]

    [SerializeField] [FMODUnity.EventRef] private string BoxPickupEventPath;
    [SerializeField] [FMODUnity.EventRef] private string BoxDropEventPath;
    [SerializeField] [FMODUnity.EventRef] private string BoxHitEventPath;


    public static FMOD.Studio.EventInstance BoxPickup;
    public static FMOD.Studio.EventInstance BoxDrop;
    public static FMOD.Studio.EventInstance BoxHit;

    public void F_BoxPickup()
    {
        BoxPickup = FMODUnity.RuntimeManager.CreateInstance(BoxPickupEventPath);
        BoxPickup.start();
        Debug.Log("BoxSound1");
    }


    public void F_BoxDrop()
    {
        BoxPickup = FMODUnity.RuntimeManager.CreateInstance(BoxDropEventPath);
        BoxPickup.start();
        Debug.Log("BoxSound2");
    }

    public void F_BoxHit()
    {
        BoxPickup = FMODUnity.RuntimeManager.CreateInstance(BoxHitEventPath);
        BoxPickup.start();
        Debug.Log("BoxSound3");
    }


}
