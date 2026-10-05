using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E15 RID: 3605
	[Token(Token = "0x2000E15")]
	public class ActivityInterlockData
	{
		// Token: 0x06006AEA RID: 27370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0x1FFC530", Offset = "0x1FFB130", VA = "0x181FFC530")]
		public ActivityInterlockData()
		{
		}

		// Token: 0x04004B1C RID: 19228
		[Token(Token = "0x4004B1C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActivityInterlockData.StageAdditionData> stageAdditionInfoMap;

		// Token: 0x04004B1D RID: 19229
		[Token(Token = "0x4004B1D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActivityInterlockData.TreasureMonsterData> treasureMonsterMap;

		// Token: 0x04004B1E RID: 19230
		[Token(Token = "0x4004B1E")]
		[FieldOffset(Offset = "0x20")]
		public SharedCharData specialAssistData;

		// Token: 0x04004B1F RID: 19231
		[Token(Token = "0x4004B1F")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityInterlockData.MileStoneItemInfo> mileStoneItemList;

		// Token: 0x04004B20 RID: 19232
		[Token(Token = "0x4004B20")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<ActivityInterlockData.FinalStageProgressData>> finalStageProgressMap;

		// Token: 0x02000E16 RID: 3606
		[Token(Token = "0x2000E16")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum InterlockStageType
		{
			// Token: 0x04004B22 RID: 19234
			[Token(Token = "0x4004B22")]
			NONE,
			// Token: 0x04004B23 RID: 19235
			[Token(Token = "0x4004B23")]
			NORMAL,
			// Token: 0x04004B24 RID: 19236
			[Token(Token = "0x4004B24")]
			INTERLOCK,
			// Token: 0x04004B25 RID: 19237
			[Token(Token = "0x4004B25")]
			FINAL
		}

		// Token: 0x02000E17 RID: 3607
		[Token(Token = "0x2000E17")]
		public class StageAdditionData
		{
			// Token: 0x06006AEB RID: 27371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AEB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StageAdditionData()
			{
			}

			// Token: 0x04004B26 RID: 19238
			[Token(Token = "0x4004B26")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004B27 RID: 19239
			[Token(Token = "0x4004B27")]
			[FieldOffset(Offset = "0x18")]
			public ActivityInterlockData.InterlockStageType stageType;

			// Token: 0x04004B28 RID: 19240
			[Token(Token = "0x4004B28")]
			[FieldOffset(Offset = "0x20")]
			public string lockStageKey;

			// Token: 0x04004B29 RID: 19241
			[Token(Token = "0x4004B29")]
			[FieldOffset(Offset = "0x28")]
			public int lockSortIndex;
		}

		// Token: 0x02000E18 RID: 3608
		[Token(Token = "0x2000E18")]
		public class MileStoneItemInfo
		{
			// Token: 0x06006AEC RID: 27372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AEC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MileStoneItemInfo()
			{
			}

			// Token: 0x04004B2A RID: 19242
			[Token(Token = "0x4004B2A")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004B2B RID: 19243
			[Token(Token = "0x4004B2B")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x04004B2C RID: 19244
			[Token(Token = "0x4004B2C")]
			[FieldOffset(Offset = "0x1C")]
			public int tokenNum;

			// Token: 0x04004B2D RID: 19245
			[Token(Token = "0x4004B2D")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}

		// Token: 0x02000E19 RID: 3609
		[Token(Token = "0x2000E19")]
		public class TreasureMonsterData
		{
			// Token: 0x06006AED RID: 27373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TreasureMonsterData()
			{
			}

			// Token: 0x04004B2E RID: 19246
			[Token(Token = "0x4004B2E")]
			[FieldOffset(Offset = "0x10")]
			public string lockStageKey;

			// Token: 0x04004B2F RID: 19247
			[Token(Token = "0x4004B2F")]
			[FieldOffset(Offset = "0x18")]
			public string enemyId;

			// Token: 0x04004B30 RID: 19248
			[Token(Token = "0x4004B30")]
			[FieldOffset(Offset = "0x20")]
			public string enemyName;

			// Token: 0x04004B31 RID: 19249
			[Token(Token = "0x4004B31")]
			[FieldOffset(Offset = "0x28")]
			public string enemyIcon;

			// Token: 0x04004B32 RID: 19250
			[Token(Token = "0x4004B32")]
			[FieldOffset(Offset = "0x30")]
			public string enemyDescription;
		}

		// Token: 0x02000E1A RID: 3610
		[Token(Token = "0x2000E1A")]
		public class FinalStageProgressData
		{
			// Token: 0x06006AEE RID: 27374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AEE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FinalStageProgressData()
			{
			}

			// Token: 0x04004B33 RID: 19251
			[Token(Token = "0x4004B33")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004B34 RID: 19252
			[Token(Token = "0x4004B34")]
			[FieldOffset(Offset = "0x18")]
			public int killCnt;

			// Token: 0x04004B35 RID: 19253
			[Token(Token = "0x4004B35")]
			[FieldOffset(Offset = "0x1C")]
			public int apCost;

			// Token: 0x04004B36 RID: 19254
			[Token(Token = "0x4004B36")]
			[FieldOffset(Offset = "0x20")]
			public int favor;

			// Token: 0x04004B37 RID: 19255
			[Token(Token = "0x4004B37")]
			[FieldOffset(Offset = "0x24")]
			public int exp;

			// Token: 0x04004B38 RID: 19256
			[Token(Token = "0x4004B38")]
			[FieldOffset(Offset = "0x28")]
			public int gold;
		}
	}
}
