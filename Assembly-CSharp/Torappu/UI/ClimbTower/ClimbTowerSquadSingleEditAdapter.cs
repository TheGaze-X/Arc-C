using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D85 RID: 23941
	[Token(Token = "0x2005D85")]
	public class ClimbTowerSquadSingleEditAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06022B42 RID: 142146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B42")]
		[Address(RVA = "0x1D42880", Offset = "0x1D41480", VA = "0x181D42880")]
		public ClimbTowerSquadSingleEditAdapter(ClimbTowerSquadSingleEditView closure)
		{
		}

		// Token: 0x06022B43 RID: 142147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B43")]
		[Address(RVA = "0x1D41DC0", Offset = "0x1D409C0", VA = "0x181D41DC0", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06022B44 RID: 142148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B44")]
		[Address(RVA = "0x1D42690", Offset = "0x1D41290", VA = "0x181D42690")]
		public void RefreshList(ClimbTowerSquadSingleEditModel editModel)
		{
		}

		// Token: 0x06022B45 RID: 142149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B45")]
		[Address(RVA = "0x1D42090", Offset = "0x1D40C90", VA = "0x181D42090")]
		public void RebuildList(ClimbTowerSquadSingleEditModel editModel)
		{
		}

		// Token: 0x06022B46 RID: 142150 RVA: 0x000BE878 File Offset: 0x000BCA78
		[Token(Token = "0x6022B46")]
		[Address(RVA = "0x1D42000", Offset = "0x1D40C00", VA = "0x181D42000")]
		public int GetProfessionIndex(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x06022B47 RID: 142151 RVA: 0x000BE890 File Offset: 0x000BCA90
		[Token(Token = "0x6022B47")]
		[Address(RVA = "0x1D41F00", Offset = "0x1D40B00", VA = "0x181D41F00")]
		public float GetCharCardOffset(ProfessionCategory profession, int cardId)
		{
			return 0f;
		}

		// Token: 0x0402FB51 RID: 195409
		[Token(Token = "0x402FB51")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<ProfessionCategory, ClimbTowerSquadSingleEditAdapter.CharGroupVirtualView> m_viewList;

		// Token: 0x0402FB52 RID: 195410
		[Token(Token = "0x402FB52")]
		[FieldOffset(Offset = "0x20")]
		private ClimbTowerSquadSingleEditView m_closure;

		// Token: 0x0402FB53 RID: 195411
		[Token(Token = "0x402FB53")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ProfessionCategory, int> m_professionIndex;

		// Token: 0x0402FB54 RID: 195412
		[Token(Token = "0x402FB54")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ProfessionCategory, List<ClimbTowerSquadItemModel>> m_groupDict;

		// Token: 0x0402FB55 RID: 195413
		[Token(Token = "0x402FB55")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402FB56 RID: 195414
		[Token(Token = "0x402FB56")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0402FB57 RID: 195415
		[Token(Token = "0x402FB57")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshList;

		// Token: 0x0402FB58 RID: 195416
		[Token(Token = "0x402FB58")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RebuildList;

		// Token: 0x0402FB59 RID: 195417
		[Token(Token = "0x402FB59")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProfessionIndex;

		// Token: 0x0402FB5A RID: 195418
		[Token(Token = "0x402FB5A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCharCardOffset;

		// Token: 0x02005D86 RID: 23942
		[Token(Token = "0x2005D86")]
		public struct CharGroupViewParam
		{
			// Token: 0x0402FB5B RID: 195419
			[Token(Token = "0x402FB5B")]
			[FieldOffset(Offset = "0x0")]
			public ClimbTowerSquadSingleEditGroupItemView prefab;

			// Token: 0x0402FB5C RID: 195420
			[Token(Token = "0x402FB5C")]
			[FieldOffset(Offset = "0x8")]
			public ProfessionCategory profession;

			// Token: 0x0402FB5D RID: 195421
			[Token(Token = "0x402FB5D")]
			[FieldOffset(Offset = "0x10")]
			public List<ClimbTowerSquadItemModel> charList;

			// Token: 0x0402FB5E RID: 195422
			[Token(Token = "0x402FB5E")]
			[FieldOffset(Offset = "0x18")]
			public SpriteHub professionSpriteHub;

			// Token: 0x0402FB5F RID: 195423
			[Token(Token = "0x402FB5F")]
			[FieldOffset(Offset = "0x20")]
			public int selectCardId;

			// Token: 0x0402FB60 RID: 195424
			[Token(Token = "0x402FB60")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> onCharSelect;

			// Token: 0x0402FB61 RID: 195425
			[Token(Token = "0x402FB61")]
			[FieldOffset(Offset = "0x30")]
			public long gameStartTs;
		}

		// Token: 0x02005D87 RID: 23943
		[Token(Token = "0x2005D87")]
		public class CharGroupVirtualView : UIRecycleLayoutAdapter.VirtualView<ClimbTowerSquadSingleEditGroupItemView>
		{
			// Token: 0x06022B48 RID: 142152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022B48")]
			[Address(RVA = "0x1D323C0", Offset = "0x1D30FC0", VA = "0x181D323C0")]
			public CharGroupVirtualView(ClimbTowerSquadSingleEditAdapter.CharGroupViewParam param)
			{
			}

			// Token: 0x06022B49 RID: 142153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022B49")]
			[Address(RVA = "0x1D31A50", Offset = "0x1D30650", VA = "0x181D31A50", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06022B4A RID: 142154 RVA: 0x000BE8A8 File Offset: 0x000BCAA8
			[Token(Token = "0x6022B4A")]
			[Address(RVA = "0x1D31C20", Offset = "0x1D30820", VA = "0x181D31C20", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06022B4B RID: 142155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022B4B")]
			[Address(RVA = "0x1D31D80", Offset = "0x1D30980", VA = "0x181D31D80", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06022B4C RID: 142156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022B4C")]
			[Address(RVA = "0x1D32100", Offset = "0x1D30D00", VA = "0x181D32100", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06022B4D RID: 142157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022B4D")]
			[Address(RVA = "0x1D321C0", Offset = "0x1D30DC0", VA = "0x181D321C0")]
			public void Refresh(int selectCardId)
			{
			}

			// Token: 0x06022B4E RID: 142158 RVA: 0x000BE8C0 File Offset: 0x000BCAC0
			[Token(Token = "0x6022B4E")]
			[Address(RVA = "0x1D31810", Offset = "0x1D30410", VA = "0x181D31810")]
			public float GetCharCardOffset(int cardId)
			{
				return 0f;
			}

			// Token: 0x0402FB62 RID: 195426
			[Token(Token = "0x402FB62")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadSingleEditAdapter.CharGroupViewParam m_param;

			// Token: 0x0402FB63 RID: 195427
			[Token(Token = "0x402FB63")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FB64 RID: 195428
			[Token(Token = "0x402FB64")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402FB65 RID: 195429
			[Token(Token = "0x402FB65")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402FB66 RID: 195430
			[Token(Token = "0x402FB66")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402FB67 RID: 195431
			[Token(Token = "0x402FB67")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402FB68 RID: 195432
			[Token(Token = "0x402FB68")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Refresh;

			// Token: 0x0402FB69 RID: 195433
			[Token(Token = "0x402FB69")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetCharCardOffset;
		}
	}
}
