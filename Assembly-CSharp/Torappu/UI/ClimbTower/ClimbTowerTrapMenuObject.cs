using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CDD RID: 23773
	[Token(Token = "0x2005CDD")]
	public class ClimbTowerTrapMenuObject : ClimbTowerMenuObject
	{
		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x0602269F RID: 140959 RVA: 0x000BD540 File Offset: 0x000BB740
		[Token(Token = "0x170050E6")]
		public ClimbTowerTrapMenuObject.ButtonState state
		{
			[Token(Token = "0x602269F")]
			[Address(RVA = "0x1CDB6F0", Offset = "0x1CDA2F0", VA = "0x181CDB6F0")]
			get
			{
				return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
			}
		}

		// Token: 0x060226A0 RID: 140960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A0")]
		[Address(RVA = "0x1CDB230", Offset = "0x1CD9E30", VA = "0x181CDB230")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060226A1 RID: 140961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A1")]
		[Address(RVA = "0x1CDB460", Offset = "0x1CDA060", VA = "0x181CDB460")]
		private void _RefreshCanvas(bool fastMode)
		{
		}

		// Token: 0x060226A2 RID: 140962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A2")]
		[Address(RVA = "0x1CDAEC0", Offset = "0x1CD9AC0", VA = "0x181CDAEC0", Slot = "4")]
		public override void Render(ClimbTowerMenuViewModel viewModel)
		{
		}

		// Token: 0x060226A3 RID: 140963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A3")]
		[Address(RVA = "0x1CDAE40", Offset = "0x1CD9A40", VA = "0x181CDAE40")]
		public void OnTacticalBuffWindowShowStatusUpdated(bool isShow)
		{
		}

		// Token: 0x060226A4 RID: 140964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A4")]
		[Address(RVA = "0x1CDB190", Offset = "0x1CD9D90", VA = "0x181CDB190")]
		public void SetState(ClimbTowerTrapMenuObject.ButtonState state, bool fastMode)
		{
		}

		// Token: 0x060226A5 RID: 140965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A5")]
		[Address(RVA = "0x1CDA970", Offset = "0x1CD9570", VA = "0x181CDA970")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x060226A6 RID: 140966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226A6")]
		[Address(RVA = "0x1CDB650", Offset = "0x1CDA250", VA = "0x181CDB650")]
		public ClimbTowerTrapMenuObject()
		{
		}

		// Token: 0x0402F4C4 RID: 193732
		[Token(Token = "0x402F4C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTrapCount;

		// Token: 0x0402F4C5 RID: 193733
		[Token(Token = "0x402F4C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCurse;

		// Token: 0x0402F4C6 RID: 193734
		[Token(Token = "0x402F4C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCard;

		// Token: 0x0402F4C7 RID: 193735
		[Token(Token = "0x402F4C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasNormal;

		// Token: 0x0402F4C8 RID: 193736
		[Token(Token = "0x402F4C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402F4C9 RID: 193737
		[Token(Token = "0x402F4C9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasSelectedOutline;

		// Token: 0x0402F4CA RID: 193738
		[Token(Token = "0x402F4CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasRoot;

		// Token: 0x0402F4CB RID: 193739
		[Token(Token = "0x402F4CB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x0402F4CC RID: 193740
		[Token(Token = "0x402F4CC")]
		[FieldOffset(Offset = "0x60")]
		private ClimbTowerTrapMenuObject.SelectedSwitchTween m_selectedSwitchTween;

		// Token: 0x0402F4CD RID: 193741
		[Token(Token = "0x402F4CD")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_outlineSwitchTween;

		// Token: 0x0402F4CE RID: 193742
		[Token(Token = "0x402F4CE")]
		[FieldOffset(Offset = "0x70")]
		private ClimbTowerTrapMenuObject.AvailableSwitchTween m_availableSwitchTween;

		// Token: 0x0402F4CF RID: 193743
		[Token(Token = "0x402F4CF")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0402F4D0 RID: 193744
		[Token(Token = "0x402F4D0")]
		[FieldOffset(Offset = "0x79")]
		private bool m_tacticalBuffWindowShow;

		// Token: 0x0402F4D1 RID: 193745
		[Token(Token = "0x402F4D1")]
		[FieldOffset(Offset = "0x7C")]
		private ClimbTowerTrapMenuObject.ButtonState m_state;

		// Token: 0x0402F4D2 RID: 193746
		[Token(Token = "0x402F4D2")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedTrapCount;

		// Token: 0x0402F4D3 RID: 193747
		[Token(Token = "0x402F4D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0402F4D4 RID: 193748
		[Token(Token = "0x402F4D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F4D5 RID: 193749
		[Token(Token = "0x402F4D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshCanvas;

		// Token: 0x0402F4D6 RID: 193750
		[Token(Token = "0x402F4D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F4D7 RID: 193751
		[Token(Token = "0x402F4D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTacticalBuffWindowShowStatusUpdated;

		// Token: 0x0402F4D8 RID: 193752
		[Token(Token = "0x402F4D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetState;

		// Token: 0x0402F4D9 RID: 193753
		[Token(Token = "0x402F4D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402F4DA RID: 193754
		[Token(Token = "0x402F4DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CDE RID: 23774
		[Token(Token = "0x2005CDE")]
		public enum ButtonState
		{
			// Token: 0x0402F4DC RID: 193756
			[Token(Token = "0x402F4DC")]
			NORMAL,
			// Token: 0x0402F4DD RID: 193757
			[Token(Token = "0x402F4DD")]
			SELECTED,
			// Token: 0x0402F4DE RID: 193758
			[Token(Token = "0x402F4DE")]
			DISABLED
		}

		// Token: 0x02005CDF RID: 23775
		[Token(Token = "0x2005CDF")]
		private class SelectedSwitchTween : UISwitchTween
		{
			// Token: 0x060226A7 RID: 140967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226A7")]
			[Address(RVA = "0x1CDEB90", Offset = "0x1CDD790", VA = "0x181CDEB90")]
			public SelectedSwitchTween(ClimbTowerTrapMenuObject closure)
			{
			}

			// Token: 0x060226A8 RID: 140968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60226A8")]
			[Address(RVA = "0x1CDE7C0", Offset = "0x1CDD3C0", VA = "0x181CDE7C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060226A9 RID: 140969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60226A9")]
			[Address(RVA = "0x1CDE930", Offset = "0x1CDD530", VA = "0x181CDE930", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060226AA RID: 140970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226AA")]
			[Address(RVA = "0x1CDE6A0", Offset = "0x1CDD2A0", VA = "0x181CDE6A0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x060226AB RID: 140971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226AB")]
			[Address(RVA = "0x1CDE730", Offset = "0x1CDD330", VA = "0x181CDE730", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060226AC RID: 140972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226AC")]
			[Address(RVA = "0x1CDEAA0", Offset = "0x1CDD6A0", VA = "0x181CDEAA0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060226AD RID: 140973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226AD")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x060226AE RID: 140974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226AE")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x060226AF RID: 140975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226AF")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F4DF RID: 193759
			[Token(Token = "0x402F4DF")]
			private const float ANIM_DURATION = 0.23f;

			// Token: 0x0402F4E0 RID: 193760
			[Token(Token = "0x402F4E0")]
			private const float ALPHA_SELECTED_BKG = 0.2f;

			// Token: 0x0402F4E1 RID: 193761
			[Token(Token = "0x402F4E1")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerTrapMenuObject m_closure;

			// Token: 0x0402F4E2 RID: 193762
			[Token(Token = "0x402F4E2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F4E3 RID: 193763
			[Token(Token = "0x402F4E3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F4E4 RID: 193764
			[Token(Token = "0x402F4E4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F4E5 RID: 193765
			[Token(Token = "0x402F4E5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F4E6 RID: 193766
			[Token(Token = "0x402F4E6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F4E7 RID: 193767
			[Token(Token = "0x402F4E7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02005CE0 RID: 23776
		[Token(Token = "0x2005CE0")]
		private class AvailableSwitchTween : UISwitchTween
		{
			// Token: 0x060226B0 RID: 140976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226B0")]
			[Address(RVA = "0x1CCCDE0", Offset = "0x1CCB9E0", VA = "0x181CCCDE0")]
			public AvailableSwitchTween(ClimbTowerTrapMenuObject closure)
			{
			}

			// Token: 0x060226B1 RID: 140977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60226B1")]
			[Address(RVA = "0x1CCCB00", Offset = "0x1CCB700", VA = "0x181CCCB00", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060226B2 RID: 140978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60226B2")]
			[Address(RVA = "0x1CCCC20", Offset = "0x1CCB820", VA = "0x181CCCC20", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060226B3 RID: 140979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226B3")]
			[Address(RVA = "0x1CCCD40", Offset = "0x1CCB940", VA = "0x181CCCD40", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060226B4 RID: 140980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60226B4")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F4E8 RID: 193768
			[Token(Token = "0x402F4E8")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0402F4E9 RID: 193769
			[Token(Token = "0x402F4E9")]
			private const float ALPHA_UNAVAILABLE = 0.2f;

			// Token: 0x0402F4EA RID: 193770
			[Token(Token = "0x402F4EA")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerTrapMenuObject m_closure;

			// Token: 0x0402F4EB RID: 193771
			[Token(Token = "0x402F4EB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F4EC RID: 193772
			[Token(Token = "0x402F4EC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F4ED RID: 193773
			[Token(Token = "0x402F4ED")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F4EE RID: 193774
			[Token(Token = "0x402F4EE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
