using UnityEngine;

public class BoxSounds : MonoBehaviour 
{
    [Header("FMOD Settings")]

    [SerializeField] [FMODUnity.EventRef] private string m_BoxPickupEventPath;
    [SerializeField] [FMODUnity.EventRef] private string m_BoxDropEventPath;
    [SerializeField] [FMODUnity.EventRef] private string m_BoxHitEventPath;


    public static FMOD.Studio.EventInstance m_BoxPickup;
    public static FMOD.Studio.EventInstance m_BoxDrop;
    public static FMOD.Studio.EventInstance m_BoxHit;

    public void FBoxPickup()
    {
        m_BoxPickup = FMODUnity.RuntimeManager.CreateInstance(m_BoxPickupEventPath);
        m_BoxPickup.start();
        //Debug.Log("BoxSound1");
    }


    public void FBoxDrop()
    {
        m_BoxPickup = FMODUnity.RuntimeManager.CreateInstance(m_BoxDropEventPath);
        m_BoxPickup.start();
        //Debug.Log("BoxSound2");
    }

    public void FBoxHit()
    {
        m_BoxPickup = FMODUnity.RuntimeManager.CreateInstance(m_BoxHitEventPath);
        m_BoxPickup.start();
        Debug.Log("BoxSound3");
    }


}
