using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{
    public override void Fire()
    {
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
    }


    public Pistol Innit(GameObject bullet, Transform spawnPoint)
    {
        bulletPrefab = bullet;
        bulletSpawn = spawnPoint;
        return this;
    }
}
