using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BitBenderGames
{
	// Token: 0x02000461 RID: 1121
	[Token(Token = "0x2000461")]
	public abstract class AbstractTouchInputController : MonoBehaviour, IWheelListener
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06004B2F RID: 19247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		public ScrollWheelHandler handler
		{
			[Token(Token = "0x6004B2F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		protected virtual GameObject scrollWheelRaycastContent
		{
			[Token(Token = "0x6004B30")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x167CC30", Offset = "0x167B830", VA = "0x18167CC30")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x167CBB0", Offset = "0x167B7B0", VA = "0x18167CBB0")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "4")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0002CE08 File Offset: 0x0002B008
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x167CC80", Offset = "0x167B880", VA = "0x18167CC80", Slot = "5")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x167CAC0", Offset = "0x167B6C0", VA = "0x18167CAC0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x167CBF0", Offset = "0x167B7F0", VA = "0x18167CBF0", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected AbstractTouchInputController()
		{
		}

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x18")]
		private ScrollWheelHandler m_handler;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x20")]
		private FullScreenScrollListener m_scrollListener;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public AbstractTouchInputController.InputDragStartDelegate OnDragStart;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public AbstractTouchInputController.Input1PositionDelegate OnFingerDown;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action OnFingerUp;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public AbstractTouchInputController.DragUpdateDelegate OnDragUpdate;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public AbstractTouchInputController.DragStopDelegate OnDragStop;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public AbstractTouchInputController.PinchStartDelegate OnPinchStart;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public AbstractTouchInputController.PinchUpdateDelegate OnPinchUpdate;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public AbstractTouchInputController.PinchUpdateExtendedDelegate OnPinchUpdateExtended;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action OnPinchStop;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public AbstractTouchInputController.InputLongTapProgress OnLongTapProgress;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public AbstractTouchInputController.InputClickDelegate OnInputClick;

		// Token: 0x02000462 RID: 1122
		// (Invoke) Token: 0x06004B39 RID: 19257
		[Token(Token = "0x2000462")]
		public delegate void InputDragStartDelegate(Vector3 pos, bool isLongTap);

		// Token: 0x02000463 RID: 1123
		// (Invoke) Token: 0x06004B3D RID: 19261
		[Token(Token = "0x2000463")]
		public delegate void Input1PositionDelegate(Vector3 pos);

		// Token: 0x02000464 RID: 1124
		// (Invoke) Token: 0x06004B41 RID: 19265
		[Token(Token = "0x2000464")]
		public delegate void DragUpdateDelegate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset);

		// Token: 0x02000465 RID: 1125
		// (Invoke) Token: 0x06004B45 RID: 19269
		[Token(Token = "0x2000465")]
		public delegate void DragStopDelegate(Vector3 dragStopPos, Vector3 dragFinalMomentum);

		// Token: 0x02000466 RID: 1126
		// (Invoke) Token: 0x06004B49 RID: 19273
		[Token(Token = "0x2000466")]
		public delegate void PinchStartDelegate(Vector3 pinchCenter, float pinchDistance);

		// Token: 0x02000467 RID: 1127
		// (Invoke) Token: 0x06004B4D RID: 19277
		[Token(Token = "0x2000467")]
		public delegate void PinchUpdateDelegate(Vector3 pinchCenter, float pinchDistance, float pinchStartDistance);

		// Token: 0x02000468 RID: 1128
		// (Invoke) Token: 0x06004B51 RID: 19281
		[Token(Token = "0x2000468")]
		public delegate void PinchUpdateExtendedDelegate(PinchUpdateData pinchUpdateData);

		// Token: 0x02000469 RID: 1129
		// (Invoke) Token: 0x06004B55 RID: 19285
		[Token(Token = "0x2000469")]
		public delegate void InputLongTapProgress(float progress);

		// Token: 0x0200046A RID: 1130
		// (Invoke) Token: 0x06004B59 RID: 19289
		[Token(Token = "0x200046A")]
		public delegate void InputClickDelegate(Vector3 clickPosition, bool isDoubleClick, bool isLongTap);
	}
}
