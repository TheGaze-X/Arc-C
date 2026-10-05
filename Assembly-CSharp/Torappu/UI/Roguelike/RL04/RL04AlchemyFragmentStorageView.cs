using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005677 RID: 22135
	[Token(Token = "0x2005677")]
	public class RL04AlchemyFragmentStorageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060207A1 RID: 133025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207A1")]
		[Address(RVA = "0x1A95920", Offset = "0x1A94520", VA = "0x181A95920")]
		public void Render(RL04AlchemyFragmentListViewModel fragmentListViewModel)
		{
		}

		// Token: 0x060207A2 RID: 133026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207A2")]
		[Address(RVA = "0x1A95AE0", Offset = "0x1A946E0", VA = "0x181A95AE0")]
		public void ResetViewSeqCache()
		{
		}

		// Token: 0x060207A3 RID: 133027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207A3")]
		[Address(RVA = "0x1A95B40", Offset = "0x1A94740", VA = "0x181A95B40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207A4 RID: 133028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207A4")]
		[Address(RVA = "0x1A95D80", Offset = "0x1A94980", VA = "0x181A95D80")]
		public RL04AlchemyFragmentStorageView()
		{
		}

		// Token: 0x0402BFE5 RID: 180197
		[Token(Token = "0x402BFE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasEmpty;

		// Token: 0x0402BFE6 RID: 180198
		[Token(Token = "0x402BFE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasStorageList;

		// Token: 0x0402BFE7 RID: 180199
		[Token(Token = "0x402BFE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL04AlchemyFragmentListTitleItemView _titleItemPrefab;

		// Token: 0x0402BFE8 RID: 180200
		[Token(Token = "0x402BFE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL04AlchemyFragmentListRowItemView _rowItemPrefab;

		// Token: 0x0402BFE9 RID: 180201
		[Token(Token = "0x402BFE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleList;

		// Token: 0x0402BFEA RID: 180202
		[Token(Token = "0x402BFEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402BFEB RID: 180203
		[Token(Token = "0x402BFEB")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402BFEC RID: 180204
		[Token(Token = "0x402BFEC")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_tweenEmpty;

		// Token: 0x0402BFED RID: 180205
		[Token(Token = "0x402BFED")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_tweenStorageList;

		// Token: 0x0402BFEE RID: 180206
		[Token(Token = "0x402BFEE")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x0402BFEF RID: 180207
		[Token(Token = "0x402BFEF")]
		[FieldOffset(Offset = "0x64")]
		private int m_cachedListRefreshSequenceNum;

		// Token: 0x0402BFF0 RID: 180208
		[Token(Token = "0x402BFF0")]
		[FieldOffset(Offset = "0x68")]
		private RL04AlchemyFragmentStorageView.RL04AlchemyFragmentListAdapter m_adapter;

		// Token: 0x0402BFF1 RID: 180209
		[Token(Token = "0x402BFF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BFF2 RID: 180210
		[Token(Token = "0x402BFF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetViewSeqCache;

		// Token: 0x0402BFF3 RID: 180211
		[Token(Token = "0x402BFF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BFF4 RID: 180212
		[Token(Token = "0x402BFF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005678 RID: 22136
		[Token(Token = "0x2005678")]
		private class RL04AlchemyFragmentListAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060207A5 RID: 133029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207A5")]
			[Address(RVA = "0x1A92DE0", Offset = "0x1A919E0", VA = "0x181A92DE0")]
			public RL04AlchemyFragmentListAdapter(RL04AlchemyFragmentStorageView closure)
			{
			}

			// Token: 0x060207A6 RID: 133030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60207A6")]
			[Address(RVA = "0x1A924E0", Offset = "0x1A910E0", VA = "0x181A924E0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060207A7 RID: 133031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207A7")]
			[Address(RVA = "0x1A92610", Offset = "0x1A91210", VA = "0x181A92610")]
			public void RebuildList(RL04AlchemyFragmentListViewModel viewModel)
			{
			}

			// Token: 0x060207A8 RID: 133032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60207A8")]
			[Address(RVA = "0x1A92AC0", Offset = "0x1A916C0", VA = "0x181A92AC0")]
			public void TryUpdateSelectStatus(RL04AlchemyFragmentListViewModel viewModel)
			{
			}

			// Token: 0x0402BFF5 RID: 180213
			[Token(Token = "0x402BFF5")]
			[FieldOffset(Offset = "0x18")]
			private RL04AlchemyFragmentStorageView m_closure;

			// Token: 0x0402BFF6 RID: 180214
			[Token(Token = "0x402BFF6")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0402BFF7 RID: 180215
			[Token(Token = "0x402BFF7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BFF8 RID: 180216
			[Token(Token = "0x402BFF8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402BFF9 RID: 180217
			[Token(Token = "0x402BFF9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x0402BFFA RID: 180218
			[Token(Token = "0x402BFFA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TryUpdateSelectStatus;
		}
	}
}
