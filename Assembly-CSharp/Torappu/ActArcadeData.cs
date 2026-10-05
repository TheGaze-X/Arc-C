using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D86 RID: 3462
	[Token(Token = "0x2000D86")]
	public class ActArcadeData
	{
		// Token: 0x06006A55 RID: 27221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A55")]
		[Address(RVA = "0x1FF7F90", Offset = "0x1FF6B90", VA = "0x181FF7F90")]
		public ActArcadeData()
		{
		}

		// Token: 0x04004733 RID: 18227
		[Token(Token = "0x4004733")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArcadeData.ArcadeStageAdditionalData> stageAdditionDataDict;

		// Token: 0x04004734 RID: 18228
		[Token(Token = "0x4004734")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, ActArcadeData.ArcadeZoneAdditionalData> zoneAdditionalDataDict;

		// Token: 0x04004735 RID: 18229
		[Token(Token = "0x4004735")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActArcadeData.ArcadeBadgeData> badgeDataDict;

		// Token: 0x04004736 RID: 18230
		[Token(Token = "0x4004736")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> tireBadgeIdDict;

		// Token: 0x04004737 RID: 18231
		[Token(Token = "0x4004737")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActArcadeData.ArcadeBadgeTypeData> badgeTypeDataDict;

		// Token: 0x04004738 RID: 18232
		[Token(Token = "0x4004738")]
		[FieldOffset(Offset = "0x38")]
		public List<ActArcadeData.ArcadeMilestoneItemData> milestoneList;

		// Token: 0x04004739 RID: 18233
		[Token(Token = "0x4004739")]
		[FieldOffset(Offset = "0x40")]
		public ActArcadeData.ArcadeConstData constData;

		// Token: 0x02000D87 RID: 3463
		[Token(Token = "0x2000D87")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Rank
		{
			// Token: 0x0400473B RID: 18235
			[Token(Token = "0x400473B")]
			B,
			// Token: 0x0400473C RID: 18236
			[Token(Token = "0x400473C")]
			A,
			// Token: 0x0400473D RID: 18237
			[Token(Token = "0x400473D")]
			S,
			// Token: 0x0400473E RID: 18238
			[Token(Token = "0x400473E")]
			SS,
			// Token: 0x0400473F RID: 18239
			[Token(Token = "0x400473F")]
			SSS
		}

		// Token: 0x02000D88 RID: 3464
		[Token(Token = "0x2000D88")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SubModeType
		{
			// Token: 0x04004741 RID: 18241
			[Token(Token = "0x4004741")]
			IGNORE = -1,
			// Token: 0x04004742 RID: 18242
			[Token(Token = "0x4004742")]
			MINER,
			// Token: 0x04004743 RID: 18243
			[Token(Token = "0x4004743")]
			DRAW,
			// Token: 0x04004744 RID: 18244
			[Token(Token = "0x4004744")]
			LINE,
			// Token: 0x04004745 RID: 18245
			[Token(Token = "0x4004745")]
			CAR,
			// Token: 0x04004746 RID: 18246
			[Token(Token = "0x4004746")]
			E_NUM
		}

		// Token: 0x02000D89 RID: 3465
		[Token(Token = "0x2000D89")]
		public class ArcadeZoneAdditionalData
		{
			// Token: 0x06006A56 RID: 27222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A56")]
			[Address(RVA = "0x1FFE640", Offset = "0x1FFD240", VA = "0x181FFE640")]
			public ArcadeZoneAdditionalData()
			{
			}

			// Token: 0x04004747 RID: 18247
			[Token(Token = "0x4004747")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004748 RID: 18248
			[Token(Token = "0x4004748")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004749 RID: 18249
			[Token(Token = "0x4004749")]
			[FieldOffset(Offset = "0x20")]
			public string zoneName;

			// Token: 0x0400474A RID: 18250
			[Token(Token = "0x400474A")]
			[FieldOffset(Offset = "0x28")]
			public string zoneEntryPicId;

			// Token: 0x0400474B RID: 18251
			[Token(Token = "0x400474B")]
			[FieldOffset(Offset = "0x30")]
			public string stageInfoPrefabId;

			// Token: 0x0400474C RID: 18252
			[Token(Token = "0x400474C")]
			[FieldOffset(Offset = "0x38")]
			public long startTs;

			// Token: 0x0400474D RID: 18253
			[Token(Token = "0x400474D")]
			[FieldOffset(Offset = "0x40")]
			public long endTs;

			// Token: 0x0400474E RID: 18254
			[Token(Token = "0x400474E")]
			[FieldOffset(Offset = "0x48")]
			public List<string> stages;

			// Token: 0x0400474F RID: 18255
			[Token(Token = "0x400474F")]
			[FieldOffset(Offset = "0x50")]
			public ActArcadeData.SubModeType subModeType;

			// Token: 0x04004750 RID: 18256
			[Token(Token = "0x4004750")]
			[FieldOffset(Offset = "0x58")]
			public string zoneDesc;
		}

		// Token: 0x02000D8A RID: 3466
		[Token(Token = "0x2000D8A")]
		public class ArcadeStageAdditionalData
		{
			// Token: 0x06006A57 RID: 27223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A57")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArcadeStageAdditionalData()
			{
			}

			// Token: 0x04004751 RID: 18257
			[Token(Token = "0x4004751")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004752 RID: 18258
			[Token(Token = "0x4004752")]
			[FieldOffset(Offset = "0x18")]
			public string zoneId;

			// Token: 0x04004753 RID: 18259
			[Token(Token = "0x4004753")]
			[FieldOffset(Offset = "0x20")]
			public string mechDescription;

			// Token: 0x04004754 RID: 18260
			[Token(Token = "0x4004754")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x04004755 RID: 18261
			[Token(Token = "0x4004755")]
			[FieldOffset(Offset = "0x2C")]
			public int maxSlot;

			// Token: 0x04004756 RID: 18262
			[Token(Token = "0x4004756")]
			[FieldOffset(Offset = "0x30")]
			public ActArcadeData.ArcadeStageRankRewardData rankRewardData;
		}

		// Token: 0x02000D8B RID: 3467
		[Token(Token = "0x2000D8B")]
		public class ArcadeStageRankRewardData
		{
			// Token: 0x06006A58 RID: 27224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A58")]
			[Address(RVA = "0x1FFE5B0", Offset = "0x1FFD1B0", VA = "0x181FFE5B0")]
			public ArcadeStageRankRewardData()
			{
			}

			// Token: 0x04004757 RID: 18263
			[Token(Token = "0x4004757")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004758 RID: 18264
			[Token(Token = "0x4004758")]
			[FieldOffset(Offset = "0x18")]
			public ActArcadeData.Rank maxRewardRank;

			// Token: 0x04004759 RID: 18265
			[Token(Token = "0x4004759")]
			[FieldOffset(Offset = "0x20")]
			public List<ActArcadeData.ArcadeStageRankRewardLevelData> rankRewardLevelDatas;
		}

		// Token: 0x02000D8C RID: 3468
		[Token(Token = "0x2000D8C")]
		public class ArcadeStageRankRewardLevelData
		{
			// Token: 0x06006A59 RID: 27225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A59")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArcadeStageRankRewardLevelData()
			{
			}

			// Token: 0x0400475A RID: 18266
			[Token(Token = "0x400475A")]
			[FieldOffset(Offset = "0x10")]
			public ActArcadeData.Rank rank;

			// Token: 0x0400475B RID: 18267
			[Token(Token = "0x400475B")]
			[FieldOffset(Offset = "0x14")]
			public int rankScore;

			// Token: 0x0400475C RID: 18268
			[Token(Token = "0x400475C")]
			[FieldOffset(Offset = "0x18")]
			public int coinCnt;
		}

		// Token: 0x02000D8D RID: 3469
		[Token(Token = "0x2000D8D")]
		public class ArcadeBadgeTierData
		{
			// Token: 0x06006A5A RID: 27226 RVA: 0x00030F00 File Offset: 0x0002F100
			[Token(Token = "0x6006A5A")]
			[Address(RVA = "0x1FFE4D0", Offset = "0x1FFD0D0", VA = "0x181FFE4D0")]
			public bool ShouldSerializebadgeTierEffectId()
			{
				return default(bool);
			}

			// Token: 0x06006A5B RID: 27227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A5B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArcadeBadgeTierData()
			{
			}

			// Token: 0x0400475D RID: 18269
			[Token(Token = "0x400475D")]
			[FieldOffset(Offset = "0x10")]
			public string badgeTierId;

			// Token: 0x0400475E RID: 18270
			[Token(Token = "0x400475E")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0400475F RID: 18271
			[Token(Token = "0x400475F")]
			[FieldOffset(Offset = "0x20")]
			public string badgeTierIconId;

			// Token: 0x04004760 RID: 18272
			[Token(Token = "0x4004760")]
			[FieldOffset(Offset = "0x28")]
			public string badgeTierShareIconId;

			// Token: 0x04004761 RID: 18273
			[Token(Token = "0x4004761")]
			[FieldOffset(Offset = "0x30")]
			public string badgeTierEffectId;

			// Token: 0x04004762 RID: 18274
			[Token(Token = "0x4004762")]
			[FieldOffset(Offset = "0x38")]
			public string title;

			// Token: 0x04004763 RID: 18275
			[Token(Token = "0x4004763")]
			[FieldOffset(Offset = "0x40")]
			public string desc;

			// Token: 0x04004764 RID: 18276
			[Token(Token = "0x4004764")]
			[FieldOffset(Offset = "0x48")]
			public string buffId;

			// Token: 0x04004765 RID: 18277
			[Token(Token = "0x4004765")]
			[FieldOffset(Offset = "0x50")]
			public string unlockDesc;

			// Token: 0x04004766 RID: 18278
			[Token(Token = "0x4004766")]
			[FieldOffset(Offset = "0x58")]
			public RuneTable.PackedRuneData runeData;
		}

		// Token: 0x02000D8E RID: 3470
		[Token(Token = "0x2000D8E")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum BadgeType
		{
			// Token: 0x04004768 RID: 18280
			[Token(Token = "0x4004768")]
			COMMON,
			// Token: 0x04004769 RID: 18281
			[Token(Token = "0x4004769")]
			ZONE,
			// Token: 0x0400476A RID: 18282
			[Token(Token = "0x400476A")]
			ULTIMATE
		}

		// Token: 0x02000D8F RID: 3471
		[Token(Token = "0x2000D8F")]
		public class ArcadeBadgeData
		{
			// Token: 0x06006A5C RID: 27228 RVA: 0x00030F18 File Offset: 0x0002F118
			[Token(Token = "0x6006A5C")]
			[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
			public bool ShouldSerializebuffRangeDesc()
			{
				return default(bool);
			}

			// Token: 0x06006A5D RID: 27229 RVA: 0x00030F30 File Offset: 0x0002F130
			[Token(Token = "0x6006A5D")]
			[Address(RVA = "0x1FF9BF0", Offset = "0x1FF87F0", VA = "0x181FF9BF0")]
			public bool ShouldSerializescoreZone()
			{
				return default(bool);
			}

			// Token: 0x06006A5E RID: 27230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A5E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArcadeBadgeData()
			{
			}

			// Token: 0x0400476B RID: 18283
			[Token(Token = "0x400476B")]
			[FieldOffset(Offset = "0x10")]
			public string badgeId;

			// Token: 0x0400476C RID: 18284
			[Token(Token = "0x400476C")]
			[FieldOffset(Offset = "0x18")]
			public ActArcadeData.BadgeType badgeType;

			// Token: 0x0400476D RID: 18285
			[Token(Token = "0x400476D")]
			[FieldOffset(Offset = "0x1C")]
			public int sortId;

			// Token: 0x0400476E RID: 18286
			[Token(Token = "0x400476E")]
			[FieldOffset(Offset = "0x20")]
			public string badgeName;

			// Token: 0x0400476F RID: 18287
			[Token(Token = "0x400476F")]
			[FieldOffset(Offset = "0x28")]
			public string buffRangeDesc;

			// Token: 0x04004770 RID: 18288
			[Token(Token = "0x4004770")]
			[FieldOffset(Offset = "0x30")]
			public bool hasScore;

			// Token: 0x04004771 RID: 18289
			[Token(Token = "0x4004771")]
			[FieldOffset(Offset = "0x38")]
			public string scoreZone;

			// Token: 0x04004772 RID: 18290
			[Token(Token = "0x4004772")]
			[FieldOffset(Offset = "0x40")]
			public ListDict<string, ActArcadeData.ArcadeBadgeTierData> tiers;
		}

		// Token: 0x02000D90 RID: 3472
		[Token(Token = "0x2000D90")]
		public class ArcadeBadgeTypeData
		{
			// Token: 0x06006A5F RID: 27231 RVA: 0x00030F48 File Offset: 0x0002F148
			[Token(Token = "0x6006A5F")]
			[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
			public bool ShouldSerializebuffRangeDesc()
			{
				return default(bool);
			}

			// Token: 0x06006A60 RID: 27232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A60")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArcadeBadgeTypeData()
			{
			}

			// Token: 0x04004773 RID: 18291
			[Token(Token = "0x4004773")]
			[FieldOffset(Offset = "0x10")]
			public ActArcadeData.BadgeType badgeType;

			// Token: 0x04004774 RID: 18292
			[Token(Token = "0x4004774")]
			[FieldOffset(Offset = "0x18")]
			public string badgeTypeName;

			// Token: 0x04004775 RID: 18293
			[Token(Token = "0x4004775")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x04004776 RID: 18294
			[Token(Token = "0x4004776")]
			[FieldOffset(Offset = "0x28")]
			public string buffRangeDesc;
		}

		// Token: 0x02000D91 RID: 3473
		[Token(Token = "0x2000D91")]
		public class ArcadeMilestoneItemData
		{
			// Token: 0x06006A61 RID: 27233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A61")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArcadeMilestoneItemData()
			{
			}

			// Token: 0x04004777 RID: 18295
			[Token(Token = "0x4004777")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004778 RID: 18296
			[Token(Token = "0x4004778")]
			[FieldOffset(Offset = "0x18")]
			public int mileStoneLvl;

			// Token: 0x04004779 RID: 18297
			[Token(Token = "0x4004779")]
			[FieldOffset(Offset = "0x1C")]
			public int needPointCnt;

			// Token: 0x0400477A RID: 18298
			[Token(Token = "0x400477A")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle reward;
		}

		// Token: 0x02000D92 RID: 3474
		[Token(Token = "0x2000D92")]
		public class ArcadeConstData
		{
			// Token: 0x06006A62 RID: 27234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A62")]
			[Address(RVA = "0x1FFE4F0", Offset = "0x1FFD0F0", VA = "0x181FFE4F0")]
			public ArcadeConstData()
			{
			}

			// Token: 0x0400477B RID: 18299
			[Token(Token = "0x400477B")]
			[FieldOffset(Offset = "0x10")]
			public string milestoneName;

			// Token: 0x0400477C RID: 18300
			[Token(Token = "0x400477C")]
			[FieldOffset(Offset = "0x18")]
			public string milestoneNameEN;

			// Token: 0x0400477D RID: 18301
			[Token(Token = "0x400477D")]
			[FieldOffset(Offset = "0x20")]
			public string milestoneItemId;

			// Token: 0x0400477E RID: 18302
			[Token(Token = "0x400477E")]
			[FieldOffset(Offset = "0x28")]
			public string rewardHomeThemeId;

			// Token: 0x0400477F RID: 18303
			[Token(Token = "0x400477F")]
			[FieldOffset(Offset = "0x30")]
			public string rewardHomeThemeText;

			// Token: 0x04004780 RID: 18304
			[Token(Token = "0x4004780")]
			[FieldOffset(Offset = "0x38")]
			public string rewardAvatarId;

			// Token: 0x04004781 RID: 18305
			[Token(Token = "0x4004781")]
			[FieldOffset(Offset = "0x40")]
			public string rewardAvatarText;

			// Token: 0x04004782 RID: 18306
			[Token(Token = "0x4004782")]
			[FieldOffset(Offset = "0x48")]
			public string badgeCollectionName;

			// Token: 0x04004783 RID: 18307
			[Token(Token = "0x4004783")]
			[FieldOffset(Offset = "0x50")]
			public string collectionEntryRelatedBadge;

			// Token: 0x04004784 RID: 18308
			[Token(Token = "0x4004784")]
			[FieldOffset(Offset = "0x58")]
			public string zoneEntryUnlockToast;

			// Token: 0x04004785 RID: 18309
			[Token(Token = "0x4004785")]
			[FieldOffset(Offset = "0x60")]
			public string zoneEntryEndText;

			// Token: 0x04004786 RID: 18310
			[Token(Token = "0x4004786")]
			[FieldOffset(Offset = "0x68")]
			public string zoneEntryEndToast;

			// Token: 0x04004787 RID: 18311
			[Token(Token = "0x4004787")]
			[FieldOffset(Offset = "0x70")]
			public string rankUnlockNextStage;

			// Token: 0x04004788 RID: 18312
			[Token(Token = "0x4004788")]
			[FieldOffset(Offset = "0x78")]
			public int stageScoreDisplayLimit;

			// Token: 0x04004789 RID: 18313
			[Token(Token = "0x4004789")]
			[FieldOffset(Offset = "0x7C")]
			public int zoneUltiScoreDisplayLimit;

			// Token: 0x0400478A RID: 18314
			[Token(Token = "0x400478A")]
			[FieldOffset(Offset = "0x80")]
			public List<string> enemyHudScore;

			// Token: 0x0400478B RID: 18315
			[Token(Token = "0x400478B")]
			[FieldOffset(Offset = "0x88")]
			public List<string> trapNotBuildableInRest;
		}
	}
}
