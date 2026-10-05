using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CD7 RID: 23767
	[Token(Token = "0x2005CD7")]
	public class ClimbTowerSquadMenuObject : ClimbTowerMenuObject
	{
		// Token: 0x170050E4 RID: 20708
		// (get) Token: 0x06022678 RID: 140920 RVA: 0x000BD510 File Offset: 0x000BB710
		[Token(Token = "0x170050E4")]
		public ClimbTowerSquadMenuObject.ButtonState state
		{
			[Token(Token = "0x6022678")]
			[Address(RVA = "0x1CD7600", Offset = "0x1CD6200", VA = "0x181CD7600")]
			get
			{
				return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
			}
		}

		// Token: 0x06022679 RID: 140921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022679")]
		[Address(RVA = "0x1CD7190", Offset = "0x1CD5D90", VA = "0x181CD7190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602267A RID: 140922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602267A")]
		[Address(RVA = "0x1CD7320", Offset = "0x1CD5F20", VA = "0x181CD7320")]
		private void _RefreshCanvas(bool fastMode)
		{
		}

		// Token: 0x0602267B RID: 140923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602267B")]
		[Address(RVA = "0x1CD6EC0", Offset = "0x1CD5AC0", VA = "0x181CD6EC0", Slot = "4")]
		public override void Render(ClimbTowerMenuViewModel viewModel)
		{
		}

		// Token: 0x0602267C RID: 140924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602267C")]
		[Address(RVA = "0x1CD6E40", Offset = "0x1CD5A40", VA = "0x181CD6E40")]
		public void OnTacticalBuffWindowShowStatusUpdated(bool isShow)
		{
		}

		// Token: 0x0602267D RID: 140925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602267D")]
		[Address(RVA = "0x1CD70F0", Offset = "0x1CD5CF0", VA = "0x181CD70F0")]
		public void SetState(ClimbTowerSquadMenuObject.ButtonState state, bool fastMode)
		{
		}

		// Token: 0x0602267E RID: 140926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602267E")]
		[Address(RVA = "0x1CD68A0", Offset = "0x1CD54A0", VA = "0x181CD68A0")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0602267F RID: 140927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602267F")]
		[Address(RVA = "0x1CD7560", Offset = "0x1CD6160", VA = "0x181CD7560")]
		public ClimbTowerSquadMenuObject()
		{
		}

		// Token: 0x0402F485 RID: 193669
		[Token(Token = "0x402F485")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textSquadCount;

		// Token: 0x0402F486 RID: 193670
		[Token(Token = "0x402F486")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasNormal;

		// Token: 0x0402F487 RID: 193671
		[Token(Token = "0x402F487")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402F488 RID: 193672
		[Token(Token = "0x402F488")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasSelectedOutline;

		// Token: 0x0402F489 RID: 193673
		[Token(Token = "0x402F489")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelFold;

		// Token: 0x0402F48A RID: 193674
		[Token(Token = "0x402F48A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _raycastBlocker;

		// Token: 0x0402F48B RID: 193675
		[Token(Token = "0x402F48B")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerSquadMenuObject.ShowSwitchTween m_selectedSwitchTween;

		// Token: 0x0402F48C RID: 193676
		[Token(Token = "0x402F48C")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_outlineSwitchTween;

		// Token: 0x0402F48D RID: 193677
		[Token(Token = "0x402F48D")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402F48E RID: 193678
		[Token(Token = "0x402F48E")]
		[FieldOffset(Offset = "0x61")]
		private bool m_tacticalBuffWindowShow;

		// Token: 0x0402F48F RID: 193679
		[Token(Token = "0x402F48F")]
		[FieldOffset(Offset = "0x64")]
		private ClimbTowerSquadMenuObject.ButtonState m_state;

		// Token: 0x0402F490 RID: 193680
		[Token(Token = "0x402F490")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0402F491 RID: 193681
		[Token(Token = "0x402F491")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F492 RID: 193682
		[Token(Token = "0x402F492")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshCanvas;

		// Token: 0x0402F493 RID: 193683
		[Token(Token = "0x402F493")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F494 RID: 193684
		[Token(Token = "0x402F494")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTacticalBuffWindowShowStatusUpdated;

		// Token: 0x0402F495 RID: 193685
		[Token(Token = "0x402F495")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetState;

		// Token: 0x0402F496 RID: 193686
		[Token(Token = "0x402F496")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402F497 RID: 193687
		[Token(Token = "0x402F497")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CD8 RID: 23768
		[Token(Token = "0x2005CD8")]
		public enum ButtonState
		{
			// Token: 0x0402F499 RID: 193689
			[Token(Token = "0x402F499")]
			NORMAL,
			// Token: 0x0402F49A RID: 193690
			[Token(Token = "0x402F49A")]
			SELECTED,
			// Token: 0x0402F49B RID: 193691
			[Token(Token = "0x402F49B")]
			FORCE_SELECTED
		}

		// Token: 0x02005CD9 RID: 23769
		[Token(Token = "0x2005CD9")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x06022680 RID: 140928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022680")]
			[Address(RVA = "0x1CDFE60", Offset = "0x1CDEA60", VA = "0x181CDFE60")]
			public ShowSwitchTween(ClimbTowerSquadMenuObject closure)
			{
			}

			// Token: 0x06022681 RID: 140929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022681")]
			[Address(RVA = "0x1CDF1B0", Offset = "0x1CDDDB0", VA = "0x181CDF1B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06022682 RID: 140930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022682")]
			[Address(RVA = "0x1CDF950", Offset = "0x1CDE550", VA = "0x181CDF950", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06022683 RID: 140931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022683")]
			[Address(RVA = "0x1CDEC10", Offset = "0x1CDD810", VA = "0x181CDEC10", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06022684 RID: 140932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022684")]
			[Address(RVA = "0x1CDEF70", Offset = "0x1CDDB70", VA = "0x181CDEF70", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06022685 RID: 140933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022685")]
			[Address(RVA = "0x1CDFD70", Offset = "0x1CDE970", VA = "0x181CDFD70", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06022686 RID: 140934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022686")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06022687 RID: 140935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022687")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06022688 RID: 140936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022688")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F49C RID: 193692
			[Token(Token = "0x402F49C")]
			private const float ANIM_DURATION = 0.23f;

			// Token: 0x0402F49D RID: 193693
			[Token(Token = "0x402F49D")]
			private const float ALPHA_SELECTED_BKG = 0.2f;

			// Token: 0x0402F49E RID: 193694
			[Token(Token = "0x402F49E")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerSquadMenuObject m_closure;

			// Token: 0x0402F49F RID: 193695
			[Token(Token = "0x402F49F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F4A0 RID: 193696
			[Token(Token = "0x402F4A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F4A1 RID: 193697
			[Token(Token = "0x402F4A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F4A2 RID: 193698
			[Token(Token = "0x402F4A2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F4A3 RID: 193699
			[Token(Token = "0x402F4A3")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F4A4 RID: 193700
			[Token(Token = "0x402F4A4")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
