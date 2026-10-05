using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007608 RID: 30216
	[Token(Token = "0x2007608")]
	public class Act24sideQuestStageGroupModel : IHotfixable
	{
		// Token: 0x17006417 RID: 25623
		// (get) Token: 0x0602A8B7 RID: 174263 RVA: 0x000D8ED0 File Offset: 0x000D70D0
		[Token(Token = "0x17006417")]
		public int rank
		{
			[Token(Token = "0x602A8B7")]
			[Address(RVA = "0x265F080", Offset = "0x265DC80", VA = "0x18265F080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006418 RID: 25624
		// (get) Token: 0x0602A8B8 RID: 174264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006418")]
		public List<Act24sideQuestStageItemModel> questItemList
		{
			[Token(Token = "0x602A8B8")]
			[Address(RVA = "0x265F020", Offset = "0x265DC20", VA = "0x18265F020")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A8B9 RID: 174265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8B9")]
		[Address(RVA = "0x265EEA0", Offset = "0x265DAA0", VA = "0x18265EEA0")]
		public void LoadData(string actId, int stageRank)
		{
		}

		// Token: 0x0602A8BA RID: 174266 RVA: 0x000D8EE8 File Offset: 0x000D70E8
		[Token(Token = "0x602A8BA")]
		[Address(RVA = "0x265ED40", Offset = "0x265D940", VA = "0x18265ED40")]
		public bool IsUrgent()
		{
			return default(bool);
		}

		// Token: 0x0602A8BB RID: 174267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8BB")]
		[Address(RVA = "0x265EF70", Offset = "0x265DB70", VA = "0x18265EF70")]
		public Act24sideQuestStageGroupModel()
		{
		}

		// Token: 0x0403D3F1 RID: 250865
		[Token(Token = "0x403D3F1")]
		[FieldOffset(Offset = "0x10")]
		private int m_rank;

		// Token: 0x0403D3F2 RID: 250866
		[Token(Token = "0x403D3F2")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x0403D3F3 RID: 250867
		[Token(Token = "0x403D3F3")]
		[FieldOffset(Offset = "0x20")]
		private List<Act24sideQuestStageItemModel> m_questItemList;

		// Token: 0x0403D3F4 RID: 250868
		[Token(Token = "0x403D3F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rank;

		// Token: 0x0403D3F5 RID: 250869
		[Token(Token = "0x403D3F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_questItemList;

		// Token: 0x0403D3F6 RID: 250870
		[Token(Token = "0x403D3F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D3F7 RID: 250871
		[Token(Token = "0x403D3F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsUrgent;

		// Token: 0x0403D3F8 RID: 250872
		[Token(Token = "0x403D3F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
