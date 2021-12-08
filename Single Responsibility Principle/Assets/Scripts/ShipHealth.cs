using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;
    private int health;

    public event Action OnDie = delegate { };

    private void Awake()
    {
        health = maxHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var projectile = collision.collider.GetComponent<Projectile>();
        if (projectile != null)
            TakeDamage(projectile.Damage);
    }

    private void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Die();
    }

    private void Die()
    {
        OnDie();
        Destroy(gameObject);
    }
}
