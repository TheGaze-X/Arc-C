using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005953 RID: 22867
	[Token(Token = "0x2005953")]
	public class CrisisV2EntryViewModel : IHotfixable
	{
		// Token: 0x06021538 RID: 136504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021538")]
		[Address(RVA = "0x1BA4D50", Offset = "0x1BA3950", VA = "0x181BA4D50")]
		public CrisisV2EntryViewModel()
		{
		}

		// Token: 0x0402D71D RID: 186141
		[Token(Token = "0x402D71D")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402D71E RID: 186142
		[Token(Token = "0x402D71E")]
		[FieldOffset(Offset = "0x18")]
		public bool isServerDataInited;

		// Token: 0x0402D71F RID: 186143
		[Token(Token = "0x402D71F")]
		[FieldOffset(Offset = "0x20")]
		public List<CrisisV2EntryViewModel.TempPart> tempStages;

		// Token: 0x0402D720 RID: 186144
		[Token(Token = "0x402D720")]
		[FieldOffset(Offset = "0x28")]
		public CrisisV2EntryViewModel.PermPart permStage;

		// Token: 0x0402D721 RID: 186145
		[Token(Token = "0x402D721")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x0402D722 RID: 186146
		[Token(Token = "0x402D722")]
		[FieldOffset(Offset = "0x38")]
		public string themeColor1;

		// Token: 0x0402D723 RID: 186147
		[Token(Token = "0x402D723")]
		[FieldOffset(Offset = "0x40")]
		public string themeColor2;

		// Token: 0x0402D724 RID: 186148
		[Token(Token = "0x402D724")]
		[FieldOffset(Offset = "0x48")]
		public string medalId;

		// Token: 0x0402D725 RID: 186149
		[Token(Token = "0x402D725")]
		[FieldOffset(Offset = "0x50")]
		public bool medalAvail;

		// Token: 0x0402D726 RID: 186150
		[Token(Token = "0x402D726")]
		[FieldOffset(Offset = "0x58")]
		public string medalGroupId;

		// Token: 0x0402D727 RID: 186151
		[Token(Token = "0x402D727")]
		[FieldOffset(Offset = "0x60")]
		public int coin;

		// Token: 0x0402D728 RID: 186152
		[Token(Token = "0x402D728")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005954 RID: 22868
		[Token(Token = "0x2005954")]
		public enum TempState
		{
			// Token: 0x0402D72A RID: 186154
			[Token(Token = "0x402D72A")]
			NOTOPEN,
			// Token: 0x0402D72B RID: 186155
			[Token(Token = "0x402D72B")]
			OPEN,
			// Token: 0x0402D72C RID: 186156
			[Token(Token = "0x402D72C")]
			REWARD_AVAIL,
			// Token: 0x0402D72D RID: 186157
			[Token(Token = "0x402D72D")]
			REWARD_ALL_GET,
			// Token: 0x0402D72E RID: 186158
			[Token(Token = "0x402D72E")]
			REWARD_OUT_OF_TIME
		}

		// Token: 0x02005955 RID: 22869
		[Token(Token = "0x2005955")]
		public class TempPart
		{
			// Token: 0x06021539 RID: 136505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021539")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TempPart()
			{
			}

			// Token: 0x0402D72F RID: 186159
			[Token(Token = "0x402D72F")]
			[FieldOffset(Offset = "0x10")]
			public string stageName;

			// Token: 0x0402D730 RID: 186160
			[Token(Token = "0x402D730")]
			[FieldOffset(Offset = "0x18")]
			public string mapId;

			// Token: 0x0402D731 RID: 186161
			[Token(Token = "0x402D731")]
			[FieldOffset(Offset = "0x20")]
			public string zoneCode;

			// Token: 0x0402D732 RID: 186162
			[Token(Token = "0x402D732")]
			[FieldOffset(Offset = "0x28")]
			public string tempStageId;

			// Token: 0x0402D733 RID: 186163
			[Token(Token = "0x402D733")]
			[FieldOffset(Offset = "0x30")]
			public CrisisV2EntryViewModel.TempState state;

			// Token: 0x0402D734 RID: 186164
			[Token(Token = "0x402D734")]
			[FieldOffset(Offset = "0x38")]
			public DateTime openTime;

			// Token: 0x0402D735 RID: 186165
			[Token(Token = "0x402D735")]
			[FieldOffset(Offset = "0x40")]
			public DateTime rewardEndTime;

			// Token: 0x0402D736 RID: 186166
			[Token(Token = "0x402D736")]
			[FieldOffset(Offset = "0x48")]
			public string logoPicId;

			// Token: 0x0402D737 RID: 186167
			[Token(Token = "0x402D737")]
			[FieldOffset(Offset = "0x50")]
			public string themeColor;
		}

		// Token: 0x02005956 RID: 22870
		[Token(Token = "0x2005956")]
		public class PermPart
		{
			// Token: 0x0602153A RID: 136506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602153A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PermPart()
			{
			}

			// Token: 0x0402D738 RID: 186168
			[Token(Token = "0x402D738")]
			[FieldOffset(Offset = "0x10")]
			public string permStageId;

			// Token: 0x0402D739 RID: 186169
			[Token(Token = "0x402D739")]
			[FieldOffset(Offset = "0x18")]
			public int score;

			// Token: 0x0402D73A RID: 186170
			[Token(Token = "0x402D73A")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x0402D73B RID: 186171
			[Token(Token = "0x402D73B")]
			[FieldOffset(Offset = "0x28")]
			public string code;

			// Token: 0x0402D73C RID: 186172
			[Token(Token = "0x402D73C")]
			[FieldOffset(Offset = "0x30")]
			public bool hasReward;
		}
	}
}
