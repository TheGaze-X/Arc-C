using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007755 RID: 30549
	[Token(Token = "0x2007755")]
	public class Act1VHalfIdlePlotCombineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AE8C RID: 175756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE8C")]
		[Address(RVA = "0x26AFC90", Offset = "0x26AE890", VA = "0x1826AFC90")]
		public void Render(string origPlotId, Act1VHalfidlePlotViewModel viewModel, bool showOrigMark)
		{
		}

		// Token: 0x0602AE8D RID: 175757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE8D")]
		[Address(RVA = "0x26B04E0", Offset = "0x26AF0E0", VA = "0x1826B04E0")]
		private void _RenderSingleRecipt(string origPlotId, Act1VHalfIdlePlotData.PlotCombineData combineData, bool showOrigMark)
		{
		}

		// Token: 0x0602AE8E RID: 175758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE8E")]
		[Address(RVA = "0x26B0290", Offset = "0x26AEE90", VA = "0x1826B0290")]
		private void _RenderMultiRecipt(string origPlotId, Act1VHalfIdlePlotData.PlotCombineData combineData, bool showOrigMark)
		{
		}

		// Token: 0x0602AE8F RID: 175759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE8F")]
		[Address(RVA = "0x26AFF60", Offset = "0x26AEB60", VA = "0x1826AFF60")]
		private void _RenderBranchRecipt(string origPlotId, Act1VHalfIdlePlotData.PlotCombineData combineData, bool showOrigMark)
		{
		}

		// Token: 0x0602AE90 RID: 175760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE90")]
		[Address(RVA = "0x26B0670", Offset = "0x26AF270", VA = "0x1826B0670")]
		public Act1VHalfIdlePlotCombineView()
		{
		}

		// Token: 0x0403DE14 RID: 253460
		[Token(Token = "0x403DE14")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DE15 RID: 253461
		[Token(Token = "0x403DE15")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _singleRecipt;

		// Token: 0x0403DE16 RID: 253462
		[Token(Token = "0x403DE16")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _multiRecipt;

		// Token: 0x0403DE17 RID: 253463
		[Token(Token = "0x403DE17")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _branchMultiRecipt;

		// Token: 0x0403DE18 RID: 253464
		[Token(Token = "0x403DE18")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlArrow;

		// Token: 0x0403DE19 RID: 253465
		[Token(Token = "0x403DE19")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act1VHalfIdlePlotReciptItemView _itemPrefab;

		// Token: 0x0403DE1A RID: 253466
		[Token(Token = "0x403DE1A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _singleReciptContainer;

		// Token: 0x0403DE1B RID: 253467
		[Token(Token = "0x403DE1B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _dualReciptContainerA;

		// Token: 0x0403DE1C RID: 253468
		[Token(Token = "0x403DE1C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _dualReciptContainerB;

		// Token: 0x0403DE1D RID: 253469
		[Token(Token = "0x403DE1D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _branchMultiReciptContainerA;

		// Token: 0x0403DE1E RID: 253470
		[Token(Token = "0x403DE1E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _branchMultiReciptContainerB;

		// Token: 0x0403DE1F RID: 253471
		[Token(Token = "0x403DE1F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _branchMultiReciptContainerC;

		// Token: 0x0403DE20 RID: 253472
		[Token(Token = "0x403DE20")]
		[FieldOffset(Offset = "0x78")]
		private string m_actId;

		// Token: 0x0403DE21 RID: 253473
		[Token(Token = "0x403DE21")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdlePlotReciptItemView m_singleReciptItemView;

		// Token: 0x0403DE22 RID: 253474
		[Token(Token = "0x403DE22")]
		[FieldOffset(Offset = "0x88")]
		private Act1VHalfIdlePlotReciptItemView m_dualReciptItemViewA;

		// Token: 0x0403DE23 RID: 253475
		[Token(Token = "0x403DE23")]
		[FieldOffset(Offset = "0x90")]
		private Act1VHalfIdlePlotReciptItemView m_dualReciptItemViewB;

		// Token: 0x0403DE24 RID: 253476
		[Token(Token = "0x403DE24")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfIdlePlotReciptItemView m_branchMultiReciptItemViewA;

		// Token: 0x0403DE25 RID: 253477
		[Token(Token = "0x403DE25")]
		[FieldOffset(Offset = "0xA0")]
		private Act1VHalfIdlePlotReciptItemView m_branchMultiReciptItemViewB;

		// Token: 0x0403DE26 RID: 253478
		[Token(Token = "0x403DE26")]
		[FieldOffset(Offset = "0xA8")]
		private Act1VHalfIdlePlotReciptItemView m_branchMultiReciptItemViewC;

		// Token: 0x0403DE27 RID: 253479
		[Token(Token = "0x403DE27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DE28 RID: 253480
		[Token(Token = "0x403DE28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSingleRecipt;

		// Token: 0x0403DE29 RID: 253481
		[Token(Token = "0x403DE29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderMultiRecipt;

		// Token: 0x0403DE2A RID: 253482
		[Token(Token = "0x403DE2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBranchRecipt;

		// Token: 0x0403DE2B RID: 253483
		[Token(Token = "0x403DE2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
