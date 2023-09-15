using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJoin : MonoBehaviour
{
    private PlayerInputManager inputManager;

    private void Awake()
    {
        inputManager = GetComponent<PlayerInputManager>();
    }

    public void OnPlayerJoin()
    {
        if (inputManager.playerCount >= 2) { return; }
        inputManager.JoinPlayer();
    }

    public void OnPLayerLeave()
    {

    }
}
