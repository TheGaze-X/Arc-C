using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005671 RID: 22129
	[Token(Token = "0x2005671")]
	public class RL04AlchemyFragmentListRowItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020789 RID: 133001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020789")]
		[Address(RVA = "0x1A936D0", Offset = "0x1A922D0", VA = "0x181A936D0")]
		public void Render(RL04AlchemyFragmentListRowItemView.RL04AlchemyFragmentListRowItemVirtualViewStruct viewStruct)
		{
		}

		// Token: 0x0602078A RID: 133002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602078A")]
		[Address(RVA = "0x1A938B0", Offset = "0x1A924B0", VA = "0x181A938B0")]
		public void TryUpdateSelectStatus(RL04AlchemyFragmentListItemRowViewModel rowViewModel, List<string> selectedFragmentInstIdList, int viewIndex)
		{
		}

		// Token: 0x0602078B RID: 133003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602078B")]
		[Address(RVA = "0x1A93AD0", Offset = "0x1A926D0", VA = "0x181A93AD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602078C RID: 133004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602078C")]
		[Address(RVA = "0x1A93CE0", Offset = "0x1A928E0", VA = "0x181A93CE0")]
		private void _RefreshAdapter(List<RL04AlchemyFragmentListItemNormalViewModel> itemNormalViewList)
		{
		}

		// Token: 0x0602078D RID: 133005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602078D")]
		[Address(RVA = "0x1A93BF0", Offset = "0x1A927F0", VA = "0x181A93BF0")]
		private void _OnItemClick(string instId)
		{
		}

		// Token: 0x0602078E RID: 133006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602078E")]
		[Address(RVA = "0x1A93EA0", Offset = "0x1A92AA0", VA = "0x181A93EA0")]
		public RL04AlchemyFragmentListRowItemView()
		{
		}

		// Token: 0x0402BFB7 RID: 180151
		[Token(Token = "0x402BFB7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _preferSize;

		// Token: 0x0402BFB8 RID: 180152
		[Token(Token = "0x402BFB8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0402BFB9 RID: 180153
		[Token(Token = "0x402BFB9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x0402BFBA RID: 180154
		[Token(Token = "0x402BFBA")]
		[FieldOffset(Offset = "0x30")]
		private RL04AlchemyFragmentListRowItemView.Adapter m_adapter;

		// Token: 0x0402BFBB RID: 180155
		[Token(Token = "0x402BFBB")]
		[FieldOffset(Offset = "0x38")]
		private int m_cacheIndex;

		// Token: 0x0402BFBC RID: 180156
		[Token(Token = "0x402BFBC")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, bool> m_fragmentInstSelectStateCacheDict;

		// Token: 0x0402BFBD RID: 180157
		[Token(Token = "0x402BFBD")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402BFBE RID: 180158
		[Token(Token = "0x402BFBE")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BFBF RID: 180159
		[Token(Token = "0x402BFBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BFC0 RID: 180160
		[Token(Token = "0x402BFC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryUpdateSelectStatus;

		// Token: 0x0402BFC1 RID: 180161
		[Token(Token = "0x402BFC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BFC2 RID: 180162
		[Token(Token = "0x402BFC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshAdapter;

		// Token: 0x0402BFC3 RID: 180163
		[Token(Token = "0x402BFC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0402BFC4 RID: 180164
		[Token(Token = "0x402BFC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005672 RID: 22130
		[Token(Token = "0x2005672")]
		public struct RL04AlchemyFragmentListRowItemVirtualViewStruct
		{
			// Token: 0x0402BFC5 RID: 180165
			[Token(Token = "0x402BFC5")]
			[FieldOffset(Offset = "0x0")]
			public RL04AlchemyFragmentListRowItemView prefab;

			// Token: 0x0402BFC6 RID: 180166
			[Token(Token = "0x402BFC6")]
			[FieldOffset(Offset = "0x8")]
			public RL04AlchemyFragmentListItemRowViewModel viewModel;

			// Token: 0x0402BFC7 RID: 180167
			[Token(Token = "0x402BFC7")]
			[FieldOffset(Offset = "0x10")]
			public int viewIndex;
		}

		// Token: 0x02005673 RID: 22131
		[Token(Token = "0x2005673")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL04AlchemyFragmentListRowItemView>
		{
			// Token: 0x0602078F RID: 133007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602078F")]
			[Address(RVA = "0x1AA3140", Offset = "0x1AA1D40", VA = "0x181AA3140")]
			public VirtualView(RL04AlchemyFragmentListRowItemView.RL04AlchemyFragmentListRowItemVirtualViewStruct viewStruct)
			{
			}

			// Token: 0x06020790 RID: 133008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020790")]
			[Address(RVA = "0x1AA2B40", Offset = "0x1AA1740", VA = "0x181AA2B40", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06020791 RID: 133009 RVA: 0x000B61F0 File Offset: 0x000B43F0
			[Token(Token = "0x6020791")]
			[Address(RVA = "0x1AA2BB0", Offset = "0x1AA17B0", VA = "0x181AA2BB0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06020792 RID: 133010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020792")]
			[Address(RVA = "0x1AA2FC0", Offset = "0x1AA1BC0", VA = "0x181AA2FC0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06020793 RID: 133011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020793")]
			[Address(RVA = "0x1AA2C90", Offset = "0x1AA1890", VA = "0x181AA2C90", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06020794 RID: 133012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020794")]
			[Address(RVA = "0x1AA3020", Offset = "0x1AA1C20", VA = "0x181AA3020")]
			public void TryUpdateSelectStatus(RL04AlchemyFragmentListItemRowViewModel viewModel, List<string> selectedFragmentInstIdList, int viewIndex)
			{
			}

			// Token: 0x0402BFC8 RID: 180168
			[Token(Token = "0x402BFC8")]
			[FieldOffset(Offset = "0x20")]
			private RL04AlchemyFragmentListRowItemView.RL04AlchemyFragmentListRowItemVirtualViewStruct m_viewStruct;

			// Token: 0x0402BFC9 RID: 180169
			[Token(Token = "0x402BFC9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BFCA RID: 180170
			[Token(Token = "0x402BFCA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402BFCB RID: 180171
			[Token(Token = "0x402BFCB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402BFCC RID: 180172
			[Token(Token = "0x402BFCC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402BFCD RID: 180173
			[Token(Token = "0x402BFCD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402BFCE RID: 180174
			[Token(Token = "0x402BFCE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_TryUpdateSelectStatus;
		}

		// Token: 0x02005674 RID: 22132
		[Token(Token = "0x2005674")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004C1C RID: 19484
			// (get) Token: 0x06020795 RID: 133013 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020796 RID: 133014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004C1C")]
			public List<RL04AlchemyFragmentListItemNormalViewModel> rowItemDataList
			{
				[Token(Token = "0x6020795")]
				[Address(RVA = "0x1A8B550", Offset = "0x1A8A150", VA = "0x181A8B550")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6020796")]
				[Address(RVA = "0x1A8B5B0", Offset = "0x1A8A1B0", VA = "0x181A8B5B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06020797 RID: 133015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020797")]
			[Address(RVA = "0x1A8B3A0", Offset = "0x1A89FA0", VA = "0x181A8B3A0")]
			public Adapter(RL04AlchemyFragmentListRowItemView view)
			{
			}

			// Token: 0x17004C1D RID: 19485
			// (get) Token: 0x06020798 RID: 133016 RVA: 0x000B6208 File Offset: 0x000B4408
			[Token(Token = "0x17004C1D")]
			public override int count
			{
				[Token(Token = "0x6020798")]
				[Address(RVA = "0x1A8B490", Offset = "0x1A8A090", VA = "0x181A8B490", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020799 RID: 133017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020799")]
			[Address(RVA = "0x1A8AED0", Offset = "0x1A89AD0", VA = "0x181A8AED0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402BFCF RID: 180175
			[Token(Token = "0x402BFCF")]
			[FieldOffset(Offset = "0x20")]
			private RL04AlchemyFragmentListRowItemView m_view;

			// Token: 0x0402BFD1 RID: 180177
			[Token(Token = "0x402BFD1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_rowItemDataList;

			// Token: 0x0402BFD2 RID: 180178
			[Token(Token = "0x402BFD2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_rowItemDataList;

			// Token: 0x0402BFD3 RID: 180179
			[Token(Token = "0x402BFD3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BFD4 RID: 180180
			[Token(Token = "0x402BFD4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402BFD5 RID: 180181
			[Token(Token = "0x402BFD5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
