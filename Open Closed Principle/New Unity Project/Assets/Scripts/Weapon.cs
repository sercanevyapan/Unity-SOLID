using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private ILauncher launcher;

    [SerializeField]
    private float fireRefreshRate = 1;

    private float nextFireTime;
    private void Awake()
    {
        launcher = GetComponent<ILauncher>();
    }

   
    void Update()
    {
        if (CanFire() && Input.GetButtonDown("Fire1"))
        {
            FireWeapon();
        }
    }

    private bool CanFire()
    {
        return Time.time >= nextFireTime;
    }

    private void FireWeapon()
    {
        nextFireTime = Time.time + fireRefreshRate;
        launcher.Launch(this);
    }
}
