using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public float fireCD;
    public int magSize;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    //probably positions and rotations but might be better to bake those into prefabs that are spawned in

    public abstract void Fire();
}
