using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200635E RID: 25438
	[Token(Token = "0x200635E")]
	public class AutoChessShopCharListRecycleAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06024B2D RID: 150317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B2D")]
		[Address(RVA = "0x1F835A0", Offset = "0x1F821A0", VA = "0x181F835A0")]
		public AutoChessShopCharListRecycleAdapter(AutoChessShopBaseCharListView closure)
		{
		}

		// Token: 0x06024B2E RID: 150318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B2E")]
		[Address(RVA = "0x1F82980", Offset = "0x1F81580", VA = "0x181F82980", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06024B2F RID: 150319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B2F")]
		[Address(RVA = "0x1F82F60", Offset = "0x1F81B60", VA = "0x181F82F60")]
		public void RebuildList(AutoChessShopLevelCharGroupListViewModel viewModel, [Optional] IDragHandler dragHandler)
		{
		}

		// Token: 0x06024B30 RID: 150320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B30")]
		[Address(RVA = "0x1F82D20", Offset = "0x1F81920", VA = "0x181F82D20")]
		public AutoChessShopLevelCharGroupItemView GetGroupItemView(int shopLevel)
		{
			return null;
		}

		// Token: 0x06024B31 RID: 150321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B31")]
		[Address(RVA = "0x1F82E40", Offset = "0x1F81A40", VA = "0x181F82E40")]
		public GameObject GetLevelLastIndexCharItemCardView(int shopLevel)
		{
			return null;
		}

		// Token: 0x06024B32 RID: 150322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B32")]
		[Address(RVA = "0x1F82BE0", Offset = "0x1F817E0", VA = "0x181F82BE0")]
		public AutoChessShopLevelCharItemCardView GetGroupItemCharCardItemView(int shopLevel, int charCardPosition)
		{
			return null;
		}

		// Token: 0x06024B33 RID: 150323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B33")]
		[Address(RVA = "0x1F83360", Offset = "0x1F81F60", VA = "0x181F83360")]
		public void TryRefreshCharCardViewsInfos(AutoChessShopLevelCharGroupListViewModel viewModel)
		{
		}

		// Token: 0x06024B34 RID: 150324 RVA: 0x000C5418 File Offset: 0x000C3618
		[Token(Token = "0x6024B34")]
		[Address(RVA = "0x1F82AB0", Offset = "0x1F816B0", VA = "0x181F82AB0")]
		public KeyValuePair<float, float> GetCharCardBounds(int viewIndex, string chessId)
		{
			return default(KeyValuePair<float, float>);
		}

		// Token: 0x040333CC RID: 209868
		[Token(Token = "0x40333CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AutoChessShopBaseCharListView m_closure;

		// Token: 0x040333CD RID: 209869
		[Token(Token = "0x40333CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<AutoChessShopCharListRecycleAdapter.CharGroupVirtualView> m_views;

		// Token: 0x040333CE RID: 209870
		[Token(Token = "0x40333CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040333CF RID: 209871
		[Token(Token = "0x40333CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x040333D0 RID: 209872
		[Token(Token = "0x40333D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RebuildList;

		// Token: 0x040333D1 RID: 209873
		[Token(Token = "0x40333D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetGroupItemView;

		// Token: 0x040333D2 RID: 209874
		[Token(Token = "0x40333D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLevelLastIndexCharItemCardView;

		// Token: 0x040333D3 RID: 209875
		[Token(Token = "0x40333D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetGroupItemCharCardItemView;

		// Token: 0x040333D4 RID: 209876
		[Token(Token = "0x40333D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryRefreshCharCardViewsInfos;

		// Token: 0x040333D5 RID: 209877
		[Token(Token = "0x40333D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCharCardBounds;

		// Token: 0x0200635F RID: 25439
		[Token(Token = "0x200635F")]
		public struct CharGroupViewParams
		{
			// Token: 0x040333D6 RID: 209878
			[Token(Token = "0x40333D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AutoChessShopLevelCharGroupItemView prefab;

			// Token: 0x040333D7 RID: 209879
			[Token(Token = "0x40333D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AutoChessShopLevelCharGroupItemViewModel groupItemViewModel;

			// Token: 0x040333D8 RID: 209880
			[Token(Token = "0x40333D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int viewIndex;

			// Token: 0x040333D9 RID: 209881
			[Token(Token = "0x40333D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IDragHandler parentDragHandler;
		}

		// Token: 0x02006360 RID: 25440
		[Token(Token = "0x2006360")]
		private class CharGroupVirtualView : UIRecycleLayoutAdapter.VirtualView<AutoChessShopLevelCharGroupItemView>
		{
			// Token: 0x06024B35 RID: 150325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B35")]
			[Address(RVA = "0x1F93880", Offset = "0x1F92480", VA = "0x181F93880")]
			public CharGroupVirtualView(AutoChessShopCharListRecycleAdapter.CharGroupViewParams param)
			{
			}

			// Token: 0x06024B36 RID: 150326 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B36")]
			[Address(RVA = "0x1F933F0", Offset = "0x1F91FF0", VA = "0x181F933F0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06024B37 RID: 150327 RVA: 0x000C5430 File Offset: 0x000C3630
			[Token(Token = "0x6024B37")]
			[Address(RVA = "0x1F93460", Offset = "0x1F92060", VA = "0x181F93460", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06024B38 RID: 150328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B38")]
			[Address(RVA = "0x1F93670", Offset = "0x1F92270", VA = "0x181F93670", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06024B39 RID: 150329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B39")]
			[Address(RVA = "0x1F93710", Offset = "0x1F92310", VA = "0x181F93710", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06024B3A RID: 150330 RVA: 0x000C5448 File Offset: 0x000C3648
			[Token(Token = "0x6024B3A")]
			[Address(RVA = "0x1F92D20", Offset = "0x1F91920", VA = "0x181F92D20")]
			public KeyValuePair<float, float> GetCharChessCardBounds(string chessId)
			{
				return default(KeyValuePair<float, float>);
			}

			// Token: 0x06024B3B RID: 150331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B3B")]
			[Address(RVA = "0x1F93770", Offset = "0x1F92370", VA = "0x181F93770")]
			public void TryRefreshCharCardViewsInfos(AutoChessShopLevelCharGroupItemViewModel groupItemViewModel, int viewIndex)
			{
			}

			// Token: 0x06024B3C RID: 150332 RVA: 0x000C5460 File Offset: 0x000C3660
			[Token(Token = "0x6024B3C")]
			[Address(RVA = "0x1F931D0", Offset = "0x1F91DD0", VA = "0x181F931D0")]
			public int GetGroupLevel()
			{
				return 0;
			}

			// Token: 0x06024B3D RID: 150333 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B3D")]
			[Address(RVA = "0x1F93100", Offset = "0x1F91D00", VA = "0x181F93100")]
			public AutoChessShopLevelCharGroupItemView GetGroupItemView()
			{
				return null;
			}

			// Token: 0x06024B3E RID: 150334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B3E")]
			[Address(RVA = "0x1F92F70", Offset = "0x1F91B70", VA = "0x181F92F70")]
			public AutoChessShopLevelCharItemCardView GetGroupItemCharCardItemView(int charCardPosition)
			{
				return null;
			}

			// Token: 0x06024B3F RID: 150335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B3F")]
			[Address(RVA = "0x1F93240", Offset = "0x1F91E40", VA = "0x181F93240")]
			public GameObject GetLevelLastIndexCharItemCardView()
			{
				return null;
			}

			// Token: 0x040333DA RID: 209882
			[Token(Token = "0x40333DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private AutoChessShopCharListRecycleAdapter.CharGroupViewParams m_param;

			// Token: 0x040333DB RID: 209883
			[Token(Token = "0x40333DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040333DC RID: 209884
			[Token(Token = "0x40333DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x040333DD RID: 209885
			[Token(Token = "0x40333DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x040333DE RID: 209886
			[Token(Token = "0x40333DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x040333DF RID: 209887
			[Token(Token = "0x40333DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x040333E0 RID: 209888
			[Token(Token = "0x40333E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetCharChessCardBounds;

			// Token: 0x040333E1 RID: 209889
			[Token(Token = "0x40333E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_TryRefreshCharCardViewsInfos;

			// Token: 0x040333E2 RID: 209890
			[Token(Token = "0x40333E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetGroupLevel;

			// Token: 0x040333E3 RID: 209891
			[Token(Token = "0x40333E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetGroupItemView;

			// Token: 0x040333E4 RID: 209892
			[Token(Token = "0x40333E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_GetGroupItemCharCardItemView;

			// Token: 0x040333E5 RID: 209893
			[Token(Token = "0x40333E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_GetLevelLastIndexCharItemCardView;
		}
	}
}
