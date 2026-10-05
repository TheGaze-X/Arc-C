using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061CC RID: 25036
	[Token(Token = "0x20061CC")]
	public class BossRushStageDetailSwitchButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x060241F8 RID: 147960 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060241F9 RID: 147961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700553B")]
		public Action onBtnClick
		{
			[Token(Token = "0x60241F8")]
			[Address(RVA = "0x1EDF070", Offset = "0x1EDDC70", VA = "0x181EDF070")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60241F9")]
			[Address(RVA = "0x1EDF0D0", Offset = "0x1EDDCD0", VA = "0x181EDF0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060241FA RID: 147962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241FA")]
		[Address(RVA = "0x1EDED30", Offset = "0x1EDD930", VA = "0x181EDED30")]
		public void Render(bool canSpModeShow, bool isSpModeShow)
		{
		}

		// Token: 0x060241FB RID: 147963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241FB")]
		[Address(RVA = "0x1EDEC40", Offset = "0x1EDD840", VA = "0x181EDEC40")]
		public void OnClick()
		{
		}

		// Token: 0x060241FC RID: 147964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241FC")]
		[Address(RVA = "0x1EDEF10", Offset = "0x1EDDB10", VA = "0x181EDEF10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060241FD RID: 147965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241FD")]
		[Address(RVA = "0x1EDF010", Offset = "0x1EDDC10", VA = "0x181EDF010")]
		public BossRushStageDetailSwitchButtonView()
		{
		}

		// Token: 0x04032380 RID: 205696
		[Token(Token = "0x4032380")]
		private const float START_WIDTH = 63f;

		// Token: 0x04032381 RID: 205697
		[Token(Token = "0x4032381")]
		private const float END_WIDTH = 241f;

		// Token: 0x04032382 RID: 205698
		[Token(Token = "0x4032382")]
		private const float HEIGHT = 59f;

		// Token: 0x04032383 RID: 205699
		[Token(Token = "0x4032383")]
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x04032384 RID: 205700
		[Token(Token = "0x4032384")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSpUnselect;

		// Token: 0x04032385 RID: 205701
		[Token(Token = "0x4032385")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSpSelect;

		// Token: 0x04032386 RID: 205702
		[Token(Token = "0x4032386")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _normalBtnToggle;

		// Token: 0x04032387 RID: 205703
		[Token(Token = "0x4032387")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAnimSwitch;

		// Token: 0x04032388 RID: 205704
		[Token(Token = "0x4032388")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroupAnimSwitch;

		// Token: 0x04032389 RID: 205705
		[Token(Token = "0x4032389")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rectAnimSwitch;

		// Token: 0x0403238A RID: 205706
		[Token(Token = "0x403238A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _toggleAnimSwitch;

		// Token: 0x0403238B RID: 205707
		[Token(Token = "0x403238B")]
		[FieldOffset(Offset = "0x50")]
		private BossRushStageDetailSwitchButtonView.SwitchTween m_switchTween;

		// Token: 0x0403238C RID: 205708
		[Token(Token = "0x403238C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403238E RID: 205710
		[Token(Token = "0x403238E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnClick;

		// Token: 0x0403238F RID: 205711
		[Token(Token = "0x403238F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnClick;

		// Token: 0x04032390 RID: 205712
		[Token(Token = "0x4032390")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032391 RID: 205713
		[Token(Token = "0x4032391")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04032392 RID: 205714
		[Token(Token = "0x4032392")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032393 RID: 205715
		[Token(Token = "0x4032393")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061CD RID: 25037
		[Token(Token = "0x20061CD")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x060241FE RID: 147966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241FE")]
			[Address(RVA = "0x1EE5650", Offset = "0x1EE4250", VA = "0x181EE5650")]
			public SwitchTween(BossRushStageDetailSwitchButtonView closure)
			{
			}

			// Token: 0x060241FF RID: 147967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241FF")]
			[Address(RVA = "0x1EE4E50", Offset = "0x1EE3A50", VA = "0x181EE4E50", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06024200 RID: 147968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024200")]
			[Address(RVA = "0x1EE4F80", Offset = "0x1EE3B80", VA = "0x181EE4F80", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06024201 RID: 147969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024201")]
			[Address(RVA = "0x1EE4D50", Offset = "0x1EE3950", VA = "0x181EE4D50", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06024202 RID: 147970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024202")]
			[Address(RVA = "0x1EE4DD0", Offset = "0x1EE39D0", VA = "0x181EE4DD0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x06024203 RID: 147971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024203")]
			[Address(RVA = "0x1EE50A0", Offset = "0x1EE3CA0", VA = "0x181EE50A0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06024204 RID: 147972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024204")]
			[Address(RVA = "0x1EE52A0", Offset = "0x1EE3EA0", VA = "0x181EE52A0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06024205 RID: 147973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024205")]
			[Address(RVA = "0x1EE54A0", Offset = "0x1EE40A0", VA = "0x181EE54A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06024208 RID: 147976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024208")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06024209 RID: 147977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024209")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602420A RID: 147978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602420A")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602420B RID: 147979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602420B")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602420C RID: 147980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602420C")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04032394 RID: 205716
			[Token(Token = "0x4032394")]
			[FieldOffset(Offset = "0x48")]
			private BossRushStageDetailSwitchButtonView m_closure;

			// Token: 0x04032395 RID: 205717
			[Token(Token = "0x4032395")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032396 RID: 205718
			[Token(Token = "0x4032396")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04032397 RID: 205719
			[Token(Token = "0x4032397")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04032398 RID: 205720
			[Token(Token = "0x4032398")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04032399 RID: 205721
			[Token(Token = "0x4032399")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0403239A RID: 205722
			[Token(Token = "0x403239A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403239B RID: 205723
			[Token(Token = "0x403239B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403239C RID: 205724
			[Token(Token = "0x403239C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
