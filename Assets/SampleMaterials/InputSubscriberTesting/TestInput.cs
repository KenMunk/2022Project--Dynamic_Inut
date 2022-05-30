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
                },
                {
                    ""name"": ""Num1"",
                    ""type"": ""Button"",
                    ""id"": ""5312cee8-6a8b-4867-8601-f3b2d5903bd9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num2"",
                    ""type"": ""Button"",
                    ""id"": ""99c4748c-29b1-43b6-8c59-408c92853e61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num3"",
                    ""type"": ""Button"",
                    ""id"": ""b7f7d101-8954-466a-bff0-8a08a99c6031"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num4"",
                    ""type"": ""Button"",
                    ""id"": ""953e0df2-218f-4c81-8296-f8fcc4da88a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num5"",
                    ""type"": ""Button"",
                    ""id"": ""f2330043-9ac7-4a58-891a-e2400a9717dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num6"",
                    ""type"": ""Button"",
                    ""id"": ""63c96fdc-bf66-467e-b940-0b0ba09e52bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num7"",
                    ""type"": ""Button"",
                    ""id"": ""8b17fcd7-e07f-4799-9293-3b90d5d31c2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num8"",
                    ""type"": ""Button"",
                    ""id"": ""529d414b-e0e7-4328-b354-06fcaf37c301"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Num9"",
                    ""type"": ""Button"",
                    ""id"": ""e005eb97-ed93-483d-8941-c5033c811d07"",
                    ""expectedControlType"": ""Button"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""eeb27409-03dc-4fec-9a5f-cd0736efce11"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0533b829-108c-4d9b-94fc-7a2ba225bb4f"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd6d7bdb-11c0-4cfe-8a9a-67134af9d6a3"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26156497-dc5a-48f6-809c-4ec6acd8ba32"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b56ae461-8d6a-429d-8129-4b7eb95c1c31"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb258054-854a-4d24-baf6-c98f0f5f4d05"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f67a01b-af07-4d25-bbf3-e9c76bab2e6d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fde3659-1b34-4aef-b038-64258f961067"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6caa68d-d264-4163-a63b-7f66e5ec8961"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69b7f0e3-7194-40b5-82a0-ffeb595c7173"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29317d3e-7533-417a-8d90-a0267a615e0e"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b286759-1a56-4d2b-87ed-e197a1c99a5f"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c513bd4e-1039-44e4-aa8f-1f8c8929ba3a"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""447671ad-21a1-4568-9689-3fd7950269a6"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5d6addf-52f6-488b-852c-2de3d6bef33f"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66571182-34ac-4e60-a901-f906b7889ee2"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c2c50a0-7686-4bca-80d1-e574a78a8280"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d71c1026-0ed6-4518-b2b7-4832cf9b0d93"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardTest"",
                    ""action"": ""Num9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        m_TestInputs_Num1 = m_TestInputs.FindAction("Num1", throwIfNotFound: true);
        m_TestInputs_Num2 = m_TestInputs.FindAction("Num2", throwIfNotFound: true);
        m_TestInputs_Num3 = m_TestInputs.FindAction("Num3", throwIfNotFound: true);
        m_TestInputs_Num4 = m_TestInputs.FindAction("Num4", throwIfNotFound: true);
        m_TestInputs_Num5 = m_TestInputs.FindAction("Num5", throwIfNotFound: true);
        m_TestInputs_Num6 = m_TestInputs.FindAction("Num6", throwIfNotFound: true);
        m_TestInputs_Num7 = m_TestInputs.FindAction("Num7", throwIfNotFound: true);
        m_TestInputs_Num8 = m_TestInputs.FindAction("Num8", throwIfNotFound: true);
        m_TestInputs_Num9 = m_TestInputs.FindAction("Num9", throwIfNotFound: true);
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
    private readonly InputAction m_TestInputs_Num1;
    private readonly InputAction m_TestInputs_Num2;
    private readonly InputAction m_TestInputs_Num3;
    private readonly InputAction m_TestInputs_Num4;
    private readonly InputAction m_TestInputs_Num5;
    private readonly InputAction m_TestInputs_Num6;
    private readonly InputAction m_TestInputs_Num7;
    private readonly InputAction m_TestInputs_Num8;
    private readonly InputAction m_TestInputs_Num9;
    public struct TestInputsActions
    {
        private @TestInput m_Wrapper;
        public TestInputsActions(@TestInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_TestInputs_WASD;
        public InputAction @Num1 => m_Wrapper.m_TestInputs_Num1;
        public InputAction @Num2 => m_Wrapper.m_TestInputs_Num2;
        public InputAction @Num3 => m_Wrapper.m_TestInputs_Num3;
        public InputAction @Num4 => m_Wrapper.m_TestInputs_Num4;
        public InputAction @Num5 => m_Wrapper.m_TestInputs_Num5;
        public InputAction @Num6 => m_Wrapper.m_TestInputs_Num6;
        public InputAction @Num7 => m_Wrapper.m_TestInputs_Num7;
        public InputAction @Num8 => m_Wrapper.m_TestInputs_Num8;
        public InputAction @Num9 => m_Wrapper.m_TestInputs_Num9;
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
                @Num1.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum1;
                @Num1.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum1;
                @Num1.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum1;
                @Num2.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum2;
                @Num2.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum2;
                @Num2.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum2;
                @Num3.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum3;
                @Num3.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum3;
                @Num3.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum3;
                @Num4.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum4;
                @Num4.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum4;
                @Num4.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum4;
                @Num5.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum5;
                @Num5.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum5;
                @Num5.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum5;
                @Num6.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum6;
                @Num6.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum6;
                @Num6.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum6;
                @Num7.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum7;
                @Num7.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum7;
                @Num7.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum7;
                @Num8.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum8;
                @Num8.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum8;
                @Num8.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum8;
                @Num9.started -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum9;
                @Num9.performed -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum9;
                @Num9.canceled -= m_Wrapper.m_TestInputsActionsCallbackInterface.OnNum9;
            }
            m_Wrapper.m_TestInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @Num1.started += instance.OnNum1;
                @Num1.performed += instance.OnNum1;
                @Num1.canceled += instance.OnNum1;
                @Num2.started += instance.OnNum2;
                @Num2.performed += instance.OnNum2;
                @Num2.canceled += instance.OnNum2;
                @Num3.started += instance.OnNum3;
                @Num3.performed += instance.OnNum3;
                @Num3.canceled += instance.OnNum3;
                @Num4.started += instance.OnNum4;
                @Num4.performed += instance.OnNum4;
                @Num4.canceled += instance.OnNum4;
                @Num5.started += instance.OnNum5;
                @Num5.performed += instance.OnNum5;
                @Num5.canceled += instance.OnNum5;
                @Num6.started += instance.OnNum6;
                @Num6.performed += instance.OnNum6;
                @Num6.canceled += instance.OnNum6;
                @Num7.started += instance.OnNum7;
                @Num7.performed += instance.OnNum7;
                @Num7.canceled += instance.OnNum7;
                @Num8.started += instance.OnNum8;
                @Num8.performed += instance.OnNum8;
                @Num8.canceled += instance.OnNum8;
                @Num9.started += instance.OnNum9;
                @Num9.performed += instance.OnNum9;
                @Num9.canceled += instance.OnNum9;
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
        void OnNum1(InputAction.CallbackContext context);
        void OnNum2(InputAction.CallbackContext context);
        void OnNum3(InputAction.CallbackContext context);
        void OnNum4(InputAction.CallbackContext context);
        void OnNum5(InputAction.CallbackContext context);
        void OnNum6(InputAction.CallbackContext context);
        void OnNum7(InputAction.CallbackContext context);
        void OnNum8(InputAction.CallbackContext context);
        void OnNum9(InputAction.CallbackContext context);
    }
}
