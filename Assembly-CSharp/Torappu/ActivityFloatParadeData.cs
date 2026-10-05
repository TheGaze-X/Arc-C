using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E0F RID: 3599
	[Token(Token = "0x2000E0F")]
	public class ActivityFloatParadeData
	{
		// Token: 0x06006AE2 RID: 27362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE2")]
		[Address(RVA = "0x1FFC380", Offset = "0x1FFAF80", VA = "0x181FFC380")]
		public ActivityFloatParadeData()
		{
		}

		// Token: 0x04004AFA RID: 19194
		[Token(Token = "0x4004AFA")]
		[FieldOffset(Offset = "0x10")]
		public ActivityFloatParadeData.ConstData constData;

		// Token: 0x04004AFB RID: 19195
		[Token(Token = "0x4004AFB")]
		[FieldOffset(Offset = "0x18")]
		public List<ActivityFloatParadeData.DailyData> dailyDataDic;

		// Token: 0x04004AFC RID: 19196
		[Token(Token = "0x4004AFC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Dictionary<string, ActivityFloatParadeData.RewardPool>> rewardPools;

		// Token: 0x04004AFD RID: 19197
		[Token(Token = "0x4004AFD")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityFloatParadeData.Tactic> tacticList;

		// Token: 0x04004AFE RID: 19198
		[Token(Token = "0x4004AFE")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActivityFloatParadeData.GroupData> groupInfos;

		// Token: 0x02000E10 RID: 3600
		[Token(Token = "0x2000E10")]
		public class ConstData
		{
			// Token: 0x06006AE3 RID: 27363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AE3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004AFF RID: 19199
			[Token(Token = "0x4004AFF")]
			[FieldOffset(Offset = "0x10")]
			public string cityName;

			// Token: 0x04004B00 RID: 19200
			[Token(Token = "0x4004B00")]
			[FieldOffset(Offset = "0x18")]
			public string cityNamePic;

			// Token: 0x04004B01 RID: 19201
			[Token(Token = "0x4004B01")]
			[FieldOffset(Offset = "0x20")]
			public float lowStandard;

			// Token: 0x04004B02 RID: 19202
			[Token(Token = "0x4004B02")]
			[FieldOffset(Offset = "0x28")]
			public string variationTitle;

			// Token: 0x04004B03 RID: 19203
			[Token(Token = "0x4004B03")]
			[FieldOffset(Offset = "0x30")]
			public string ruleDesc;
		}

		// Token: 0x02000E11 RID: 3601
		[Token(Token = "0x2000E11")]
		public class DailyData
		{
			// Token: 0x06006AE4 RID: 27364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AE4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DailyData()
			{
			}

			// Token: 0x04004B04 RID: 19204
			[Token(Token = "0x4004B04")]
			[FieldOffset(Offset = "0x10")]
			public int dayIndex;

			// Token: 0x04004B05 RID: 19205
			[Token(Token = "0x4004B05")]
			[FieldOffset(Offset = "0x18")]
			public string dateName;

			// Token: 0x04004B06 RID: 19206
			[Token(Token = "0x4004B06")]
			[FieldOffset(Offset = "0x20")]
			public string placeName;

			// Token: 0x04004B07 RID: 19207
			[Token(Token = "0x4004B07")]
			[FieldOffset(Offset = "0x28")]
			public string placeEnName;

			// Token: 0x04004B08 RID: 19208
			[Token(Token = "0x4004B08")]
			[FieldOffset(Offset = "0x30")]
			public string placePic;

			// Token: 0x04004B09 RID: 19209
			[Token(Token = "0x4004B09")]
			[FieldOffset(Offset = "0x38")]
			public string eventGroupId;

			// Token: 0x04004B0A RID: 19210
			[Token(Token = "0x4004B0A")]
			[FieldOffset(Offset = "0x40")]
			public ItemBundle extReward;
		}

		// Token: 0x02000E12 RID: 3602
		[Token(Token = "0x2000E12")]
		public class GroupData
		{
			// Token: 0x06006AE5 RID: 27365 RVA: 0x000311E8 File Offset: 0x0002F3E8
			[Token(Token = "0x6006AE5")]
			[Address(RVA = "0x200A010", Offset = "0x2008C10", VA = "0x18200A010")]
			public bool ShouldSerializeextRewardDay()
			{
				return default(bool);
			}

			// Token: 0x06006AE6 RID: 27366 RVA: 0x00031200 File Offset: 0x0002F400
			[Token(Token = "0x6006AE6")]
			[Address(RVA = "0x200A000", Offset = "0x2008C00", VA = "0x18200A000")]
			public bool ShouldSerializeextRewardCount()
			{
				return default(bool);
			}

			// Token: 0x06006AE7 RID: 27367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AE7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GroupData()
			{
			}

			// Token: 0x04004B0B RID: 19211
			[Token(Token = "0x4004B0B")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04004B0C RID: 19212
			[Token(Token = "0x4004B0C")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004B0D RID: 19213
			[Token(Token = "0x4004B0D")]
			[FieldOffset(Offset = "0x20")]
			public int startDay;

			// Token: 0x04004B0E RID: 19214
			[Token(Token = "0x4004B0E")]
			[FieldOffset(Offset = "0x24")]
			public int endDay;

			// Token: 0x04004B0F RID: 19215
			[Token(Token = "0x4004B0F")]
			[FieldOffset(Offset = "0x28")]
			public int extRewardDay;

			// Token: 0x04004B10 RID: 19216
			[Token(Token = "0x4004B10")]
			[FieldOffset(Offset = "0x2C")]
			public int extRewardCount;
		}

		// Token: 0x02000E13 RID: 3603
		[Token(Token = "0x2000E13")]
		public class RewardPool
		{
			// Token: 0x06006AE8 RID: 27368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AE8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RewardPool()
			{
			}

			// Token: 0x04004B11 RID: 19217
			[Token(Token = "0x4004B11")]
			[FieldOffset(Offset = "0x10")]
			public string grpId;

			// Token: 0x04004B12 RID: 19218
			[Token(Token = "0x4004B12")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x04004B13 RID: 19219
			[Token(Token = "0x4004B13")]
			[FieldOffset(Offset = "0x20")]
			public string type;

			// Token: 0x04004B14 RID: 19220
			[Token(Token = "0x4004B14")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04004B15 RID: 19221
			[Token(Token = "0x4004B15")]
			[FieldOffset(Offset = "0x30")]
			public string desc;

			// Token: 0x04004B16 RID: 19222
			[Token(Token = "0x4004B16")]
			[FieldOffset(Offset = "0x38")]
			public ItemBundle reward;
		}

		// Token: 0x02000E14 RID: 3604
		[Token(Token = "0x2000E14")]
		public class Tactic
		{
			// Token: 0x06006AE9 RID: 27369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AE9")]
			[Address(RVA = "0x200E1B0", Offset = "0x200CDB0", VA = "0x18200E1B0")]
			public Tactic()
			{
			}

			// Token: 0x04004B17 RID: 19223
			[Token(Token = "0x4004B17")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			// Token: 0x04004B18 RID: 19224
			[Token(Token = "0x4004B18")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004B19 RID: 19225
			[Token(Token = "0x4004B19")]
			[FieldOffset(Offset = "0x20")]
			public string packName;

			// Token: 0x04004B1A RID: 19226
			[Token(Token = "0x4004B1A")]
			[FieldOffset(Offset = "0x28")]
			public string briefName;

			// Token: 0x04004B1B RID: 19227
			[Token(Token = "0x4004B1B")]
			[FieldOffset(Offset = "0x30")]
			public ListDict<string, float> rewardVar;
		}
	}
}
