using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSocket : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    private float fireCDTimer = 0f;

    public Player1ControlsMap input;

    private Gun weaponSocket;


    private void Awake()
    {
        input = GetComponent<Movement>().input;
    }
    private void Start()
    {
        weaponSocket = new Pistol().Innit(bulletPrefab, bulletSpawn);
        
    }

    // Update is called once per frame
    void Update()
    {
        fireCDTimer += Time.deltaTime;
        if (input.Player1Controls.Fire.triggered && fireCDTimer >= 0.25f)
        {
            fireCDTimer = 0;
            weaponSocket.Fire();
        }
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }
}
