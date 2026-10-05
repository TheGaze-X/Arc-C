using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D67 RID: 3431
	[Token(Token = "0x2000D67")]
	public class Act4D0Data
	{
		// Token: 0x06006A39 RID: 27193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A39")]
		[Address(RVA = "0x1FF6DE0", Offset = "0x1FF59E0", VA = "0x181FF6DE0")]
		public Act4D0Data()
		{
		}

		// Token: 0x0400469B RID: 18075
		[Token(Token = "0x400469B")]
		[FieldOffset(Offset = "0x10")]
		public List<Act4D0Data.MileStoneItemInfo> mileStoneItemList;

		// Token: 0x0400469C RID: 18076
		[Token(Token = "0x400469C")]
		[FieldOffset(Offset = "0x18")]
		public List<Act4D0Data.MileStoneStoryInfo> mileStoneStoryList;

		// Token: 0x0400469D RID: 18077
		[Token(Token = "0x400469D")]
		[FieldOffset(Offset = "0x20")]
		public List<Act4D0Data.StoryInfo> storyInfoList;

		// Token: 0x0400469E RID: 18078
		[Token(Token = "0x400469E")]
		[FieldOffset(Offset = "0x28")]
		public List<Act4D0Data.StageJumpInfo> stageInfo;

		// Token: 0x0400469F RID: 18079
		[Token(Token = "0x400469F")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle tokenItem;

		// Token: 0x040046A0 RID: 18080
		[Token(Token = "0x40046A0")]
		[FieldOffset(Offset = "0x38")]
		public string charStoneId;

		// Token: 0x040046A1 RID: 18081
		[Token(Token = "0x40046A1")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x040046A2 RID: 18082
		[Token(Token = "0x40046A2")]
		[FieldOffset(Offset = "0x48")]
		public List<string> extraDropZones;

		// Token: 0x02000D68 RID: 3432
		[Token(Token = "0x2000D68")]
		public class StageJumpInfo
		{
			// Token: 0x06006A3A RID: 27194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A3A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StageJumpInfo()
			{
			}

			// Token: 0x040046A3 RID: 18083
			[Token(Token = "0x40046A3")]
			[FieldOffset(Offset = "0x10")]
			public string stageKey;

			// Token: 0x040046A4 RID: 18084
			[Token(Token = "0x40046A4")]
			[FieldOffset(Offset = "0x18")]
			public string zoneId;

			// Token: 0x040046A5 RID: 18085
			[Token(Token = "0x40046A5")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x040046A6 RID: 18086
			[Token(Token = "0x40046A6")]
			[FieldOffset(Offset = "0x28")]
			public string unlockDesc;

			// Token: 0x040046A7 RID: 18087
			[Token(Token = "0x40046A7")]
			[FieldOffset(Offset = "0x30")]
			public string lockDesc;
		}

		// Token: 0x02000D69 RID: 3433
		[Token(Token = "0x2000D69")]
		public class MileStoneItemInfo
		{
			// Token: 0x06006A3B RID: 27195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A3B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MileStoneItemInfo()
			{
			}

			// Token: 0x040046A8 RID: 18088
			[Token(Token = "0x40046A8")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x040046A9 RID: 18089
			[Token(Token = "0x40046A9")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x040046AA RID: 18090
			[Token(Token = "0x40046AA")]
			[FieldOffset(Offset = "0x1C")]
			public int tokenNum;

			// Token: 0x040046AB RID: 18091
			[Token(Token = "0x40046AB")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}

		// Token: 0x02000D6A RID: 3434
		[Token(Token = "0x2000D6A")]
		public class MileStoneStoryInfo
		{
			// Token: 0x06006A3C RID: 27196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A3C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MileStoneStoryInfo()
			{
			}

			// Token: 0x040046AC RID: 18092
			[Token(Token = "0x40046AC")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x040046AD RID: 18093
			[Token(Token = "0x40046AD")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x040046AE RID: 18094
			[Token(Token = "0x40046AE")]
			[FieldOffset(Offset = "0x1C")]
			public int tokenNum;

			// Token: 0x040046AF RID: 18095
			[Token(Token = "0x40046AF")]
			[FieldOffset(Offset = "0x20")]
			public string storyKey;

			// Token: 0x040046B0 RID: 18096
			[Token(Token = "0x40046B0")]
			[FieldOffset(Offset = "0x28")]
			public string desc;
		}

		// Token: 0x02000D6B RID: 3435
		[Token(Token = "0x2000D6B")]
		public class StoryInfo
		{
			// Token: 0x06006A3D RID: 27197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A3D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StoryInfo()
			{
			}

			// Token: 0x040046B1 RID: 18097
			[Token(Token = "0x40046B1")]
			[FieldOffset(Offset = "0x10")]
			public string storyKey;

			// Token: 0x040046B2 RID: 18098
			[Token(Token = "0x40046B2")]
			[FieldOffset(Offset = "0x18")]
			public string storyId;

			// Token: 0x040046B3 RID: 18099
			[Token(Token = "0x40046B3")]
			[FieldOffset(Offset = "0x20")]
			public string storySort;

			// Token: 0x040046B4 RID: 18100
			[Token(Token = "0x40046B4")]
			[FieldOffset(Offset = "0x28")]
			public string storyName;

			// Token: 0x040046B5 RID: 18101
			[Token(Token = "0x40046B5")]
			[FieldOffset(Offset = "0x30")]
			public string lockDesc;

			// Token: 0x040046B6 RID: 18102
			[Token(Token = "0x40046B6")]
			[FieldOffset(Offset = "0x38")]
			public string storyDesc;
		}
	}
}
