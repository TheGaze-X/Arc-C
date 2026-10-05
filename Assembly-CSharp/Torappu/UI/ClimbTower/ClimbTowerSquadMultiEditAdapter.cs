using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D72 RID: 23922
	[Token(Token = "0x2005D72")]
	public class ClimbTowerSquadMultiEditAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06022ABD RID: 142013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ABD")]
		[Address(RVA = "0x1D3BB30", Offset = "0x1D3A730", VA = "0x181D3BB30")]
		public ClimbTowerSquadMultiEditAdapter(ClimbTowerSquadMultiEditView closure)
		{
		}

		// Token: 0x06022ABE RID: 142014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022ABE")]
		[Address(RVA = "0x1D3B110", Offset = "0x1D39D10", VA = "0x181D3B110", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06022ABF RID: 142015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022ABF")]
		[Address(RVA = "0x1D3B920", Offset = "0x1D3A520", VA = "0x181D3B920")]
		public void RefreshList(ClimbTowerSquadMultiEditModel editModel, bool needRebuild)
		{
		}

		// Token: 0x06022AC0 RID: 142016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AC0")]
		[Address(RVA = "0x1D3B2D0", Offset = "0x1D39ED0", VA = "0x181D3B2D0")]
		public void RebuildList(ClimbTowerSquadMultiEditModel editModel, bool needRebuild)
		{
		}

		// Token: 0x06022AC1 RID: 142017 RVA: 0x000BE5F0 File Offset: 0x000BC7F0
		[Token(Token = "0x6022AC1")]
		[Address(RVA = "0x1D3B240", Offset = "0x1D39E40", VA = "0x181D3B240")]
		public int GetProfessionIndex(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x0402FA71 RID: 195185
		[Token(Token = "0x402FA71")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerSquadMultiEditView m_closure;

		// Token: 0x0402FA72 RID: 195186
		[Token(Token = "0x402FA72")]
		[FieldOffset(Offset = "0x20")]
		private List<ClimbTowerSquadMultiEditAdapter.CharGroupVirtualView> m_viewList;

		// Token: 0x0402FA73 RID: 195187
		[Token(Token = "0x402FA73")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ProfessionCategory, int> m_professionIndex;

		// Token: 0x0402FA74 RID: 195188
		[Token(Token = "0x402FA74")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ProfessionCategory, List<ClimbTowerSquadMultiEditCharModel>> m_groupDict;

		// Token: 0x0402FA75 RID: 195189
		[Token(Token = "0x402FA75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402FA76 RID: 195190
		[Token(Token = "0x402FA76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0402FA77 RID: 195191
		[Token(Token = "0x402FA77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshList;

		// Token: 0x0402FA78 RID: 195192
		[Token(Token = "0x402FA78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RebuildList;

		// Token: 0x0402FA79 RID: 195193
		[Token(Token = "0x402FA79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProfessionIndex;

		// Token: 0x02005D73 RID: 23923
		[Token(Token = "0x2005D73")]
		public struct CharGroupViewParam
		{
			// Token: 0x0402FA7A RID: 195194
			[Token(Token = "0x402FA7A")]
			[FieldOffset(Offset = "0x0")]
			public ClimbTowerSquadMultiEditGroupItemView prefab;

			// Token: 0x0402FA7B RID: 195195
			[Token(Token = "0x402FA7B")]
			[FieldOffset(Offset = "0x8")]
			public ProfessionCategory profession;

			// Token: 0x0402FA7C RID: 195196
			[Token(Token = "0x402FA7C")]
			[FieldOffset(Offset = "0x10")]
			public List<ClimbTowerSquadMultiEditCharModel> charList;

			// Token: 0x0402FA7D RID: 195197
			[Token(Token = "0x402FA7D")]
			[FieldOffset(Offset = "0x18")]
			public ClimbTowerSquadMultiEditModel.EditType editType;

			// Token: 0x0402FA7E RID: 195198
			[Token(Token = "0x402FA7E")]
			[FieldOffset(Offset = "0x20")]
			public SpriteHub professionSpriteHub;

			// Token: 0x0402FA7F RID: 195199
			[Token(Token = "0x402FA7F")]
			[FieldOffset(Offset = "0x28")]
			public Action<int, string> onSkillSelect;

			// Token: 0x0402FA80 RID: 195200
			[Token(Token = "0x402FA80")]
			[FieldOffset(Offset = "0x30")]
			public Action<int, string> onEquipSelect;

			// Token: 0x0402FA81 RID: 195201
			[Token(Token = "0x402FA81")]
			[FieldOffset(Offset = "0x38")]
			public int viewIndex;

			// Token: 0x0402FA82 RID: 195202
			[Token(Token = "0x402FA82")]
			[FieldOffset(Offset = "0x40")]
			public long gameStartTs;

			// Token: 0x0402FA83 RID: 195203
			[Token(Token = "0x402FA83")]
			[FieldOffset(Offset = "0x48")]
			public bool needRebuild;
		}

		// Token: 0x02005D74 RID: 23924
		[Token(Token = "0x2005D74")]
		public class CharGroupVirtualView : UIRecycleLayoutAdapter.VirtualView<ClimbTowerSquadMultiEditGroupItemView>
		{
			// Token: 0x06022AC2 RID: 142018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AC2")]
			[Address(RVA = "0x1D32490", Offset = "0x1D31090", VA = "0x181D32490")]
			public CharGroupVirtualView(ClimbTowerSquadMultiEditAdapter.CharGroupViewParam param)
			{
			}

			// Token: 0x06022AC3 RID: 142019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022AC3")]
			[Address(RVA = "0x1D319E0", Offset = "0x1D305E0", VA = "0x181D319E0", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06022AC4 RID: 142020 RVA: 0x000BE608 File Offset: 0x000BC808
			[Token(Token = "0x6022AC4")]
			[Address(RVA = "0x1D31AC0", Offset = "0x1D306C0", VA = "0x181D31AC0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06022AC5 RID: 142021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AC5")]
			[Address(RVA = "0x1D31ED0", Offset = "0x1D30AD0", VA = "0x181D31ED0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06022AC6 RID: 142022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AC6")]
			[Address(RVA = "0x1D32160", Offset = "0x1D30D60", VA = "0x181D32160", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06022AC7 RID: 142023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022AC7")]
			[Address(RVA = "0x1D322B0", Offset = "0x1D30EB0", VA = "0x181D322B0")]
			public void Refresh(ClimbTowerSquadMultiEditModel.EditType editType, bool needRebuild)
			{
			}

			// Token: 0x0402FA84 RID: 195204
			[Token(Token = "0x402FA84")]
			[FieldOffset(Offset = "0x20")]
			private ClimbTowerSquadMultiEditAdapter.CharGroupViewParam m_param;

			// Token: 0x0402FA85 RID: 195205
			[Token(Token = "0x402FA85")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FA86 RID: 195206
			[Token(Token = "0x402FA86")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402FA87 RID: 195207
			[Token(Token = "0x402FA87")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402FA88 RID: 195208
			[Token(Token = "0x402FA88")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402FA89 RID: 195209
			[Token(Token = "0x402FA89")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402FA8A RID: 195210
			[Token(Token = "0x402FA8A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Refresh;
		}
	}
}
