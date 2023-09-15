//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Player2ControlsMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Player2ControlsMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player2ControlsMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player2ControlsMap"",
    ""maps"": [
        {
            ""name"": ""Player2Controls"",
            ""id"": ""fdebf798-078d-4e6b-a5c2-4500947aa9f7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5112c35d-1dbb-4766-928e-105e354d1761"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""7b8d3475-d8d0-47fc-b597-6ef044414575"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""714dc93b-7b6f-4ba2-9556-0eddab097d18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""9abc8ae9-ab58-4397-925f-8d743b242627"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b754318-3557-44e6-aa4d-509e7f56ad94"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a91749c-2150-4cce-800f-28745cbbde1d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""875241f2-b284-4425-b625-b107e7ae2bd5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6b9a376-1094-40f9-b83d-98b62e02d85e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player2Controls
        m_Player2Controls = asset.FindActionMap("Player2Controls", throwIfNotFound: true);
        m_Player2Controls_Movement = m_Player2Controls.FindAction("Movement", throwIfNotFound: true);
        m_Player2Controls_Look = m_Player2Controls.FindAction("Look", throwIfNotFound: true);
        m_Player2Controls_Jump = m_Player2Controls.FindAction("Jump", throwIfNotFound: true);
        m_Player2Controls_Fire = m_Player2Controls.FindAction("Fire", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player2Controls
    private readonly InputActionMap m_Player2Controls;
    private IPlayer2ControlsActions m_Player2ControlsActionsCallbackInterface;
    private readonly InputAction m_Player2Controls_Movement;
    private readonly InputAction m_Player2Controls_Look;
    private readonly InputAction m_Player2Controls_Jump;
    private readonly InputAction m_Player2Controls_Fire;
    public struct Player2ControlsActions
    {
        private @Player2ControlsMap m_Wrapper;
        public Player2ControlsActions(@Player2ControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2Controls_Movement;
        public InputAction @Look => m_Wrapper.m_Player2Controls_Look;
        public InputAction @Jump => m_Wrapper.m_Player2Controls_Jump;
        public InputAction @Fire => m_Wrapper.m_Player2Controls_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player2Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2ControlsActions instance)
        {
            if (m_Wrapper.m_Player2ControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnJump;
                @Fire.started -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_Player2ControlsActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_Player2ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public Player2ControlsActions @Player2Controls => new Player2ControlsActions(this);
    public interface IPlayer2ControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}