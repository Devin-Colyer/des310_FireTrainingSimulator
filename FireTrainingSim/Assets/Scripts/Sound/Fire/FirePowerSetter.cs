using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePowerSetter : MonoBehaviour {


    public int m_FFirePowerValueDefiner;
    public FireSound m_FireSoundScript;

    void OnEnable()
    {
        FireSound.m_FFirePowerValue = m_FFirePowerValueDefiner;
        m_FireSoundScript.m_Fire.setParameterByName("FirePower", m_FFirePowerValueDefiner);
    }
}
