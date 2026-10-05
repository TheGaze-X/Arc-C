using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C51 RID: 3153
	[Token(Token = "0x2000C51")]
	public class Act12SideData
	{
		// Token: 0x06006935 RID: 26933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006935")]
		[Address(RVA = "0x1FF2210", Offset = "0x1FF0E10", VA = "0x181FF2210")]
		public Act12SideData()
		{
		}

		// Token: 0x0400403B RID: 16443
		[Token(Token = "0x400403B")]
		[FieldOffset(Offset = "0x10")]
		public Act12SideData.ConstData constData;

		// Token: 0x0400403C RID: 16444
		[Token(Token = "0x400403C")]
		[FieldOffset(Offset = "0x18")]
		public List<Act12SideData.ZoneAdditionData> zoneAdditionDataList;

		// Token: 0x0400403D RID: 16445
		[Token(Token = "0x400403D")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, Act12SideData.MissionDescInfo> missionDescList;

		// Token: 0x0400403E RID: 16446
		[Token(Token = "0x400403E")]
		[FieldOffset(Offset = "0x28")]
		public List<Act12SideData.MileStoneInfo> mileStoneInfoList;

		// Token: 0x0400403F RID: 16447
		[Token(Token = "0x400403F")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, Act12SideData.PhotoInfo> photoList;

		// Token: 0x04004040 RID: 16448
		[Token(Token = "0x4004040")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<Act12SideData.RecycleDialogType, List<Act12SideData.RecycleDialogData>> recycleDialogDict;

		// Token: 0x02000C52 RID: 3154
		[Token(Token = "0x2000C52")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ActZoneClass
		{
			// Token: 0x04004042 RID: 16450
			[Token(Token = "0x4004042")]
			NONE,
			// Token: 0x04004043 RID: 16451
			[Token(Token = "0x4004043")]
			NORMAL,
			// Token: 0x04004044 RID: 16452
			[Token(Token = "0x4004044")]
			HIGHLEVEL,
			// Token: 0x04004045 RID: 16453
			[Token(Token = "0x4004045")]
			SUB
		}

		// Token: 0x02000C53 RID: 3155
		[Token(Token = "0x2000C53")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum RecycleDialogType
		{
			// Token: 0x04004047 RID: 16455
			[Token(Token = "0x4004047")]
			NONE,
			// Token: 0x04004048 RID: 16456
			[Token(Token = "0x4004048")]
			EMPTY,
			// Token: 0x04004049 RID: 16457
			[Token(Token = "0x4004049")]
			LOW,
			// Token: 0x0400404A RID: 16458
			[Token(Token = "0x400404A")]
			MEDIUM,
			// Token: 0x0400404B RID: 16459
			[Token(Token = "0x400404B")]
			HIGH,
			// Token: 0x0400404C RID: 16460
			[Token(Token = "0x400404C")]
			GACHA
		}

		// Token: 0x02000C54 RID: 3156
		[Token(Token = "0x2000C54")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum RecycleAnimationState
		{
			// Token: 0x0400404E RID: 16462
			[Token(Token = "0x400404E")]
			NONE,
			// Token: 0x0400404F RID: 16463
			[Token(Token = "0x400404F")]
			NORMAL,
			// Token: 0x04004050 RID: 16464
			[Token(Token = "0x4004050")]
			SMILE
		}

		// Token: 0x02000C55 RID: 3157
		[Token(Token = "0x2000C55")]
		public class ZoneAdditionData
		{
			// Token: 0x06006936 RID: 26934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006936")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneAdditionData()
			{
			}

			// Token: 0x04004051 RID: 16465
			[Token(Token = "0x4004051")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004052 RID: 16466
			[Token(Token = "0x4004052")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;

			// Token: 0x04004053 RID: 16467
			[Token(Token = "0x4004053")]
			[FieldOffset(Offset = "0x20")]
			public Act12SideData.ActZoneClass zoneClass;
		}

		// Token: 0x02000C56 RID: 3158
		[Token(Token = "0x2000C56")]
		public class ConstData
		{
			// Token: 0x06006937 RID: 26935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006937")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004054 RID: 16468
			[Token(Token = "0x4004054")]
			[FieldOffset(Offset = "0x10")]
			public int recycleRewardThreshold;

			// Token: 0x04004055 RID: 16469
			[Token(Token = "0x4004055")]
			[FieldOffset(Offset = "0x18")]
			public string charmRepoUnlockStageId;

			// Token: 0x04004056 RID: 16470
			[Token(Token = "0x4004056")]
			[FieldOffset(Offset = "0x20")]
			public int recycleLowThreshold;

			// Token: 0x04004057 RID: 16471
			[Token(Token = "0x4004057")]
			[FieldOffset(Offset = "0x24")]
			public int recycleMediumThreshold;

			// Token: 0x04004058 RID: 16472
			[Token(Token = "0x4004058")]
			[FieldOffset(Offset = "0x28")]
			public int recycleHighThreshold;

			// Token: 0x04004059 RID: 16473
			[Token(Token = "0x4004059")]
			[FieldOffset(Offset = "0x30")]
			public string autoGetCharmId;

			// Token: 0x0400405A RID: 16474
			[Token(Token = "0x400405A")]
			[FieldOffset(Offset = "0x38")]
			public string fogStageId;

			// Token: 0x0400405B RID: 16475
			[Token(Token = "0x400405B")]
			[FieldOffset(Offset = "0x40")]
			public string fogUnlockStageId;

			// Token: 0x0400405C RID: 16476
			[Token(Token = "0x400405C")]
			[FieldOffset(Offset = "0x48")]
			public long fogUnlockTs;

			// Token: 0x0400405D RID: 16477
			[Token(Token = "0x400405D")]
			[FieldOffset(Offset = "0x50")]
			public string fogUnlockDesc;
		}

		// Token: 0x02000C57 RID: 3159
		[Token(Token = "0x2000C57")]
		public class MissionDescInfo
		{
			// Token: 0x06006938 RID: 26936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006938")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionDescInfo()
			{
			}

			// Token: 0x0400405E RID: 16478
			[Token(Token = "0x400405E")]
			[FieldOffset(Offset = "0x10")]
			public Act12SideData.ActZoneClass zoneClass;

			// Token: 0x0400405F RID: 16479
			[Token(Token = "0x400405F")]
			[FieldOffset(Offset = "0x18")]
			public string specialMissionDesc;

			// Token: 0x04004060 RID: 16480
			[Token(Token = "0x4004060")]
			[FieldOffset(Offset = "0x20")]
			public bool needLock;

			// Token: 0x04004061 RID: 16481
			[Token(Token = "0x4004061")]
			[FieldOffset(Offset = "0x28")]
			public string unlockHint;

			// Token: 0x04004062 RID: 16482
			[Token(Token = "0x4004062")]
			[FieldOffset(Offset = "0x30")]
			public string unlockStage;
		}

		// Token: 0x02000C58 RID: 3160
		[Token(Token = "0x2000C58")]
		public class MileStoneInfo
		{
			// Token: 0x06006939 RID: 26937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006939")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MileStoneInfo()
			{
			}

			// Token: 0x04004063 RID: 16483
			[Token(Token = "0x4004063")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004064 RID: 16484
			[Token(Token = "0x4004064")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x04004065 RID: 16485
			[Token(Token = "0x4004065")]
			[FieldOffset(Offset = "0x1C")]
			public int tokenNum;

			// Token: 0x04004066 RID: 16486
			[Token(Token = "0x4004066")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;

			// Token: 0x04004067 RID: 16487
			[Token(Token = "0x4004067")]
			[FieldOffset(Offset = "0x28")]
			public bool isPrecious;

			// Token: 0x04004068 RID: 16488
			[Token(Token = "0x4004068")]
			[FieldOffset(Offset = "0x2C")]
			public int mileStoneStage;
		}

		// Token: 0x02000C59 RID: 3161
		[Token(Token = "0x2000C59")]
		public class PhotoInfo
		{
			// Token: 0x0600693A RID: 26938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600693A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PhotoInfo()
			{
			}

			// Token: 0x04004069 RID: 16489
			[Token(Token = "0x4004069")]
			[FieldOffset(Offset = "0x10")]
			public string picId;

			// Token: 0x0400406A RID: 16490
			[Token(Token = "0x400406A")]
			[FieldOffset(Offset = "0x18")]
			public string picName;

			// Token: 0x0400406B RID: 16491
			[Token(Token = "0x400406B")]
			[FieldOffset(Offset = "0x20")]
			public string mileStoneId;

			// Token: 0x0400406C RID: 16492
			[Token(Token = "0x400406C")]
			[FieldOffset(Offset = "0x28")]
			public string picDesc;

			// Token: 0x0400406D RID: 16493
			[Token(Token = "0x400406D")]
			[FieldOffset(Offset = "0x30")]
			public string jumpStageId;
		}

		// Token: 0x02000C5A RID: 3162
		[Token(Token = "0x2000C5A")]
		public class RecycleDialogData
		{
			// Token: 0x0600693B RID: 26939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600693B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecycleDialogData()
			{
			}

			// Token: 0x0400406E RID: 16494
			[Token(Token = "0x400406E")]
			[FieldOffset(Offset = "0x10")]
			public Act12SideData.RecycleDialogType dialogType;

			// Token: 0x0400406F RID: 16495
			[Token(Token = "0x400406F")]
			[FieldOffset(Offset = "0x18")]
			public string dialog;

			// Token: 0x04004070 RID: 16496
			[Token(Token = "0x4004070")]
			[FieldOffset(Offset = "0x20")]
			public Act12SideData.RecycleAnimationState dialogExpress;
		}
	}
}
