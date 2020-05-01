using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSound : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string FireEventPath;

    // Hear fire from: 0= Nowhere 1=OtherRoom 2=Concerned Room 3=Minigame
    public static int F_FirePowerValue=1;

    public FMOD.Studio.EventInstance Fire;

    void Start()
    {
        Fire = FMODUnity.RuntimeManager.CreateInstance(FireEventPath);
        Fire.setParameterByName("FirePower", F_FirePowerValue);
        Fire.start();
    }

    //public void ChangeFirePower()
    //{

    //    Fire = FMODUnity.RuntimeManager.CreateInstance(FireEventPath);
    //    Fire.setParameterByName("FirePower", F_FirePowerValue);
    //    Debug.Log("testy" + F_FirePowerValue);
    //}

}
