//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Lesson_4/Scripts/Input/BalloonInput.inputactions
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

public partial class @BalloonInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BalloonInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BalloonInput"",
    ""maps"": [
        {
            ""name"": ""Weapon"",
            ""id"": ""c0472cb2-8656-4f30-844a-f0f64e205690"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""92cafd21-6220-4dbf-b3b8-18a475a80523"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch_weapon_1"",
                    ""type"": ""Button"",
                    ""id"": ""fc143ffc-4b9b-4597-9527-b271fffe8479"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch_weapon_2"",
                    ""type"": ""Button"",
                    ""id"": ""45390a13-be0e-4ee1-89af-2531fe284c4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch_weapon_3"",
                    ""type"": ""Button"",
                    ""id"": ""7b42c8d4-c5f5-4613-b571-645385c5086e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""8ce220d4-3e68-4e9a-beed-ead82efeff7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""67ed2622-eef3-496a-a7ad-211b007e9419"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7cb4b63-9121-4587-912b-2d02af81db17"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch_weapon_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c931ab9e-7747-4e26-8535-53548b39398d"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch_weapon_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""362dd727-56aa-44db-854d-40f65f96fdd1"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch_weapon_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1df56bdc-141c-46df-a2ae-be24db12d7ef"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Merchant"",
            ""id"": ""0e6b0adb-71a6-424a-ae77-5c8b22aa87a2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""408abecc-2384-408d-b361-a91cb14f2017"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Switch_behaviour_1"",
                    ""type"": ""Button"",
                    ""id"": ""16eb27de-4cd4-486e-9d99-b9ce271220b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch_behaviour_2"",
                    ""type"": ""Button"",
                    ""id"": ""340f0601-2ad6-47e1-a352-2b90d27c6c4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Switch_behaviour_3"",
                    ""type"": ""Button"",
                    ""id"": ""3a58604d-eacd-46cf-a3cc-325e895f9938"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Trade"",
                    ""type"": ""Button"",
                    ""id"": ""a836d42d-a380-487b-9ea9-8dc4c1a31ea8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""11434a7e-2590-46d5-a64f-52cfc55ae605"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1f15394-dd3c-4d19-9777-93400ae70dfc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4a04760-150d-4629-9542-a605a570e82f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87144e07-ac7e-40dd-bfff-70c9a199dfea"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""747ec920-35e4-461f-9c24-3d3d64e8f78d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""95e949ee-a3dd-487d-a038-13959a1e2783"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch_behaviour_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4f59176-470b-44aa-afb0-149ba515c900"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch_behaviour_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9fa0526-fee0-48ad-a0cf-f207614d5dbb"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch_behaviour_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a23e54dc-f9bd-4fe0-8099-6122e48aa735"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ballon"",
            ""id"": ""86e55036-c5bd-49ae-82f1-e6107e7ab220"",
            ""actions"": [
                {
                    ""name"": ""Burst"",
                    ""type"": ""Button"",
                    ""id"": ""7704c2dc-9e91-4f3f-b7d4-83a2a74ac1ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReloadScene"",
                    ""type"": ""Button"",
                    ""id"": ""8a2c2661-4607-4e59-a8c7-abf964891c73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""60caa225-3af2-444a-8d0d-aacb4346d63f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Burst"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d37e39c-8638-4103-8f7b-b3efccdb1c72"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReloadScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Fire = m_Weapon.FindAction("Fire", throwIfNotFound: true);
        m_Weapon_Switch_weapon_1 = m_Weapon.FindAction("Switch_weapon_1", throwIfNotFound: true);
        m_Weapon_Switch_weapon_2 = m_Weapon.FindAction("Switch_weapon_2", throwIfNotFound: true);
        m_Weapon_Switch_weapon_3 = m_Weapon.FindAction("Switch_weapon_3", throwIfNotFound: true);
        m_Weapon_Reload = m_Weapon.FindAction("Reload", throwIfNotFound: true);
        // Merchant
        m_Merchant = asset.FindActionMap("Merchant", throwIfNotFound: true);
        m_Merchant_Move = m_Merchant.FindAction("Move", throwIfNotFound: true);
        m_Merchant_Switch_behaviour_1 = m_Merchant.FindAction("Switch_behaviour_1", throwIfNotFound: true);
        m_Merchant_Switch_behaviour_2 = m_Merchant.FindAction("Switch_behaviour_2", throwIfNotFound: true);
        m_Merchant_Switch_behaviour_3 = m_Merchant.FindAction("Switch_behaviour_3", throwIfNotFound: true);
        m_Merchant_Trade = m_Merchant.FindAction("Trade", throwIfNotFound: true);
        // Ballon
        m_Ballon = asset.FindActionMap("Ballon", throwIfNotFound: true);
        m_Ballon_Burst = m_Ballon.FindAction("Burst", throwIfNotFound: true);
        m_Ballon_ReloadScene = m_Ballon.FindAction("ReloadScene", throwIfNotFound: true);
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

    // Weapon
    private readonly InputActionMap m_Weapon;
    private List<IWeaponActions> m_WeaponActionsCallbackInterfaces = new List<IWeaponActions>();
    private readonly InputAction m_Weapon_Fire;
    private readonly InputAction m_Weapon_Switch_weapon_1;
    private readonly InputAction m_Weapon_Switch_weapon_2;
    private readonly InputAction m_Weapon_Switch_weapon_3;
    private readonly InputAction m_Weapon_Reload;
    public struct WeaponActions
    {
        private @BalloonInput m_Wrapper;
        public WeaponActions(@BalloonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Weapon_Fire;
        public InputAction @Switch_weapon_1 => m_Wrapper.m_Weapon_Switch_weapon_1;
        public InputAction @Switch_weapon_2 => m_Wrapper.m_Weapon_Switch_weapon_2;
        public InputAction @Switch_weapon_3 => m_Wrapper.m_Weapon_Switch_weapon_3;
        public InputAction @Reload => m_Wrapper.m_Weapon_Reload;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void AddCallbacks(IWeaponActions instance)
        {
            if (instance == null || m_Wrapper.m_WeaponActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Add(instance);
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
            @Switch_weapon_1.started += instance.OnSwitch_weapon_1;
            @Switch_weapon_1.performed += instance.OnSwitch_weapon_1;
            @Switch_weapon_1.canceled += instance.OnSwitch_weapon_1;
            @Switch_weapon_2.started += instance.OnSwitch_weapon_2;
            @Switch_weapon_2.performed += instance.OnSwitch_weapon_2;
            @Switch_weapon_2.canceled += instance.OnSwitch_weapon_2;
            @Switch_weapon_3.started += instance.OnSwitch_weapon_3;
            @Switch_weapon_3.performed += instance.OnSwitch_weapon_3;
            @Switch_weapon_3.canceled += instance.OnSwitch_weapon_3;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IWeaponActions instance)
        {
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
            @Switch_weapon_1.started -= instance.OnSwitch_weapon_1;
            @Switch_weapon_1.performed -= instance.OnSwitch_weapon_1;
            @Switch_weapon_1.canceled -= instance.OnSwitch_weapon_1;
            @Switch_weapon_2.started -= instance.OnSwitch_weapon_2;
            @Switch_weapon_2.performed -= instance.OnSwitch_weapon_2;
            @Switch_weapon_2.canceled -= instance.OnSwitch_weapon_2;
            @Switch_weapon_3.started -= instance.OnSwitch_weapon_3;
            @Switch_weapon_3.performed -= instance.OnSwitch_weapon_3;
            @Switch_weapon_3.canceled -= instance.OnSwitch_weapon_3;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IWeaponActions instance)
        {
            foreach (var item in m_Wrapper.m_WeaponActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_WeaponActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);

    // Merchant
    private readonly InputActionMap m_Merchant;
    private List<IMerchantActions> m_MerchantActionsCallbackInterfaces = new List<IMerchantActions>();
    private readonly InputAction m_Merchant_Move;
    private readonly InputAction m_Merchant_Switch_behaviour_1;
    private readonly InputAction m_Merchant_Switch_behaviour_2;
    private readonly InputAction m_Merchant_Switch_behaviour_3;
    private readonly InputAction m_Merchant_Trade;
    public struct MerchantActions
    {
        private @BalloonInput m_Wrapper;
        public MerchantActions(@BalloonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Merchant_Move;
        public InputAction @Switch_behaviour_1 => m_Wrapper.m_Merchant_Switch_behaviour_1;
        public InputAction @Switch_behaviour_2 => m_Wrapper.m_Merchant_Switch_behaviour_2;
        public InputAction @Switch_behaviour_3 => m_Wrapper.m_Merchant_Switch_behaviour_3;
        public InputAction @Trade => m_Wrapper.m_Merchant_Trade;
        public InputActionMap Get() { return m_Wrapper.m_Merchant; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MerchantActions set) { return set.Get(); }
        public void AddCallbacks(IMerchantActions instance)
        {
            if (instance == null || m_Wrapper.m_MerchantActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MerchantActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Switch_behaviour_1.started += instance.OnSwitch_behaviour_1;
            @Switch_behaviour_1.performed += instance.OnSwitch_behaviour_1;
            @Switch_behaviour_1.canceled += instance.OnSwitch_behaviour_1;
            @Switch_behaviour_2.started += instance.OnSwitch_behaviour_2;
            @Switch_behaviour_2.performed += instance.OnSwitch_behaviour_2;
            @Switch_behaviour_2.canceled += instance.OnSwitch_behaviour_2;
            @Switch_behaviour_3.started += instance.OnSwitch_behaviour_3;
            @Switch_behaviour_3.performed += instance.OnSwitch_behaviour_3;
            @Switch_behaviour_3.canceled += instance.OnSwitch_behaviour_3;
            @Trade.started += instance.OnTrade;
            @Trade.performed += instance.OnTrade;
            @Trade.canceled += instance.OnTrade;
        }

        private void UnregisterCallbacks(IMerchantActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Switch_behaviour_1.started -= instance.OnSwitch_behaviour_1;
            @Switch_behaviour_1.performed -= instance.OnSwitch_behaviour_1;
            @Switch_behaviour_1.canceled -= instance.OnSwitch_behaviour_1;
            @Switch_behaviour_2.started -= instance.OnSwitch_behaviour_2;
            @Switch_behaviour_2.performed -= instance.OnSwitch_behaviour_2;
            @Switch_behaviour_2.canceled -= instance.OnSwitch_behaviour_2;
            @Switch_behaviour_3.started -= instance.OnSwitch_behaviour_3;
            @Switch_behaviour_3.performed -= instance.OnSwitch_behaviour_3;
            @Switch_behaviour_3.canceled -= instance.OnSwitch_behaviour_3;
            @Trade.started -= instance.OnTrade;
            @Trade.performed -= instance.OnTrade;
            @Trade.canceled -= instance.OnTrade;
        }

        public void RemoveCallbacks(IMerchantActions instance)
        {
            if (m_Wrapper.m_MerchantActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMerchantActions instance)
        {
            foreach (var item in m_Wrapper.m_MerchantActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MerchantActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MerchantActions @Merchant => new MerchantActions(this);

    // Ballon
    private readonly InputActionMap m_Ballon;
    private List<IBallonActions> m_BallonActionsCallbackInterfaces = new List<IBallonActions>();
    private readonly InputAction m_Ballon_Burst;
    private readonly InputAction m_Ballon_ReloadScene;
    public struct BallonActions
    {
        private @BalloonInput m_Wrapper;
        public BallonActions(@BalloonInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Burst => m_Wrapper.m_Ballon_Burst;
        public InputAction @ReloadScene => m_Wrapper.m_Ballon_ReloadScene;
        public InputActionMap Get() { return m_Wrapper.m_Ballon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallonActions set) { return set.Get(); }
        public void AddCallbacks(IBallonActions instance)
        {
            if (instance == null || m_Wrapper.m_BallonActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BallonActionsCallbackInterfaces.Add(instance);
            @Burst.started += instance.OnBurst;
            @Burst.performed += instance.OnBurst;
            @Burst.canceled += instance.OnBurst;
            @ReloadScene.started += instance.OnReloadScene;
            @ReloadScene.performed += instance.OnReloadScene;
            @ReloadScene.canceled += instance.OnReloadScene;
        }

        private void UnregisterCallbacks(IBallonActions instance)
        {
            @Burst.started -= instance.OnBurst;
            @Burst.performed -= instance.OnBurst;
            @Burst.canceled -= instance.OnBurst;
            @ReloadScene.started -= instance.OnReloadScene;
            @ReloadScene.performed -= instance.OnReloadScene;
            @ReloadScene.canceled -= instance.OnReloadScene;
        }

        public void RemoveCallbacks(IBallonActions instance)
        {
            if (m_Wrapper.m_BallonActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBallonActions instance)
        {
            foreach (var item in m_Wrapper.m_BallonActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BallonActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BallonActions @Ballon => new BallonActions(this);
    public interface IWeaponActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnSwitch_weapon_1(InputAction.CallbackContext context);
        void OnSwitch_weapon_2(InputAction.CallbackContext context);
        void OnSwitch_weapon_3(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IMerchantActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSwitch_behaviour_1(InputAction.CallbackContext context);
        void OnSwitch_behaviour_2(InputAction.CallbackContext context);
        void OnSwitch_behaviour_3(InputAction.CallbackContext context);
        void OnTrade(InputAction.CallbackContext context);
    }
    public interface IBallonActions
    {
        void OnBurst(InputAction.CallbackContext context);
        void OnReloadScene(InputAction.CallbackContext context);
    }
}