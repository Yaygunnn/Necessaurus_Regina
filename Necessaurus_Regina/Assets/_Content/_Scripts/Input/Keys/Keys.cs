//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Content/_Scripts/Input/Keys/Keys.inputactions
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

public partial class @Keys: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Keys()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Keys"",
    ""maps"": [
        {
            ""name"": ""SideScroller"",
            ""id"": ""659ddf24-8e82-4575-9f45-ff1525ebf0ec"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""539f912f-4845-4686-9cf9-80a4e5db1e52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""c377b192-0d1a-4c41-9469-d7ddaf08e259"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9fbbbd35-44ec-4758-bed3-2baa1de2806b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""552d24f5-3ecd-4916-953e-353770090427"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b09ea644-a168-40d5-bfe6-db17c075bbed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e57f05c8-e948-4acc-bbf9-24e847b196cd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SideScroller
        m_SideScroller = asset.FindActionMap("SideScroller", throwIfNotFound: true);
        m_SideScroller_Jump = m_SideScroller.FindAction("Jump", throwIfNotFound: true);
        m_SideScroller_Crouch = m_SideScroller.FindAction("Crouch", throwIfNotFound: true);
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

    // SideScroller
    private readonly InputActionMap m_SideScroller;
    private List<ISideScrollerActions> m_SideScrollerActionsCallbackInterfaces = new List<ISideScrollerActions>();
    private readonly InputAction m_SideScroller_Jump;
    private readonly InputAction m_SideScroller_Crouch;
    public struct SideScrollerActions
    {
        private @Keys m_Wrapper;
        public SideScrollerActions(@Keys wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_SideScroller_Jump;
        public InputAction @Crouch => m_Wrapper.m_SideScroller_Crouch;
        public InputActionMap Get() { return m_Wrapper.m_SideScroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SideScrollerActions set) { return set.Get(); }
        public void AddCallbacks(ISideScrollerActions instance)
        {
            if (instance == null || m_Wrapper.m_SideScrollerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SideScrollerActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
        }

        private void UnregisterCallbacks(ISideScrollerActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
        }

        public void RemoveCallbacks(ISideScrollerActions instance)
        {
            if (m_Wrapper.m_SideScrollerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISideScrollerActions instance)
        {
            foreach (var item in m_Wrapper.m_SideScrollerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SideScrollerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SideScrollerActions @SideScroller => new SideScrollerActions(this);
    public interface ISideScrollerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
    }
}
