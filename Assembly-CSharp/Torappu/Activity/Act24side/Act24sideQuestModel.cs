using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007609 RID: 30217
	[Token(Token = "0x2007609")]
	public class Act24sideQuestModel : IHotfixable
	{
		// Token: 0x17006419 RID: 25625
		// (get) Token: 0x0602A8BC RID: 174268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006419")]
		public List<Act24sideQuestStageGroupModel> displayQuestGroupList
		{
			[Token(Token = "0x602A8BC")]
			[Address(RVA = "0x265EBA0", Offset = "0x265D7A0", VA = "0x18265EBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700641A RID: 25626
		// (get) Token: 0x0602A8BD RID: 174269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700641A")]
		public string actId
		{
			[Token(Token = "0x602A8BD")]
			[Address(RVA = "0x265EB40", Offset = "0x265D740", VA = "0x18265EB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700641B RID: 25627
		// (get) Token: 0x0602A8BE RID: 174270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A8BF RID: 174271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700641B")]
		public string selectStageId
		{
			[Token(Token = "0x602A8BE")]
			[Address(RVA = "0x265EC00", Offset = "0x265D800", VA = "0x18265EC00")]
			get
			{
				return null;
			}
			[Token(Token = "0x602A8BF")]
			[Address(RVA = "0x265EC60", Offset = "0x265D860", VA = "0x18265EC60")]
			set
			{
			}
		}

		// Token: 0x0602A8C0 RID: 174272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8C0")]
		[Address(RVA = "0x265DDA0", Offset = "0x265C9A0", VA = "0x18265DDA0")]
		public Act24sideQuestStageItemModel FindSelectedQuestItemModel()
		{
			return null;
		}

		// Token: 0x0602A8C1 RID: 174273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8C1")]
		[Address(RVA = "0x265DBC0", Offset = "0x265C7C0", VA = "0x18265DBC0")]
		public Act24sideQuestStageItemModel FindNormalStageModel(string hardStageId)
		{
			return null;
		}

		// Token: 0x0602A8C2 RID: 174274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8C2")]
		[Address(RVA = "0x265DE00", Offset = "0x265CA00", VA = "0x18265DE00")]
		public void LoadData(string actId, string selectStageId)
		{
		}

		// Token: 0x0602A8C3 RID: 174275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8C3")]
		[Address(RVA = "0x265E780", Offset = "0x265D380", VA = "0x18265E780")]
		public void SaveLastSelectQuest()
		{
		}

		// Token: 0x0602A8C4 RID: 174276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8C4")]
		[Address(RVA = "0x265E800", Offset = "0x265D400", VA = "0x18265E800")]
		private Act24sideQuestStageItemModel _FindQuestItemModel(string questId)
		{
			return null;
		}

		// Token: 0x0602A8C5 RID: 174277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8C5")]
		[Address(RVA = "0x265E9C0", Offset = "0x265D5C0", VA = "0x18265E9C0")]
		private string _GetSelectStageFromLocalCache(string cacheStageIdFromBattle)
		{
			return null;
		}

		// Token: 0x0602A8C6 RID: 174278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8C6")]
		[Address(RVA = "0x265EAE0", Offset = "0x265D6E0", VA = "0x18265EAE0")]
		public Act24sideQuestModel()
		{
		}

		// Token: 0x0403D3F9 RID: 250873
		[Token(Token = "0x403D3F9")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403D3FA RID: 250874
		[Token(Token = "0x403D3FA")]
		[FieldOffset(Offset = "0x18")]
		private List<Act24sideQuestStageGroupModel> m_displayQuestGroupList;

		// Token: 0x0403D3FB RID: 250875
		[Token(Token = "0x403D3FB")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectStageId;

		// Token: 0x0403D3FC RID: 250876
		[Token(Token = "0x403D3FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayQuestGroupList;

		// Token: 0x0403D3FD RID: 250877
		[Token(Token = "0x403D3FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403D3FE RID: 250878
		[Token(Token = "0x403D3FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectStageId;

		// Token: 0x0403D3FF RID: 250879
		[Token(Token = "0x403D3FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectStageId;

		// Token: 0x0403D400 RID: 250880
		[Token(Token = "0x403D400")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindSelectedQuestItemModel;

		// Token: 0x0403D401 RID: 250881
		[Token(Token = "0x403D401")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FindNormalStageModel;

		// Token: 0x0403D402 RID: 250882
		[Token(Token = "0x403D402")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D403 RID: 250883
		[Token(Token = "0x403D403")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveLastSelectQuest;

		// Token: 0x0403D404 RID: 250884
		[Token(Token = "0x403D404")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FindQuestItemModel;

		// Token: 0x0403D405 RID: 250885
		[Token(Token = "0x403D405")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetSelectStageFromLocalCache;

		// Token: 0x0403D406 RID: 250886
		[Token(Token = "0x403D406")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
