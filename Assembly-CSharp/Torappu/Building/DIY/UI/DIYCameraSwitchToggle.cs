using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200196F RID: 6511
	[Token(Token = "0x200196F")]
	public class DIYCameraSwitchToggle : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A395 RID: 41877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A395")]
		[Address(RVA = "0x31D6340", Offset = "0x31D4F40", VA = "0x1831D6340")]
		public void OnSwitchToggle(DIYCameraSwitchToggle.CameraSwitchState state)
		{
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A396")]
		[Address(RVA = "0x31D66E0", Offset = "0x31D52E0", VA = "0x1831D66E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600A397 RID: 41879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A397")]
		[Address(RVA = "0x31D68C0", Offset = "0x31D54C0", VA = "0x1831D68C0")]
		private void _SetSwitchIconState(DIYCameraSwitchToggle.CameraSwitchState state)
		{
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A398")]
		[Address(RVA = "0x31D6840", Offset = "0x31D5440", VA = "0x1831D6840")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A399")]
		[Address(RVA = "0x31D69C0", Offset = "0x31D55C0", VA = "0x1831D69C0")]
		public DIYCameraSwitchToggle()
		{
		}

		// Token: 0x04009A15 RID: 39445
		[Token(Token = "0x4009A15")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic _ceilingSwitchIcon;

		// Token: 0x04009A16 RID: 39446
		[Token(Token = "0x4009A16")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _wallSwitchIcon;

		// Token: 0x04009A17 RID: 39447
		[Token(Token = "0x4009A17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _floorSwitchIcon;

		// Token: 0x04009A18 RID: 39448
		[Token(Token = "0x4009A18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic _generalSwitchIcon;

		// Token: 0x04009A19 RID: 39449
		[Token(Token = "0x4009A19")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _ceilingButton;

		// Token: 0x04009A1A RID: 39450
		[Token(Token = "0x4009A1A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _wallButton;

		// Token: 0x04009A1B RID: 39451
		[Token(Token = "0x4009A1B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _floorButton;

		// Token: 0x04009A1C RID: 39452
		[Token(Token = "0x4009A1C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _cameraPointer;

		// Token: 0x04009A1D RID: 39453
		[Token(Token = "0x4009A1D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x04009A1E RID: 39454
		[Token(Token = "0x4009A1E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _toggleButton;

		// Token: 0x04009A1F RID: 39455
		[Token(Token = "0x4009A1F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _buttonsGroup;

		// Token: 0x04009A20 RID: 39456
		[Token(Token = "0x4009A20")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _radiusMax;

		// Token: 0x04009A21 RID: 39457
		[Token(Token = "0x4009A21")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _radiusMin;

		// Token: 0x04009A22 RID: 39458
		[Token(Token = "0x4009A22")]
		[FieldOffset(Offset = "0x78")]
		private DIYCameraSwitchToggle.CameraSwitchState m_cameraState;

		// Token: 0x04009A23 RID: 39459
		[Token(Token = "0x4009A23")]
		[FieldOffset(Offset = "0x80")]
		private Graphic m_currentFoldSwitchIcon;

		// Token: 0x04009A24 RID: 39460
		[Token(Token = "0x4009A24")]
		[FieldOffset(Offset = "0x88")]
		private DIYCameraSwitchToggle.DIYCameraSwitchTween m_cameraSwitchTween;

		// Token: 0x04009A25 RID: 39461
		[Token(Token = "0x4009A25")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInit;

		// Token: 0x04009A26 RID: 39462
		[Token(Token = "0x4009A26")]
		private const float SQRT_2_DIV_2 = 0.7071f;

		// Token: 0x04009A27 RID: 39463
		[Token(Token = "0x4009A27")]
		private const float DURATION = 0.25f;

		// Token: 0x04009A28 RID: 39464
		[Token(Token = "0x4009A28")]
		private const float CEILING_ICON_ANGLE = -81f;

		// Token: 0x04009A29 RID: 39465
		[Token(Token = "0x4009A29")]
		private const float WALL_ICON_ANGLE = -45f;

		// Token: 0x04009A2A RID: 39466
		[Token(Token = "0x4009A2A")]
		private const float FLOOR_ICON_ANGLE = -9f;

		// Token: 0x04009A2B RID: 39467
		[Token(Token = "0x4009A2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSwitchToggle;

		// Token: 0x04009A2C RID: 39468
		[Token(Token = "0x4009A2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009A2D RID: 39469
		[Token(Token = "0x4009A2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetSwitchIconState;

		// Token: 0x04009A2E RID: 39470
		[Token(Token = "0x4009A2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x04009A2F RID: 39471
		[Token(Token = "0x4009A2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001970 RID: 6512
		[Token(Token = "0x2001970")]
		private class DIYCameraSwitchTween : UISwitchTween
		{
			// Token: 0x0600A39A RID: 41882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39A")]
			[Address(RVA = "0x31D70B0", Offset = "0x31D5CB0", VA = "0x1831D70B0")]
			public DIYCameraSwitchTween(DIYCameraSwitchToggle switchToggle)
			{
			}

			// Token: 0x0600A39B RID: 41883 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A39B")]
			[Address(RVA = "0x31D6B50", Offset = "0x31D5750", VA = "0x1831D6B50", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0600A39C RID: 41884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A39C")]
			[Address(RVA = "0x31D6E00", Offset = "0x31D5A00", VA = "0x1831D6E00", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0600A39D RID: 41885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39D")]
			[Address(RVA = "0x31D6AC0", Offset = "0x31D56C0", VA = "0x1831D6AC0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0600A39E RID: 41886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39E")]
			[Address(RVA = "0x31D6A30", Offset = "0x31D5630", VA = "0x1831D6A30", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0600A39F RID: 41887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A39F")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0600A3A0 RID: 41888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A0")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x04009A30 RID: 39472
			[Token(Token = "0x4009A30")]
			[FieldOffset(Offset = "0x48")]
			private DIYCameraSwitchToggle m_closure;

			// Token: 0x04009A31 RID: 39473
			[Token(Token = "0x4009A31")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009A32 RID: 39474
			[Token(Token = "0x4009A32")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04009A33 RID: 39475
			[Token(Token = "0x4009A33")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04009A34 RID: 39476
			[Token(Token = "0x4009A34")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04009A35 RID: 39477
			[Token(Token = "0x4009A35")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;
		}

		// Token: 0x02001971 RID: 6513
		[Token(Token = "0x2001971")]
		[Serializable]
		public class DIYGeneralSwitchEvent : UnityEvent
		{
			// Token: 0x0600A3A1 RID: 41889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3A1")]
			[Address(RVA = "0x50BD90", Offset = "0x50A990", VA = "0x18050BD90")]
			public DIYGeneralSwitchEvent()
			{
			}
		}

		// Token: 0x02001972 RID: 6514
		[Token(Token = "0x2001972")]
		public enum CameraSwitchState
		{
			// Token: 0x04009A37 RID: 39479
			[Token(Token = "0x4009A37")]
			GENERAL,
			// Token: 0x04009A38 RID: 39480
			[Token(Token = "0x4009A38")]
			CEILING,
			// Token: 0x04009A39 RID: 39481
			[Token(Token = "0x4009A39")]
			WALL,
			// Token: 0x04009A3A RID: 39482
			[Token(Token = "0x4009A3A")]
			FLOOR
		}
	}
}
