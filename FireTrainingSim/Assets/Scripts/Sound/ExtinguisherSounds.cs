using UnityEngine;

public class ExtinguisherSounds : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string m_ExtinguisherEventPath;
    [SerializeField] [FMODUnity.EventRef] private string m_ExtinguisherStopEventPath;
    [SerializeField] [FMODUnity.EventRef] private string m_ExtinguisherPinOutEventPath;

    public FMOD.Studio.EventInstance m_Extinguisher;
    public FMOD.Studio.EventInstance m_ExtinguisherStop;
    public FMOD.Studio.EventInstance m_ExtinguisherPinOut;

    void OnEnable()
    {
        m_ExtinguisherPinOut = FMODUnity.RuntimeManager.CreateInstance(m_ExtinguisherPinOutEventPath);
        m_ExtinguisherPinOut.start();
        m_ExtinguisherStop = FMODUnity.RuntimeManager.CreateInstance(m_ExtinguisherStopEventPath);
        m_Extinguisher = FMODUnity.RuntimeManager.CreateInstance(m_ExtinguisherEventPath);
    }


    public void FireExtinguisher()
    {
        m_Extinguisher.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        m_ExtinguisherStop.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        m_Extinguisher.start();
        Debug.Log("PLAY");
    }

    public void StopExtinguisher()
    {
        m_Extinguisher.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        m_ExtinguisherStop.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        m_ExtinguisherStop.start();
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
