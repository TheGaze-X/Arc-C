using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F70 RID: 28528
	[Token(Token = "0x2006F70")]
	public class ActMultiV3TitlePagerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028801 RID: 165889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028801")]
		[Address(RVA = "0x23D11C0", Offset = "0x23CFDC0", VA = "0x1823D11C0")]
		public void Render(ActMultiV3ManualTitleListModel model, bool fastMode)
		{
		}

		// Token: 0x06028802 RID: 165890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028802")]
		[Address(RVA = "0x23D1390", Offset = "0x23CFF90", VA = "0x1823D1390")]
		private void Update()
		{
		}

		// Token: 0x06028803 RID: 165891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028803")]
		[Address(RVA = "0x23D1440", Offset = "0x23D0040", VA = "0x1823D1440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028804 RID: 165892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028804")]
		[Address(RVA = "0x23D1830", Offset = "0x23D0430", VA = "0x1823D1830")]
		private void _ResetScrollIfNecessary(ActMultiV3ManualTitleListModel model, bool fastMode)
		{
		}

		// Token: 0x06028805 RID: 165893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028805")]
		[Address(RVA = "0x23D16A0", Offset = "0x23D02A0", VA = "0x1823D16A0")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x06028806 RID: 165894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028806")]
		[Address(RVA = "0x23D1930", Offset = "0x23D0530", VA = "0x1823D1930")]
		public ActMultiV3TitlePagerView()
		{
		}

		// Token: 0x04039A5C RID: 236124
		[Token(Token = "0x4039A5C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InertiaScrollViewPager _wheelPager;

		// Token: 0x04039A5D RID: 236125
		[Token(Token = "0x4039A5D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04039A5E RID: 236126
		[Token(Token = "0x4039A5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3TitleItemView _itemViewPrefab;

		// Token: 0x04039A5F RID: 236127
		[Token(Token = "0x4039A5F")]
		[FieldOffset(Offset = "0x30")]
		private bool m_inited;

		// Token: 0x04039A60 RID: 236128
		[Token(Token = "0x4039A60")]
		[FieldOffset(Offset = "0x31")]
		private bool m_cachedIsBack;

		// Token: 0x04039A61 RID: 236129
		[Token(Token = "0x4039A61")]
		[FieldOffset(Offset = "0x38")]
		private long m_dragContextID;

		// Token: 0x04039A62 RID: 236130
		[Token(Token = "0x4039A62")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3TitlePagerView.PagerAdapter m_adapter;

		// Token: 0x04039A63 RID: 236131
		[Token(Token = "0x4039A63")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039A64 RID: 236132
		[Token(Token = "0x4039A64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039A65 RID: 236133
		[Token(Token = "0x4039A65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04039A66 RID: 236134
		[Token(Token = "0x4039A66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039A67 RID: 236135
		[Token(Token = "0x4039A67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetScrollIfNecessary;

		// Token: 0x04039A68 RID: 236136
		[Token(Token = "0x4039A68")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x04039A69 RID: 236137
		[Token(Token = "0x4039A69")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F71 RID: 28529
		[Token(Token = "0x2006F71")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06028807 RID: 165895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028807")]
			[Address(RVA = "0x23D2240", Offset = "0x23D0E40", VA = "0x1823D2240")]
			public PagerAdapter(ActMultiV3TitlePagerView closure)
			{
			}

			// Token: 0x06028808 RID: 165896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028808")]
			[Address(RVA = "0x23D1F60", Offset = "0x23D0B60", VA = "0x1823D1F60")]
			public void RebuildListIfNeeded(ActMultiV3ManualTitleListModel model)
			{
			}

			// Token: 0x06028809 RID: 165897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028809")]
			[Address(RVA = "0x23D1D00", Offset = "0x23D0900", VA = "0x1823D1D00")]
			public void NotifyFocusPage(int pageIdx)
			{
			}

			// Token: 0x0602880A RID: 165898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602880A")]
			[Address(RVA = "0x23D1BD0", Offset = "0x23D07D0", VA = "0x1823D1BD0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x04039A6A RID: 236138
			[Token(Token = "0x4039A6A")]
			[FieldOffset(Offset = "0x18")]
			private ActMultiV3TitlePagerView m_closure;

			// Token: 0x04039A6B RID: 236139
			[Token(Token = "0x4039A6B")]
			[FieldOffset(Offset = "0x20")]
			private List<ActMultiV3TitleItemView.VirtualView> m_cells;

			// Token: 0x04039A6C RID: 236140
			[Token(Token = "0x4039A6C")]
			[FieldOffset(Offset = "0x28")]
			private int m_focusPageIndex;

			// Token: 0x04039A6D RID: 236141
			[Token(Token = "0x4039A6D")]
			[FieldOffset(Offset = "0x2C")]
			private int m_cachedLoadSeqNum;

			// Token: 0x04039A6E RID: 236142
			[Token(Token = "0x4039A6E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039A6F RID: 236143
			[Token(Token = "0x4039A6F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildListIfNeeded;

			// Token: 0x04039A70 RID: 236144
			[Token(Token = "0x4039A70")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_NotifyFocusPage;

			// Token: 0x04039A71 RID: 236145
			[Token(Token = "0x4039A71")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
		}
	}
}
