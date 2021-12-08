using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFull : MonoBehaviour
{

    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private Rigidbody projectile;
    [SerializeField]
    private Transform weaponMountPoint;
    [SerializeField]
    private float fireForce = 300f;
    [SerializeField]
    private float turnSpeed = 5f;
    [SerializeField]
    private GameObject thrusterParticles;
    [SerializeField]
    private int maxHealth = 100;
    [SerializeField]
    private GameObject deathParticleSystemPrefab;

    private int health;

    private void Awake()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            FireWeapon();

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.position += Time.deltaTime * vertical * transform.forward * speed;
        transform.Rotate(Vector3.up * horizontal * turnSpeed * Time.deltaTime);

        thrusterParticles.SetActive(vertical > 0);
            
    }

    private void FireWeapon()
    {
        var spawnedProjectile = Instantiate(projectile, weaponMountPoint.position, weaponMountPoint.rotation);
        spawnedProjectile.AddForce(spawnedProjectile.transform.forward * fireForce);
    }


    private void OnCollisionEnter(Collision collision)
    {
        //var projectile = collision.collider.GetComponent<Projectile>();
        //if (projectile != null)
        //    TakeDamage(projectile.Damage);
    }

    private void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Die();
    }

    private void Die()
    {
        Instantiate(deathParticleSystemPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
