using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006383 RID: 25475
	[Token(Token = "0x2006383")]
	public class AutoChessShopTrapListRecycleAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06024BF8 RID: 150520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BF8")]
		[Address(RVA = "0x1FA3E20", Offset = "0x1FA2A20", VA = "0x181FA3E20")]
		public AutoChessShopTrapListRecycleAdapter(AutoChessShopTrapListView closure)
		{
		}

		// Token: 0x06024BF9 RID: 150521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024BF9")]
		[Address(RVA = "0x1FA39E0", Offset = "0x1FA25E0", VA = "0x181FA39E0", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06024BFA RID: 150522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BFA")]
		[Address(RVA = "0x1FA3B10", Offset = "0x1FA2710", VA = "0x181FA3B10")]
		public void RebuildList(AutoChessShopLevelTrapGroupListViewModel viewModel)
		{
		}

		// Token: 0x0403356C RID: 210284
		[Token(Token = "0x403356C")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessShopTrapListView m_closure;

		// Token: 0x0403356D RID: 210285
		[Token(Token = "0x403356D")]
		[FieldOffset(Offset = "0x20")]
		private List<AutoChessShopTrapListRecycleAdapter.TrapGroupVirtualView> m_views;

		// Token: 0x0403356E RID: 210286
		[Token(Token = "0x403356E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0403356F RID: 210287
		[Token(Token = "0x403356F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x04033570 RID: 210288
		[Token(Token = "0x4033570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RebuildList;

		// Token: 0x02006384 RID: 25476
		[Token(Token = "0x2006384")]
		public struct TrapGroupViewParams
		{
			// Token: 0x04033571 RID: 210289
			[Token(Token = "0x4033571")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessShopLevelTrapGroupItemView prefab;

			// Token: 0x04033572 RID: 210290
			[Token(Token = "0x4033572")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessShopLevelTrapGroupItemViewModel groupItemViewModel;

			// Token: 0x04033573 RID: 210291
			[Token(Token = "0x4033573")]
			[FieldOffset(Offset = "0x10")]
			public int viewIndex;
		}

		// Token: 0x02006385 RID: 25477
		[Token(Token = "0x2006385")]
		private class TrapGroupVirtualView : UIRecycleLayoutAdapter.VirtualView<AutoChessShopLevelTrapGroupItemView>
		{
			// Token: 0x06024BFB RID: 150523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BFB")]
			[Address(RVA = "0x1FAD630", Offset = "0x1FAC230", VA = "0x181FAD630")]
			public TrapGroupVirtualView(AutoChessShopTrapListRecycleAdapter.TrapGroupViewParams param)
			{
			}

			// Token: 0x06024BFC RID: 150524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024BFC")]
			[Address(RVA = "0x1FAD350", Offset = "0x1FABF50", VA = "0x181FAD350", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06024BFD RID: 150525 RVA: 0x000C5610 File Offset: 0x000C3810
			[Token(Token = "0x6024BFD")]
			[Address(RVA = "0x1FAD3C0", Offset = "0x1FABFC0", VA = "0x181FAD3C0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06024BFE RID: 150526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BFE")]
			[Address(RVA = "0x1FAD530", Offset = "0x1FAC130", VA = "0x181FAD530", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06024BFF RID: 150527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BFF")]
			[Address(RVA = "0x1FAD5D0", Offset = "0x1FAC1D0", VA = "0x181FAD5D0", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x04033574 RID: 210292
			[Token(Token = "0x4033574")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopTrapListRecycleAdapter.TrapGroupViewParams m_param;

			// Token: 0x04033575 RID: 210293
			[Token(Token = "0x4033575")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033576 RID: 210294
			[Token(Token = "0x4033576")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04033577 RID: 210295
			[Token(Token = "0x4033577")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04033578 RID: 210296
			[Token(Token = "0x4033578")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04033579 RID: 210297
			[Token(Token = "0x4033579")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;
		}
	}
}
