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
            ""name"": ""TestInputs"",
            ""id"": ""5b556e6d-352c-476e-8ccd-6fc7a76040de"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""Value"",
                    ""id"": ""56bbfdc6-4a75-4627-9b57-523a39df3242"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d14e888d-fb5e-4752-86e0-41dd97e84e5e"",
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
                    ""id"": ""19487955-76ba-4578-9a9d-a1f8dee2dc94"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5c68acf-8fba-4351-8d5b-d910befa9a10"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b1bbbe28-d518-413c-985b-1d8eda61597b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b4985851-8770-403e-8a8b-5300d4cf7944"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardTest"",
            ""bindingGroup"": ""KeyboardTest"",
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
        // TestInputs
        m_TestInputs = asset.FindActionMap("TestInputs", throwIfNotFound: true);
        m_TestInputs_WASD = m_TestInputs.FindAction("WASD", throwIfNotFound: true);
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

    // TestInputs
    private readonly InputActionMap m_TestInputs;
    private ITestInputsActions m_TestInputsActionsCallbackInterface;
    private readonly InputAction m_TestInputs_WASD;
    public struct TestInputsActions
    {
        private @TestInput m_Wrapper;
        public TestInputsActions(@TestInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_TestInputs_WASD;
        public InputActionMap Get() { return m_Wrapper.m_TestInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestInputsActions set) { return set.Get(); }
        public void SetCallbacks(ITestInputsActions instance)
        {
            if (m_Wrapper.m_TestInputsActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnWASD;
            }
            m_Wrapper.m_TestInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
            }
        }
    }
    public TestInputsActions @TestInputs => new TestInputsActions(this);
    private int m_KeyboardTestSchemeIndex = -1;
    public InputControlScheme KeyboardTestScheme
    {
        get
        {
            if (m_KeyboardTestSchemeIndex == -1) m_KeyboardTestSchemeIndex = asset.FindControlSchemeIndex("KeyboardTest");
            return asset.controlSchemes[m_KeyboardTestSchemeIndex];
        }
    }
    public interface ITestInputsActions
    {
        void OnWASD(InputAction.CallbackContext context);
    }
}
