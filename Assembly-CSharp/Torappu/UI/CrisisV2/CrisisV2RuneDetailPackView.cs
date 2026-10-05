using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059C7 RID: 22983
	[Token(Token = "0x20059C7")]
	public class CrisisV2RuneDetailPackView : UICustomAdapterLayout<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>
	{
		// Token: 0x060217F8 RID: 137208 RVA: 0x000BA738 File Offset: 0x000B8938
		[Token(Token = "0x60217F8")]
		[Address(RVA = "0x1BDA2E0", Offset = "0x1BD8EE0", VA = "0x181BDA2E0")]
		public bool ShowPackView(CrisisV2MapModel model)
		{
			return default(bool);
		}

		// Token: 0x060217F9 RID: 137209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217F9")]
		[Address(RVA = "0x1BDA460", Offset = "0x1BD9060", VA = "0x181BDA460")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060217FA RID: 137210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60217FA")]
		[Address(RVA = "0x1BDA6E0", Offset = "0x1BD92E0", VA = "0x181BDA6E0")]
		public CrisisV2RuneDetailPackView()
		{
		}

		// Token: 0x0402DC4C RID: 187468
		[Token(Token = "0x402DC4C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402DC4D RID: 187469
		[Token(Token = "0x402DC4D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x0402DC4E RID: 187470
		[Token(Token = "0x402DC4E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x0402DC4F RID: 187471
		[Token(Token = "0x402DC4F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0402DC50 RID: 187472
		[Token(Token = "0x402DC50")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _downPadding;

		// Token: 0x0402DC51 RID: 187473
		[Token(Token = "0x402DC51")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CrisisV2RuneSelectInfoGroupView _packViewPrefab;

		// Token: 0x0402DC52 RID: 187474
		[Token(Token = "0x402DC52")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _showHideDuration;

		// Token: 0x0402DC53 RID: 187475
		[Token(Token = "0x402DC53")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x0402DC54 RID: 187476
		[Token(Token = "0x402DC54")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0402DC55 RID: 187477
		[Token(Token = "0x402DC55")]
		[FieldOffset(Offset = "0xB8")]
		private CrisisV2RuneDetailPackView.InnerLayouter m_layouter;

		// Token: 0x0402DC56 RID: 187478
		[Token(Token = "0x402DC56")]
		[FieldOffset(Offset = "0xC0")]
		private CrisisV2RuneDetailPackView.InnerAdapter m_adapter;

		// Token: 0x0402DC57 RID: 187479
		[Token(Token = "0x402DC57")]
		[FieldOffset(Offset = "0xC8")]
		private UICustomSingleOrientationLayouter<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.Options m_layoutOption;

		// Token: 0x0402DC58 RID: 187480
		[Token(Token = "0x402DC58")]
		[FieldOffset(Offset = "0xE8")]
		private CrisisV2MapModel m_model;

		// Token: 0x0402DC59 RID: 187481
		[Token(Token = "0x402DC59")]
		[FieldOffset(Offset = "0xF0")]
		private int m_cachedFocusSeq;

		// Token: 0x0402DC5A RID: 187482
		[Token(Token = "0x402DC5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowPackView;

		// Token: 0x0402DC5B RID: 187483
		[Token(Token = "0x402DC5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DC5C RID: 187484
		[Token(Token = "0x402DC5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059C8 RID: 22984
		[Token(Token = "0x20059C8")]
		private class InnerAdapter : UICustomAdapterLayout<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.Adapter
		{
			// Token: 0x060217FB RID: 137211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60217FB")]
			[Address(RVA = "0x1BE1540", Offset = "0x1BE0140", VA = "0x181BE1540")]
			public InnerAdapter(CrisisV2RuneDetailPackView closure)
			{
			}

			// Token: 0x060217FC RID: 137212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60217FC")]
			[Address(RVA = "0x1BE0F10", Offset = "0x1BDFB10", VA = "0x181BE0F10", Slot = "6")]
			public override CrisisV2RuneSelectInfoBaseView CreateInst(CrisisV2RunePackViewModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x060217FD RID: 137213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60217FD")]
			[Address(RVA = "0x1BE13D0", Offset = "0x1BDFFD0", VA = "0x181BE13D0", Slot = "7")]
			public override void UpdateView(CrisisV2RuneSelectInfoBaseView view, CrisisV2RunePackViewModel data)
			{
			}

			// Token: 0x060217FE RID: 137214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60217FE")]
			[Address(RVA = "0x1BE1110", Offset = "0x1BDFD10", VA = "0x181BE1110", Slot = "5")]
			public override string GetId(CrisisV2RunePackViewModel data)
			{
				return null;
			}

			// Token: 0x060217FF RID: 137215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60217FF")]
			[Address(RVA = "0x1BE0FF0", Offset = "0x1BDFBF0", VA = "0x181BE0FF0", Slot = "4")]
			public override IList<CrisisV2RunePackViewModel> GetData()
			{
				return null;
			}

			// Token: 0x0402DC5D RID: 187485
			[Token(Token = "0x402DC5D")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2RuneDetailPackView m_closure;

			// Token: 0x0402DC5E RID: 187486
			[Token(Token = "0x402DC5E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DC5F RID: 187487
			[Token(Token = "0x402DC5F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0402DC60 RID: 187488
			[Token(Token = "0x402DC60")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x0402DC61 RID: 187489
			[Token(Token = "0x402DC61")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0402DC62 RID: 187490
			[Token(Token = "0x402DC62")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x020059C9 RID: 22985
		[Token(Token = "0x20059C9")]
		private class InnerLayouter : UICustomSingleOrientationLayouter<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>
		{
			// Token: 0x06021800 RID: 137216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021800")]
			[Address(RVA = "0x1BE5D50", Offset = "0x1BE4950", VA = "0x181BE5D50")]
			public InnerLayouter(CrisisV2RuneDetailPackView closure)
			{
			}

			// Token: 0x06021801 RID: 137217 RVA: 0x000BA750 File Offset: 0x000B8950
			[Token(Token = "0x6021801")]
			[Address(RVA = "0x1BE1670", Offset = "0x1BE0270", VA = "0x181BE1670", Slot = "6")]
			protected override int DataComparison(CrisisV2RunePackViewModel lhs, CrisisV2RunePackViewModel rhs)
			{
				return 0;
			}

			// Token: 0x06021802 RID: 137218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021802")]
			[Address(RVA = "0x1BE1710", Offset = "0x1BE0310", VA = "0x181BE1710", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x06021803 RID: 137219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021803")]
			[Address(RVA = "0x1BE1C30", Offset = "0x1BE0830", VA = "0x181BE1C30", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x06021804 RID: 137220 RVA: 0x000BA768 File Offset: 0x000B8968
			[Token(Token = "0x6021804")]
			[Address(RVA = "0x1BE5770", Offset = "0x1BE4370", VA = "0x181BE5770")]
			private float _TryGetTotalElementHeight()
			{
				return 0f;
			}

			// Token: 0x06021805 RID: 137221 RVA: 0x000BA780 File Offset: 0x000B8980
			[Token(Token = "0x6021805")]
			[Address(RVA = "0x1BE5070", Offset = "0x1BE3C70", VA = "0x181BE5070")]
			private float _TryGetHeightBeforeCurElement(int curIndex)
			{
				return 0f;
			}

			// Token: 0x06021806 RID: 137222 RVA: 0x000BA798 File Offset: 0x000B8998
			[Token(Token = "0x6021806")]
			[Address(RVA = "0x1BE4F10", Offset = "0x1BE3B10", VA = "0x181BE4F10")]
			private float _TryGetHeightAfterCurElement(int curIndex)
			{
				return 0f;
			}

			// Token: 0x06021807 RID: 137223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021807")]
			[Address(RVA = "0x1BE4990", Offset = "0x1BE3590", VA = "0x181BE4990")]
			private void _TransitionRemoved(UICustomAdapterLayout<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x06021808 RID: 137224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021808")]
			[Address(RVA = "0x1BE4690", Offset = "0x1BE3290", VA = "0x181BE4690")]
			private void _TransitionNewAdded(UICustomAdapterLayout<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x06021809 RID: 137225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021809")]
			[Address(RVA = "0x1BE3C70", Offset = "0x1BE2870", VA = "0x181BE3C70")]
			private void _TransitionFocusItem(UICustomAdapterLayout<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float afterHeight)
			{
			}

			// Token: 0x0602180A RID: 137226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602180A")]
			[Address(RVA = "0x1BE2780", Offset = "0x1BE1380", VA = "0x181BE2780")]
			private void _FocusItem(UICustomSingleOrientationLayouter<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float laterHeight)
			{
			}

			// Token: 0x0602180B RID: 137227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602180B")]
			[Address(RVA = "0x1BE3E50", Offset = "0x1BE2A50", VA = "0x181BE3E50")]
			private void _TransitionMove(UICustomSingleOrientationLayouter<CrisisV2RunePackViewModel, CrisisV2RuneSelectInfoBaseView>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x0402DC63 RID: 187491
			[Token(Token = "0x402DC63")]
			[FieldOffset(Offset = "0x70")]
			private CrisisV2RuneDetailPackView m_closure;

			// Token: 0x0402DC64 RID: 187492
			[Token(Token = "0x402DC64")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DC65 RID: 187493
			[Token(Token = "0x402DC65")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataComparison;

			// Token: 0x0402DC66 RID: 187494
			[Token(Token = "0x402DC66")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x0402DC67 RID: 187495
			[Token(Token = "0x402DC67")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x0402DC68 RID: 187496
			[Token(Token = "0x402DC68")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TryGetTotalElementHeight;

			// Token: 0x0402DC69 RID: 187497
			[Token(Token = "0x402DC69")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TryGetHeightBeforeCurElement;

			// Token: 0x0402DC6A RID: 187498
			[Token(Token = "0x402DC6A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TryGetHeightAfterCurElement;

			// Token: 0x0402DC6B RID: 187499
			[Token(Token = "0x402DC6B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x0402DC6C RID: 187500
			[Token(Token = "0x402DC6C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TransitionNewAdded;

			// Token: 0x0402DC6D RID: 187501
			[Token(Token = "0x402DC6D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__TransitionFocusItem;

			// Token: 0x0402DC6E RID: 187502
			[Token(Token = "0x402DC6E")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__FocusItem;

			// Token: 0x0402DC6F RID: 187503
			[Token(Token = "0x402DC6F")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}
	}
}
