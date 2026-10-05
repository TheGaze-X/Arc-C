using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D3B RID: 3387
	[Token(Token = "0x2000D3B")]
	public class Act42D0Data
	{
		// Token: 0x06006A10 RID: 27152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A10")]
		[Address(RVA = "0x1FF5F80", Offset = "0x1FF4B80", VA = "0x181FF5F80")]
		public Act42D0Data()
		{
		}

		// Token: 0x04004592 RID: 17810
		[Token(Token = "0x4004592")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act42D0Data.Act42D0AreaInfoData> areaInfoData;

		// Token: 0x04004593 RID: 17811
		[Token(Token = "0x4004593")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act42D0Data.Act42D0StageInfoData> stageInfoData;

		// Token: 0x04004594 RID: 17812
		[Token(Token = "0x4004594")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act42D0Data.Act42D0EffectGroupInfoData> effectGroupInfoData;

		// Token: 0x04004595 RID: 17813
		[Token(Token = "0x4004595")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act42D0Data.Act42D0EffectInfoData> effectInfoData;

		// Token: 0x04004596 RID: 17814
		[Token(Token = "0x4004596")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act42D0Data.Act42D0ChallengeInfoData> challengeInfoData;

		// Token: 0x04004597 RID: 17815
		[Token(Token = "0x4004597")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act42D0Data.Act42D0StageRatingInfoData> stageRatingInfoData;

		// Token: 0x04004598 RID: 17816
		[Token(Token = "0x4004598")]
		[FieldOffset(Offset = "0x40")]
		public List<Act42D0Data.Act42D0MilestoneData> milestoneData;

		// Token: 0x04004599 RID: 17817
		[Token(Token = "0x4004599")]
		[FieldOffset(Offset = "0x48")]
		public Act42D0Data.Act42D0ConstData constData;

		// Token: 0x0400459A RID: 17818
		[Token(Token = "0x400459A")]
		[FieldOffset(Offset = "0x50")]
		public List<long> trackPointPeriodData;

		// Token: 0x02000D3C RID: 3388
		[Token(Token = "0x2000D3C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Act42D0AreaDifficulty
		{
			// Token: 0x0400459C RID: 17820
			[Token(Token = "0x400459C")]
			NONE,
			// Token: 0x0400459D RID: 17821
			[Token(Token = "0x400459D")]
			NORMAL,
			// Token: 0x0400459E RID: 17822
			[Token(Token = "0x400459E")]
			HARD
		}

		// Token: 0x02000D3D RID: 3389
		[Token(Token = "0x2000D3D")]
		public class Act42D0AreaInfoData
		{
			// Token: 0x06006A11 RID: 27153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A11")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0AreaInfoData()
			{
			}

			// Token: 0x0400459F RID: 17823
			[Token(Token = "0x400459F")]
			[FieldOffset(Offset = "0x10")]
			public string areaId;

			// Token: 0x040045A0 RID: 17824
			[Token(Token = "0x40045A0")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040045A1 RID: 17825
			[Token(Token = "0x40045A1")]
			[FieldOffset(Offset = "0x20")]
			public string areaCode;

			// Token: 0x040045A2 RID: 17826
			[Token(Token = "0x40045A2")]
			[FieldOffset(Offset = "0x28")]
			public string areaName;

			// Token: 0x040045A3 RID: 17827
			[Token(Token = "0x40045A3")]
			[FieldOffset(Offset = "0x30")]
			public Act42D0Data.Act42D0AreaDifficulty difficulty;

			// Token: 0x040045A4 RID: 17828
			[Token(Token = "0x40045A4")]
			[FieldOffset(Offset = "0x38")]
			public string areaDesc;

			// Token: 0x040045A5 RID: 17829
			[Token(Token = "0x40045A5")]
			[FieldOffset(Offset = "0x40")]
			public int costLimit;

			// Token: 0x040045A6 RID: 17830
			[Token(Token = "0x40045A6")]
			[FieldOffset(Offset = "0x48")]
			public string bossIcon;

			// Token: 0x040045A7 RID: 17831
			[Token(Token = "0x40045A7")]
			[FieldOffset(Offset = "0x50")]
			public string bossId;

			// Token: 0x040045A8 RID: 17832
			[Token(Token = "0x40045A8")]
			[FieldOffset(Offset = "0x58")]
			public string nextAreaStage;
		}

		// Token: 0x02000D3E RID: 3390
		[Token(Token = "0x2000D3E")]
		public class Act42D0StageInfoData
		{
			// Token: 0x06006A12 RID: 27154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A12")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0StageInfoData()
			{
			}

			// Token: 0x040045A9 RID: 17833
			[Token(Token = "0x40045A9")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040045AA RID: 17834
			[Token(Token = "0x40045AA")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;

			// Token: 0x040045AB RID: 17835
			[Token(Token = "0x40045AB")]
			[FieldOffset(Offset = "0x20")]
			public string stageCode;

			// Token: 0x040045AC RID: 17836
			[Token(Token = "0x40045AC")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x040045AD RID: 17837
			[Token(Token = "0x40045AD")]
			[FieldOffset(Offset = "0x30")]
			public List<string> stageDesc;

			// Token: 0x040045AE RID: 17838
			[Token(Token = "0x40045AE")]
			[FieldOffset(Offset = "0x38")]
			public string levelId;

			// Token: 0x040045AF RID: 17839
			[Token(Token = "0x40045AF")]
			[FieldOffset(Offset = "0x40")]
			public string code;

			// Token: 0x040045B0 RID: 17840
			[Token(Token = "0x40045B0")]
			[FieldOffset(Offset = "0x48")]
			public string name;

			// Token: 0x040045B1 RID: 17841
			[Token(Token = "0x40045B1")]
			[FieldOffset(Offset = "0x50")]
			public string loadingPicId;
		}

		// Token: 0x02000D3F RID: 3391
		[Token(Token = "0x2000D3F")]
		public class Act42D0EffectGroupInfoData
		{
			// Token: 0x06006A13 RID: 27155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A13")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0EffectGroupInfoData()
			{
			}

			// Token: 0x040045B2 RID: 17842
			[Token(Token = "0x40045B2")]
			[FieldOffset(Offset = "0x10")]
			public string effectGroupId;

			// Token: 0x040045B3 RID: 17843
			[Token(Token = "0x40045B3")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040045B4 RID: 17844
			[Token(Token = "0x40045B4")]
			[FieldOffset(Offset = "0x20")]
			public string effectGroupName;
		}

		// Token: 0x02000D40 RID: 3392
		[Token(Token = "0x2000D40")]
		public class Act42D0EffectInfoData
		{
			// Token: 0x06006A14 RID: 27156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A14")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0EffectInfoData()
			{
			}

			// Token: 0x040045B5 RID: 17845
			[Token(Token = "0x40045B5")]
			[FieldOffset(Offset = "0x10")]
			public string effectId;

			// Token: 0x040045B6 RID: 17846
			[Token(Token = "0x40045B6")]
			[FieldOffset(Offset = "0x18")]
			public string effectGroupId;

			// Token: 0x040045B7 RID: 17847
			[Token(Token = "0x40045B7")]
			[FieldOffset(Offset = "0x20")]
			public int row;

			// Token: 0x040045B8 RID: 17848
			[Token(Token = "0x40045B8")]
			[FieldOffset(Offset = "0x24")]
			public int col;

			// Token: 0x040045B9 RID: 17849
			[Token(Token = "0x40045B9")]
			[FieldOffset(Offset = "0x28")]
			public string effectName;

			// Token: 0x040045BA RID: 17850
			[Token(Token = "0x40045BA")]
			[FieldOffset(Offset = "0x30")]
			public string effectIcon;

			// Token: 0x040045BB RID: 17851
			[Token(Token = "0x40045BB")]
			[FieldOffset(Offset = "0x38")]
			public int cost;

			// Token: 0x040045BC RID: 17852
			[Token(Token = "0x40045BC")]
			[FieldOffset(Offset = "0x40")]
			public string effectDesc;

			// Token: 0x040045BD RID: 17853
			[Token(Token = "0x40045BD")]
			[FieldOffset(Offset = "0x48")]
			public long unlockTime;

			// Token: 0x040045BE RID: 17854
			[Token(Token = "0x40045BE")]
			[FieldOffset(Offset = "0x50")]
			public RuneTable.PackedRuneData runeData;
		}

		// Token: 0x02000D41 RID: 3393
		[Token(Token = "0x2000D41")]
		public class Act42D0ChallengeInfoData
		{
			// Token: 0x06006A15 RID: 27157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A15")]
			[Address(RVA = "0x1FF5EF0", Offset = "0x1FF4AF0", VA = "0x181FF5EF0")]
			public Act42D0ChallengeInfoData()
			{
			}

			// Token: 0x040045BF RID: 17855
			[Token(Token = "0x40045BF")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040045C0 RID: 17856
			[Token(Token = "0x40045C0")]
			[FieldOffset(Offset = "0x18")]
			public string stageDesc;

			// Token: 0x040045C1 RID: 17857
			[Token(Token = "0x40045C1")]
			[FieldOffset(Offset = "0x20")]
			public long startTs;

			// Token: 0x040045C2 RID: 17858
			[Token(Token = "0x40045C2")]
			[FieldOffset(Offset = "0x28")]
			public long endTs;

			// Token: 0x040045C3 RID: 17859
			[Token(Token = "0x40045C3")]
			[FieldOffset(Offset = "0x30")]
			public string levelId;

			// Token: 0x040045C4 RID: 17860
			[Token(Token = "0x40045C4")]
			[FieldOffset(Offset = "0x38")]
			public string code;

			// Token: 0x040045C5 RID: 17861
			[Token(Token = "0x40045C5")]
			[FieldOffset(Offset = "0x40")]
			public string name;

			// Token: 0x040045C6 RID: 17862
			[Token(Token = "0x40045C6")]
			[FieldOffset(Offset = "0x48")]
			public string loadingPicId;

			// Token: 0x040045C7 RID: 17863
			[Token(Token = "0x40045C7")]
			[FieldOffset(Offset = "0x50")]
			public List<Act42D0Data.Act42D0ChallengeMissionData> challengeMissionData;
		}

		// Token: 0x02000D42 RID: 3394
		[Token(Token = "0x2000D42")]
		public class Act42D0ChallengeMissionData
		{
			// Token: 0x06006A16 RID: 27158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A16")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0ChallengeMissionData()
			{
			}

			// Token: 0x040045C8 RID: 17864
			[Token(Token = "0x40045C8")]
			[FieldOffset(Offset = "0x10")]
			public string missionId;

			// Token: 0x040045C9 RID: 17865
			[Token(Token = "0x40045C9")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040045CA RID: 17866
			[Token(Token = "0x40045CA")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x040045CB RID: 17867
			[Token(Token = "0x40045CB")]
			[FieldOffset(Offset = "0x28")]
			public string missionDesc;

			// Token: 0x040045CC RID: 17868
			[Token(Token = "0x40045CC")]
			[FieldOffset(Offset = "0x30")]
			public int milestoneCount;
		}

		// Token: 0x02000D43 RID: 3395
		[Token(Token = "0x2000D43")]
		public class Act42D0StageRatingInfoData
		{
			// Token: 0x06006A17 RID: 27159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A17")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0StageRatingInfoData()
			{
			}

			// Token: 0x040045CD RID: 17869
			[Token(Token = "0x40045CD")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040045CE RID: 17870
			[Token(Token = "0x40045CE")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;

			// Token: 0x040045CF RID: 17871
			[Token(Token = "0x40045CF")]
			[FieldOffset(Offset = "0x20")]
			public List<Act42D0Data.Act42D0RatingInfoData> milestoneData;
		}

		// Token: 0x02000D44 RID: 3396
		[Token(Token = "0x2000D44")]
		public class Act42D0RatingInfoData
		{
			// Token: 0x06006A18 RID: 27160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A18")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0RatingInfoData()
			{
			}

			// Token: 0x040045D0 RID: 17872
			[Token(Token = "0x40045D0")]
			[FieldOffset(Offset = "0x10")]
			public int ratingLevel;

			// Token: 0x040045D1 RID: 17873
			[Token(Token = "0x40045D1")]
			[FieldOffset(Offset = "0x14")]
			public int costUpLimit;

			// Token: 0x040045D2 RID: 17874
			[Token(Token = "0x40045D2")]
			[FieldOffset(Offset = "0x18")]
			public string achivement;

			// Token: 0x040045D3 RID: 17875
			[Token(Token = "0x40045D3")]
			[FieldOffset(Offset = "0x20")]
			public string icon;

			// Token: 0x040045D4 RID: 17876
			[Token(Token = "0x40045D4")]
			[FieldOffset(Offset = "0x28")]
			public int milestoneCount;
		}

		// Token: 0x02000D45 RID: 3397
		[Token(Token = "0x2000D45")]
		public class Act42D0MilestoneData
		{
			// Token: 0x06006A19 RID: 27161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A19")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0MilestoneData()
			{
			}

			// Token: 0x040045D5 RID: 17877
			[Token(Token = "0x40045D5")]
			[FieldOffset(Offset = "0x10")]
			public string milestoneId;

			// Token: 0x040045D6 RID: 17878
			[Token(Token = "0x40045D6")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x040045D7 RID: 17879
			[Token(Token = "0x40045D7")]
			[FieldOffset(Offset = "0x1C")]
			public int tokenNum;

			// Token: 0x040045D8 RID: 17880
			[Token(Token = "0x40045D8")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}

		// Token: 0x02000D46 RID: 3398
		[Token(Token = "0x2000D46")]
		public class Act42D0ConstData
		{
			// Token: 0x06006A1A RID: 27162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A1A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42D0ConstData()
			{
			}

			// Token: 0x040045D9 RID: 17881
			[Token(Token = "0x40045D9")]
			[FieldOffset(Offset = "0x10")]
			public string milestoneId;

			// Token: 0x040045DA RID: 17882
			[Token(Token = "0x40045DA")]
			[FieldOffset(Offset = "0x18")]
			public string strifeName;

			// Token: 0x040045DB RID: 17883
			[Token(Token = "0x40045DB")]
			[FieldOffset(Offset = "0x20")]
			public string strifeDesc;

			// Token: 0x040045DC RID: 17884
			[Token(Token = "0x40045DC")]
			[FieldOffset(Offset = "0x28")]
			public string unlockDesc;

			// Token: 0x040045DD RID: 17885
			[Token(Token = "0x40045DD")]
			[FieldOffset(Offset = "0x30")]
			public string rewardDesc;

			// Token: 0x040045DE RID: 17886
			[Token(Token = "0x40045DE")]
			[FieldOffset(Offset = "0x38")]
			public string traumaDesc;

			// Token: 0x040045DF RID: 17887
			[Token(Token = "0x40045DF")]
			[FieldOffset(Offset = "0x40")]
			public string milestoneAreaName;

			// Token: 0x040045E0 RID: 17888
			[Token(Token = "0x40045E0")]
			[FieldOffset(Offset = "0x48")]
			public string traumaName;
		}
	}
}
