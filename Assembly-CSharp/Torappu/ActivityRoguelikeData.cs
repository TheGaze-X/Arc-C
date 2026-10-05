using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E24 RID: 3620
	[Token(Token = "0x2000E24")]
	public class ActivityRoguelikeData
	{
		// Token: 0x06006AF8 RID: 27384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0x1FFCAC0", Offset = "0x1FFB6C0", VA = "0x181FFCAC0")]
		public ActivityRoguelikeData()
		{
		}

		// Token: 0x04004B5C RID: 19292
		[Token(Token = "0x4004B5C")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, ActivityRoguelikeData.OuterBuffUnlockInfoData> outBuffInfos;

		// Token: 0x04004B5D RID: 19293
		[Token(Token = "0x4004B5D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x04004B5E RID: 19294
		[Token(Token = "0x4004B5E")]
		[FieldOffset(Offset = "0x20")]
		public string outerBuffToken;

		// Token: 0x04004B5F RID: 19295
		[Token(Token = "0x4004B5F")]
		[FieldOffset(Offset = "0x28")]
		public string shopToken;

		// Token: 0x04004B60 RID: 19296
		[Token(Token = "0x4004B60")]
		[FieldOffset(Offset = "0x30")]
		public long relicUnlockTime;

		// Token: 0x04004B61 RID: 19297
		[Token(Token = "0x4004B61")]
		[FieldOffset(Offset = "0x38")]
		public float milestoneTokenRatio;

		// Token: 0x04004B62 RID: 19298
		[Token(Token = "0x4004B62")]
		[FieldOffset(Offset = "0x3C")]
		public float outerBuffTokenRatio;

		// Token: 0x04004B63 RID: 19299
		[Token(Token = "0x4004B63")]
		[FieldOffset(Offset = "0x40")]
		public float relicTokenRatio;

		// Token: 0x04004B64 RID: 19300
		[Token(Token = "0x4004B64")]
		[FieldOffset(Offset = "0x44")]
		public float relicOuterBuffTokenRatio;

		// Token: 0x04004B65 RID: 19301
		[Token(Token = "0x4004B65")]
		[FieldOffset(Offset = "0x48")]
		public int reOpenCoolDown;

		// Token: 0x04004B66 RID: 19302
		[Token(Token = "0x4004B66")]
		[FieldOffset(Offset = "0x50")]
		public ItemBundle tokenItem;

		// Token: 0x04004B67 RID: 19303
		[Token(Token = "0x4004B67")]
		[FieldOffset(Offset = "0x58")]
		public string charStoneId;

		// Token: 0x04004B68 RID: 19304
		[Token(Token = "0x4004B68")]
		[FieldOffset(Offset = "0x60")]
		public List<ActivityRoguelikeData.MileStoneItemInfo> milestone;

		// Token: 0x04004B69 RID: 19305
		[Token(Token = "0x4004B69")]
		[FieldOffset(Offset = "0x68")]
		public List<ActivityTable.CustomUnlockCond> unlockConds;

		// Token: 0x02000E25 RID: 3621
		[Token(Token = "0x2000E25")]
		public class OuterBuffUnlockInfoData
		{
			// Token: 0x06006AF9 RID: 27385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF9")]
			[Address(RVA = "0x200B9D0", Offset = "0x200A5D0", VA = "0x18200B9D0")]
			public OuterBuffUnlockInfoData()
			{
			}

			// Token: 0x04004B6A RID: 19306
			[Token(Token = "0x4004B6A")]
			[FieldOffset(Offset = "0x10")]
			public string buffId;

			// Token: 0x04004B6B RID: 19307
			[Token(Token = "0x4004B6B")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, ActivityRoguelikeData.OuterBuffUnlockInfo> buffUnlockInfos;
		}

		// Token: 0x02000E26 RID: 3622
		[Token(Token = "0x2000E26")]
		public class OuterBuffUnlockInfo
		{
			// Token: 0x06006AFA RID: 27386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AFA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OuterBuffUnlockInfo()
			{
			}

			// Token: 0x04004B6C RID: 19308
			[Token(Token = "0x4004B6C")]
			[FieldOffset(Offset = "0x10")]
			public int buffLevel;

			// Token: 0x04004B6D RID: 19309
			[Token(Token = "0x4004B6D")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004B6E RID: 19310
			[Token(Token = "0x4004B6E")]
			[FieldOffset(Offset = "0x20")]
			public string iconId;

			// Token: 0x04004B6F RID: 19311
			[Token(Token = "0x4004B6F")]
			[FieldOffset(Offset = "0x28")]
			public string description;

			// Token: 0x04004B70 RID: 19312
			[Token(Token = "0x4004B70")]
			[FieldOffset(Offset = "0x30")]
			public string usage;

			// Token: 0x04004B71 RID: 19313
			[Token(Token = "0x4004B71")]
			[FieldOffset(Offset = "0x38")]
			public string itemId;

			// Token: 0x04004B72 RID: 19314
			[Token(Token = "0x4004B72")]
			[FieldOffset(Offset = "0x40")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType itemType;

			// Token: 0x04004B73 RID: 19315
			[Token(Token = "0x4004B73")]
			[FieldOffset(Offset = "0x44")]
			public int cost;
		}

		// Token: 0x02000E27 RID: 3623
		[Token(Token = "0x2000E27")]
		public class MileStoneItemInfo
		{
			// Token: 0x06006AFB RID: 27387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MileStoneItemInfo()
			{
			}

			// Token: 0x04004B74 RID: 19316
			[Token(Token = "0x4004B74")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004B75 RID: 19317
			[Token(Token = "0x4004B75")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x04004B76 RID: 19318
			[Token(Token = "0x4004B76")]
			[FieldOffset(Offset = "0x1C")]
			public int tokenNum;

			// Token: 0x04004B77 RID: 19319
			[Token(Token = "0x4004B77")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}
	}
}
