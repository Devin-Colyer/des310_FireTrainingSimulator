using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherSounds : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string ExtinguisherEventPath;
    [SerializeField] [FMODUnity.EventRef] private string ExtinguisherStopEventPath;
    [SerializeField] [FMODUnity.EventRef] private string ExtinguisherPinOutEventPath;

    public FMOD.Studio.EventInstance Extinguisher;
    public FMOD.Studio.EventInstance ExtinguisherStop;
    public FMOD.Studio.EventInstance ExtinguisherPinOut;

    void OnEnable()
    {
        ExtinguisherPinOut = FMODUnity.RuntimeManager.CreateInstance(ExtinguisherPinOutEventPath);
        ExtinguisherPinOut.start();
        ExtinguisherStop = FMODUnity.RuntimeManager.CreateInstance(ExtinguisherStopEventPath);
        Extinguisher = FMODUnity.RuntimeManager.CreateInstance(ExtinguisherEventPath);
    }


    public void FireExtinguisher()
    {
        Extinguisher.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        ExtinguisherStop.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        Extinguisher.start();
        Debug.Log("PLAY");
    }

    public void StopExtinguisher()
    {
        Extinguisher.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        ExtinguisherStop.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        ExtinguisherStop.start();
        Debug.Log("STOP");
    }










    //void Update()
    //{
    //    if (ExtinguisherMinigameCamera.activeSelf==false)
    //    {
    //        Debug.Log("Fin");
    //    }
    //    else if (ExtinguisherMinigameCamera.activeSelf == true)
    //    {
    //        Debug.Log("Debut");
    //    }
    //}

    //void OnDiasable()
    //{
    //    Extinguisher.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    //    ExtinguisherStop.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    //    Debug.Log("");
    //}

}
