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
                },
                {
                    ""name"": ""RightStep"",
                    ""type"": ""Button"",
                    ""id"": ""1be1ad56-65cd-4f11-8f34-3d07de1b0d76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftStep"",
                    ""type"": ""Button"",
                    ""id"": ""f36dee78-c60e-429d-bbbc-f7c93322d30e"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""5432566b-0ca9-47a5-b9cf-7cb227a8c86e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d90b448-a3f4-46b1-a48e-973462648f20"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb31e81e-9c69-4889-ad1f-b15d2c63b4ab"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e42bd8c-9408-408e-a900-9f73656eb758"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BallGame"",
            ""id"": ""6482a7d3-2819-4eca-bffe-35c4f73dba08"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""db0f32e9-1a75-4448-a9b4-a422088c2a2b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""HeadHit"",
                    ""type"": ""Button"",
                    ""id"": ""198a0bc9-904b-41bd-8a5f-361617bc5852"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftFoot"",
                    ""type"": ""Button"",
                    ""id"": ""37fef2af-4981-4755-9f56-344a0d37645a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightFoot"",
                    ""type"": ""Button"",
                    ""id"": ""1c79c354-f78d-4db0-bb20-47c6e04010b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChestHit"",
                    ""type"": ""Button"",
                    ""id"": ""68c874ed-abc7-42ef-906a-207245d565d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4d72aca4-ce12-448a-872d-f903b7d6a9c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""491be190-ae4a-4dd8-b46c-ed30a2b0dc77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e08d64f6-0367-4d54-9a81-ea750ba82e6a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3a3831de-e601-4320-afce-d44533a82545"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7c183401-4198-4313-91b5-d4f0d4b9b8d5"",
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
                    ""id"": ""f8831ce7-533f-4ebd-9bfb-d7f7b9d6f653"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeadHit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d22fc848-eb54-4c3f-9aaf-2e66e32fb468"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftFoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a02adbc-2681-464b-bbde-67aadc432465"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightFoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8220013f-f6d9-4b32-9322-4a0e22b99103"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChestHit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fce79a0-dfcb-4f00-a783-5e2ffd39f623"",
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
                    ""id"": ""76ea294d-023a-4519-a26e-aa5abb940532"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
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
        m_SideScroller_RightStep = m_SideScroller.FindAction("RightStep", throwIfNotFound: true);
        m_SideScroller_LeftStep = m_SideScroller.FindAction("LeftStep", throwIfNotFound: true);
        // BallGame
        m_BallGame = asset.FindActionMap("BallGame", throwIfNotFound: true);
        m_BallGame_Move = m_BallGame.FindAction("Move", throwIfNotFound: true);
        m_BallGame_HeadHit = m_BallGame.FindAction("HeadHit", throwIfNotFound: true);
        m_BallGame_LeftFoot = m_BallGame.FindAction("LeftFoot", throwIfNotFound: true);
        m_BallGame_RightFoot = m_BallGame.FindAction("RightFoot", throwIfNotFound: true);
        m_BallGame_ChestHit = m_BallGame.FindAction("ChestHit", throwIfNotFound: true);
        m_BallGame_Jump = m_BallGame.FindAction("Jump", throwIfNotFound: true);
        m_BallGame_Turn = m_BallGame.FindAction("Turn", throwIfNotFound: true);
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
    private readonly InputAction m_SideScroller_RightStep;
    private readonly InputAction m_SideScroller_LeftStep;
    public struct SideScrollerActions
    {
        private @Keys m_Wrapper;
        public SideScrollerActions(@Keys wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_SideScroller_Jump;
        public InputAction @Crouch => m_Wrapper.m_SideScroller_Crouch;
        public InputAction @RightStep => m_Wrapper.m_SideScroller_RightStep;
        public InputAction @LeftStep => m_Wrapper.m_SideScroller_LeftStep;
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
            @RightStep.started += instance.OnRightStep;
            @RightStep.performed += instance.OnRightStep;
            @RightStep.canceled += instance.OnRightStep;
            @LeftStep.started += instance.OnLeftStep;
            @LeftStep.performed += instance.OnLeftStep;
            @LeftStep.canceled += instance.OnLeftStep;
        }

        private void UnregisterCallbacks(ISideScrollerActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @RightStep.started -= instance.OnRightStep;
            @RightStep.performed -= instance.OnRightStep;
            @RightStep.canceled -= instance.OnRightStep;
            @LeftStep.started -= instance.OnLeftStep;
            @LeftStep.performed -= instance.OnLeftStep;
            @LeftStep.canceled -= instance.OnLeftStep;
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

    // BallGame
    private readonly InputActionMap m_BallGame;
    private List<IBallGameActions> m_BallGameActionsCallbackInterfaces = new List<IBallGameActions>();
    private readonly InputAction m_BallGame_Move;
    private readonly InputAction m_BallGame_HeadHit;
    private readonly InputAction m_BallGame_LeftFoot;
    private readonly InputAction m_BallGame_RightFoot;
    private readonly InputAction m_BallGame_ChestHit;
    private readonly InputAction m_BallGame_Jump;
    private readonly InputAction m_BallGame_Turn;
    public struct BallGameActions
    {
        private @Keys m_Wrapper;
        public BallGameActions(@Keys wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BallGame_Move;
        public InputAction @HeadHit => m_Wrapper.m_BallGame_HeadHit;
        public InputAction @LeftFoot => m_Wrapper.m_BallGame_LeftFoot;
        public InputAction @RightFoot => m_Wrapper.m_BallGame_RightFoot;
        public InputAction @ChestHit => m_Wrapper.m_BallGame_ChestHit;
        public InputAction @Jump => m_Wrapper.m_BallGame_Jump;
        public InputAction @Turn => m_Wrapper.m_BallGame_Turn;
        public InputActionMap Get() { return m_Wrapper.m_BallGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallGameActions set) { return set.Get(); }
        public void AddCallbacks(IBallGameActions instance)
        {
            if (instance == null || m_Wrapper.m_BallGameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BallGameActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @HeadHit.started += instance.OnHeadHit;
            @HeadHit.performed += instance.OnHeadHit;
            @HeadHit.canceled += instance.OnHeadHit;
            @LeftFoot.started += instance.OnLeftFoot;
            @LeftFoot.performed += instance.OnLeftFoot;
            @LeftFoot.canceled += instance.OnLeftFoot;
            @RightFoot.started += instance.OnRightFoot;
            @RightFoot.performed += instance.OnRightFoot;
            @RightFoot.canceled += instance.OnRightFoot;
            @ChestHit.started += instance.OnChestHit;
            @ChestHit.performed += instance.OnChestHit;
            @ChestHit.canceled += instance.OnChestHit;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Turn.started += instance.OnTurn;
            @Turn.performed += instance.OnTurn;
            @Turn.canceled += instance.OnTurn;
        }

        private void UnregisterCallbacks(IBallGameActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @HeadHit.started -= instance.OnHeadHit;
            @HeadHit.performed -= instance.OnHeadHit;
            @HeadHit.canceled -= instance.OnHeadHit;
            @LeftFoot.started -= instance.OnLeftFoot;
            @LeftFoot.performed -= instance.OnLeftFoot;
            @LeftFoot.canceled -= instance.OnLeftFoot;
            @RightFoot.started -= instance.OnRightFoot;
            @RightFoot.performed -= instance.OnRightFoot;
            @RightFoot.canceled -= instance.OnRightFoot;
            @ChestHit.started -= instance.OnChestHit;
            @ChestHit.performed -= instance.OnChestHit;
            @ChestHit.canceled -= instance.OnChestHit;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Turn.started -= instance.OnTurn;
            @Turn.performed -= instance.OnTurn;
            @Turn.canceled -= instance.OnTurn;
        }

        public void RemoveCallbacks(IBallGameActions instance)
        {
            if (m_Wrapper.m_BallGameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBallGameActions instance)
        {
            foreach (var item in m_Wrapper.m_BallGameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BallGameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BallGameActions @BallGame => new BallGameActions(this);
    public interface ISideScrollerActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRightStep(InputAction.CallbackContext context);
        void OnLeftStep(InputAction.CallbackContext context);
    }
    public interface IBallGameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnHeadHit(InputAction.CallbackContext context);
        void OnLeftFoot(InputAction.CallbackContext context);
        void OnRightFoot(InputAction.CallbackContext context);
        void OnChestHit(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
    }
}
