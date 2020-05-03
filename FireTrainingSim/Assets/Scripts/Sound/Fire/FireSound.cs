using UnityEngine;

public class FireSound : MonoBehaviour {

    [Header("FMOD Settings")]
    [SerializeField] [FMODUnity.EventRef] private string m_FireEventPath;

    // Hear fire from: 0= Nowhere 1=OtherRoom 2=Concerned Room 3=Minigame
    public static int m_FFirePowerValue = 1;

    public FMOD.Studio.EventInstance m_Fire;

    void Start()
    {
        m_Fire = FMODUnity.RuntimeManager.CreateInstance(m_FireEventPath);
        m_Fire.setParameterByName("FirePower", m_FFirePowerValue);
        m_Fire.start();
    }

    //public void ChangeFirePower()
    //{

    //    Fire = FMODUnity.RuntimeManager.CreateInstance(FireEventPath);
    //    Fire.setParameterByName("FirePower", F_FirePowerValue);
    //    Debug.Log("testy" + F_FirePowerValue);
    //}

}
