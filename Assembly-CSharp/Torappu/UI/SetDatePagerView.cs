using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039B5 RID: 14773
	[Token(Token = "0x20039B5")]
	public class SetDatePagerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017585 RID: 95621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017585")]
		[Address(RVA = "0xFB6850", Offset = "0xFB5450", VA = "0x180FB6850")]
		public void Render(SetDateListViewModel model, bool showImmediate = false)
		{
		}

		// Token: 0x06017586 RID: 95622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017586")]
		[Address(RVA = "0xFB6AB0", Offset = "0xFB56B0", VA = "0x180FB6AB0")]
		private void Update()
		{
		}

		// Token: 0x06017587 RID: 95623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017587")]
		[Address(RVA = "0xFB6B50", Offset = "0xFB5750", VA = "0x180FB6B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017588 RID: 95624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017588")]
		[Address(RVA = "0xFB6E70", Offset = "0xFB5A70", VA = "0x180FB6E70")]
		private void _ResetScrollIfNecessary(SetDateListViewModel model, bool showImmediate)
		{
		}

		// Token: 0x06017589 RID: 95625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017589")]
		[Address(RVA = "0xFB6DB0", Offset = "0xFB59B0", VA = "0x180FB6DB0")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x0601758A RID: 95626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601758A")]
		[Address(RVA = "0xFB6F70", Offset = "0xFB5B70", VA = "0x180FB6F70")]
		public SetDatePagerView()
		{
		}

		// Token: 0x0401C2FB RID: 115451
		[Token(Token = "0x401C2FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InertiaScrollViewPager _wheelPager;

		// Token: 0x0401C2FC RID: 115452
		[Token(Token = "0x401C2FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x0401C2FD RID: 115453
		[Token(Token = "0x401C2FD")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<int> onItemClicked;

		// Token: 0x0401C2FE RID: 115454
		[Token(Token = "0x401C2FE")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public SetDateItemView itemPrefab;

		// Token: 0x0401C2FF RID: 115455
		[Token(Token = "0x401C2FF")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401C300 RID: 115456
		[Token(Token = "0x401C300")]
		[FieldOffset(Offset = "0x40")]
		private long m_dragContextID;

		// Token: 0x0401C301 RID: 115457
		[Token(Token = "0x401C301")]
		[FieldOffset(Offset = "0x48")]
		private SetDatePagerView.PagerAdapter m_adapter;

		// Token: 0x0401C302 RID: 115458
		[Token(Token = "0x401C302")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedPage;

		// Token: 0x0401C303 RID: 115459
		[Token(Token = "0x401C303")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401C304 RID: 115460
		[Token(Token = "0x401C304")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401C305 RID: 115461
		[Token(Token = "0x401C305")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C306 RID: 115462
		[Token(Token = "0x401C306")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetScrollIfNecessary;

		// Token: 0x0401C307 RID: 115463
		[Token(Token = "0x401C307")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x0401C308 RID: 115464
		[Token(Token = "0x401C308")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039B6 RID: 14774
		[Token(Token = "0x20039B6")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601758B RID: 95627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601758B")]
			[Address(RVA = "0xFB2550", Offset = "0xFB1150", VA = "0x180FB2550")]
			public PagerAdapter(SetDatePagerView closure)
			{
			}

			// Token: 0x0601758C RID: 95628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601758C")]
			[Address(RVA = "0xFB1FA0", Offset = "0xFB0BA0", VA = "0x180FB1FA0")]
			public void RebuildListIfNeeded(SetDateListViewModel model)
			{
			}

			// Token: 0x0601758D RID: 95629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601758D")]
			[Address(RVA = "0xFB2380", Offset = "0xFB0F80", VA = "0x180FB2380")]
			public void UpdateSelection(int selectPageIdx)
			{
			}

			// Token: 0x0601758E RID: 95630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601758E")]
			[Address(RVA = "0xFB1E70", Offset = "0xFB0A70", VA = "0x180FB1E70", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0401C309 RID: 115465
			[Token(Token = "0x401C309")]
			[FieldOffset(Offset = "0x18")]
			private SetDatePagerView m_closure;

			// Token: 0x0401C30A RID: 115466
			[Token(Token = "0x401C30A")]
			[FieldOffset(Offset = "0x20")]
			private List<SetDateItemView.VirtualView> m_cells;

			// Token: 0x0401C30B RID: 115467
			[Token(Token = "0x401C30B")]
			[FieldOffset(Offset = "0x28")]
			private int m_cachedPageCount;

			// Token: 0x0401C30C RID: 115468
			[Token(Token = "0x401C30C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C30D RID: 115469
			[Token(Token = "0x401C30D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildListIfNeeded;

			// Token: 0x0401C30E RID: 115470
			[Token(Token = "0x401C30E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateSelection;

			// Token: 0x0401C30F RID: 115471
			[Token(Token = "0x401C30F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
		}
	}
}
