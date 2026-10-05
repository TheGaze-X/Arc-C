using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DA5 RID: 3493
	[Token(Token = "0x2000DA5")]
	public class ActAutoChessData
	{
		// Token: 0x06006A63 RID: 27235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A63")]
		[Address(RVA = "0x1FF92D0", Offset = "0x1FF7ED0", VA = "0x181FF92D0")]
		public ActAutoChessData()
		{
		}

		// Token: 0x040047FE RID: 18430
		[Token(Token = "0x40047FE")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActAutoChessData.ActAutoChessModeData> modeDataDict;

		// Token: 0x040047FF RID: 18431
		[Token(Token = "0x40047FF")]
		[FieldOffset(Offset = "0x18")]
		public List<ActAutoChessData.ActAutoChessBaseRewardData> baseRewardDataList;

		// Token: 0x04004800 RID: 18432
		[Token(Token = "0x4004800")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, ActAutoChessData.ActAutoChessBandData> bandDataListDict;

		// Token: 0x04004801 RID: 18433
		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charChessDataDict;

		// Token: 0x04004802 RID: 18434
		[Token(Token = "0x4004802")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> chessNormalIdLookupDict;

		// Token: 0x04004803 RID: 18435
		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, RarityRank> diyChessDict;

		// Token: 0x04004804 RID: 18436
		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Dictionary<int, ActAutoChessData.ActAutoChessShopLevelData>> shopLevelDataDict;

		// Token: 0x04004805 RID: 18437
		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, ActAutoChessData.ActAutoChessShopLevelDisplayData> shopLevelDisplayDataDict;

		// Token: 0x04004806 RID: 18438
		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, ActAutoChessData.ActAutoChessCharShopChessData> charShopChessDatas;

		// Token: 0x04004807 RID: 18439
		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, ActAutoChessData.ActAutoChessTrapChessData> trapChessDataDict;

		// Token: 0x04004808 RID: 18440
		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0x60")]
		public ListDict<string, ActAutoChessData.ActAutoChessTrapShopChessData> trapShopChessDatas;

		// Token: 0x04004809 RID: 18441
		[Token(Token = "0x4004809")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, ActAutoChessData.ActAutoChessStageData> stageDatasDict;

		// Token: 0x0400480A RID: 18442
		[Token(Token = "0x400480A")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, Dictionary<int, List<ActAutoChessData.ActAutoChessBattleData>>> battleDataDict;

		// Token: 0x0400480B RID: 18443
		[Token(Token = "0x400480B")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, ActAutoChessData.ActAutoChessBondInfo> bondInfoDict;

		// Token: 0x0400480C RID: 18444
		[Token(Token = "0x400480C")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, ActAutoChessData.ActAutoChessGarrisonData> garrisonDataDict;

		// Token: 0x0400480D RID: 18445
		[Token(Token = "0x400480D")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, ActAutoChessData.ActAutoChessEffectInfoData> effectInfoDataDict;

		// Token: 0x0400480E RID: 18446
		[Token(Token = "0x400480E")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<string, List<ActAutoChessData.ActAutoChessBuffInfoData>> effectBuffInfoDataDict;

		// Token: 0x0400480F RID: 18447
		[Token(Token = "0x400480F")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, ActAutoChessData.ActAutoChessEffectChoiceInfoData> effectChoiceInfoDict;

		// Token: 0x04004810 RID: 18448
		[Token(Token = "0x4004810")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<string, ActAutoChessData.ActAutochessBossEntry> bossInfoDict;

		// Token: 0x04004811 RID: 18449
		[Token(Token = "0x4004811")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, ActAutoChessData.ActAutochessSpecialEnemyEntry> specialEnemyInfoDict;

		// Token: 0x04004812 RID: 18450
		[Token(Token = "0x4004812")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, List<string>> enemyInfoDict;

		// Token: 0x04004813 RID: 18451
		[Token(Token = "0x4004813")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, ActAutoChessData.ActAutochessSpecialEnemyTypeEntry> specialEnemyRandomTypeDict;

		// Token: 0x04004814 RID: 18452
		[Token(Token = "0x4004814")]
		[FieldOffset(Offset = "0xC0")]
		public List<ActAutoChessData.ActAutoChessTrainingNpcData> trainingNpcList;

		// Token: 0x04004815 RID: 18453
		[Token(Token = "0x4004815")]
		[FieldOffset(Offset = "0xC8")]
		public List<ActivityCommonMilestoneData> milestoneList;

		// Token: 0x04004816 RID: 18454
		[Token(Token = "0x4004816")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<string, float> modeFactorInfo;

		// Token: 0x04004817 RID: 18455
		[Token(Token = "0x4004817")]
		[FieldOffset(Offset = "0xD8")]
		public Dictionary<string, float> difficultyFactorInfo;

		// Token: 0x04004818 RID: 18456
		[Token(Token = "0x4004818")]
		[FieldOffset(Offset = "0xE0")]
		public Dictionary<string, ActAutoChessData.ActAutoChessPlayerTitleData> playerTitleDataDict;

		// Token: 0x04004819 RID: 18457
		[Token(Token = "0x4004819")]
		[FieldOffset(Offset = "0xE8")]
		public Dictionary<int, List<ActAutoChessData.ActAutoChessShopCharChessInfoData>> shopCharChessInfoData;

		// Token: 0x0400481A RID: 18458
		[Token(Token = "0x400481A")]
		[FieldOffset(Offset = "0xF0")]
		public ActAutoChessData.ActAutoChessConstData constData;

		// Token: 0x02000DA6 RID: 3494
		[Token(Token = "0x2000DA6")]
		public class ActAutoChessModeData
		{
			// Token: 0x06006A64 RID: 27236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A64")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessModeData()
			{
			}

			// Token: 0x0400481B RID: 18459
			[Token(Token = "0x400481B")]
			[FieldOffset(Offset = "0x10")]
			public string modeId;

			// Token: 0x0400481C RID: 18460
			[Token(Token = "0x400481C")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0400481D RID: 18461
			[Token(Token = "0x400481D")]
			[FieldOffset(Offset = "0x20")]
			public string code;

			// Token: 0x0400481E RID: 18462
			[Token(Token = "0x400481E")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x0400481F RID: 18463
			[Token(Token = "0x400481F")]
			[FieldOffset(Offset = "0x30")]
			public string backgroundId;

			// Token: 0x04004820 RID: 18464
			[Token(Token = "0x4004820")]
			[FieldOffset(Offset = "0x38")]
			public string desc;

			// Token: 0x04004821 RID: 18465
			[Token(Token = "0x4004821")]
			[FieldOffset(Offset = "0x40")]
			public List<string> effectDescList;

			// Token: 0x04004822 RID: 18466
			[Token(Token = "0x4004822")]
			[FieldOffset(Offset = "0x48")]
			public string preposedMode;

			// Token: 0x04004823 RID: 18467
			[Token(Token = "0x4004823")]
			[FieldOffset(Offset = "0x50")]
			public string unlockText;

			// Token: 0x04004824 RID: 18468
			[Token(Token = "0x4004824")]
			[FieldOffset(Offset = "0x58")]
			public string loadingPicId;

			// Token: 0x04004825 RID: 18469
			[Token(Token = "0x4004825")]
			[FieldOffset(Offset = "0x60")]
			public ActAutoChessModeType modeType;

			// Token: 0x04004826 RID: 18470
			[Token(Token = "0x4004826")]
			[FieldOffset(Offset = "0x64")]
			public ActAutoChessModeDifficultyType modeDifficulty;

			// Token: 0x04004827 RID: 18471
			[Token(Token = "0x4004827")]
			[FieldOffset(Offset = "0x68")]
			public string modeIconId;

			// Token: 0x04004828 RID: 18472
			[Token(Token = "0x4004828")]
			[FieldOffset(Offset = "0x70")]
			public string modeColor;

			// Token: 0x04004829 RID: 18473
			[Token(Token = "0x4004829")]
			[FieldOffset(Offset = "0x78")]
			public int specialPhaseTime;

			// Token: 0x0400482A RID: 18474
			[Token(Token = "0x400482A")]
			[FieldOffset(Offset = "0x80")]
			public List<string> activeBondIdList;

			// Token: 0x0400482B RID: 18475
			[Token(Token = "0x400482B")]
			[FieldOffset(Offset = "0x88")]
			public List<string> inactiveBondIdList;

			// Token: 0x0400482C RID: 18476
			[Token(Token = "0x400482C")]
			[FieldOffset(Offset = "0x90")]
			public List<string> inactiveEnemyKey;

			// Token: 0x0400482D RID: 18477
			[Token(Token = "0x400482D")]
			[FieldOffset(Offset = "0x98")]
			public long startTime;
		}

		// Token: 0x02000DA7 RID: 3495
		[Token(Token = "0x2000DA7")]
		public class ActAutoChessBondInfo
		{
			// Token: 0x06006A65 RID: 27237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A65")]
			[Address(RVA = "0x1FF9220", Offset = "0x1FF7E20", VA = "0x181FF9220")]
			public ActAutoChessBondInfo()
			{
			}

			// Token: 0x0400482E RID: 18478
			[Token(Token = "0x400482E")]
			[FieldOffset(Offset = "0x10")]
			public string bondId;

			// Token: 0x0400482F RID: 18479
			[Token(Token = "0x400482F")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004830 RID: 18480
			[Token(Token = "0x4004830")]
			[FieldOffset(Offset = "0x20")]
			public string desc;

			// Token: 0x04004831 RID: 18481
			[Token(Token = "0x4004831")]
			[FieldOffset(Offset = "0x28")]
			public string iconId;

			// Token: 0x04004832 RID: 18482
			[Token(Token = "0x4004832")]
			[FieldOffset(Offset = "0x30")]
			public int activeCount;

			// Token: 0x04004833 RID: 18483
			[Token(Token = "0x4004833")]
			[FieldOffset(Offset = "0x34")]
			public ActAutoChessBondActiveConditionType activeCondition;

			// Token: 0x04004834 RID: 18484
			[Token(Token = "0x4004834")]
			[FieldOffset(Offset = "0x38")]
			public string activeConditionTemplate;

			// Token: 0x04004835 RID: 18485
			[Token(Token = "0x4004835")]
			[FieldOffset(Offset = "0x40")]
			public List<string> activeParamList;

			// Token: 0x04004836 RID: 18486
			[Token(Token = "0x4004836")]
			[FieldOffset(Offset = "0x48")]
			public string effectId;

			// Token: 0x04004837 RID: 18487
			[Token(Token = "0x4004837")]
			[FieldOffset(Offset = "0x50")]
			public ActAutoChessBondActiveType activeType;

			// Token: 0x04004838 RID: 18488
			[Token(Token = "0x4004838")]
			[FieldOffset(Offset = "0x54")]
			public int identifier;

			// Token: 0x04004839 RID: 18489
			[Token(Token = "0x4004839")]
			[FieldOffset(Offset = "0x58")]
			public int weight;

			// Token: 0x0400483A RID: 18490
			[Token(Token = "0x400483A")]
			[FieldOffset(Offset = "0x5C")]
			public bool isActiveInDeck;

			// Token: 0x0400483B RID: 18491
			[Token(Token = "0x400483B")]
			[FieldOffset(Offset = "0x60")]
			public int maxInactiveBondCount;

			// Token: 0x0400483C RID: 18492
			[Token(Token = "0x400483C")]
			[FieldOffset(Offset = "0x68")]
			public List<string> descParamBaseList;

			// Token: 0x0400483D RID: 18493
			[Token(Token = "0x400483D")]
			[FieldOffset(Offset = "0x70")]
			public List<string> descParamPerStackList;

			// Token: 0x0400483E RID: 18494
			[Token(Token = "0x400483E")]
			[FieldOffset(Offset = "0x78")]
			public bool noStack;

			// Token: 0x0400483F RID: 18495
			[Token(Token = "0x400483F")]
			[FieldOffset(Offset = "0x80")]
			public List<string> chessIdList;
		}

		// Token: 0x02000DA8 RID: 3496
		[Token(Token = "0x2000DA8")]
		public class ActAutoChessGarrisonData
		{
			// Token: 0x06006A66 RID: 27238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A66")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessGarrisonData()
			{
			}

			// Token: 0x04004840 RID: 18496
			[Token(Token = "0x4004840")]
			[FieldOffset(Offset = "0x10")]
			public string garrisonDesc;

			// Token: 0x04004841 RID: 18497
			[Token(Token = "0x4004841")]
			[FieldOffset(Offset = "0x18")]
			public string eventType;

			// Token: 0x04004842 RID: 18498
			[Token(Token = "0x4004842")]
			[FieldOffset(Offset = "0x20")]
			public string eventTypeDesc;

			// Token: 0x04004843 RID: 18499
			[Token(Token = "0x4004843")]
			[FieldOffset(Offset = "0x28")]
			public string eventTypeIcon;

			// Token: 0x04004844 RID: 18500
			[Token(Token = "0x4004844")]
			[FieldOffset(Offset = "0x30")]
			public string eventTypeSmallIcon;

			// Token: 0x04004845 RID: 18501
			[Token(Token = "0x4004845")]
			[FieldOffset(Offset = "0x38")]
			public string effectType;

			// Token: 0x04004846 RID: 18502
			[Token(Token = "0x4004846")]
			[FieldOffset(Offset = "0x40")]
			public int charLevel;

			// Token: 0x04004847 RID: 18503
			[Token(Token = "0x4004847")]
			[FieldOffset(Offset = "0x48")]
			public string battleRuneKey;

			// Token: 0x04004848 RID: 18504
			[Token(Token = "0x4004848")]
			[FieldOffset(Offset = "0x50")]
			public Blackboard blackboard;

			// Token: 0x04004849 RID: 18505
			[Token(Token = "0x4004849")]
			[FieldOffset(Offset = "0x58")]
			public string description;
		}

		// Token: 0x02000DA9 RID: 3497
		[Token(Token = "0x2000DA9")]
		public class ActAutoChessBandData
		{
			// Token: 0x06006A67 RID: 27239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A67")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessBandData()
			{
			}

			// Token: 0x0400484A RID: 18506
			[Token(Token = "0x400484A")]
			[FieldOffset(Offset = "0x10")]
			public string bandId;

			// Token: 0x0400484B RID: 18507
			[Token(Token = "0x400484B")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0400484C RID: 18508
			[Token(Token = "0x400484C")]
			[FieldOffset(Offset = "0x20")]
			public List<string> modeTypeList;

			// Token: 0x0400484D RID: 18509
			[Token(Token = "0x400484D")]
			[FieldOffset(Offset = "0x28")]
			public string bandDesc;

			// Token: 0x0400484E RID: 18510
			[Token(Token = "0x400484E")]
			[FieldOffset(Offset = "0x30")]
			public int totalHp;

			// Token: 0x0400484F RID: 18511
			[Token(Token = "0x400484F")]
			[FieldOffset(Offset = "0x38")]
			public string effectId;

			// Token: 0x04004850 RID: 18512
			[Token(Token = "0x4004850")]
			[FieldOffset(Offset = "0x40")]
			public int victorCount;

			// Token: 0x04004851 RID: 18513
			[Token(Token = "0x4004851")]
			[FieldOffset(Offset = "0x44")]
			public float bandRewardModulus;

			// Token: 0x04004852 RID: 18514
			[Token(Token = "0x4004852")]
			[FieldOffset(Offset = "0x48")]
			public long updateTime;
		}

		// Token: 0x02000DAA RID: 3498
		[Token(Token = "0x2000DAA")]
		public class ActAutoChessCharChessStatusData
		{
			// Token: 0x06006A68 RID: 27240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A68")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessCharChessStatusData()
			{
			}

			// Token: 0x04004853 RID: 18515
			[Token(Token = "0x4004853")]
			[FieldOffset(Offset = "0x10")]
			public EvolvePhase evolvePhase;

			// Token: 0x04004854 RID: 18516
			[Token(Token = "0x4004854")]
			[FieldOffset(Offset = "0x14")]
			public int charLevel;

			// Token: 0x04004855 RID: 18517
			[Token(Token = "0x4004855")]
			[FieldOffset(Offset = "0x18")]
			public int skillLevel;

			// Token: 0x04004856 RID: 18518
			[Token(Token = "0x4004856")]
			[FieldOffset(Offset = "0x1C")]
			public int favorPoint;

			// Token: 0x04004857 RID: 18519
			[Token(Token = "0x4004857")]
			[FieldOffset(Offset = "0x20")]
			public int equipLevel;
		}

		// Token: 0x02000DAB RID: 3499
		[Token(Token = "0x2000DAB")]
		public class ActAutoChessCharChessData
		{
			// Token: 0x06006A69 RID: 27241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A69")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessCharChessData()
			{
			}

			// Token: 0x04004858 RID: 18520
			[Token(Token = "0x4004858")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x04004859 RID: 18521
			[Token(Token = "0x4004859")]
			[FieldOffset(Offset = "0x18")]
			public int identifier;

			// Token: 0x0400485A RID: 18522
			[Token(Token = "0x400485A")]
			[FieldOffset(Offset = "0x1C")]
			public bool isGolden;

			// Token: 0x0400485B RID: 18523
			[Token(Token = "0x400485B")]
			[FieldOffset(Offset = "0x20")]
			public ActAutoChessData.ActAutoChessCharChessStatusData status;

			// Token: 0x0400485C RID: 18524
			[Token(Token = "0x400485C")]
			[FieldOffset(Offset = "0x28")]
			public string upgradeChessId;

			// Token: 0x0400485D RID: 18525
			[Token(Token = "0x400485D")]
			[FieldOffset(Offset = "0x30")]
			public int upgradeNum;

			// Token: 0x0400485E RID: 18526
			[Token(Token = "0x400485E")]
			[FieldOffset(Offset = "0x38")]
			public List<string> bondIds;

			// Token: 0x0400485F RID: 18527
			[Token(Token = "0x400485F")]
			[FieldOffset(Offset = "0x40")]
			public List<string> garrisonIds;
		}

		// Token: 0x02000DAC RID: 3500
		[Token(Token = "0x2000DAC")]
		public class ActAutoChessShopLevelData
		{
			// Token: 0x06006A6A RID: 27242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessShopLevelData()
			{
			}

			// Token: 0x04004860 RID: 18528
			[Token(Token = "0x4004860")]
			[FieldOffset(Offset = "0x10")]
			public int shopLevel;

			// Token: 0x04004861 RID: 18529
			[Token(Token = "0x4004861")]
			[FieldOffset(Offset = "0x14")]
			public int initialUpgradePrice;

			// Token: 0x04004862 RID: 18530
			[Token(Token = "0x4004862")]
			[FieldOffset(Offset = "0x18")]
			public int charChessCount;

			// Token: 0x04004863 RID: 18531
			[Token(Token = "0x4004863")]
			[FieldOffset(Offset = "0x1C")]
			public int itemCount;

			// Token: 0x04004864 RID: 18532
			[Token(Token = "0x4004864")]
			[FieldOffset(Offset = "0x20")]
			public string levelTagBgColor;
		}

		// Token: 0x02000DAD RID: 3501
		[Token(Token = "0x2000DAD")]
		public class ActAutoChessShopCharChessInfoData
		{
			// Token: 0x06006A6B RID: 27243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessShopCharChessInfoData()
			{
			}

			// Token: 0x04004865 RID: 18533
			[Token(Token = "0x4004865")]
			[FieldOffset(Offset = "0x10")]
			public int chessLevel;

			// Token: 0x04004866 RID: 18534
			[Token(Token = "0x4004866")]
			[FieldOffset(Offset = "0x14")]
			public bool isGolden;

			// Token: 0x04004867 RID: 18535
			[Token(Token = "0x4004867")]
			[FieldOffset(Offset = "0x18")]
			public EvolvePhase evolvePhase;

			// Token: 0x04004868 RID: 18536
			[Token(Token = "0x4004868")]
			[FieldOffset(Offset = "0x1C")]
			public int charLevel;

			// Token: 0x04004869 RID: 18537
			[Token(Token = "0x4004869")]
			[FieldOffset(Offset = "0x20")]
			public int skillLevel;

			// Token: 0x0400486A RID: 18538
			[Token(Token = "0x400486A")]
			[FieldOffset(Offset = "0x24")]
			public int favorPoint;

			// Token: 0x0400486B RID: 18539
			[Token(Token = "0x400486B")]
			[FieldOffset(Offset = "0x28")]
			public int equipLevel;

			// Token: 0x0400486C RID: 18540
			[Token(Token = "0x400486C")]
			[FieldOffset(Offset = "0x2C")]
			public int purchasePrice;

			// Token: 0x0400486D RID: 18541
			[Token(Token = "0x400486D")]
			[FieldOffset(Offset = "0x30")]
			public int chessSoldPrice;

			// Token: 0x0400486E RID: 18542
			[Token(Token = "0x400486E")]
			[FieldOffset(Offset = "0x38")]
			public string eliteIconId;
		}

		// Token: 0x02000DAE RID: 3502
		[Token(Token = "0x2000DAE")]
		public class ActAutoChessShopLevelDisplayData
		{
			// Token: 0x06006A6C RID: 27244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessShopLevelDisplayData()
			{
			}

			// Token: 0x0400486F RID: 18543
			[Token(Token = "0x400486F")]
			[FieldOffset(Offset = "0x10")]
			public int shopLevel;

			// Token: 0x04004870 RID: 18544
			[Token(Token = "0x4004870")]
			[FieldOffset(Offset = "0x18")]
			public string levelTagBgColor;

			// Token: 0x04004871 RID: 18545
			[Token(Token = "0x4004871")]
			[FieldOffset(Offset = "0x20")]
			public bool isLevelCharChessEmpty;

			// Token: 0x04004872 RID: 18546
			[Token(Token = "0x4004872")]
			[FieldOffset(Offset = "0x21")]
			public bool isLevelTrapChessEmpty;

			// Token: 0x04004873 RID: 18547
			[Token(Token = "0x4004873")]
			[FieldOffset(Offset = "0x28")]
			public List<string> charChessDiySlotIdList;
		}

		// Token: 0x02000DAF RID: 3503
		[Token(Token = "0x2000DAF")]
		public class ActAutoChessCharShopChessData
		{
			// Token: 0x06006A6D RID: 27245 RVA: 0x00030F60 File Offset: 0x0002F160
			[Token(Token = "0x6006A6D")]
			[Address(RVA = "0x1FF92C0", Offset = "0x1FF7EC0", VA = "0x181FF92C0")]
			public bool ShouldSerializeisHidden()
			{
				return default(bool);
			}

			// Token: 0x06006A6E RID: 27246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessCharShopChessData()
			{
			}

			// Token: 0x04004874 RID: 18548
			[Token(Token = "0x4004874")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x04004875 RID: 18549
			[Token(Token = "0x4004875")]
			[FieldOffset(Offset = "0x18")]
			public string goldenChessId;

			// Token: 0x04004876 RID: 18550
			[Token(Token = "0x4004876")]
			[FieldOffset(Offset = "0x20")]
			public int chessLevel;

			// Token: 0x04004877 RID: 18551
			[Token(Token = "0x4004877")]
			[FieldOffset(Offset = "0x24")]
			public int shopLevelSortId;

			// Token: 0x04004878 RID: 18552
			[Token(Token = "0x4004878")]
			[FieldOffset(Offset = "0x28")]
			public AutoChessChessType chessType;

			// Token: 0x04004879 RID: 18553
			[Token(Token = "0x4004879")]
			[FieldOffset(Offset = "0x30")]
			public string charId;

			// Token: 0x0400487A RID: 18554
			[Token(Token = "0x400487A")]
			[FieldOffset(Offset = "0x38")]
			public string tmplId;

			// Token: 0x0400487B RID: 18555
			[Token(Token = "0x400487B")]
			[FieldOffset(Offset = "0x40")]
			public int defaultSkillIndex;

			// Token: 0x0400487C RID: 18556
			[Token(Token = "0x400487C")]
			[FieldOffset(Offset = "0x48")]
			public string defaultUniEquipId;

			// Token: 0x0400487D RID: 18557
			[Token(Token = "0x400487D")]
			[FieldOffset(Offset = "0x50")]
			public string backupCharId;

			// Token: 0x0400487E RID: 18558
			[Token(Token = "0x400487E")]
			[FieldOffset(Offset = "0x58")]
			public string backupTmplId;

			// Token: 0x0400487F RID: 18559
			[Token(Token = "0x400487F")]
			[FieldOffset(Offset = "0x60")]
			public int backupCharSkillIndex;

			// Token: 0x04004880 RID: 18560
			[Token(Token = "0x4004880")]
			[FieldOffset(Offset = "0x68")]
			public string backupCharUniEquipId;

			// Token: 0x04004881 RID: 18561
			[Token(Token = "0x4004881")]
			[FieldOffset(Offset = "0x70")]
			public int backupCharPotRank;

			// Token: 0x04004882 RID: 18562
			[Token(Token = "0x4004882")]
			[FieldOffset(Offset = "0x74")]
			public bool isHidden;
		}

		// Token: 0x02000DB0 RID: 3504
		[Token(Token = "0x2000DB0")]
		public class AutoChessTrapChessStatusData
		{
			// Token: 0x06006A6F RID: 27247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A6F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessTrapChessStatusData()
			{
			}

			// Token: 0x04004883 RID: 18563
			[Token(Token = "0x4004883")]
			[FieldOffset(Offset = "0x10")]
			public EvolvePhase evolvePhase;

			// Token: 0x04004884 RID: 18564
			[Token(Token = "0x4004884")]
			[FieldOffset(Offset = "0x14")]
			public int trapLevel;

			// Token: 0x04004885 RID: 18565
			[Token(Token = "0x4004885")]
			[FieldOffset(Offset = "0x18")]
			public int skillIndex;

			// Token: 0x04004886 RID: 18566
			[Token(Token = "0x4004886")]
			[FieldOffset(Offset = "0x1C")]
			public int skillLevel;
		}

		// Token: 0x02000DB1 RID: 3505
		[Token(Token = "0x2000DB1")]
		public class ActAutoChessTrapChessData
		{
			// Token: 0x06006A70 RID: 27248 RVA: 0x00030F78 File Offset: 0x0002F178
			[Token(Token = "0x6006A70")]
			[Address(RVA = "0x1FF9C20", Offset = "0x1FF8820", VA = "0x181FF9C20")]
			public bool ShouldSerializegiveBondId()
			{
				return default(bool);
			}

			// Token: 0x06006A71 RID: 27249 RVA: 0x00030F90 File Offset: 0x0002F190
			[Token(Token = "0x6006A71")]
			[Address(RVA = "0x1FF9C40", Offset = "0x1FF8840", VA = "0x181FF9C40")]
			public bool ShouldSerializegivePowerId()
			{
				return default(bool);
			}

			// Token: 0x06006A72 RID: 27250 RVA: 0x00030FA8 File Offset: 0x0002F1A8
			[Token(Token = "0x6006A72")]
			[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
			public bool ShouldSerializecanGiveBond()
			{
				return default(bool);
			}

			// Token: 0x06006A73 RID: 27251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessTrapChessData()
			{
			}

			// Token: 0x04004887 RID: 18567
			[Token(Token = "0x4004887")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x04004888 RID: 18568
			[Token(Token = "0x4004888")]
			[FieldOffset(Offset = "0x18")]
			public int identifier;

			// Token: 0x04004889 RID: 18569
			[Token(Token = "0x4004889")]
			[FieldOffset(Offset = "0x20")]
			public string charId;

			// Token: 0x0400488A RID: 18570
			[Token(Token = "0x400488A")]
			[FieldOffset(Offset = "0x28")]
			public bool isGolden;

			// Token: 0x0400488B RID: 18571
			[Token(Token = "0x400488B")]
			[FieldOffset(Offset = "0x2C")]
			public int purchasePrice;

			// Token: 0x0400488C RID: 18572
			[Token(Token = "0x400488C")]
			[FieldOffset(Offset = "0x30")]
			public ActAutoChessData.AutoChessTrapChessStatusData status;

			// Token: 0x0400488D RID: 18573
			[Token(Token = "0x400488D")]
			[FieldOffset(Offset = "0x38")]
			public string upgradeChessId;

			// Token: 0x0400488E RID: 18574
			[Token(Token = "0x400488E")]
			[FieldOffset(Offset = "0x40")]
			public int upgradeNum;

			// Token: 0x0400488F RID: 18575
			[Token(Token = "0x400488F")]
			[FieldOffset(Offset = "0x44")]
			public int trapDuration;

			// Token: 0x04004890 RID: 18576
			[Token(Token = "0x4004890")]
			[FieldOffset(Offset = "0x48")]
			public string effectId;

			// Token: 0x04004891 RID: 18577
			[Token(Token = "0x4004891")]
			[FieldOffset(Offset = "0x50")]
			public string giveBondId;

			// Token: 0x04004892 RID: 18578
			[Token(Token = "0x4004892")]
			[FieldOffset(Offset = "0x58")]
			public string givePowerId;

			// Token: 0x04004893 RID: 18579
			[Token(Token = "0x4004893")]
			[FieldOffset(Offset = "0x60")]
			public bool canGiveBond;

			// Token: 0x04004894 RID: 18580
			[Token(Token = "0x4004894")]
			[FieldOffset(Offset = "0x64")]
			public AutoChessItemType itemType;
		}

		// Token: 0x02000DB2 RID: 3506
		[Token(Token = "0x2000DB2")]
		public class ActAutoChessTrapShopChessData
		{
			// Token: 0x06006A74 RID: 27252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A74")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessTrapShopChessData()
			{
			}

			// Token: 0x04004895 RID: 18581
			[Token(Token = "0x4004895")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04004896 RID: 18582
			[Token(Token = "0x4004896")]
			[FieldOffset(Offset = "0x18")]
			public string goldenItemId;

			// Token: 0x04004897 RID: 18583
			[Token(Token = "0x4004897")]
			[FieldOffset(Offset = "0x20")]
			public bool hideInShop;

			// Token: 0x04004898 RID: 18584
			[Token(Token = "0x4004898")]
			[FieldOffset(Offset = "0x24")]
			public int itemLevel;

			// Token: 0x04004899 RID: 18585
			[Token(Token = "0x4004899")]
			[FieldOffset(Offset = "0x28")]
			public int iconLevel;

			// Token: 0x0400489A RID: 18586
			[Token(Token = "0x400489A")]
			[FieldOffset(Offset = "0x2C")]
			public int shopLevelSortId;

			// Token: 0x0400489B RID: 18587
			[Token(Token = "0x400489B")]
			[FieldOffset(Offset = "0x30")]
			public AutoChessItemType itemType;

			// Token: 0x0400489C RID: 18588
			[Token(Token = "0x400489C")]
			[FieldOffset(Offset = "0x38")]
			public string trapId;
		}

		// Token: 0x02000DB3 RID: 3507
		[Token(Token = "0x2000DB3")]
		public class ActAutoChessStageData
		{
			// Token: 0x06006A75 RID: 27253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A75")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessStageData()
			{
			}

			// Token: 0x0400489D RID: 18589
			[Token(Token = "0x400489D")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x0400489E RID: 18590
			[Token(Token = "0x400489E")]
			[FieldOffset(Offset = "0x18")]
			public string[] mode;

			// Token: 0x0400489F RID: 18591
			[Token(Token = "0x400489F")]
			[FieldOffset(Offset = "0x20")]
			public int weight;
		}

		// Token: 0x02000DB4 RID: 3508
		[Token(Token = "0x2000DB4")]
		public class ActAutoChessBattleData
		{
			// Token: 0x06006A76 RID: 27254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A76")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessBattleData()
			{
			}

			// Token: 0x040048A0 RID: 18592
			[Token(Token = "0x40048A0")]
			[FieldOffset(Offset = "0x10")]
			public string bossId;

			// Token: 0x040048A1 RID: 18593
			[Token(Token = "0x40048A1")]
			[FieldOffset(Offset = "0x18")]
			public string levelId;

			// Token: 0x040048A2 RID: 18594
			[Token(Token = "0x40048A2")]
			[FieldOffset(Offset = "0x20")]
			public bool isSpPrepare;
		}

		// Token: 0x02000DB5 RID: 3509
		[Token(Token = "0x2000DB5")]
		public class ActAutoChessEffectInfoData
		{
			// Token: 0x06006A77 RID: 27255 RVA: 0x00030FC0 File Offset: 0x0002F1C0
			[Token(Token = "0x6006A77")]
			[Address(RVA = "0x1FF9BE0", Offset = "0x1FF87E0", VA = "0x181FF9BE0")]
			public bool ShouldSerializeeffectCounterType()
			{
				return default(bool);
			}

			// Token: 0x06006A78 RID: 27256 RVA: 0x00030FD8 File Offset: 0x0002F1D8
			[Token(Token = "0x6006A78")]
			[Address(RVA = "0x1FF9BF0", Offset = "0x1FF87F0", VA = "0x181FF9BF0")]
			public bool ShouldSerializeeffectDecoIconId()
			{
				return default(bool);
			}

			// Token: 0x06006A79 RID: 27257 RVA: 0x00030FF0 File Offset: 0x0002F1F0
			[Token(Token = "0x6006A79")]
			[Address(RVA = "0x1FF9C10", Offset = "0x1FF8810", VA = "0x181FF9C10")]
			public bool ShouldSerializeenemyPrice()
			{
				return default(bool);
			}

			// Token: 0x06006A7A RID: 27258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A7A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessEffectInfoData()
			{
			}

			// Token: 0x040048A3 RID: 18595
			[Token(Token = "0x40048A3")]
			[FieldOffset(Offset = "0x10")]
			public string effectId;

			// Token: 0x040048A4 RID: 18596
			[Token(Token = "0x40048A4")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessEffectType effectType;

			// Token: 0x040048A5 RID: 18597
			[Token(Token = "0x40048A5")]
			[FieldOffset(Offset = "0x1C")]
			public AutoChessEffectCounterType effectCounterType;

			// Token: 0x040048A6 RID: 18598
			[Token(Token = "0x40048A6")]
			[FieldOffset(Offset = "0x20")]
			public int continuedRound;

			// Token: 0x040048A7 RID: 18599
			[Token(Token = "0x40048A7")]
			[FieldOffset(Offset = "0x28")]
			public string effectName;

			// Token: 0x040048A8 RID: 18600
			[Token(Token = "0x40048A8")]
			[FieldOffset(Offset = "0x30")]
			public string effectDesc;

			// Token: 0x040048A9 RID: 18601
			[Token(Token = "0x40048A9")]
			[FieldOffset(Offset = "0x38")]
			public string effectDecoIconId;

			// Token: 0x040048AA RID: 18602
			[Token(Token = "0x40048AA")]
			[FieldOffset(Offset = "0x40")]
			public int enemyPrice;
		}

		// Token: 0x02000DB6 RID: 3510
		[Token(Token = "0x2000DB6")]
		public class ActAutoChessBuffInfoData
		{
			// Token: 0x06006A7B RID: 27259 RVA: 0x00031008 File Offset: 0x0002F208
			[Token(Token = "0x6006A7B")]
			[Address(RVA = "0x1FF92B0", Offset = "0x1FF7EB0", VA = "0x181FF92B0")]
			public bool ShouldSerializecountType()
			{
				return default(bool);
			}

			// Token: 0x06006A7C RID: 27260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A7C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessBuffInfoData()
			{
			}

			// Token: 0x040048AB RID: 18603
			[Token(Token = "0x40048AB")]
			[FieldOffset(Offset = "0x10")]
			public string key;

			// Token: 0x040048AC RID: 18604
			[Token(Token = "0x40048AC")]
			[FieldOffset(Offset = "0x18")]
			public Blackboard blackboard;

			// Token: 0x040048AD RID: 18605
			[Token(Token = "0x40048AD")]
			[FieldOffset(Offset = "0x20")]
			public AutoChessCountType countType;
		}

		// Token: 0x02000DB7 RID: 3511
		[Token(Token = "0x2000DB7")]
		public class ActAutoChessEffectChoiceInfoData
		{
			// Token: 0x06006A7D RID: 27261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A7D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessEffectChoiceInfoData()
			{
			}

			// Token: 0x040048AE RID: 18606
			[Token(Token = "0x40048AE")]
			[FieldOffset(Offset = "0x10")]
			public string choiceEventId;

			// Token: 0x040048AF RID: 18607
			[Token(Token = "0x40048AF")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessEffectChoiceType choiceType;

			// Token: 0x040048B0 RID: 18608
			[Token(Token = "0x40048B0")]
			[FieldOffset(Offset = "0x1C")]
			public AutoChessEffectType effectType;

			// Token: 0x040048B1 RID: 18609
			[Token(Token = "0x40048B1")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x040048B2 RID: 18610
			[Token(Token = "0x40048B2")]
			[FieldOffset(Offset = "0x28")]
			public string desc;

			// Token: 0x040048B3 RID: 18611
			[Token(Token = "0x40048B3")]
			[FieldOffset(Offset = "0x30")]
			public string typeTxtColor;
		}

		// Token: 0x02000DB8 RID: 3512
		[Token(Token = "0x2000DB8")]
		public class ActAutoChessPlayerTitleData
		{
			// Token: 0x06006A7E RID: 27262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A7E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessPlayerTitleData()
			{
			}

			// Token: 0x040048B4 RID: 18612
			[Token(Token = "0x40048B4")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040048B5 RID: 18613
			[Token(Token = "0x40048B5")]
			[FieldOffset(Offset = "0x18")]
			public string picId;

			// Token: 0x040048B6 RID: 18614
			[Token(Token = "0x40048B6")]
			[FieldOffset(Offset = "0x20")]
			public string txt;
		}

		// Token: 0x02000DB9 RID: 3513
		[Token(Token = "0x2000DB9")]
		public class ActAutochessBossEntry : IItemWithWeight
		{
			// Token: 0x17000CFE RID: 3326
			// (get) Token: 0x06006A7F RID: 27263 RVA: 0x00031020 File Offset: 0x0002F220
			[Token(Token = "0x17000CFE")]
			public float weightValue
			{
				[Token(Token = "0x6006A7F")]
				[Address(RVA = "0x7C6170", Offset = "0x7C4D70", VA = "0x1807C6170", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06006A80 RID: 27264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A80")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutochessBossEntry()
			{
			}

			// Token: 0x040048B7 RID: 18615
			[Token(Token = "0x40048B7")]
			[FieldOffset(Offset = "0x10")]
			public string bossId;

			// Token: 0x040048B8 RID: 18616
			[Token(Token = "0x40048B8")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040048B9 RID: 18617
			[Token(Token = "0x40048B9")]
			[FieldOffset(Offset = "0x1C")]
			public int weight;

			// Token: 0x040048BA RID: 18618
			[Token(Token = "0x40048BA")]
			[FieldOffset(Offset = "0x20")]
			public int bloodPoint;

			// Token: 0x040048BB RID: 18619
			[Token(Token = "0x40048BB")]
			[FieldOffset(Offset = "0x24")]
			public int bloodPointNormal;

			// Token: 0x040048BC RID: 18620
			[Token(Token = "0x40048BC")]
			[FieldOffset(Offset = "0x28")]
			public int bloodPointHard;

			// Token: 0x040048BD RID: 18621
			[Token(Token = "0x40048BD")]
			[FieldOffset(Offset = "0x2C")]
			public int bloodPointAbyss;

			// Token: 0x040048BE RID: 18622
			[Token(Token = "0x40048BE")]
			[FieldOffset(Offset = "0x30")]
			public bool isHidingBoss;
		}

		// Token: 0x02000DBA RID: 3514
		[Token(Token = "0x2000DBA")]
		public class ActAutochessSpecialEnemyEntry : IItemWithWeight
		{
			// Token: 0x17000CFF RID: 3327
			// (get) Token: 0x06006A81 RID: 27265 RVA: 0x00031038 File Offset: 0x0002F238
			[Token(Token = "0x17000CFF")]
			public float weightValue
			{
				[Token(Token = "0x6006A81")]
				[Address(RVA = "0x1FF9D20", Offset = "0x1FF8920", VA = "0x181FF9D20", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06006A82 RID: 27266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A82")]
			[Address(RVA = "0x1FF9C60", Offset = "0x1FF8860", VA = "0x181FF9C60")]
			public ActAutochessSpecialEnemyEntry()
			{
			}

			// Token: 0x040048BF RID: 18623
			[Token(Token = "0x40048BF")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x040048C0 RID: 18624
			[Token(Token = "0x40048C0")]
			[FieldOffset(Offset = "0x18")]
			public string specialEnemyKey;

			// Token: 0x040048C1 RID: 18625
			[Token(Token = "0x40048C1")]
			[FieldOffset(Offset = "0x20")]
			public int randomWeight;

			// Token: 0x040048C2 RID: 18626
			[Token(Token = "0x40048C2")]
			[FieldOffset(Offset = "0x24")]
			public bool isInFirstHalf;

			// Token: 0x040048C3 RID: 18627
			[Token(Token = "0x40048C3")]
			[FieldOffset(Offset = "0x28")]
			public List<string> attachedNormalEnemyKeys;

			// Token: 0x040048C4 RID: 18628
			[Token(Token = "0x40048C4")]
			[FieldOffset(Offset = "0x30")]
			public List<string> attachedEliteEnemyKeys;
		}

		// Token: 0x02000DBB RID: 3515
		[Token(Token = "0x2000DBB")]
		public class ActAutochessSpecialEnemyTypeEntry : IItemWithWeight
		{
			// Token: 0x17000D00 RID: 3328
			// (get) Token: 0x06006A83 RID: 27267 RVA: 0x00031050 File Offset: 0x0002F250
			[Token(Token = "0x17000D00")]
			public float weightValue
			{
				[Token(Token = "0x6006A83")]
				[Address(RVA = "0x1FF9D30", Offset = "0x1FF8930", VA = "0x181FF9D30", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06006A84 RID: 27268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A84")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutochessSpecialEnemyTypeEntry()
			{
			}

			// Token: 0x040048C5 RID: 18629
			[Token(Token = "0x40048C5")]
			[FieldOffset(Offset = "0x10")]
			public int count;

			// Token: 0x040048C6 RID: 18630
			[Token(Token = "0x40048C6")]
			[FieldOffset(Offset = "0x14")]
			public int weight;
		}

		// Token: 0x02000DBC RID: 3516
		[Token(Token = "0x2000DBC")]
		public class ActAutoChessBaseRewardData
		{
			// Token: 0x06006A85 RID: 27269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A85")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessBaseRewardData()
			{
			}

			// Token: 0x040048C7 RID: 18631
			[Token(Token = "0x40048C7")]
			[FieldOffset(Offset = "0x10")]
			public int round;

			// Token: 0x040048C8 RID: 18632
			[Token(Token = "0x40048C8")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle item;

			// Token: 0x040048C9 RID: 18633
			[Token(Token = "0x40048C9")]
			[FieldOffset(Offset = "0x20")]
			public int dailyMissionPoint;
		}

		// Token: 0x02000DBD RID: 3517
		[Token(Token = "0x2000DBD")]
		public class ActAutoChessTrainingNpcData
		{
			// Token: 0x06006A86 RID: 27270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A86")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessTrainingNpcData()
			{
			}

			// Token: 0x040048CA RID: 18634
			[Token(Token = "0x40048CA")]
			[FieldOffset(Offset = "0x10")]
			public string npcId;

			// Token: 0x040048CB RID: 18635
			[Token(Token = "0x40048CB")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x040048CC RID: 18636
			[Token(Token = "0x40048CC")]
			[FieldOffset(Offset = "0x20")]
			public string nameCardSkinId;

			// Token: 0x040048CD RID: 18637
			[Token(Token = "0x40048CD")]
			[FieldOffset(Offset = "0x28")]
			public int medalCount;

			// Token: 0x040048CE RID: 18638
			[Token(Token = "0x40048CE")]
			[FieldOffset(Offset = "0x30")]
			public string bandId;
		}

		// Token: 0x02000DBE RID: 3518
		[Token(Token = "0x2000DBE")]
		public class ActAutoChessConstData
		{
			// Token: 0x06006A87 RID: 27271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A87")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActAutoChessConstData()
			{
			}

			// Token: 0x040048CF RID: 18639
			[Token(Token = "0x40048CF")]
			[FieldOffset(Offset = "0x10")]
			public int shopRefreshPrice;

			// Token: 0x040048D0 RID: 18640
			[Token(Token = "0x40048D0")]
			[FieldOffset(Offset = "0x14")]
			public int maxDeckChessCnt;

			// Token: 0x040048D1 RID: 18641
			[Token(Token = "0x40048D1")]
			[FieldOffset(Offset = "0x18")]
			public int maxBattleChessCnt;

			// Token: 0x040048D2 RID: 18642
			[Token(Token = "0x40048D2")]
			[FieldOffset(Offset = "0x20")]
			public string fallbackBondId;

			// Token: 0x040048D3 RID: 18643
			[Token(Token = "0x40048D3")]
			[FieldOffset(Offset = "0x28")]
			public int storeCntMax;

			// Token: 0x040048D4 RID: 18644
			[Token(Token = "0x40048D4")]
			[FieldOffset(Offset = "0x2C")]
			public int costPlayerHpLimit;

			// Token: 0x040048D5 RID: 18645
			[Token(Token = "0x40048D5")]
			[FieldOffset(Offset = "0x30")]
			public string milestoneId;

			// Token: 0x040048D6 RID: 18646
			[Token(Token = "0x40048D6")]
			[FieldOffset(Offset = "0x38")]
			public int borrowCount;

			// Token: 0x040048D7 RID: 18647
			[Token(Token = "0x40048D7")]
			[FieldOffset(Offset = "0x3C")]
			public int dailyMissionParam;

			// Token: 0x040048D8 RID: 18648
			[Token(Token = "0x40048D8")]
			[FieldOffset(Offset = "0x40")]
			public string dailyMissionName;

			// Token: 0x040048D9 RID: 18649
			[Token(Token = "0x40048D9")]
			[FieldOffset(Offset = "0x48")]
			public string dailyMissionRule;

			// Token: 0x040048DA RID: 18650
			[Token(Token = "0x40048DA")]
			[FieldOffset(Offset = "0x50")]
			public string trstageBandId;

			// Token: 0x040048DB RID: 18651
			[Token(Token = "0x40048DB")]
			[FieldOffset(Offset = "0x58")]
			public string trstageBossId;

			// Token: 0x040048DC RID: 18652
			[Token(Token = "0x40048DC")]
			[FieldOffset(Offset = "0x60")]
			public string trStageId;

			// Token: 0x040048DD RID: 18653
			[Token(Token = "0x40048DD")]
			[FieldOffset(Offset = "0x68")]
			public string trainingModeId;

			// Token: 0x040048DE RID: 18654
			[Token(Token = "0x40048DE")]
			[FieldOffset(Offset = "0x70")]
			public List<string> trSpecialEnemyTypes;

			// Token: 0x040048DF RID: 18655
			[Token(Token = "0x40048DF")]
			[FieldOffset(Offset = "0x78")]
			public List<string> trBondIds;

			// Token: 0x040048E0 RID: 18656
			[Token(Token = "0x40048E0")]
			[FieldOffset(Offset = "0x80")]
			public List<string> trBannedBondIds;

			// Token: 0x040048E1 RID: 18657
			[Token(Token = "0x40048E1")]
			[FieldOffset(Offset = "0x88")]
			public string milestoneTrackId;

			// Token: 0x040048E2 RID: 18658
			[Token(Token = "0x40048E2")]
			[FieldOffset(Offset = "0x90")]
			public string escapedBattleTemplateMapSinglePlayer;

			// Token: 0x040048E3 RID: 18659
			[Token(Token = "0x40048E3")]
			[FieldOffset(Offset = "0x98")]
			public string escapedBattleTemplateMapMultiPlayer;

			// Token: 0x040048E4 RID: 18660
			[Token(Token = "0x40048E4")]
			[FieldOffset(Offset = "0xA0")]
			public string webBusType;
		}
	}
}
