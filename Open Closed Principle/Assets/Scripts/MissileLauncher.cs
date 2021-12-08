using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour, ILauncher
{
    [SerializeField]
    private Missile missilePrefab;
    public void Launch(Weapon weapon)
    {
        Transform target = FindObjectOfType<Transform>();
        var missile = Instantiate(missilePrefab);
        missile.SetTarget(target);
    }
}
