using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059E4 RID: 23012
	[Token(Token = "0x20059E4")]
	public class CrisisV2RuneSelectInfoSingleItemView : CrisisV2RuneSelectInfoBaseView
	{
		// Token: 0x17004EC7 RID: 20167
		// (get) Token: 0x06021876 RID: 137334 RVA: 0x000BA978 File Offset: 0x000B8B78
		[Token(Token = "0x17004EC7")]
		public override float preferredWidth
		{
			[Token(Token = "0x6021876")]
			[Address(RVA = "0x1BDE980", Offset = "0x1BDD580", VA = "0x181BDE980", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EC8 RID: 20168
		// (get) Token: 0x06021877 RID: 137335 RVA: 0x000BA990 File Offset: 0x000B8B90
		[Token(Token = "0x17004EC8")]
		public override float preferredHeight
		{
			[Token(Token = "0x6021877")]
			[Address(RVA = "0x1BDE8B0", Offset = "0x1BDD4B0", VA = "0x181BDE8B0", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004EC9 RID: 20169
		// (get) Token: 0x06021878 RID: 137336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004EC9")]
		public override CanvasGroup alphaHandler
		{
			[Token(Token = "0x6021878")]
			[Address(RVA = "0x1BDE850", Offset = "0x1BDD450", VA = "0x181BDE850", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021879 RID: 137337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021879")]
		[Address(RVA = "0x1BDD500", Offset = "0x1BDC100", VA = "0x181BDD500", Slot = "16")]
		protected override void OnDataUpdated(CrisisV2RuneBaseViewModel viewModel)
		{
		}

		// Token: 0x0602187A RID: 137338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602187A")]
		[Address(RVA = "0x1BDDD20", Offset = "0x1BDC920", VA = "0x181BDDD20", Slot = "17")]
		protected override void OnFocusStatusChanged(bool isFocused)
		{
		}

		// Token: 0x0602187B RID: 137339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602187B")]
		[Address(RVA = "0x1BDDC40", Offset = "0x1BDC840", VA = "0x181BDDC40", Slot = "18")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602187C RID: 137340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602187C")]
		[Address(RVA = "0x1BDDFA0", Offset = "0x1BDCBA0", VA = "0x181BDDFA0")]
		private void _InitFocusStatusIfNot()
		{
		}

		// Token: 0x0602187D RID: 137341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602187D")]
		[Address(RVA = "0x1BDE140", Offset = "0x1BDCD40", VA = "0x181BDE140")]
		private void _RenderBg(CrisisV2RuneBaseViewModel.SingleViewInfoBgType itemBgType)
		{
		}

		// Token: 0x0602187E RID: 137342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602187E")]
		[Address(RVA = "0x1BDE2E0", Offset = "0x1BDCEE0", VA = "0x181BDE2E0")]
		private void _TweenFocusState(float focusStayDur)
		{
		}

		// Token: 0x0602187F RID: 137343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602187F")]
		[Address(RVA = "0x1BDE670", Offset = "0x1BDD270", VA = "0x181BDE670")]
		private void _TweenUnFocusState()
		{
		}

		// Token: 0x06021880 RID: 137344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021880")]
		[Address(RVA = "0x1BDE210", Offset = "0x1BDCE10", VA = "0x181BDE210")]
		private void _ShowOuterGlow(bool show)
		{
		}

		// Token: 0x06021881 RID: 137345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021881")]
		[Address(RVA = "0x1BDDF10", Offset = "0x1BDCB10", VA = "0x181BDDF10")]
		private void _ClearFocusTween()
		{
		}

		// Token: 0x06021882 RID: 137346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021882")]
		[Address(RVA = "0x1BDD3F0", Offset = "0x1BDBFF0", VA = "0x181BDD3F0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06021883 RID: 137347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021883")]
		[Address(RVA = "0x1BDE7A0", Offset = "0x1BDD3A0", VA = "0x181BDE7A0")]
		public CrisisV2RuneSelectInfoSingleItemView()
		{
		}

		// Token: 0x06021884 RID: 137348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021884")]
		[Address(RVA = "0x1BDB670", Offset = "0x1BDA270", VA = "0x181BDB670")]
		private void <>xLuaBaseProxy_OnFocusStatusChanged(bool P0)
		{
		}

		// Token: 0x06021885 RID: 137349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021885")]
		[Address(RVA = "0x1BDB610", Offset = "0x1BDA210", VA = "0x181BDB610")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402DD14 RID: 187668
		[Token(Token = "0x402DD14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402DD15 RID: 187669
		[Token(Token = "0x402DD15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _paddingHeight;

		// Token: 0x0402DD16 RID: 187670
		[Token(Token = "0x402DD16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _panelFocus;

		// Token: 0x0402DD17 RID: 187671
		[Token(Token = "0x402DD17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CrisisV2RuneSelectInfoItemView _itemView;

		// Token: 0x0402DD18 RID: 187672
		[Token(Token = "0x402DD18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x0402DD19 RID: 187673
		[Token(Token = "0x402DD19")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colBgDark;

		// Token: 0x0402DD1A RID: 187674
		[Token(Token = "0x402DD1A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colBgGray;

		// Token: 0x0402DD1B RID: 187675
		[Token(Token = "0x402DD1B")]
		[FieldOffset(Offset = "0x68")]
		private string m_nodeId;

		// Token: 0x0402DD1C RID: 187676
		[Token(Token = "0x402DD1C")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isFocusInited;

		// Token: 0x0402DD1D RID: 187677
		[Token(Token = "0x402DD1D")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_focusTween;

		// Token: 0x0402DD1E RID: 187678
		[Token(Token = "0x402DD1E")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_focusOuterGlowTween;

		// Token: 0x0402DD1F RID: 187679
		[Token(Token = "0x402DD1F")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DD20 RID: 187680
		[Token(Token = "0x402DD20")]
		[FieldOffset(Offset = "0x98")]
		private string m_cacheId;

		// Token: 0x0402DD21 RID: 187681
		[Token(Token = "0x402DD21")]
		[FieldOffset(Offset = "0xA0")]
		private CrisisV2RuneBaseViewModel.SingleViewInfoBgType m_cachedBgType;

		// Token: 0x0402DD22 RID: 187682
		[Token(Token = "0x402DD22")]
		[FieldOffset(Offset = "0xA4")]
		private float FOCUS_BY_CLICK_SELF;

		// Token: 0x0402DD23 RID: 187683
		[Token(Token = "0x402DD23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0402DD24 RID: 187684
		[Token(Token = "0x402DD24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402DD25 RID: 187685
		[Token(Token = "0x402DD25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0402DD26 RID: 187686
		[Token(Token = "0x402DD26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0402DD27 RID: 187687
		[Token(Token = "0x402DD27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFocusStatusChanged;

		// Token: 0x0402DD28 RID: 187688
		[Token(Token = "0x402DD28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DD29 RID: 187689
		[Token(Token = "0x402DD29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitFocusStatusIfNot;

		// Token: 0x0402DD2A RID: 187690
		[Token(Token = "0x402DD2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBg;

		// Token: 0x0402DD2B RID: 187691
		[Token(Token = "0x402DD2B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TweenFocusState;

		// Token: 0x0402DD2C RID: 187692
		[Token(Token = "0x402DD2C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TweenUnFocusState;

		// Token: 0x0402DD2D RID: 187693
		[Token(Token = "0x402DD2D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowOuterGlow;

		// Token: 0x0402DD2E RID: 187694
		[Token(Token = "0x402DD2E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ClearFocusTween;

		// Token: 0x0402DD2F RID: 187695
		[Token(Token = "0x402DD2F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x0402DD30 RID: 187696
		[Token(Token = "0x402DD30")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
