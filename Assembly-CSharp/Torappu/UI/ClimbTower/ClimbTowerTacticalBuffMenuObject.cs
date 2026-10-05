using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CDA RID: 23770
	[Token(Token = "0x2005CDA")]
	public class ClimbTowerTacticalBuffMenuObject : ClimbTowerMenuObject
	{
		// Token: 0x06022689 RID: 140937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022689")]
		[Address(RVA = "0x1CD7B10", Offset = "0x1CD6710", VA = "0x181CD7B10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602268A RID: 140938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602268A")]
		[Address(RVA = "0x1CD7660", Offset = "0x1CD6260", VA = "0x181CD7660", Slot = "4")]
		public override void Render(ClimbTowerMenuViewModel viewModel)
		{
		}

		// Token: 0x0602268B RID: 140939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602268B")]
		[Address(RVA = "0x1CD7720", Offset = "0x1CD6320", VA = "0x181CD7720")]
		public void SetShow(bool show)
		{
		}

		// Token: 0x0602268C RID: 140940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602268C")]
		[Address(RVA = "0x1CD7910", Offset = "0x1CD6510", VA = "0x181CD7910")]
		public void Toggle()
		{
		}

		// Token: 0x0602268D RID: 140941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602268D")]
		[Address(RVA = "0x1CD7DD0", Offset = "0x1CD69D0", VA = "0x181CD7DD0")]
		public ClimbTowerTacticalBuffMenuObject()
		{
		}

		// Token: 0x0402F4A5 RID: 193701
		[Token(Token = "0x402F4A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelFloat;

		// Token: 0x0402F4A6 RID: 193702
		[Token(Token = "0x402F4A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x0402F4A7 RID: 193703
		[Token(Token = "0x402F4A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasNormal;

		// Token: 0x0402F4A8 RID: 193704
		[Token(Token = "0x402F4A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402F4A9 RID: 193705
		[Token(Token = "0x402F4A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F4AA RID: 193706
		[Token(Token = "0x402F4AA")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerTacticalBuffMenuObject.ShowSwitchTween m_switchTween;

		// Token: 0x0402F4AB RID: 193707
		[Token(Token = "0x402F4AB")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerInnerBuffListModel m_cachedModel;

		// Token: 0x0402F4AC RID: 193708
		[Token(Token = "0x402F4AC")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerTacticalBuffMenuObject.Adapter m_adapter;

		// Token: 0x0402F4AD RID: 193709
		[Token(Token = "0x402F4AD")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402F4AE RID: 193710
		[Token(Token = "0x402F4AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F4AF RID: 193711
		[Token(Token = "0x402F4AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F4B0 RID: 193712
		[Token(Token = "0x402F4B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402F4B1 RID: 193713
		[Token(Token = "0x402F4B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Toggle;

		// Token: 0x0402F4B2 RID: 193714
		[Token(Token = "0x402F4B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CDB RID: 23771
		[Token(Token = "0x2005CDB")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602268F RID: 140943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602268F")]
			[Address(RVA = "0x1CCC520", Offset = "0x1CCB120", VA = "0x181CCC520")]
			public Adapter(ClimbTowerTacticalBuffMenuObject closure)
			{
			}

			// Token: 0x170050E5 RID: 20709
			// (get) Token: 0x06022690 RID: 140944 RVA: 0x000BD528 File Offset: 0x000BB728
			[Token(Token = "0x170050E5")]
			public override int count
			{
				[Token(Token = "0x6022690")]
				[Address(RVA = "0x1CCC6E0", Offset = "0x1CCB2E0", VA = "0x181CCC6E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022691 RID: 140945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022691")]
			[Address(RVA = "0x1CCC160", Offset = "0x1CCAD60", VA = "0x181CCC160", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402F4B3 RID: 193715
			[Token(Token = "0x402F4B3")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerTacticalBuffMenuObject m_closure;

			// Token: 0x0402F4B4 RID: 193716
			[Token(Token = "0x402F4B4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F4B5 RID: 193717
			[Token(Token = "0x402F4B5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402F4B6 RID: 193718
			[Token(Token = "0x402F4B6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02005CDC RID: 23772
		[Token(Token = "0x2005CDC")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x06022692 RID: 140946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022692")]
			[Address(RVA = "0x1CDFEE0", Offset = "0x1CDEAE0", VA = "0x181CDFEE0")]
			public ShowSwitchTween(ClimbTowerTacticalBuffMenuObject closure)
			{
			}

			// Token: 0x06022693 RID: 140947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022693")]
			[Address(RVA = "0x1CDF320", Offset = "0x1CDDF20", VA = "0x181CDF320", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06022694 RID: 140948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022694")]
			[Address(RVA = "0x1CDF740", Offset = "0x1CDE340", VA = "0x181CDF740", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06022695 RID: 140949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022695")]
			[Address(RVA = "0x1CDECA0", Offset = "0x1CDD8A0", VA = "0x181CDECA0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06022696 RID: 140950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022696")]
			[Address(RVA = "0x1CDF000", Offset = "0x1CDDC00", VA = "0x181CDF000", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06022697 RID: 140951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022697")]
			[Address(RVA = "0x1CDEDE0", Offset = "0x1CDD9E0", VA = "0x181CDEDE0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x06022698 RID: 140952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022698")]
			[Address(RVA = "0x1CDEEE0", Offset = "0x1CDDAE0", VA = "0x181CDEEE0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06022699 RID: 140953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022699")]
			[Address(RVA = "0x1CDFAC0", Offset = "0x1CDE6C0", VA = "0x181CDFAC0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602269A RID: 140954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602269A")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602269B RID: 140955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602269B")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602269C RID: 140956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602269C")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602269D RID: 140957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602269D")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602269E RID: 140958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602269E")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F4B7 RID: 193719
			[Token(Token = "0x402F4B7")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0402F4B8 RID: 193720
			[Token(Token = "0x402F4B8")]
			private const int CONTENT_HIDE_POS_Y = -18;

			// Token: 0x0402F4B9 RID: 193721
			[Token(Token = "0x402F4B9")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerTacticalBuffMenuObject m_closure;

			// Token: 0x0402F4BA RID: 193722
			[Token(Token = "0x402F4BA")]
			[FieldOffset(Offset = "0x50")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x0402F4BB RID: 193723
			[Token(Token = "0x402F4BB")]
			[FieldOffset(Offset = "0x58")]
			private RectTransform m_transContent;

			// Token: 0x0402F4BC RID: 193724
			[Token(Token = "0x402F4BC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F4BD RID: 193725
			[Token(Token = "0x402F4BD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F4BE RID: 193726
			[Token(Token = "0x402F4BE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F4BF RID: 193727
			[Token(Token = "0x402F4BF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F4C0 RID: 193728
			[Token(Token = "0x402F4C0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F4C1 RID: 193729
			[Token(Token = "0x402F4C1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402F4C2 RID: 193730
			[Token(Token = "0x402F4C2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402F4C3 RID: 193731
			[Token(Token = "0x402F4C3")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
