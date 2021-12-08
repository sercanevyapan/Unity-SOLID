using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour, ILauncher
{
    [SerializeField]
    private Bullet bulletPrefab;
    public void Launch(Weapon weapon)
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.Launch(weapon.transform.forward);
    }
}
