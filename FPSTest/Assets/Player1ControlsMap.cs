//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Player1ControlsMap.inputactions
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

public partial class @Player1ControlsMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player1ControlsMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1ControlsMap"",
    ""maps"": [
        {
            ""name"": ""Player1Controls"",
            ""id"": ""54eb2dc9-1715-4156-8061-b6631876792a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d74565fd-af16-4212-9aac-b6b9968df1fe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3ad18a6f-1d87-439a-8d92-6a0c742a0736"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""749b3273-12cd-433e-9e4f-61fd9fec0d8a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""6428faf7-a3e9-48d9-9e96-ddc37c0deb4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f6ba4fc9-6765-4e84-965b-01682766ee32"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2a69bcc-c3cc-4e33-b004-4973835690eb"",
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
                    ""id"": ""58b24223-21ff-4f89-a4ff-1e10fa27f8d3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad6b7099-3fa1-46bd-a744-5e50c3c07d6d"",
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
        // Player1Controls
        m_Player1Controls = asset.FindActionMap("Player1Controls", throwIfNotFound: true);
        m_Player1Controls_Movement = m_Player1Controls.FindAction("Movement", throwIfNotFound: true);
        m_Player1Controls_Jump = m_Player1Controls.FindAction("Jump", throwIfNotFound: true);
        m_Player1Controls_Look = m_Player1Controls.FindAction("Look", throwIfNotFound: true);
        m_Player1Controls_Fire = m_Player1Controls.FindAction("Fire", throwIfNotFound: true);
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

    // Player1Controls
    private readonly InputActionMap m_Player1Controls;
    private IPlayer1ControlsActions m_Player1ControlsActionsCallbackInterface;
    private readonly InputAction m_Player1Controls_Movement;
    private readonly InputAction m_Player1Controls_Jump;
    private readonly InputAction m_Player1Controls_Look;
    private readonly InputAction m_Player1Controls_Fire;
    public struct Player1ControlsActions
    {
        private @Player1ControlsMap m_Wrapper;
        public Player1ControlsActions(@Player1ControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1Controls_Movement;
        public InputAction @Jump => m_Wrapper.m_Player1Controls_Jump;
        public InputAction @Look => m_Wrapper.m_Player1Controls_Look;
        public InputAction @Fire => m_Wrapper.m_Player1Controls_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Player1Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1ControlsActions instance)
        {
            if (m_Wrapper.m_Player1ControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_Player1ControlsActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_Player1ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public Player1ControlsActions @Player1Controls => new Player1ControlsActions(this);
    public interface IPlayer1ControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
