// GENERATED AUTOMATICALLY FROM 'Assets/SampleMaterials/InputSubscriberTesting/TestInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TestInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestInput"",
    ""maps"": [
        {
            ""name"": ""DefaultActions"",
            ""id"": ""da4f6f0f-91dd-48c7-9c03-b6b9ef0b60a9"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""7f6c3500-e2e3-41cb-8df8-3c8090365b49"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Value"",
                    ""id"": ""9440daf7-7486-40a2-9c18-a21bd91a2794"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Value"",
                    ""id"": ""7dbb19e1-13eb-401b-ae85-2afad447c806"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ae8ad5b4-1b7d-4661-a603-d00619aef7fd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eae7f329-0b00-4add-80ff-5e77bb784ed8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOnly"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ce02b4b3-da59-4835-ba2f-2049fd8bbd42"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOnly"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ebc93ea9-5237-4607-9345-ee0c38714518"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOnly"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5cd25735-1052-4738-b7b1-9718d989aed1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOnly"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d263a149-0a45-4d3d-8b8f-96d88dcda5ef"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOnly"",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66fde46f-fc01-4a45-b90b-f4350edb1814"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOnly"",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardOnly"",
            ""bindingGroup"": ""KeyboardOnly"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // DefaultActions
        m_DefaultActions = asset.FindActionMap("DefaultActions", throwIfNotFound: true);
        m_DefaultActions_WASD = m_DefaultActions.FindAction("WASD", throwIfNotFound: true);
        m_DefaultActions_Space = m_DefaultActions.FindAction("Space", throwIfNotFound: true);
        m_DefaultActions_Esc = m_DefaultActions.FindAction("Esc", throwIfNotFound: true);
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

    // DefaultActions
    private readonly InputActionMap m_DefaultActions;
    private IDefaultActionsActions m_DefaultActionsActionsCallbackInterface;
    private readonly InputAction m_DefaultActions_WASD;
    private readonly InputAction m_DefaultActions_Space;
    private readonly InputAction m_DefaultActions_Esc;
    public struct DefaultActionsActions
    {
        private @TestInput m_Wrapper;
        public DefaultActionsActions(@TestInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_DefaultActions_WASD;
        public InputAction @Space => m_Wrapper.m_DefaultActions_Space;
        public InputAction @Esc => m_Wrapper.m_DefaultActions_Esc;
        public InputActionMap Get() { return m_Wrapper.m_DefaultActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActionsActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActionsActions instance)
        {
            if (m_Wrapper.m_DefaultActionsActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnWASD;
                @Space.started -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnSpace;
                @Esc.started -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_DefaultActionsActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_DefaultActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public DefaultActionsActions @DefaultActions => new DefaultActionsActions(this);
    private int m_KeyboardOnlySchemeIndex = -1;
    public InputControlScheme KeyboardOnlyScheme
    {
        get
        {
            if (m_KeyboardOnlySchemeIndex == -1) m_KeyboardOnlySchemeIndex = asset.FindControlSchemeIndex("KeyboardOnly");
            return asset.controlSchemes[m_KeyboardOnlySchemeIndex];
        }
    }
    public interface IDefaultActionsActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
    }
}
