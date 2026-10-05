using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D66 RID: 23910
	[Token(Token = "0x2005D66")]
	public class ClimbTowerSquadEditRecylceAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06022A42 RID: 141890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A42")]
		[Address(RVA = "0x1D27230", Offset = "0x1D25E30", VA = "0x181D27230")]
		public ClimbTowerSquadEditRecylceAdapter(ClimbTowerSquadEditView closure)
		{
		}

		// Token: 0x06022A43 RID: 141891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022A43")]
		[Address(RVA = "0x1D26950", Offset = "0x1D25550", VA = "0x181D26950", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06022A44 RID: 141892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022A44")]
		[Address(RVA = "0x1D26C50", Offset = "0x1D25850", VA = "0x181D26C50")]
		public void RebuildList(List<ClimbTowerSquadItemModel> charList)
		{
		}

		// Token: 0x06022A45 RID: 141893 RVA: 0x000BE368 File Offset: 0x000BC568
		[Token(Token = "0x6022A45")]
		[Address(RVA = "0x1D26BC0", Offset = "0x1D257C0", VA = "0x181D26BC0")]
		public int GetProfessionIndex(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x06022A46 RID: 141894 RVA: 0x000BE380 File Offset: 0x000BC580
		[Token(Token = "0x6022A46")]
		[Address(RVA = "0x1D26A90", Offset = "0x1D25690", VA = "0x181D26A90")]
		public KeyValuePair<float, float> GetCharCardBounds(ProfessionCategory profession, string charId)
		{
			return default(KeyValuePair<float, float>);
		}

		// Token: 0x0402F9CD RID: 195021
		[Token(Token = "0x402F9CD")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerSquadEditView m_closure;

		// Token: 0x0402F9CE RID: 195022
		[Token(Token = "0x402F9CE")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<ProfessionCategory, ClimbTowerSquadEditRecylceAdapter.CharGroupVirtualView> m_viewList;

		// Token: 0x0402F9CF RID: 195023
		[Token(Token = "0x402F9CF")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ProfessionCategory, int> m_professionIndex;

		// Token: 0x0402F9D0 RID: 195024
		[Token(Token = "0x402F9D0")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ProfessionCategory, List<ClimbTowerSquadItemModel>> m_groupDict;

		// Token: 0x0402F9D1 RID: 195025
		[Token(Token = "0x402F9D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402F9D2 RID: 195026
		[Token(Token = "0x402F9D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0402F9D3 RID: 195027
		[Token(Token = "0x402F9D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RebuildList;

		// Token: 0x0402F9D4 RID: 195028
		[Token(Token = "0x402F9D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProfessionIndex;

		// Token: 0x0402F9D5 RID: 195029
		[Token(Token = "0x402F9D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCharCardBounds;

		// Token: 0x02005D67 RID: 23911
		[Token(Token = "0x2005D67")]
		public struct CharGroupViewParam
		{
			// Token: 0x0402F9D6 RID: 195030
			[Token(Token = "0x402F9D6")]
			[FieldOffset(Offset = "0x0")]
			public ClimbTowerSquadEditGroupItemView prefab;

			// Token: 0x0402F9D7 RID: 195031
			[Token(Token = "0x402F9D7")]
			[FieldOffset(Offset = "0x8")]
			public ProfessionCategory profession;

			// Token: 0x0402F9D8 RID: 195032
			[Token(Token = "0x402F9D8")]
			[FieldOffset(Offset = "0x10")]
			public List<ClimbTowerSquadItemModel> charList;

			// Token: 0x0402F9D9 RID: 195033
			[Token(Token = "0x402F9D9")]
			[FieldOffset(Offset = "0x18")]
			public SpriteHub professionSpriteHub;

			// Token: 0x0402F9DA RID: 195034
			[Token(Token = "0x402F9DA")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> onCharSelect;

			// Token: 0x0402F9DB RID: 195035
			[Token(Token = "0x402F9DB")]
			[FieldOffset(Offset = "0x28")]
			public int viewIndex;

			// Token: 0x0402F9DC RID: 195036
			[Token(Token = "0x402F9DC")]
			[FieldOffset(Offset = "0x30")]
			public long gameStartTs;
		}

		// Token: 0x02005D68 RID: 23912
		[Token(Token = "0x2005D68")]
		public class CharGroupVirtualView : UIRecycleLayoutAdapter.VirtualView<ClimbTowerSquadEditGroupItemView>
		{
			// Token: 0x06022A47 RID: 141895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A47")]
			[Address(RVA = "0x1D16880", Offset = "0x1D15480", VA = "0x181D16880")]
			public CharGroupVirtualView(ClimbTowerSquadEditRecylceAdapter.CharGroupViewParam param)
			{
			}

			// Token: 0x06022A48 RID: 141896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022A48")]
			[Address(RVA = "0x1D164C0", Offset = "0x1D150C0", VA = "0x181D164C0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06022A49 RID: 141897 RVA: 0x000BE398 File Offset: 0x000BC598
			[Token(Token = "0x6022A49")]
			[Address(RVA = "0x1D16530", Offset = "0x1D15130", VA = "0x181D16530", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06022A4A RID: 141898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A4A")]
			[Address(RVA = "0x1D16690", Offset = "0x1D15290", VA = "0x181D16690", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06022A4B RID: 141899 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022A4B")]
			[Address(RVA = "0x1D16820", Offset = "0x1D15420", VA = "0x181D16820", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06022A4C RID: 141900 RVA: 0x000BE3B0 File Offset: 0x000BC5B0
			[Token(Token = "0x6022A4C")]
			[Address(RVA = "0x1D16260", Offset = "0x1D14E60", VA = "0x181D16260")]
			public KeyValuePair<float, float> GetCharCardBounds(string charId)
			{
				return default(KeyValuePair<float, float>);
			}

			// Token: 0x0402F9DD RID: 195037
			[Token(Token = "0x402F9DD")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadEditRecylceAdapter.CharGroupViewParam m_param;

			// Token: 0x0402F9DE RID: 195038
			[Token(Token = "0x402F9DE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F9DF RID: 195039
			[Token(Token = "0x402F9DF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402F9E0 RID: 195040
			[Token(Token = "0x402F9E0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402F9E1 RID: 195041
			[Token(Token = "0x402F9E1")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402F9E2 RID: 195042
			[Token(Token = "0x402F9E2")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402F9E3 RID: 195043
			[Token(Token = "0x402F9E3")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetCharCardBounds;
		}
	}
}
