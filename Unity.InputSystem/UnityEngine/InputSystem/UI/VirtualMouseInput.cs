using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[AddComponentMenu("Input/Virtual Mouse")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/UISupport.html#virtual-mouse-cursor-control")]
	public class VirtualMouseInput : MonoBehaviour
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000397")]
		public RectTransform cursorTransform
		{
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D96")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000398")]
		public float cursorSpeed
		{
			[Token(Token = "0x6000D97")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000399")]
		public VirtualMouseInput.CursorMode cursorMode
		{
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return VirtualMouseInput.CursorMode.SoftwareCursor;
			}
			[Token(Token = "0x6000D9A")]
			[Address(RVA = "0x56CE510", Offset = "0x56CD110", VA = "0x1856CE510")]
			set
			{
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039A")]
		public Graphic cursorGraphic
		{
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x56CE4A0", Offset = "0x56CD0A0", VA = "0x1856CE4A0")]
			set
			{
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00006AB0 File Offset: 0x00004CB0
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039B")]
		public float scrollSpeed
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700039C")]
		public Mouse virtualMouse
		{
			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00006AC8 File Offset: 0x00004CC8
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039D")]
		public InputActionProperty stickAction
		{
			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x2739440", Offset = "0x2738040", VA = "0x182739440")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DA1")]
			[Address(RVA = "0x56CEA70", Offset = "0x56CD670", VA = "0x1856CEA70")]
			set
			{
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00006AE0 File Offset: 0x00004CE0
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039E")]
		public InputActionProperty leftButtonAction
		{
			[Token(Token = "0x6000DA2")]
			[Address(RVA = "0x442DCA0", Offset = "0x442C8A0", VA = "0x18442DCA0")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DA3")]
			[Address(RVA = "0x56CE730", Offset = "0x56CD330", VA = "0x1856CE730")]
			set
			{
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00006AF8 File Offset: 0x00004CF8
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		public InputActionProperty rightButtonAction
		{
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x56CE350", Offset = "0x56CCF50", VA = "0x1856CE350")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x56CE930", Offset = "0x56CD530", VA = "0x1856CE930")]
			set
			{
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00006B10 File Offset: 0x00004D10
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A0")]
		public InputActionProperty middleButtonAction
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x56CE330", Offset = "0x56CCF30", VA = "0x1856CE330")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DA7")]
			[Address(RVA = "0x56CE830", Offset = "0x56CD430", VA = "0x1856CE830")]
			set
			{
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00006B28 File Offset: 0x00004D28
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		public InputActionProperty forwardButtonAction
		{
			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x56CE310", Offset = "0x56CCF10", VA = "0x1856CE310")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x56CE620", Offset = "0x56CD220", VA = "0x1856CE620")]
			set
			{
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00006B40 File Offset: 0x00004D40
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public InputActionProperty backButtonAction
		{
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x56CE2F0", Offset = "0x56CCEF0", VA = "0x1856CE2F0")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x56CE390", Offset = "0x56CCF90", VA = "0x1856CE390")]
			set
			{
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00006B58 File Offset: 0x00004D58
		// (set) Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public InputActionProperty scrollWheelAction
		{
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x56CE370", Offset = "0x56CCF70", VA = "0x1856CE370")]
			get
			{
				return default(InputActionProperty);
			}
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x56CEA40", Offset = "0x56CD640", VA = "0x1856CEA40")]
			set
			{
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x56CD450", Offset = "0x56CC050", VA = "0x1856CD450")]
		protected void OnEnable()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x56CD0E0", Offset = "0x56CBCE0", VA = "0x1856CD0E0")]
		protected void OnDisable()
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x56CDDF0", Offset = "0x56CC9F0", VA = "0x1856CDDF0")]
		private void TryFindCanvas()
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x56CDBC0", Offset = "0x56CC7C0", VA = "0x1856CDBC0")]
		private void TryEnableHardwareCursor()
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x56CDE50", Offset = "0x56CCA50", VA = "0x1856CDE50")]
		private void UpdateMotion()
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x56CCEF0", Offset = "0x56CBAF0", VA = "0x1856CCEF0")]
		private void OnButtonActionTriggered(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x56CDA20", Offset = "0x56CC620", VA = "0x1856CDA20")]
		private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = true)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x56CDAA0", Offset = "0x56CC6A0", VA = "0x1856CDAA0")]
		private static void SetAction(ref InputActionProperty field, InputActionProperty value)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x56CCEE0", Offset = "0x56CBAE0", VA = "0x1856CCEE0")]
		private void OnAfterInputUpdate()
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x56CE2D0", Offset = "0x56CCED0", VA = "0x1856CE2D0")]
		public VirtualMouseInput()
		{
		}

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by 'Cursor Graphic') will be hidden.")]
		[Header("Cursor")]
		private VirtualMouseInput.CursorMode m_CursorMode;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see 'Cursor Mode') is used.")]
		private Graphic m_CursorGraphic;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see 'Cursor Mode'). Moving the cursor updates the anchored position of the transform.")]
		private RectTransform m_CursorTransform;

		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from 'Stick Action'.")]
		[Header("Motion")]
		private float m_CursorSpeed;

		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("Scale factor to apply to 'Scroll Wheel Action' when setting the mouse 'scrollWheel' control.")]
		private float m_ScrollSpeed;

		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
		[Space(10f)]
		private InputActionProperty m_StickAction;

		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Button action that triggers a left-click on the mouse.")]
		[SerializeField]
		private InputActionProperty m_LeftButtonAction;

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Button action that triggers a middle-click on the mouse.")]
		[SerializeField]
		private InputActionProperty m_MiddleButtonAction;

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("Button action that triggers a right-click on the mouse.")]
		private InputActionProperty m_RightButtonAction;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
		[SerializeField]
		private InputActionProperty m_ForwardButtonAction;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
		[SerializeField]
		private InputActionProperty m_BackButtonAction;

		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Tooltip("Vector2 action that feeds into the mouse 'scrollWheel' action (scaled by 'Scroll Speed').")]
		private InputActionProperty m_ScrollWheelAction;

		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		[FieldOffset(Offset = "0xE0")]
		private Canvas m_Canvas;

		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		[FieldOffset(Offset = "0xE8")]
		private Mouse m_VirtualMouse;

		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		[FieldOffset(Offset = "0xF0")]
		private Mouse m_SystemMouse;

		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		[FieldOffset(Offset = "0xF8")]
		private Action m_AfterInputUpdateDelegate;

		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		[FieldOffset(Offset = "0x100")]
		private Action<InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;

		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		[FieldOffset(Offset = "0x108")]
		private double m_LastTime;

		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		[FieldOffset(Offset = "0x110")]
		private Vector2 m_LastStickValue;

		// Token: 0x0200011D RID: 285
		[Token(Token = "0x200011D")]
		public enum CursorMode
		{
			// Token: 0x0400068A RID: 1674
			[Token(Token = "0x400068A")]
			SoftwareCursor,
			// Token: 0x0400068B RID: 1675
			[Token(Token = "0x400068B")]
			HardwareCursorIfAvailable
		}
	}
}
