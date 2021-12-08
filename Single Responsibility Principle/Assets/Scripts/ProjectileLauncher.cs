using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    private Rigidbody projectilePrefab;
    [SerializeField]
    private Transform weaponMountPoint;
    [SerializeField]
    private float fireForce = 300f;
    private void Awake()
    {
        GetComponent<ShipInput>().OnFire += HandleFire;
    }

    private void HandleFire()
    {
        var spawnedProjectile = Instantiate(projectilePrefab, weaponMountPoint.position, weaponMountPoint.rotation);
        spawnedProjectile.AddForce(spawnedProjectile.transform.forward * fireForce);
    }

   
}
