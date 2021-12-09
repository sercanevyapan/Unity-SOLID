using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DamageDealer : MonoBehaviour
{
   

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            DealDamageToNearestCharacter();
        }
    }

    private void DealDamageToNearestCharacter()
    {
        Character nearestCharacter = FindObjectsOfType<Character>().OrderBy(t => Vector3.Distance(transform.position, t.transform.position)).FirstOrDefault();

        int damageToDeal = 1;

        nearestCharacter.TakeDamage(damageToDeal);
    }
}
