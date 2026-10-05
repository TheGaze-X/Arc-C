using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047B7 RID: 18359
	[Token(Token = "0x20047B7")]
	public class RecalRuneStageRunePackView : UICustomAdapterLayout<IRecalRunePack, RecalRuneStageRunePackItemBase>
	{
		// Token: 0x0601BCC6 RID: 113862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCC6")]
		[Address(RVA = "0x1532350", Offset = "0x1530F50", VA = "0x181532350")]
		public void Render(RecalRuneStageRuneViewModel model)
		{
		}

		// Token: 0x0601BCC7 RID: 113863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCC7")]
		[Address(RVA = "0x1532410", Offset = "0x1531010", VA = "0x181532410")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BCC8 RID: 113864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCC8")]
		[Address(RVA = "0x1532690", Offset = "0x1531290", VA = "0x181532690")]
		public RecalRuneStageRunePackView()
		{
		}

		// Token: 0x04024287 RID: 148103
		[Token(Token = "0x4024287")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04024288 RID: 148104
		[Token(Token = "0x4024288")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x04024289 RID: 148105
		[Token(Token = "0x4024289")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x0402428A RID: 148106
		[Token(Token = "0x402428A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0402428B RID: 148107
		[Token(Token = "0x402428B")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _downPadding;

		// Token: 0x0402428C RID: 148108
		[Token(Token = "0x402428C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RecalRuneStageRunePackItemBase _runePrefab;

		// Token: 0x0402428D RID: 148109
		[Token(Token = "0x402428D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RecalRuneStageRunePackItemBase _headPrefab;

		// Token: 0x0402428E RID: 148110
		[Token(Token = "0x402428E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _showHideDuration;

		// Token: 0x0402428F RID: 148111
		[Token(Token = "0x402428F")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x04024290 RID: 148112
		[Token(Token = "0x4024290")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x04024291 RID: 148113
		[Token(Token = "0x4024291")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x04024292 RID: 148114
		[Token(Token = "0x4024292")]
		[FieldOffset(Offset = "0xC8")]
		private RecalRuneStageRunePackView.InnerLayouter m_layouter;

		// Token: 0x04024293 RID: 148115
		[Token(Token = "0x4024293")]
		[FieldOffset(Offset = "0xD0")]
		private RecalRuneStageRunePackView.InnerAdapter m_adapter;

		// Token: 0x04024294 RID: 148116
		[Token(Token = "0x4024294")]
		[FieldOffset(Offset = "0xD8")]
		private UICustomSingleOrientationLayouter<IRecalRunePack, RecalRuneStageRunePackItemBase>.Options m_layoutOption;

		// Token: 0x04024295 RID: 148117
		[Token(Token = "0x4024295")]
		[FieldOffset(Offset = "0xF8")]
		private RecalRuneStageRuneViewModel m_model;

		// Token: 0x04024296 RID: 148118
		[Token(Token = "0x4024296")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024297 RID: 148119
		[Token(Token = "0x4024297")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024298 RID: 148120
		[Token(Token = "0x4024298")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047B8 RID: 18360
		[Token(Token = "0x20047B8")]
		private class InnerAdapter : UICustomAdapterLayout<IRecalRunePack, RecalRuneStageRunePackItemBase>.Adapter
		{
			// Token: 0x0601BCC9 RID: 113865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCC9")]
			[Address(RVA = "0x1521850", Offset = "0x1520450", VA = "0x181521850")]
			public InnerAdapter(RecalRuneStageRunePackView closure)
			{
			}

			// Token: 0x0601BCCA RID: 113866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BCCA")]
			[Address(RVA = "0x15214B0", Offset = "0x15200B0", VA = "0x1815214B0", Slot = "6")]
			public override RecalRuneStageRunePackItemBase CreateInst(IRecalRunePack data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0601BCCB RID: 113867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCCB")]
			[Address(RVA = "0x1521700", Offset = "0x1520300", VA = "0x181521700", Slot = "7")]
			public override void UpdateView(RecalRuneStageRunePackItemBase view, IRecalRunePack data)
			{
			}

			// Token: 0x0601BCCC RID: 113868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BCCC")]
			[Address(RVA = "0x1521670", Offset = "0x1520270", VA = "0x181521670", Slot = "5")]
			public override string GetId(IRecalRunePack data)
			{
				return null;
			}

			// Token: 0x0601BCCD RID: 113869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601BCCD")]
			[Address(RVA = "0x15215F0", Offset = "0x15201F0", VA = "0x1815215F0", Slot = "4")]
			public override IList<IRecalRunePack> GetData()
			{
				return null;
			}

			// Token: 0x04024299 RID: 148121
			[Token(Token = "0x4024299")]
			[FieldOffset(Offset = "0x20")]
			private RecalRuneStageRunePackView m_closure;

			// Token: 0x0402429A RID: 148122
			[Token(Token = "0x402429A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402429B RID: 148123
			[Token(Token = "0x402429B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0402429C RID: 148124
			[Token(Token = "0x402429C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateView;

			// Token: 0x0402429D RID: 148125
			[Token(Token = "0x402429D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0402429E RID: 148126
			[Token(Token = "0x402429E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetData;
		}

		// Token: 0x020047B9 RID: 18361
		[Token(Token = "0x20047B9")]
		private class InnerLayouter : UICustomSingleOrientationLayouter<IRecalRunePack, RecalRuneStageRunePackItemBase>
		{
			// Token: 0x0601BCCE RID: 113870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCCE")]
			[Address(RVA = "0x1523750", Offset = "0x1522350", VA = "0x181523750")]
			public InnerLayouter(RecalRuneStageRunePackView closure)
			{
			}

			// Token: 0x0601BCCF RID: 113871 RVA: 0x000A64E8 File Offset: 0x000A46E8
			[Token(Token = "0x601BCCF")]
			[Address(RVA = "0x15218E0", Offset = "0x15204E0", VA = "0x1815218E0", Slot = "6")]
			protected override int DataComparison(IRecalRunePack lhs, IRecalRunePack rhs)
			{
				return 0;
			}

			// Token: 0x0601BCD0 RID: 113872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD0")]
			[Address(RVA = "0x1521A10", Offset = "0x1520610", VA = "0x181521A10", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x0601BCD1 RID: 113873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD1")]
			[Address(RVA = "0x1521CA0", Offset = "0x15208A0", VA = "0x181521CA0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x0601BCD2 RID: 113874 RVA: 0x000A6500 File Offset: 0x000A4700
			[Token(Token = "0x601BCD2")]
			[Address(RVA = "0x1523330", Offset = "0x1521F30", VA = "0x181523330")]
			private float _TryGetTotalElementHeight()
			{
				return 0f;
			}

			// Token: 0x0601BCD3 RID: 113875 RVA: 0x000A6518 File Offset: 0x000A4718
			[Token(Token = "0x601BCD3")]
			[Address(RVA = "0x1523210", Offset = "0x1521E10", VA = "0x181523210")]
			private float _TryGetHeightBeforeCurElement(int curIndex)
			{
				return 0f;
			}

			// Token: 0x0601BCD4 RID: 113876 RVA: 0x000A6530 File Offset: 0x000A4730
			[Token(Token = "0x601BCD4")]
			[Address(RVA = "0x15230B0", Offset = "0x1521CB0", VA = "0x1815230B0")]
			private float _TryGetHeightAfterCurElement(int curIndex)
			{
				return 0f;
			}

			// Token: 0x0601BCD5 RID: 113877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD5")]
			[Address(RVA = "0x1522E80", Offset = "0x1521A80", VA = "0x181522E80")]
			private void _TransitionRemoved(UICustomAdapterLayout<IRecalRunePack, RecalRuneStageRunePackItemBase>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0601BCD6 RID: 113878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD6")]
			[Address(RVA = "0x1522B60", Offset = "0x1521760", VA = "0x181522B60")]
			private void _TransitionNewAdded(UICustomAdapterLayout<IRecalRunePack, RecalRuneStageRunePackItemBase>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<IRecalRunePack, RecalRuneStageRunePackItemBase>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x0601BCD7 RID: 113879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD7")]
			[Address(RVA = "0x15234A0", Offset = "0x15220A0", VA = "0x1815234A0")]
			private void _TryTransitionFocusItem(UICustomAdapterLayout<IRecalRunePack, RecalRuneStageRunePackItemBase>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<IRecalRunePack, RecalRuneStageRunePackItemBase>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float afterHeight)
			{
			}

			// Token: 0x0601BCD8 RID: 113880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD8")]
			[Address(RVA = "0x1522170", Offset = "0x1520D70", VA = "0x181522170")]
			private void _FocusOnRune(UICustomSingleOrientationLayouter<IRecalRunePack, RecalRuneStageRunePackItemBase>.LayoutMeta meta, RectTransform rectTrans, float totalHeight, float beforeHeight, float laterHeight)
			{
			}

			// Token: 0x0601BCD9 RID: 113881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BCD9")]
			[Address(RVA = "0x15228C0", Offset = "0x15214C0", VA = "0x1815228C0")]
			private void _TransitionMove(UICustomSingleOrientationLayouter<IRecalRunePack, RecalRuneStageRunePackItemBase>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x0402429F RID: 148127
			[Token(Token = "0x402429F")]
			[FieldOffset(Offset = "0x70")]
			private RecalRuneStageRunePackView m_closure;

			// Token: 0x040242A0 RID: 148128
			[Token(Token = "0x40242A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040242A1 RID: 148129
			[Token(Token = "0x40242A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataComparison;

			// Token: 0x040242A2 RID: 148130
			[Token(Token = "0x40242A2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x040242A3 RID: 148131
			[Token(Token = "0x40242A3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x040242A4 RID: 148132
			[Token(Token = "0x40242A4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TryGetTotalElementHeight;

			// Token: 0x040242A5 RID: 148133
			[Token(Token = "0x40242A5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TryGetHeightBeforeCurElement;

			// Token: 0x040242A6 RID: 148134
			[Token(Token = "0x40242A6")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TryGetHeightAfterCurElement;

			// Token: 0x040242A7 RID: 148135
			[Token(Token = "0x40242A7")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x040242A8 RID: 148136
			[Token(Token = "0x40242A8")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TransitionNewAdded;

			// Token: 0x040242A9 RID: 148137
			[Token(Token = "0x40242A9")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__TryTransitionFocusItem;

			// Token: 0x040242AA RID: 148138
			[Token(Token = "0x40242AA")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__FocusOnRune;

			// Token: 0x040242AB RID: 148139
			[Token(Token = "0x40242AB")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}
	}
}
