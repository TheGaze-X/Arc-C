using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059E0 RID: 23008
	[Token(Token = "0x20059E0")]
	public class CrisisV2RuneSelectInfoGroupView : CrisisV2RuneSelectInfoBaseView
	{
		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x06021856 RID: 137302 RVA: 0x000BA8A0 File Offset: 0x000B8AA0
		[Token(Token = "0x17004EC2")]
		public override float preferredWidth
		{
			[Token(Token = "0x6021856")]
			[Address(RVA = "0x1BDC980", Offset = "0x1BDB580", VA = "0x181BDC980", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x06021857 RID: 137303 RVA: 0x000BA8B8 File Offset: 0x000B8AB8
		[Token(Token = "0x17004EC3")]
		public override float preferredHeight
		{
			[Token(Token = "0x6021857")]
			[Address(RVA = "0x1BDC910", Offset = "0x1BDB510", VA = "0x181BDC910", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x06021858 RID: 137304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EC4")]
		public override CanvasGroup alphaHandler
		{
			[Token(Token = "0x6021858")]
			[Address(RVA = "0x1BDC8B0", Offset = "0x1BDB4B0", VA = "0x181BDC8B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021859 RID: 137305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021859")]
		[Address(RVA = "0x1BDBBD0", Offset = "0x1BDA7D0", VA = "0x181BDBBD0", Slot = "16")]
		protected override void OnDataUpdated(CrisisV2RuneBaseViewModel viewModel)
		{
		}

		// Token: 0x0602185A RID: 137306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602185A")]
		[Address(RVA = "0x1BDBEC0", Offset = "0x1BDAAC0", VA = "0x181BDBEC0", Slot = "17")]
		protected override void OnFocusStatusChanged(bool isFocused)
		{
		}

		// Token: 0x0602185B RID: 137307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602185B")]
		[Address(RVA = "0x1BDBE00", Offset = "0x1BDAA00", VA = "0x181BDBE00", Slot = "18")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602185C RID: 137308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602185C")]
		[Address(RVA = "0x1BDC1D0", Offset = "0x1BDADD0", VA = "0x181BDC1D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602185D RID: 137309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602185D")]
		[Address(RVA = "0x1BDC0F0", Offset = "0x1BDACF0", VA = "0x181BDC0F0")]
		private void _InitFocusStatusIfNot()
		{
		}

		// Token: 0x0602185E RID: 137310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602185E")]
		[Address(RVA = "0x1BDC3C0", Offset = "0x1BDAFC0", VA = "0x181BDC3C0")]
		private void _TweenFocusState(float focusStayDur)
		{
		}

		// Token: 0x0602185F RID: 137311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602185F")]
		[Address(RVA = "0x1BDC710", Offset = "0x1BDB310", VA = "0x181BDC710")]
		private void _TweenUnFocusState()
		{
		}

		// Token: 0x06021860 RID: 137312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021860")]
		[Address(RVA = "0x1BDC2F0", Offset = "0x1BDAEF0", VA = "0x181BDC2F0")]
		private void _ShowOuterGlow(bool show)
		{
		}

		// Token: 0x06021861 RID: 137313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021861")]
		[Address(RVA = "0x1BDC060", Offset = "0x1BDAC60", VA = "0x181BDC060")]
		private void _ClearFocusTween()
		{
		}

		// Token: 0x06021862 RID: 137314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021862")]
		[Address(RVA = "0x1BDBAC0", Offset = "0x1BDA6C0", VA = "0x181BDBAC0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06021863 RID: 137315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021863")]
		[Address(RVA = "0x1BDC800", Offset = "0x1BDB400", VA = "0x181BDC800")]
		public CrisisV2RuneSelectInfoGroupView()
		{
		}

		// Token: 0x06021864 RID: 137316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021864")]
		[Address(RVA = "0x1BDB670", Offset = "0x1BDA270", VA = "0x181BDB670")]
		private void <>xLuaBaseProxy_OnFocusStatusChanged(bool P0)
		{
		}

		// Token: 0x06021865 RID: 137317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021865")]
		[Address(RVA = "0x1BDB610", Offset = "0x1BDA210", VA = "0x181BDB610")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402DCDC RID: 187612
		[Token(Token = "0x402DCDC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0402DCDD RID: 187613
		[Token(Token = "0x402DCDD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402DCDE RID: 187614
		[Token(Token = "0x402DCDE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _panelFocus;

		// Token: 0x0402DCDF RID: 187615
		[Token(Token = "0x402DCDF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402DCE0 RID: 187616
		[Token(Token = "0x402DCE0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VerticalLayoutGroup _layout;

		// Token: 0x0402DCE1 RID: 187617
		[Token(Token = "0x402DCE1")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402DCE2 RID: 187618
		[Token(Token = "0x402DCE2")]
		[FieldOffset(Offset = "0x50")]
		private string m_bagId;

		// Token: 0x0402DCE3 RID: 187619
		[Token(Token = "0x402DCE3")]
		[FieldOffset(Offset = "0x58")]
		private CrisisV2RuneSelectInfoGroupView.Adapter m_adapter;

		// Token: 0x0402DCE4 RID: 187620
		[Token(Token = "0x402DCE4")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_focusTween;

		// Token: 0x0402DCE5 RID: 187621
		[Token(Token = "0x402DCE5")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_focusOuterGlowTween;

		// Token: 0x0402DCE6 RID: 187622
		[Token(Token = "0x402DCE6")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isFocusInited;

		// Token: 0x0402DCE7 RID: 187623
		[Token(Token = "0x402DCE7")]
		[FieldOffset(Offset = "0x78")]
		private CrisisV2RunePackViewModel m_model;

		// Token: 0x0402DCE8 RID: 187624
		[Token(Token = "0x402DCE8")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DCE9 RID: 187625
		[Token(Token = "0x402DCE9")]
		[FieldOffset(Offset = "0x90")]
		private float FOCUS_BY_CLICK_SELF;

		// Token: 0x0402DCEA RID: 187626
		[Token(Token = "0x402DCEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0402DCEB RID: 187627
		[Token(Token = "0x402DCEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402DCEC RID: 187628
		[Token(Token = "0x402DCEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0402DCED RID: 187629
		[Token(Token = "0x402DCED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0402DCEE RID: 187630
		[Token(Token = "0x402DCEE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFocusStatusChanged;

		// Token: 0x0402DCEF RID: 187631
		[Token(Token = "0x402DCEF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DCF0 RID: 187632
		[Token(Token = "0x402DCF0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DCF1 RID: 187633
		[Token(Token = "0x402DCF1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitFocusStatusIfNot;

		// Token: 0x0402DCF2 RID: 187634
		[Token(Token = "0x402DCF2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TweenFocusState;

		// Token: 0x0402DCF3 RID: 187635
		[Token(Token = "0x402DCF3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TweenUnFocusState;

		// Token: 0x0402DCF4 RID: 187636
		[Token(Token = "0x402DCF4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowOuterGlow;

		// Token: 0x0402DCF5 RID: 187637
		[Token(Token = "0x402DCF5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearFocusTween;

		// Token: 0x0402DCF6 RID: 187638
		[Token(Token = "0x402DCF6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0402DCF7 RID: 187639
		[Token(Token = "0x402DCF7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059E1 RID: 23009
		[Token(Token = "0x20059E1")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06021866 RID: 137318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021866")]
			[Address(RVA = "0x1BD13D0", Offset = "0x1BCFFD0", VA = "0x181BD13D0")]
			public Adapter(CrisisV2RuneSelectInfoGroupView closure)
			{
			}

			// Token: 0x17004EC5 RID: 20165
			// (get) Token: 0x06021867 RID: 137319 RVA: 0x000BA8D0 File Offset: 0x000B8AD0
			[Token(Token = "0x17004EC5")]
			public override int count
			{
				[Token(Token = "0x6021867")]
				[Address(RVA = "0x1BD1450", Offset = "0x1BD0050", VA = "0x181BD1450", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021868 RID: 137320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021868")]
			[Address(RVA = "0x1BD1220", Offset = "0x1BCFE20", VA = "0x181BD1220", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021869 RID: 137321 RVA: 0x000BA8E8 File Offset: 0x000B8AE8
			[Token(Token = "0x6021869")]
			[Address(RVA = "0x1BD1060", Offset = "0x1BCFC60", VA = "0x181BD1060")]
			public float CalcHeight()
			{
				return 0f;
			}

			// Token: 0x0402DCF8 RID: 187640
			[Token(Token = "0x402DCF8")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2RuneSelectInfoGroupView m_closure;

			// Token: 0x0402DCF9 RID: 187641
			[Token(Token = "0x402DCF9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DCFA RID: 187642
			[Token(Token = "0x402DCFA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DCFB RID: 187643
			[Token(Token = "0x402DCFB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402DCFC RID: 187644
			[Token(Token = "0x402DCFC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CalcHeight;
		}
	}
}
