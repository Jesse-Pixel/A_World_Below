// GENERATED AUTOMATICALLY FROM 'Assets/Input/ShipInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ShipInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ShipInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ShipInput"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""905a781b-0ce1-4d1b-a2a3-0b99b338e207"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc2b636f-62fd-4d2c-8e66-3226aac98c99"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseAim"",
                    ""type"": ""Value"",
                    ""id"": ""f2f0639e-6237-4d07-91e8-ac77ab664d04"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AnalogAim"",
                    ""type"": ""Value"",
                    ""id"": ""055ed141-db20-4f6f-af11-82f77a8ce8e1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c137f59d-a445-4ecc-abe3-3daa33d12256"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomWheel"",
                    ""type"": ""Value"",
                    ""id"": ""f72004ad-11f6-4690-9136-13b7e8f89348"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomIn"",
                    ""type"": ""Button"",
                    ""id"": ""a6be2e93-5099-4a3d-9d1e-56c0beefd081"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ZoomOut"",
                    ""type"": ""Button"",
                    ""id"": ""bd362635-fda5-4a29-aa6d-99501c36c85e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""512495ca-f902-4a53-a6e8-863016f36c73"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b33c7b8d-c632-4ecf-987c-944d1308a998"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""edc5d2ab-a0ad-43a9-a044-596aaa20d7c6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""27f54279-b859-4a56-a632-0be200320b5b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""52555d3d-2238-4179-baba-215f92ab0b08"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""db616c41-9131-43ea-b38b-6fc6c66f4ff3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33180af7-63e6-45a0-bace-98d0d9c6d0e6"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MouseAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8663db26-54af-4e65-aad7-fc79dfcdebd9"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Controller"",
                    ""action"": ""AnalogAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff58f3e1-2cb9-4c27-bf7a-e91e005034ab"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2278699a-2723-4a16-bb5f-1bcdb8aad996"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e23d95a-363d-4eb2-adc7-6682d0d5e2da"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3e91beb-4aee-424b-a84b-1f5d5596cdd2"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""ZoomWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""085ec08b-7bb5-4775-8285-d32bb0167729"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ZoomIn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf081adf-d6e7-4cd2-a428-913f567c167d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZoomOut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseKeyboard"",
            ""bindingGroup"": ""MouseKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Movement = m_Ship.FindAction("Movement", throwIfNotFound: true);
        m_Ship_MouseAim = m_Ship.FindAction("MouseAim", throwIfNotFound: true);
        m_Ship_AnalogAim = m_Ship.FindAction("AnalogAim", throwIfNotFound: true);
        m_Ship_Shoot = m_Ship.FindAction("Shoot", throwIfNotFound: true);
        m_Ship_ZoomWheel = m_Ship.FindAction("ZoomWheel", throwIfNotFound: true);
        m_Ship_ZoomIn = m_Ship.FindAction("ZoomIn", throwIfNotFound: true);
        m_Ship_ZoomOut = m_Ship.FindAction("ZoomOut", throwIfNotFound: true);
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

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_Movement;
    private readonly InputAction m_Ship_MouseAim;
    private readonly InputAction m_Ship_AnalogAim;
    private readonly InputAction m_Ship_Shoot;
    private readonly InputAction m_Ship_ZoomWheel;
    private readonly InputAction m_Ship_ZoomIn;
    private readonly InputAction m_Ship_ZoomOut;
    public struct ShipActions
    {
        private @ShipInput m_Wrapper;
        public ShipActions(@ShipInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Ship_Movement;
        public InputAction @MouseAim => m_Wrapper.m_Ship_MouseAim;
        public InputAction @AnalogAim => m_Wrapper.m_Ship_AnalogAim;
        public InputAction @Shoot => m_Wrapper.m_Ship_Shoot;
        public InputAction @ZoomWheel => m_Wrapper.m_Ship_ZoomWheel;
        public InputAction @ZoomIn => m_Wrapper.m_Ship_ZoomIn;
        public InputAction @ZoomOut => m_Wrapper.m_Ship_ZoomOut;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @MouseAim.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMouseAim;
                @MouseAim.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMouseAim;
                @MouseAim.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMouseAim;
                @AnalogAim.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnAnalogAim;
                @AnalogAim.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnAnalogAim;
                @AnalogAim.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnAnalogAim;
                @Shoot.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnShoot;
                @ZoomWheel.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomWheel;
                @ZoomWheel.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomWheel;
                @ZoomWheel.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomWheel;
                @ZoomIn.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomIn;
                @ZoomIn.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomIn;
                @ZoomIn.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomIn;
                @ZoomOut.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomOut;
                @ZoomOut.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomOut;
                @ZoomOut.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnZoomOut;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseAim.started += instance.OnMouseAim;
                @MouseAim.performed += instance.OnMouseAim;
                @MouseAim.canceled += instance.OnMouseAim;
                @AnalogAim.started += instance.OnAnalogAim;
                @AnalogAim.performed += instance.OnAnalogAim;
                @AnalogAim.canceled += instance.OnAnalogAim;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @ZoomWheel.started += instance.OnZoomWheel;
                @ZoomWheel.performed += instance.OnZoomWheel;
                @ZoomWheel.canceled += instance.OnZoomWheel;
                @ZoomIn.started += instance.OnZoomIn;
                @ZoomIn.performed += instance.OnZoomIn;
                @ZoomIn.canceled += instance.OnZoomIn;
                @ZoomOut.started += instance.OnZoomOut;
                @ZoomOut.performed += instance.OnZoomOut;
                @ZoomOut.canceled += instance.OnZoomOut;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseKeyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IShipActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseAim(InputAction.CallbackContext context);
        void OnAnalogAim(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnZoomWheel(InputAction.CallbackContext context);
        void OnZoomIn(InputAction.CallbackContext context);
        void OnZoomOut(InputAction.CallbackContext context);
    }
}
