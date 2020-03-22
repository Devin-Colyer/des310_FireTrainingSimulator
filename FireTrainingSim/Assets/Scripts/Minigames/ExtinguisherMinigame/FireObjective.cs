using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireObjective : MonoBehaviour
{
    private const float m_MaxFlameIntesity = 100f;
    private float m_FlameIntensitiy = 100f;

    public bool m_Burning{ get; private set; }
    ParticleSystem m_FireParticleEmitter;

    // Use this for initialization
    void Start()
    {
        m_Burning = true;
        m_FireParticleEmitter = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_FlameIntensitiy <= 0)
        {
            m_FireParticleEmitter.Stop();
            m_Burning = false;
        }
        else
        {
            ParticleSystem.MainModule m_FireParticleEmitterData = m_FireParticleEmitter.main;
            m_FireParticleEmitterData.startLifetime = m_FlameIntensitiy / m_MaxFlameIntesity;
        }
    }

    public void ExtinguishByPercentage(float in_reductionPercentage)
    {
        m_FlameIntensitiy -= in_reductionPercentage;
    }
}
