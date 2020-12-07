using KartGame.KartSystems;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public ParticleSystem fire;

    private ArcadeKart m_Kart;

    private float m_BaseTopSpeed = 0;

    private float m_BaseAcceleration = 0;

    void Start()
    {
        m_Kart = GetComponent<ArcadeKart>();
        m_BaseTopSpeed = m_Kart.baseStats.TopSpeed;
        m_BaseAcceleration = m_Kart.baseStats.Acceleration;

        fire.Stop();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (fire.isStopped)
                fire.Play();

            m_Kart.baseStats.TopSpeed = m_BaseTopSpeed * 3;
            m_Kart.baseStats.Acceleration = m_BaseAcceleration * 3;
        }
        else
        {
            m_Kart.baseStats.TopSpeed = m_BaseTopSpeed;
            m_Kart.baseStats.Acceleration = m_BaseAcceleration;

            if (fire.isPlaying)
                fire.Stop();
        }
    }
}
