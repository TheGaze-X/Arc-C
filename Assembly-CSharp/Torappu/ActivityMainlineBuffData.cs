using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E1C RID: 3612
	[Token(Token = "0x2000E1C")]
	public class ActivityMainlineBuffData
	{
		// Token: 0x06006AF0 RID: 27376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF0")]
		[Address(RVA = "0x1FFC840", Offset = "0x1FFB440", VA = "0x181FFC840")]
		public ActivityMainlineBuffData()
		{
		}

		// Token: 0x04004B3C RID: 19260
		[Token(Token = "0x4004B3C")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, ActivityMainlineBuffData.MissionGroupData> missionGroupList;

		// Token: 0x04004B3D RID: 19261
		[Token(Token = "0x4004B3D")]
		[FieldOffset(Offset = "0x18")]
		public List<ActivityMainlineBuffData.PeriodData> periodDataList;

		// Token: 0x04004B3E RID: 19262
		[Token(Token = "0x4004B3E")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, long> apSupplyOutOfDateDict;

		// Token: 0x04004B3F RID: 19263
		[Token(Token = "0x4004B3F")]
		[FieldOffset(Offset = "0x28")]
		public ActivityMainlineBuffData.ConstData constData;

		// Token: 0x02000E1D RID: 3613
		[Token(Token = "0x2000E1D")]
		public class MissionGroupData
		{
			// Token: 0x06006AF1 RID: 27377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionGroupData()
			{
			}

			// Token: 0x04004B40 RID: 19264
			[Token(Token = "0x4004B40")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004B41 RID: 19265
			[Token(Token = "0x4004B41")]
			[FieldOffset(Offset = "0x18")]
			public string bindBanner;

			// Token: 0x04004B42 RID: 19266
			[Token(Token = "0x4004B42")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x04004B43 RID: 19267
			[Token(Token = "0x4004B43")]
			[FieldOffset(Offset = "0x28")]
			public string zoneId;

			// Token: 0x04004B44 RID: 19268
			[Token(Token = "0x4004B44")]
			[FieldOffset(Offset = "0x30")]
			public List<string> missionIdList;
		}

		// Token: 0x02000E1E RID: 3614
		[Token(Token = "0x2000E1E")]
		public class PeriodData
		{
			// Token: 0x06006AF2 RID: 27378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF2")]
			[Address(RVA = "0x200BA60", Offset = "0x200A660", VA = "0x18200BA60")]
			public PeriodData()
			{
			}

			// Token: 0x04004B45 RID: 19269
			[Token(Token = "0x4004B45")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004B46 RID: 19270
			[Token(Token = "0x4004B46")]
			[FieldOffset(Offset = "0x18")]
			public long startTime;

			// Token: 0x04004B47 RID: 19271
			[Token(Token = "0x4004B47")]
			[FieldOffset(Offset = "0x20")]
			public long endTime;

			// Token: 0x04004B48 RID: 19272
			[Token(Token = "0x4004B48")]
			[FieldOffset(Offset = "0x28")]
			public string favorUpCharDesc;

			// Token: 0x04004B49 RID: 19273
			[Token(Token = "0x4004B49")]
			[FieldOffset(Offset = "0x30")]
			public string favorUpImgName;

			// Token: 0x04004B4A RID: 19274
			[Token(Token = "0x4004B4A")]
			[FieldOffset(Offset = "0x38")]
			public string newChapterImgName;

			// Token: 0x04004B4B RID: 19275
			[Token(Token = "0x4004B4B")]
			[FieldOffset(Offset = "0x40")]
			public string newChapterZoneId;

			// Token: 0x04004B4C RID: 19276
			[Token(Token = "0x4004B4C")]
			[FieldOffset(Offset = "0x48")]
			public List<ActivityMainlineBuffData.PeriodData.StepData> stepDataList;

			// Token: 0x02000E1F RID: 3615
			[Token(Token = "0x2000E1F")]
			public class StepData
			{
				// Token: 0x06006AF3 RID: 27379 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006AF3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public StepData()
				{
				}

				// Token: 0x04004B4D RID: 19277
				[Token(Token = "0x4004B4D")]
				[FieldOffset(Offset = "0x10")]
				public bool isBlock;

				// Token: 0x04004B4E RID: 19278
				[Token(Token = "0x4004B4E")]
				[FieldOffset(Offset = "0x18")]
				public string favorUpDesc;

				// Token: 0x04004B4F RID: 19279
				[Token(Token = "0x4004B4F")]
				[FieldOffset(Offset = "0x20")]
				public string unlockDesc;

				// Token: 0x04004B50 RID: 19280
				[Token(Token = "0x4004B50")]
				[FieldOffset(Offset = "0x28")]
				public string bindStageId;

				// Token: 0x04004B51 RID: 19281
				[Token(Token = "0x4004B51")]
				[FieldOffset(Offset = "0x30")]
				public string blockDesc;
			}
		}

		// Token: 0x02000E20 RID: 3616
		[Token(Token = "0x2000E20")]
		public class ConstData
		{
			// Token: 0x06006AF4 RID: 27380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AF4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004B52 RID: 19282
			[Token(Token = "0x4004B52")]
			[FieldOffset(Offset = "0x10")]
			public string favorUpStageRange;
		}
	}
}
