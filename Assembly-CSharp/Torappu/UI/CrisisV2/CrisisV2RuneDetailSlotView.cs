using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059D1 RID: 22993
	[Token(Token = "0x20059D1")]
	public class CrisisV2RuneDetailSlotView : UICustomAdapterLayout<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>
	{
		// Token: 0x06021819 RID: 137241 RVA: 0x000BA7B0 File Offset: 0x000B89B0
		[Token(Token = "0x6021819")]
		[Address(RVA = "0x1BDA770", Offset = "0x1BD9370", VA = "0x181BDA770")]
		public bool ShowSlotView(CrisisV2MapModel model)
		{
			return default(bool);
		}

		// Token: 0x0602181A RID: 137242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602181A")]
		[Address(RVA = "0x1BDA8F0", Offset = "0x1BD94F0", VA = "0x181BDA8F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602181B RID: 137243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602181B")]
		[Address(RVA = "0x1BDAC20", Offset = "0x1BD9820", VA = "0x181BDAC20")]
		private void _OnRuneDetailListChanged()
		{
		}

		// Token: 0x0602181C RID: 137244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602181C")]
		[Address(RVA = "0x1BDACD0", Offset = "0x1BD98D0", VA = "0x181BDACD0")]
		public CrisisV2RuneDetailSlotView()
		{
		}

		// Token: 0x0402DC7E RID: 187518
		[Token(Token = "0x402DC7E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402DC7F RID: 187519
		[Token(Token = "0x402DC7F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x0402DC80 RID: 187520
		[Token(Token = "0x402DC80")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x0402DC81 RID: 187521
		[Token(Token = "0x402DC81")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0402DC82 RID: 187522
		[Token(Token = "0x402DC82")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _downPadding;

		// Token: 0x0402DC83 RID: 187523
		[Token(Token = "0x402DC83")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CrisisV2RuneSelectInfoSingleItemView _itemViewPrefab;

		// Token: 0x0402DC84 RID: 187524
		[Token(Token = "0x402DC84")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CrisisV2RuneSelectInfoSingleTitleView _titleViewPrefab;

		// Token: 0x0402DC85 RID: 187525
		[Token(Token = "0x402DC85")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _showHideDuration;

		// Token: 0x0402DC86 RID: 187526
		[Token(Token = "0x402DC86")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x0402DC87 RID: 187527
		[Token(Token = "0x402DC87")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x0402DC88 RID: 187528
		[Token(Token = "0x402DC88")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0402DC89 RID: 187529
		[Token(Token = "0x402DC89")]
		[FieldOffset(Offset = "0xC8")]
		private CrisisV2RuneDetailSlotView.InnerLayouter m_layouter;

		// Token: 0x0402DC8A RID: 187530
		[Token(Token = "0x402DC8A")]
		[FieldOffset(Offset = "0xD0")]
		private CrisisV2RuneDetailSlotView.InnerAdapter m_adapter;

		// Token: 0x0402DC8B RID: 187531
		[Token(Token = "0x402DC8B")]
		[FieldOffset(Offset = "0xD8")]
		private UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.Options m_layoutOption;

		// Token: 0x0402DC8C RID: 187532
		[Token(Token = "0x402DC8C")]
		[FieldOffset(Offset = "0xF8")]
		private CrisisV2MapModel m_model;

		// Token: 0x0402DC8D RID: 187533
		[Token(Token = "0x402DC8D")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedFocusSeq;

		// Token: 0x0402DC8E RID: 187534
		[Token(Token = "0x402DC8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowSlotView;

		// Token: 0x0402DC8F RID: 187535
		[Token(Token = "0x402DC8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DC90 RID: 187536
		[Token(Token = "0x402DC90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnRuneDetailListChanged;

		// Token: 0x0402DC91 RID: 187537
		[Token(Token = "0x402DC91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059D2 RID: 22994
		[Token(Token = "0x20059D2")]
		private class InnerAdapter : UICustomAdapterLayout<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.Adapter
		{
			// Token: 0x0602181D RID: 137245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602181D")]
			[Address(RVA = "0x1BE14B0", Offset = "0x1BE00B0", VA = "0x181BE14B0")]
			public InnerAdapter(CrisisV2RuneDetailSlotView closure)
			{
			}

			// Token: 0x0602181E RID: 137246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602181E")]
			[Address(RVA = "0x1BE0D90", Offset = "0x1BDF990", VA = "0x181BE0D90", Slot = "6")]
			public override CrisisV2RuneSelectInfoBaseView CreateInst(CrisisV2RuneSingleViewModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0602181F RID: 137247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602181F")]
			[Address(RVA = "0x1BE1250", Offset = "0x1BDFE50", VA = "0x181BE1250", Slot = "7")]
			public override void UpdateView(CrisisV2RuneSelectInfoBaseView view, CrisisV2RuneSingleViewModel data)
			{
			}

			// Token: 0x06021820 RID: 137248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021820")]
			[Address(RVA = "0x1BE11B0", Offset = "0x1BDFDB0", VA = "0x181BE11B0", Slot = "5")]
			public override string GetId(CrisisV2RuneSingleViewModel data)
			{
				return null;
			}

			// Token: 0x06021821 RID: 137249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021821")]
			[Address(RVA = "0x1BE1080", Offset = "0x1BDFC80", VA = "0x181BE1080", Slot = "4")]
			public override IList<CrisisV2RuneSingleViewModel> GetData()
			{
				return null;
			}

			// Token: 0x0402DC92 RID: 187538
			[Token(Token = "0x402DC92")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2RuneDetailSlotView m_closure;

			// Token: 0x0402DC93 RID: 187539
			[Token(Token = "0x402DC93")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DC94 RID: 187540
			[Token(Token = "0x402DC94")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0402DC95 RID: 187541
			[Token(Token = "0x402DC95")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x0402DC96 RID: 187542
			[Token(Token = "0x402DC96")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0402DC97 RID: 187543
			[Token(Token = "0x402DC97")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x020059D3 RID: 22995
		[Token(Token = "0x20059D3")]
		private class InnerLayouter : UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>
		{
			// Token: 0x06021822 RID: 137250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021822")]
			[Address(RVA = "0x1BE5DE0", Offset = "0x1BE49E0", VA = "0x181BE5DE0")]
			public InnerLayouter(CrisisV2RuneDetailSlotView closure)
			{
			}

			// Token: 0x06021823 RID: 137251 RVA: 0x000BA7C8 File Offset: 0x000B89C8
			[Token(Token = "0x6021823")]
			[Address(RVA = "0x1BE15D0", Offset = "0x1BE01D0", VA = "0x181BE15D0", Slot = "6")]
			protected override int DataComparison(CrisisV2RuneSingleViewModel lhs, CrisisV2RuneSingleViewModel rhs)
			{
				return 0;
			}

			// Token: 0x06021824 RID: 137252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021824")]
			[Address(RVA = "0x1BE19A0", Offset = "0x1BE05A0", VA = "0x181BE19A0", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x06021825 RID: 137253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021825")]
			[Address(RVA = "0x1BE21F0", Offset = "0x1BE0DF0", VA = "0x181BE21F0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x06021826 RID: 137254 RVA: 0x000BA7E0 File Offset: 0x000B89E0
			[Token(Token = "0x6021826")]
			[Address(RVA = "0x1BE5600", Offset = "0x1BE4200", VA = "0x181BE5600")]
			private float _TryGetTotalElementHeight()
			{
				return 0f;
			}

			// Token: 0x06021827 RID: 137255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021827")]
			[Address(RVA = "0x1BE52B0", Offset = "0x1BE3EB0", VA = "0x181BE52B0")]
			private Dictionary<string, float> _TryGetTitlePosDict()
			{
				return null;
			}

			// Token: 0x06021828 RID: 137256 RVA: 0x000BA7F8 File Offset: 0x000B89F8
			[Token(Token = "0x6021828")]
			[Address(RVA = "0x1BE5190", Offset = "0x1BE3D90", VA = "0x181BE5190")]
			private float _TryGetHeightBeforeCurElement(int curIndex)
			{
				return 0f;
			}

			// Token: 0x06021829 RID: 137257 RVA: 0x000BA810 File Offset: 0x000B8A10
			[Token(Token = "0x6021829")]
			[Address(RVA = "0x1BE4DB0", Offset = "0x1BE39B0", VA = "0x181BE4DB0")]
			private float _TryGetHeightAfterCurElement(int curIndex)
			{
				return 0f;
			}

			// Token: 0x0602182A RID: 137258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602182A")]
			[Address(RVA = "0x1BE4BA0", Offset = "0x1BE37A0", VA = "0x181BE4BA0")]
			private void _TransitionRemoved(UICustomAdapterLayout<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0602182B RID: 137259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602182B")]
			[Address(RVA = "0x1BE4390", Offset = "0x1BE2F90", VA = "0x181BE4390")]
			private void _TransitionNewAdded(UICustomAdapterLayout<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x0602182C RID: 137260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602182C")]
			[Address(RVA = "0x1BE58E0", Offset = "0x1BE44E0", VA = "0x181BE58E0")]
			private void _TryTransitionFocusItem(UICustomAdapterLayout<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float afterHeight, float bagPosY)
			{
			}

			// Token: 0x0602182D RID: 137261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602182D")]
			[Address(RVA = "0x1BE3620", Offset = "0x1BE2220", VA = "0x181BE3620")]
			private void _FocusOnTitle(UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float laterHeight, bool isBagSelf, float titlePos)
			{
			}

			// Token: 0x0602182E RID: 137262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602182E")]
			[Address(RVA = "0x1BE2ED0", Offset = "0x1BE1AD0", VA = "0x181BE2ED0")]
			private void _FocusOnNode(UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float laterHeight)
			{
			}

			// Token: 0x0602182F RID: 137263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602182F")]
			[Address(RVA = "0x1BE40F0", Offset = "0x1BE2CF0", VA = "0x181BE40F0")]
			private void _TransitionMove(UICustomSingleOrientationLayouter<CrisisV2RuneSingleViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x0402DC98 RID: 187544
			[Token(Token = "0x402DC98")]
			[FieldOffset(Offset = "0x70")]
			private CrisisV2RuneDetailSlotView m_closure;

			// Token: 0x0402DC99 RID: 187545
			[Token(Token = "0x402DC99")]
			[FieldOffset(Offset = "0x78")]
			private bool m_isFocusedOnTitle;

			// Token: 0x0402DC9A RID: 187546
			[Token(Token = "0x402DC9A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DC9B RID: 187547
			[Token(Token = "0x402DC9B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataComparison;

			// Token: 0x0402DC9C RID: 187548
			[Token(Token = "0x402DC9C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x0402DC9D RID: 187549
			[Token(Token = "0x402DC9D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x0402DC9E RID: 187550
			[Token(Token = "0x402DC9E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TryGetTotalElementHeight;

			// Token: 0x0402DC9F RID: 187551
			[Token(Token = "0x402DC9F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TryGetTitlePosDict;

			// Token: 0x0402DCA0 RID: 187552
			[Token(Token = "0x402DCA0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TryGetHeightBeforeCurElement;

			// Token: 0x0402DCA1 RID: 187553
			[Token(Token = "0x402DCA1")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TryGetHeightAfterCurElement;

			// Token: 0x0402DCA2 RID: 187554
			[Token(Token = "0x402DCA2")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x0402DCA3 RID: 187555
			[Token(Token = "0x402DCA3")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__TransitionNewAdded;

			// Token: 0x0402DCA4 RID: 187556
			[Token(Token = "0x402DCA4")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__TryTransitionFocusItem;

			// Token: 0x0402DCA5 RID: 187557
			[Token(Token = "0x402DCA5")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__FocusOnTitle;

			// Token: 0x0402DCA6 RID: 187558
			[Token(Token = "0x402DCA6")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__FocusOnNode;

			// Token: 0x0402DCA7 RID: 187559
			[Token(Token = "0x402DCA7")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}
	}
}
