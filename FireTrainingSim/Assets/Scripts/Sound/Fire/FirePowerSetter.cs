using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePowerSetter : MonoBehaviour {


    public int Definer_F_FirePowerValue;
    public FireSound FireSoundScript;

    void OnEnable()
    {
        FireSound.F_FirePowerValue = Definer_F_FirePowerValue;
        FireSoundScript.Fire.setParameterByName("FirePower", Definer_F_FirePowerValue);
    }
}
