using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipParticles : MonoBehaviour
{
    [SerializeField]
    private GameObject thrusterParticles;
    [SerializeField]
    private GameObject deathParticleSystemPrefab;
    private void Awake()
    {
        GetComponent<ShipEngine>().ThrustChanged += HandleThrustChanged;

        if(GetComponent<ShipHealth>()!=null)
            GetComponent<ShipHealth>().OnDie += HandleShipDeath;

    }

    private void HandleThrustChanged(float thrust)
    {
        thrusterParticles.SetActive(thrust > 0);
    }

    private void HandleShipDeath()
    {
        Instantiate(deathParticleSystemPrefab, transform.position, Quaternion.identity);
    }
}
