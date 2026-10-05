using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F9 RID: 4857
	[Token(Token = "0x20012F9")]
	public class SandboxV2Data
	{
		// Token: 0x06007272 RID: 29298 RVA: 0x00032DA8 File Offset: 0x00030FA8
		[Token(Token = "0x6007272")]
		[Address(RVA = "0x220E7C0", Offset = "0x220D3C0", VA = "0x18220E7C0")]
		public bool ShouldSerializechallengeModeData()
		{
			return default(bool);
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x00032DC0 File Offset: 0x00030FC0
		[Token(Token = "0x6007273")]
		[Address(RVA = "0x220E7E0", Offset = "0x220D3E0", VA = "0x18220E7E0")]
		public bool ShouldSerializeracingData()
		{
			return default(bool);
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007274")]
		[Address(RVA = "0x220E800", Offset = "0x220D400", VA = "0x18220E800")]
		public SandboxV2Data()
		{
		}

		// Token: 0x04006B55 RID: 27477
		[Token(Token = "0x4006B55")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SandboxV2MapData> mapData;

		// Token: 0x04006B56 RID: 27478
		[Token(Token = "0x4006B56")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SandboxV2ItemTrapData> itemTrapData;

		// Token: 0x04006B57 RID: 27479
		[Token(Token = "0x4006B57")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SandboxV2ItemTrapTagData> itemTrapTagData;

		// Token: 0x04006B58 RID: 27480
		[Token(Token = "0x4006B58")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SandboxV2BuildingItemData> buildingItemData;

		// Token: 0x04006B59 RID: 27481
		[Token(Token = "0x4006B59")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, SandboxV2CraftItemData> craftItemData;

		// Token: 0x04006B5A RID: 27482
		[Token(Token = "0x4006B5A")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SandboxV2LivestockData> livestockProduceData;

		// Token: 0x04006B5B RID: 27483
		[Token(Token = "0x4006B5B")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, SandboxV2CraftGroupData> craftGroupData;

		// Token: 0x04006B5C RID: 27484
		[Token(Token = "0x4006B5C")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, SandboxV2AlchemyRecipeData> alchemyRecipeData;

		// Token: 0x04006B5D RID: 27485
		[Token(Token = "0x4006B5D")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, SandboxV2DrinkMatData> drinkMatData;

		// Token: 0x04006B5E RID: 27486
		[Token(Token = "0x4006B5E")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, SandboxV2FoodMatData> foodMatData;

		// Token: 0x04006B5F RID: 27487
		[Token(Token = "0x4006B5F")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, SandboxV2FoodData> foodData;

		// Token: 0x04006B60 RID: 27488
		[Token(Token = "0x4006B60")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, SandboxV2NodeTypeData> nodeTypeData;

		// Token: 0x04006B61 RID: 27489
		[Token(Token = "0x4006B61")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, SandboxV2NodeUpgradeData> nodeUpgradeData;

		// Token: 0x04006B62 RID: 27490
		[Token(Token = "0x4006B62")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, SandboxV2WeatherData> weatherData;

		// Token: 0x04006B63 RID: 27491
		[Token(Token = "0x4006B63")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, SandboxV2StageData> stageData;

		// Token: 0x04006B64 RID: 27492
		[Token(Token = "0x4006B64")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, SandboxV2ZoneData> zoneData;

		// Token: 0x04006B65 RID: 27493
		[Token(Token = "0x4006B65")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<string, SandboxV2NodeBuffData> nodeBuffData;

		// Token: 0x04006B66 RID: 27494
		[Token(Token = "0x4006B66")]
		[FieldOffset(Offset = "0x98")]
		public SandboxV2RewardConfigGroupData rewardConfigData;

		// Token: 0x04006B67 RID: 27495
		[Token(Token = "0x4006B67")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<string, SandboxV2FloatIconData> floatIconData;

		// Token: 0x04006B68 RID: 27496
		[Token(Token = "0x4006B68")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, SandboxV2EnemyRushTypeData> enemyRushTypeData;

		// Token: 0x04006B69 RID: 27497
		[Token(Token = "0x4006B69")]
		[FieldOffset(Offset = "0xB0")]
		public SandboxV2BattleRushEnemyData rushEnemyData;

		// Token: 0x04006B6A RID: 27498
		[Token(Token = "0x4006B6A")]
		[FieldOffset(Offset = "0xB8")]
		public SandboxV2GameConst gameConst;

		// Token: 0x04006B6B RID: 27499
		[Token(Token = "0x4006B6B")]
		[FieldOffset(Offset = "0xC0")]
		public SandboxV2BasicConst basicConst;

		// Token: 0x04006B6C RID: 27500
		[Token(Token = "0x4006B6C")]
		[FieldOffset(Offset = "0xC8")]
		public SandboxV2RiftConst riftConst;

		// Token: 0x04006B6D RID: 27501
		[Token(Token = "0x4006B6D")]
		[FieldOffset(Offset = "0xD0")]
		public SandboxV2DevelopmentConst developmentConst;

		// Token: 0x04006B6E RID: 27502
		[Token(Token = "0x4006B6E")]
		[FieldOffset(Offset = "0xD8")]
		public List<TipData> battleLoadingTips;

		// Token: 0x04006B6F RID: 27503
		[Token(Token = "0x4006B6F")]
		[FieldOffset(Offset = "0xE0")]
		public Dictionary<string, RuneTable.PackedRuneData> runeDatas;

		// Token: 0x04006B70 RID: 27504
		[Token(Token = "0x4006B70")]
		[FieldOffset(Offset = "0xE8")]
		public Dictionary<string, List<LegacyInLevelRuneData>> itemRuneList;

		// Token: 0x04006B71 RID: 27505
		[Token(Token = "0x4006B71")]
		[FieldOffset(Offset = "0xF0")]
		public Dictionary<string, SandboxV2QuestData> questData;

		// Token: 0x04006B72 RID: 27506
		[Token(Token = "0x4006B72")]
		[FieldOffset(Offset = "0xF8")]
		public Dictionary<string, SandboxV2NpcData> npcData;

		// Token: 0x04006B73 RID: 27507
		[Token(Token = "0x4006B73")]
		[FieldOffset(Offset = "0x100")]
		public Dictionary<string, SandboxV2DialogData> dialogData;

		// Token: 0x04006B74 RID: 27508
		[Token(Token = "0x4006B74")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<string, SandboxV2QuestLineData> questLineData;

		// Token: 0x04006B75 RID: 27509
		[Token(Token = "0x4006B75")]
		[FieldOffset(Offset = "0x110")]
		public Dictionary<string, string> questLineStoryData;

		// Token: 0x04006B76 RID: 27510
		[Token(Token = "0x4006B76")]
		[FieldOffset(Offset = "0x118")]
		public Dictionary<string, SandboxV2GuideQuestData> guideQuestData;

		// Token: 0x04006B77 RID: 27511
		[Token(Token = "0x4006B77")]
		[FieldOffset(Offset = "0x120")]
		public Dictionary<string, SandboxV2DevelopmentData> developmentData;

		// Token: 0x04006B78 RID: 27512
		[Token(Token = "0x4006B78")]
		[FieldOffset(Offset = "0x128")]
		public Dictionary<string, SandboxV2EventData> eventData;

		// Token: 0x04006B79 RID: 27513
		[Token(Token = "0x4006B79")]
		[FieldOffset(Offset = "0x130")]
		public Dictionary<string, SandboxV2EventSceneData> eventSceneData;

		// Token: 0x04006B7A RID: 27514
		[Token(Token = "0x4006B7A")]
		[FieldOffset(Offset = "0x138")]
		public Dictionary<string, SandboxV2EventChoiceData> eventChoiceData;

		// Token: 0x04006B7B RID: 27515
		[Token(Token = "0x4006B7B")]
		[FieldOffset(Offset = "0x140")]
		public Dictionary<string, SandboxV2ExpeditionData> expeditionData;

		// Token: 0x04006B7C RID: 27516
		[Token(Token = "0x4006B7C")]
		[FieldOffset(Offset = "0x148")]
		public Dictionary<string, SandboxV2EventEffectData> eventEffectData;

		// Token: 0x04006B7D RID: 27517
		[Token(Token = "0x4006B7D")]
		[FieldOffset(Offset = "0x150")]
		public Dictionary<string, SandboxV2ShopGoodData> shopGoodData;

		// Token: 0x04006B7E RID: 27518
		[Token(Token = "0x4006B7E")]
		[FieldOffset(Offset = "0x158")]
		public SandboxV2ShopDialogData shopDialogData;

		// Token: 0x04006B7F RID: 27519
		[Token(Token = "0x4006B7F")]
		[FieldOffset(Offset = "0x160")]
		public List<SandboxV2LogisticsData> logisticsData;

		// Token: 0x04006B80 RID: 27520
		[Token(Token = "0x4006B80")]
		[FieldOffset(Offset = "0x168")]
		public Dictionary<int, Dictionary<int, List<SandboxV2LogisticsCharData>>> logisticsCharMapping;

		// Token: 0x04006B81 RID: 27521
		[Token(Token = "0x4006B81")]
		[FieldOffset(Offset = "0x170")]
		public Dictionary<string, string> materialKeywordData;

		// Token: 0x04006B82 RID: 27522
		[Token(Token = "0x4006B82")]
		[FieldOffset(Offset = "0x178")]
		public List<SandboxV2MonthRushData> monthRushData;

		// Token: 0x04006B83 RID: 27523
		[Token(Token = "0x4006B83")]
		[FieldOffset(Offset = "0x180")]
		public Dictionary<string, SandboxV2RiftParamData> riftTerrainParamData;

		// Token: 0x04006B84 RID: 27524
		[Token(Token = "0x4006B84")]
		[FieldOffset(Offset = "0x188")]
		public Dictionary<string, SandboxV2RiftParamData> riftClimateParamData;

		// Token: 0x04006B85 RID: 27525
		[Token(Token = "0x4006B85")]
		[FieldOffset(Offset = "0x190")]
		public Dictionary<string, SandboxV2RiftParamData> riftEnemyParamData;

		// Token: 0x04006B86 RID: 27526
		[Token(Token = "0x4006B86")]
		[FieldOffset(Offset = "0x198")]
		public Dictionary<string, SandboxV2RiftSubTargetData> riftSubTargetData;

		// Token: 0x04006B87 RID: 27527
		[Token(Token = "0x4006B87")]
		[FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, SandboxV2RiftMainTargetData> riftMainTargetData;

		// Token: 0x04006B88 RID: 27528
		[Token(Token = "0x4006B88")]
		[FieldOffset(Offset = "0x1A8")]
		public Dictionary<string, SandboxV2RiftGlobalEffectData> riftGlobalEffectData;

		// Token: 0x04006B89 RID: 27529
		[Token(Token = "0x4006B89")]
		[FieldOffset(Offset = "0x1B0")]
		public Dictionary<string, SandboxV2FixedRiftData> fixedRiftData;

		// Token: 0x04006B8A RID: 27530
		[Token(Token = "0x4006B8A")]
		[FieldOffset(Offset = "0x1B8")]
		public Dictionary<string, List<SandboxV2RiftTeamBuffData>> riftTeamBuffData;

		// Token: 0x04006B8B RID: 27531
		[Token(Token = "0x4006B8B")]
		[FieldOffset(Offset = "0x1C0")]
		public ListDict<string, SandboxV2RiftDifficultyData> riftDifficultyData;

		// Token: 0x04006B8C RID: 27532
		[Token(Token = "0x4006B8C")]
		[FieldOffset(Offset = "0x1C8")]
		public Dictionary<string, List<string>> riftRewardDisplayData;

		// Token: 0x04006B8D RID: 27533
		[Token(Token = "0x4006B8D")]
		[FieldOffset(Offset = "0x1D0")]
		public Dictionary<string, Dictionary<string, string>> enemyReplaceData;

		// Token: 0x04006B8E RID: 27534
		[Token(Token = "0x4006B8E")]
		[FieldOffset(Offset = "0x1D8")]
		public Dictionary<string, SandboxV2ArchiveQuestData> archiveQuestData;

		// Token: 0x04006B8F RID: 27535
		[Token(Token = "0x4006B8F")]
		[FieldOffset(Offset = "0x1E0")]
		public Dictionary<string, SandboxV2ArchiveAchievementData> achievementData;

		// Token: 0x04006B90 RID: 27536
		[Token(Token = "0x4006B90")]
		[FieldOffset(Offset = "0x1E8")]
		public Dictionary<string, SandboxV2ArchiveAchievementTypeData> achievementTypeData;

		// Token: 0x04006B91 RID: 27537
		[Token(Token = "0x4006B91")]
		[FieldOffset(Offset = "0x1F0")]
		public Dictionary<string, SandboxV2ArchiveQuestTypeData> archiveQuestTypeData;

		// Token: 0x04006B92 RID: 27538
		[Token(Token = "0x4006B92")]
		[FieldOffset(Offset = "0x1F8")]
		public Dictionary<string, SandboxV2ArchiveMusicUnlockData> archiveMusicUnlockData;

		// Token: 0x04006B93 RID: 27539
		[Token(Token = "0x4006B93")]
		[FieldOffset(Offset = "0x200")]
		public List<SandboxV2BaseUpdateData> baseUpdate;

		// Token: 0x04006B94 RID: 27540
		[Token(Token = "0x4006B94")]
		[FieldOffset(Offset = "0x208")]
		public List<SandboxV2DevelopmentLineSegmentData> developmentLineSegmentDatas;

		// Token: 0x04006B95 RID: 27541
		[Token(Token = "0x4006B95")]
		[FieldOffset(Offset = "0x210")]
		public Dictionary<string, SandboxV2BuildingNodeScoreData> buildingNodeScoreData;

		// Token: 0x04006B96 RID: 27542
		[Token(Token = "0x4006B96")]
		[FieldOffset(Offset = "0x218")]
		public Dictionary<string, SandboxV2SeasonData> seasonData;

		// Token: 0x04006B97 RID: 27543
		[Token(Token = "0x4006B97")]
		[FieldOffset(Offset = "0x220")]
		public List<SandboxV2ConfirmIconData> confirmIconData;

		// Token: 0x04006B98 RID: 27544
		[Token(Token = "0x4006B98")]
		[FieldOffset(Offset = "0x228")]
		public List<long> shopUpdateTimeData;

		// Token: 0x04006B99 RID: 27545
		[Token(Token = "0x4006B99")]
		[FieldOffset(Offset = "0x230")]
		public SandboxV2TutorialData tutorialData;

		// Token: 0x04006B9A RID: 27546
		[Token(Token = "0x4006B9A")]
		[FieldOffset(Offset = "0x238")]
		public SandboxV2RacingData racingData;

		// Token: 0x04006B9B RID: 27547
		[Token(Token = "0x4006B9B")]
		[FieldOffset(Offset = "0x240")]
		public SandboxV2ChallengeModeData challengeModeData;
	}
}
