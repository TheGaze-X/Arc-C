using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem.OnScreen
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	[AddComponentMenu("Input/On-Screen Stick")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/OnScreen.html#on-screen-sticks")]
	public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x56C8200", Offset = "0x56C6E00", VA = "0x1856C8200", Slot = "8")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x56C7A60", Offset = "0x56C6660", VA = "0x1856C7A60", Slot = "10")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x56C84F0", Offset = "0x56C70F0", VA = "0x1856C84F0", Slot = "9")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x56C8500", Offset = "0x56C7100", VA = "0x1856C8500")]
		private void Start()
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x56C7080", Offset = "0x56C5C80", VA = "0x1856C7080")]
		private void BeginInteraction(Vector2 pointerPosition, Camera uiCamera)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x56C76B0", Offset = "0x56C62B0", VA = "0x1856C76B0")]
		private void MoveStick(Vector2 pointerPosition, Camera uiCamera)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x56C7480", Offset = "0x56C6080", VA = "0x1856C7480")]
		private void EndInteraction()
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x56C7E40", Offset = "0x56C6A40", VA = "0x1856C7E40")]
		private void OnPointerDown(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x56C82C0", Offset = "0x56C6EC0", VA = "0x1856C82C0")]
		private void OnPointerMove(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x56C8450", Offset = "0x56C7050", VA = "0x1856C8450")]
		private void OnPointerUp(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x56C7580", Offset = "0x56C6180", VA = "0x1856C7580")]
		private Camera GetCameraFromCanvas()
		{
			return null;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x56C7B20", Offset = "0x56C6720", VA = "0x1856C7B20")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x56C72F0", Offset = "0x56C5EF0", VA = "0x1856C72F0")]
		private void DrawGizmoCircle(Vector2 center, float radius)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x56C8C90", Offset = "0x56C7890", VA = "0x1856C8C90")]
		private void UpdateDynamicOriginClickableArea()
		{
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00006CF0 File Offset: 0x00004EF0
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B0")]
		public float movementRange
		{
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00006D08 File Offset: 0x00004F08
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B1")]
		public float dynamicOriginRange
		{
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x56C8DB0", Offset = "0x56C79B0", VA = "0x1856C8DB0")]
			set
			{
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00006D20 File Offset: 0x00004F20
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B2")]
		public bool useIsolatedInputActions
		{
			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0x220E7B0", Offset = "0x220D3B0", VA = "0x18220E7B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DFC")]
			[Address(RVA = "0x4E71920", Offset = "0x4E70520", VA = "0x184E71920")]
			set
			{
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B3")]
		protected override string controlPathInternal
		{
			[Token(Token = "0x6000DFD")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00006D38 File Offset: 0x00004F38
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B4")]
		public OnScreenStick.Behaviour behaviour
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return OnScreenStick.Behaviour.RelativePositionWithStaticOrigin;
			}
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			set
			{
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x56C8D90", Offset = "0x56C7990", VA = "0x1856C8D90")]
		public OnScreenStick()
		{
		}

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		private const string kDynamicOriginClickable = "DynamicOriginClickable";

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("movementRange")]
		[SerializeField]
		[Min(0f)]
		private float m_MovementRange;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x34")]
		[Min(0f)]
		[SerializeField]
		[Tooltip("Defines the circular region where the onscreen control may have it's origin placed.")]
		private float m_DynamicOriginRange;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x38")]
		[InputControl(layout = "Vector2")]
		[SerializeField]
		private string m_ControlPath;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Choose how the onscreen stick will move relative to it's origin and the press position.\n\nRelativePositionWithStaticOrigin: The control's center of origin is fixed. The control will begin un-actuated at it's centered position and then move relative to the pointer or finger motion.\n\nExactPositionWithStaticOrigin: The control's center of origin is fixed. The stick will immediately jump to the exact position of the click or touch and begin tracking motion from there.\n\nExactPositionWithDynamicOrigin: The control's center of origin is determined by the initial press position. The stick will begin un-actuated at this center position and then track the current pointer or finger position.")]
		private OnScreenStick.Behaviour m_Behaviour;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Tooltip("Set this to true to prevent cancellation of pointer events due to device switching. Cancellation will appear as the stick jumping back and forth between the pointer position and the stick center.")]
		private bool m_UseIsolatedInputActions;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("The action that will be used to detect pointer down events on the stick control. Note that if no bindings are set, default ones will be provided.")]
		private InputAction m_PointerDownAction;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("The action that will be used to detect pointer movement on the stick control. Note that if no bindings are set, default ones will be provided.")]
		private InputAction m_PointerMoveAction;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 m_StartPos;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x64")]
		private Vector2 m_PointerDownPos;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private List<RaycastResult> m_RaycastResults;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private PointerEventData m_PointerEventData;

		// Token: 0x0200012F RID: 303
		[Token(Token = "0x200012F")]
		public enum Behaviour
		{
			// Token: 0x040006F7 RID: 1783
			[Token(Token = "0x40006F7")]
			RelativePositionWithStaticOrigin,
			// Token: 0x040006F8 RID: 1784
			[Token(Token = "0x40006F8")]
			ExactPositionWithStaticOrigin,
			// Token: 0x040006F9 RID: 1785
			[Token(Token = "0x40006F9")]
			ExactPositionWithDynamicOrigin
		}
	}
}
