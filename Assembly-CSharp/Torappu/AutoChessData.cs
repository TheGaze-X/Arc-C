using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000DBF RID: 3519
	[Token(Token = "0x2000DBF")]
	public class AutoChessData
	{
		// Token: 0x06006A88 RID: 27272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A88")]
		[Address(RVA = "0x2001180", Offset = "0x1FFFD80", VA = "0x182001180")]
		public AutoChessData()
		{
		}

		// Token: 0x040048E5 RID: 18661
		[Token(Token = "0x40048E5")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, AutoChessData.AutoChessVersionInfoData> versionInfoDict;

		// Token: 0x040048E6 RID: 18662
		[Token(Token = "0x40048E6")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, AutoChessData.AutoChessBandData> bandDataDict;

		// Token: 0x040048E7 RID: 18663
		[Token(Token = "0x40048E7")]
		[FieldOffset(Offset = "0x20")]
		public List<AutoChessData.AutoChessCultivateRelationData> cultivateEffectList;

		// Token: 0x040048E8 RID: 18664
		[Token(Token = "0x40048E8")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, AutoChessData.AutoChessEffectTypeData> effectTypeDataDict;

		// Token: 0x040048E9 RID: 18665
		[Token(Token = "0x40048E9")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, AutoChessData.AutoChessBondInfoData> bondInfoDict;

		// Token: 0x040048EA RID: 18666
		[Token(Token = "0x40048EA")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, AutoChessData.AutoChessBossInfoData> bossInfoDict;

		// Token: 0x040048EB RID: 18667
		[Token(Token = "0x40048EB")]
		[FieldOffset(Offset = "0x40")]
		public ListDict<string, AutoChessData.AutoChessEnemyTypeData> enemyTypeDatas;

		// Token: 0x040048EC RID: 18668
		[Token(Token = "0x40048EC")]
		[FieldOffset(Offset = "0x48")]
		public List<AutoChessData.AutoChessEnterStepData> enterStepList;

		// Token: 0x040048ED RID: 18669
		[Token(Token = "0x40048ED")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, AutoChessData.AutoChessShopStateTokenData> shopStateTokenDict;

		// Token: 0x040048EE RID: 18670
		[Token(Token = "0x40048EE")]
		[FieldOffset(Offset = "0x58")]
		public List<AutoChessData.AutoChessSkillTriggerData> skillTriggerDataList;

		// Token: 0x040048EF RID: 18671
		[Token(Token = "0x40048EF")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, string> skillRangeDict;

		// Token: 0x040048F0 RID: 18672
		[Token(Token = "0x40048F0")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, AutoChessData.AutoChessPrepareStateData> prepareStateDict;

		// Token: 0x040048F1 RID: 18673
		[Token(Token = "0x40048F1")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, AutoChessData.AutoChessRandomEnemyAttributeData> randomEnemyAttributeDict;

		// Token: 0x040048F2 RID: 18674
		[Token(Token = "0x40048F2")]
		[FieldOffset(Offset = "0x78")]
		public List<string> enabledEmoticonThemeIdList;

		// Token: 0x040048F3 RID: 18675
		[Token(Token = "0x40048F3")]
		[FieldOffset(Offset = "0x80")]
		public List<AutoChessData.AutoChessGameTipData> gameTipsList;

		// Token: 0x040048F4 RID: 18676
		[Token(Token = "0x40048F4")]
		[FieldOffset(Offset = "0x88")]
		public List<AutoChessData.AutoChessMedalData> medalDataList;

		// Token: 0x040048F5 RID: 18677
		[Token(Token = "0x40048F5")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<string, Dictionary<int, AutoChessData.AutoChessTurnInfoData>> turnInfoDataDict;

		// Token: 0x040048F6 RID: 18678
		[Token(Token = "0x40048F6")]
		[FieldOffset(Offset = "0x98")]
		public List<AutoChessData.AutoChessRoundScoreData> roundScoreDataList;

		// Token: 0x040048F7 RID: 18679
		[Token(Token = "0x40048F7")]
		[FieldOffset(Offset = "0xA0")]
		public List<CommonReportPlayerData> reportPlayerDataList;

		// Token: 0x040048F8 RID: 18680
		[Token(Token = "0x40048F8")]
		[FieldOffset(Offset = "0xA8")]
		public List<AutoChessData.AutoChessBroadcastData> broadcastList;

		// Token: 0x040048F9 RID: 18681
		[Token(Token = "0x40048F9")]
		[FieldOffset(Offset = "0xB0")]
		public AutoChessData.AutoChessConstData constData;

		// Token: 0x02000DC0 RID: 3520
		[Token(Token = "0x2000DC0")]
		public class AutoChessVersionInfoData
		{
			// Token: 0x06006A89 RID: 27273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A89")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessVersionInfoData()
			{
			}

			// Token: 0x040048FA RID: 18682
			[Token(Token = "0x40048FA")]
			[FieldOffset(Offset = "0x10")]
			public string versionId;

			// Token: 0x040048FB RID: 18683
			[Token(Token = "0x40048FB")]
			[FieldOffset(Offset = "0x18")]
			public string activityId;

			// Token: 0x040048FC RID: 18684
			[Token(Token = "0x40048FC")]
			[FieldOffset(Offset = "0x20")]
			public string seasonName;

			// Token: 0x040048FD RID: 18685
			[Token(Token = "0x40048FD")]
			[FieldOffset(Offset = "0x28")]
			public long startTime;
		}

		// Token: 0x02000DC1 RID: 3521
		[Token(Token = "0x2000DC1")]
		public class AutoChessBandData
		{
			// Token: 0x06006A8A RID: 27274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessBandData()
			{
			}

			// Token: 0x040048FE RID: 18686
			[Token(Token = "0x40048FE")]
			[FieldOffset(Offset = "0x10")]
			public string bandId;

			// Token: 0x040048FF RID: 18687
			[Token(Token = "0x40048FF")]
			[FieldOffset(Offset = "0x18")]
			public string bandName;

			// Token: 0x04004900 RID: 18688
			[Token(Token = "0x4004900")]
			[FieldOffset(Offset = "0x20")]
			public string bandIconId;

			// Token: 0x04004901 RID: 18689
			[Token(Token = "0x4004901")]
			[FieldOffset(Offset = "0x28")]
			public string unlockDesc;
		}

		// Token: 0x02000DC2 RID: 3522
		[Token(Token = "0x2000DC2")]
		public class AutoChessBroadcastData
		{
			// Token: 0x06006A8B RID: 27275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessBroadcastData()
			{
			}

			// Token: 0x04004902 RID: 18690
			[Token(Token = "0x4004902")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004903 RID: 18691
			[Token(Token = "0x4004903")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04004904 RID: 18692
			[Token(Token = "0x4004904")]
			[FieldOffset(Offset = "0x20")]
			public int priority;

			// Token: 0x04004905 RID: 18693
			[Token(Token = "0x4004905")]
			[FieldOffset(Offset = "0x24")]
			public AutoChessBroadcastType type;

			// Token: 0x04004906 RID: 18694
			[Token(Token = "0x4004906")]
			[FieldOffset(Offset = "0x28")]
			public List<string> paramList;
		}

		// Token: 0x02000DC3 RID: 3523
		[Token(Token = "0x2000DC3")]
		public class AutoChessCultivateRelationData
		{
			// Token: 0x06006A8C RID: 27276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessCultivateRelationData()
			{
			}

			// Token: 0x04004907 RID: 18695
			[Token(Token = "0x4004907")]
			public const int TRANS_NUM = 1000;

			// Token: 0x04004908 RID: 18696
			[Token(Token = "0x4004908")]
			[FieldOffset(Offset = "0x10")]
			public int cultivateNum;

			// Token: 0x04004909 RID: 18697
			[Token(Token = "0x4004909")]
			[FieldOffset(Offset = "0x18")]
			public string effectId;

			// Token: 0x0400490A RID: 18698
			[Token(Token = "0x400490A")]
			[FieldOffset(Offset = "0x20")]
			public EvolvePhase evolvePhase;

			// Token: 0x0400490B RID: 18699
			[Token(Token = "0x400490B")]
			[FieldOffset(Offset = "0x24")]
			public int charLevel;

			// Token: 0x0400490C RID: 18700
			[Token(Token = "0x400490C")]
			[FieldOffset(Offset = "0x28")]
			public int atkPer;

			// Token: 0x0400490D RID: 18701
			[Token(Token = "0x400490D")]
			[FieldOffset(Offset = "0x2C")]
			public int defPer;

			// Token: 0x0400490E RID: 18702
			[Token(Token = "0x400490E")]
			[FieldOffset(Offset = "0x30")]
			public int hpPer;
		}

		// Token: 0x02000DC4 RID: 3524
		[Token(Token = "0x2000DC4")]
		public class AutoChessEffectTypeData
		{
			// Token: 0x06006A8D RID: 27277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessEffectTypeData()
			{
			}

			// Token: 0x0400490F RID: 18703
			[Token(Token = "0x400490F")]
			[FieldOffset(Offset = "0x10")]
			public string description;
		}

		// Token: 0x02000DC5 RID: 3525
		[Token(Token = "0x2000DC5")]
		public class AutoChessBondInfoData
		{
			// Token: 0x06006A8E RID: 27278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessBondInfoData()
			{
			}

			// Token: 0x04004910 RID: 18704
			[Token(Token = "0x4004910")]
			[FieldOffset(Offset = "0x10")]
			public string bondId;

			// Token: 0x04004911 RID: 18705
			[Token(Token = "0x4004911")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessBondType bondType;

			// Token: 0x04004912 RID: 18706
			[Token(Token = "0x4004912")]
			[FieldOffset(Offset = "0x20")]
			public List<string> powerIdList;

			// Token: 0x04004913 RID: 18707
			[Token(Token = "0x4004913")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04004914 RID: 18708
			[Token(Token = "0x4004914")]
			[FieldOffset(Offset = "0x30")]
			public string icon;

			// Token: 0x04004915 RID: 18709
			[Token(Token = "0x4004915")]
			[FieldOffset(Offset = "0x38")]
			public bool isPower;

			// Token: 0x04004916 RID: 18710
			[Token(Token = "0x4004916")]
			[FieldOffset(Offset = "0x3C")]
			public int bondOrder;

			// Token: 0x04004917 RID: 18711
			[Token(Token = "0x4004917")]
			[FieldOffset(Offset = "0x40")]
			public bool isHiddenCharList;
		}

		// Token: 0x02000DC6 RID: 3526
		[Token(Token = "0x2000DC6")]
		public class AutoChessBossInfoData
		{
			// Token: 0x06006A8F RID: 27279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A8F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessBossInfoData()
			{
			}

			// Token: 0x04004918 RID: 18712
			[Token(Token = "0x4004918")]
			[FieldOffset(Offset = "0x10")]
			public string bossId;

			// Token: 0x04004919 RID: 18713
			[Token(Token = "0x4004919")]
			[FieldOffset(Offset = "0x18")]
			public string enemyId;

			// Token: 0x0400491A RID: 18714
			[Token(Token = "0x400491A")]
			[FieldOffset(Offset = "0x20")]
			public string handbookEnemyId;
		}

		// Token: 0x02000DC7 RID: 3527
		[Token(Token = "0x2000DC7")]
		public class AutoChessEnemyTypeData
		{
			// Token: 0x06006A90 RID: 27280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A90")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessEnemyTypeData()
			{
			}

			// Token: 0x0400491B RID: 18715
			[Token(Token = "0x400491B")]
			[FieldOffset(Offset = "0x10")]
			public string type;

			// Token: 0x0400491C RID: 18716
			[Token(Token = "0x400491C")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0400491D RID: 18717
			[Token(Token = "0x400491D")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x0400491E RID: 18718
			[Token(Token = "0x400491E")]
			[FieldOffset(Offset = "0x28")]
			public string description;

			// Token: 0x0400491F RID: 18719
			[Token(Token = "0x400491F")]
			[FieldOffset(Offset = "0x30")]
			public string icon;

			// Token: 0x04004920 RID: 18720
			[Token(Token = "0x4004920")]
			[FieldOffset(Offset = "0x38")]
			public int typeIdentifier;

			// Token: 0x04004921 RID: 18721
			[Token(Token = "0x4004921")]
			[FieldOffset(Offset = "0x3C")]
			public bool involveRandom;
		}

		// Token: 0x02000DC8 RID: 3528
		[Token(Token = "0x2000DC8")]
		public class AutoChessEnterStepData
		{
			// Token: 0x06006A91 RID: 27281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A91")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessEnterStepData()
			{
			}

			// Token: 0x04004922 RID: 18722
			[Token(Token = "0x4004922")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessPrepareStepType stepType;

			// Token: 0x04004923 RID: 18723
			[Token(Token = "0x4004923")]
			[FieldOffset(Offset = "0x14")]
			public int sortId;

			// Token: 0x04004924 RID: 18724
			[Token(Token = "0x4004924")]
			[FieldOffset(Offset = "0x18")]
			public int time;

			// Token: 0x04004925 RID: 18725
			[Token(Token = "0x4004925")]
			[FieldOffset(Offset = "0x1C")]
			public int hintTime;

			// Token: 0x04004926 RID: 18726
			[Token(Token = "0x4004926")]
			[FieldOffset(Offset = "0x20")]
			public string title;

			// Token: 0x04004927 RID: 18727
			[Token(Token = "0x4004927")]
			[FieldOffset(Offset = "0x28")]
			public string desc;
		}

		// Token: 0x02000DC9 RID: 3529
		[Token(Token = "0x2000DC9")]
		public class AutoChessShopStateTokenData
		{
			// Token: 0x06006A92 RID: 27282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A92")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessShopStateTokenData()
			{
			}

			// Token: 0x04004928 RID: 18728
			[Token(Token = "0x4004928")]
			[FieldOffset(Offset = "0x10")]
			public string tokenId;

			// Token: 0x04004929 RID: 18729
			[Token(Token = "0x4004929")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessShopTokenDisplayType tokenDisplayType;
		}

		// Token: 0x02000DCA RID: 3530
		[Token(Token = "0x2000DCA")]
		public class AutoChessSkillTriggerData
		{
			// Token: 0x06006A93 RID: 27283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A93")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessSkillTriggerData()
			{
			}

			// Token: 0x0400492A RID: 18730
			[Token(Token = "0x400492A")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory profession;

			// Token: 0x0400492B RID: 18731
			[Token(Token = "0x400492B")]
			[FieldOffset(Offset = "0x18")]
			public string subProfessionId;

			// Token: 0x0400492C RID: 18732
			[Token(Token = "0x400492C")]
			[FieldOffset(Offset = "0x20")]
			public string charId;

			// Token: 0x0400492D RID: 18733
			[Token(Token = "0x400492D")]
			[FieldOffset(Offset = "0x28")]
			public int skillIndex;

			// Token: 0x0400492E RID: 18734
			[Token(Token = "0x400492E")]
			[FieldOffset(Offset = "0x2C")]
			public AutoChessSkillTriggerType skillTriggerType;
		}

		// Token: 0x02000DCB RID: 3531
		[Token(Token = "0x2000DCB")]
		public class AutoChessPrepareStateData
		{
			// Token: 0x06006A94 RID: 27284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A94")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessPrepareStateData()
			{
			}

			// Token: 0x0400492F RID: 18735
			[Token(Token = "0x400492F")]
			[FieldOffset(Offset = "0x10")]
			public string effectId;

			// Token: 0x04004930 RID: 18736
			[Token(Token = "0x4004930")]
			[FieldOffset(Offset = "0x18")]
			public string buff;

			// Token: 0x04004931 RID: 18737
			[Token(Token = "0x4004931")]
			[FieldOffset(Offset = "0x20")]
			public Blackboard blackBoard;
		}

		// Token: 0x02000DCC RID: 3532
		[Token(Token = "0x2000DCC")]
		public class AutoChessRandomEnemyAttributeData
		{
			// Token: 0x06006A95 RID: 27285 RVA: 0x00031068 File Offset: 0x0002F268
			[Token(Token = "0x6006A95")]
			[Address(RVA = "0x20018F0", Offset = "0x20004F0", VA = "0x1820018F0")]
			public bool ShouldSerializeextraEnemyKeyList()
			{
				return default(bool);
			}

			// Token: 0x06006A96 RID: 27286 RVA: 0x00031080 File Offset: 0x0002F280
			[Token(Token = "0x6006A96")]
			[Address(RVA = "0x20018E0", Offset = "0x20004E0", VA = "0x1820018E0")]
			public bool ShouldSerializeextraEnemyIdentifier()
			{
				return default(bool);
			}

			// Token: 0x06006A97 RID: 27287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A97")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessRandomEnemyAttributeData()
			{
			}

			// Token: 0x04004932 RID: 18738
			[Token(Token = "0x4004932")]
			[FieldOffset(Offset = "0x10")]
			public string enemyKey;

			// Token: 0x04004933 RID: 18739
			[Token(Token = "0x4004933")]
			[FieldOffset(Offset = "0x18")]
			public int level;

			// Token: 0x04004934 RID: 18740
			[Token(Token = "0x4004934")]
			[FieldOffset(Offset = "0x1C")]
			public int extraEnemyIdentifier;

			// Token: 0x04004935 RID: 18741
			[Token(Token = "0x4004935")]
			[FieldOffset(Offset = "0x20")]
			public List<string> extraEnemyKeyList;

			// Token: 0x04004936 RID: 18742
			[Token(Token = "0x4004936")]
			[FieldOffset(Offset = "0x28")]
			public bool isFlyEnemy;

			// Token: 0x04004937 RID: 18743
			[Token(Token = "0x4004937")]
			[FieldOffset(Offset = "0x2C")]
			public float enemyBattleEffectivenessFactor;
		}

		// Token: 0x02000DCD RID: 3533
		[Token(Token = "0x2000DCD")]
		public class AutoChessConstData
		{
			// Token: 0x06006A98 RID: 27288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A98")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessConstData()
			{
			}

			// Token: 0x04004938 RID: 18744
			[Token(Token = "0x4004938")]
			[FieldOffset(Offset = "0x10")]
			public List<PingCond> pingConds;

			// Token: 0x04004939 RID: 18745
			[Token(Token = "0x4004939")]
			[FieldOffset(Offset = "0x18")]
			public float matchingTipRotateInterval;

			// Token: 0x0400493A RID: 18746
			[Token(Token = "0x400493A")]
			[FieldOffset(Offset = "0x1C")]
			public int minReplacedEnemyCount;

			// Token: 0x0400493B RID: 18747
			[Token(Token = "0x400493B")]
			[FieldOffset(Offset = "0x20")]
			public int maxReplacedEnemyCount;

			// Token: 0x0400493C RID: 18748
			[Token(Token = "0x400493C")]
			[FieldOffset(Offset = "0x28")]
			public string templateEnemyNormal;

			// Token: 0x0400493D RID: 18749
			[Token(Token = "0x400493D")]
			[FieldOffset(Offset = "0x30")]
			public string templateEnemyElite;

			// Token: 0x0400493E RID: 18750
			[Token(Token = "0x400493E")]
			[FieldOffset(Offset = "0x38")]
			public string templateEnemySpecial;

			// Token: 0x0400493F RID: 18751
			[Token(Token = "0x400493F")]
			[FieldOffset(Offset = "0x40")]
			public string templateEnemyNormalFly;

			// Token: 0x04004940 RID: 18752
			[Token(Token = "0x4004940")]
			[FieldOffset(Offset = "0x48")]
			public string templateEnemyEliteFly;

			// Token: 0x04004941 RID: 18753
			[Token(Token = "0x4004941")]
			[FieldOffset(Offset = "0x50")]
			public string templateEnemySpecialFly;

			// Token: 0x04004942 RID: 18754
			[Token(Token = "0x4004942")]
			[FieldOffset(Offset = "0x58")]
			public string templateEnemyToken;

			// Token: 0x04004943 RID: 18755
			[Token(Token = "0x4004943")]
			[FieldOffset(Offset = "0x60")]
			public string templateEnemyTokenFly;

			// Token: 0x04004944 RID: 18756
			[Token(Token = "0x4004944")]
			[FieldOffset(Offset = "0x68")]
			public int maxLevelCnt;

			// Token: 0x04004945 RID: 18757
			[Token(Token = "0x4004945")]
			[FieldOffset(Offset = "0x6C")]
			public int specialEnemyNum;

			// Token: 0x04004946 RID: 18758
			[Token(Token = "0x4004946")]
			[FieldOffset(Offset = "0x70")]
			public int enemyTypeIdentifierToFillRandom;

			// Token: 0x04004947 RID: 18759
			[Token(Token = "0x4004947")]
			[FieldOffset(Offset = "0x74")]
			public float enemyMaxHpFactor;

			// Token: 0x04004948 RID: 18760
			[Token(Token = "0x4004948")]
			[FieldOffset(Offset = "0x78")]
			public float enemyAtkFactor;

			// Token: 0x04004949 RID: 18761
			[Token(Token = "0x4004949")]
			[FieldOffset(Offset = "0x7C")]
			public float enemyDefFactor;

			// Token: 0x0400494A RID: 18762
			[Token(Token = "0x400494A")]
			[FieldOffset(Offset = "0x80")]
			public float enemyMagicResistanceFactor;

			// Token: 0x0400494B RID: 18763
			[Token(Token = "0x400494B")]
			[FieldOffset(Offset = "0x84")]
			public int singleReconnectTime;

			// Token: 0x0400494C RID: 18764
			[Token(Token = "0x400494C")]
			[FieldOffset(Offset = "0x88")]
			public int specialPhaseStayTime;

			// Token: 0x0400494D RID: 18765
			[Token(Token = "0x400494D")]
			[FieldOffset(Offset = "0x8C")]
			public int hintTimeSpecialPhase;

			// Token: 0x0400494E RID: 18766
			[Token(Token = "0x400494E")]
			[FieldOffset(Offset = "0x90")]
			public int hintTimeNormalPhase;

			// Token: 0x0400494F RID: 18767
			[Token(Token = "0x400494F")]
			[FieldOffset(Offset = "0x94")]
			public int hintTimeFightPhase;

			// Token: 0x04004950 RID: 18768
			[Token(Token = "0x4004950")]
			[FieldOffset(Offset = "0x98")]
			public int hintTimeDotPhase;

			// Token: 0x04004951 RID: 18769
			[Token(Token = "0x4004951")]
			[FieldOffset(Offset = "0x9C")]
			public int invitationSendCd;

			// Token: 0x04004952 RID: 18770
			[Token(Token = "0x4004952")]
			[FieldOffset(Offset = "0xA0")]
			public string discountColor;

			// Token: 0x04004953 RID: 18771
			[Token(Token = "0x4004953")]
			[FieldOffset(Offset = "0xA8")]
			public string premiumColor;

			// Token: 0x04004954 RID: 18772
			[Token(Token = "0x4004954")]
			[FieldOffset(Offset = "0xB0")]
			public string normalColor;

			// Token: 0x04004955 RID: 18773
			[Token(Token = "0x4004955")]
			[FieldOffset(Offset = "0xB8")]
			public int reportMaxNum;

			// Token: 0x04004956 RID: 18774
			[Token(Token = "0x4004956")]
			[FieldOffset(Offset = "0xBC")]
			public float chatCD;

			// Token: 0x04004957 RID: 18775
			[Token(Token = "0x4004957")]
			[FieldOffset(Offset = "0xC0")]
			public float chatTime;

			// Token: 0x04004958 RID: 18776
			[Token(Token = "0x4004958")]
			[FieldOffset(Offset = "0xC4")]
			public float broadcastBeginDelay;

			// Token: 0x04004959 RID: 18777
			[Token(Token = "0x4004959")]
			[FieldOffset(Offset = "0xC8")]
			public List<string> noMoneyTipsBand;

			// Token: 0x0400495A RID: 18778
			[Token(Token = "0x400495A")]
			[FieldOffset(Offset = "0xD0")]
			public int bossTrailerStartRound;

			// Token: 0x0400495B RID: 18779
			[Token(Token = "0x400495B")]
			[FieldOffset(Offset = "0xD4")]
			public float singleClosureStayTime;

			// Token: 0x0400495C RID: 18780
			[Token(Token = "0x400495C")]
			[FieldOffset(Offset = "0xD8")]
			public float matchTimeMax;

			// Token: 0x0400495D RID: 18781
			[Token(Token = "0x400495D")]
			[FieldOffset(Offset = "0xE0")]
			public string enemyDataLevelId;
		}

		// Token: 0x02000DCE RID: 3534
		[Token(Token = "0x2000DCE")]
		public class AutoChessTurnInfoData
		{
			// Token: 0x06006A99 RID: 27289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A99")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessTurnInfoData()
			{
			}

			// Token: 0x0400495E RID: 18782
			[Token(Token = "0x400495E")]
			[FieldOffset(Offset = "0x10")]
			public int round;

			// Token: 0x0400495F RID: 18783
			[Token(Token = "0x400495F")]
			[FieldOffset(Offset = "0x14")]
			public int normalPhaseTime;

			// Token: 0x04004960 RID: 18784
			[Token(Token = "0x4004960")]
			[FieldOffset(Offset = "0x18")]
			public bool isBossTurn;

			// Token: 0x04004961 RID: 18785
			[Token(Token = "0x4004961")]
			[FieldOffset(Offset = "0x1C")]
			public int bossTurnHpReduceTime;
		}

		// Token: 0x02000DCF RID: 3535
		[Token(Token = "0x2000DCF")]
		public class AutoChessMedalData
		{
			// Token: 0x06006A9A RID: 27290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A9A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessMedalData()
			{
			}

			// Token: 0x04004962 RID: 18786
			[Token(Token = "0x4004962")]
			[FieldOffset(Offset = "0x10")]
			public int medalCount;

			// Token: 0x04004963 RID: 18787
			[Token(Token = "0x4004963")]
			[FieldOffset(Offset = "0x18")]
			public string medalIconId;
		}

		// Token: 0x02000DD0 RID: 3536
		[Token(Token = "0x2000DD0")]
		public class AutoChessGameTipData : IItemWithWeight, IHotfixable
		{
			// Token: 0x17000D01 RID: 3329
			// (get) Token: 0x06006A9B RID: 27291 RVA: 0x00031098 File Offset: 0x0002F298
			[Token(Token = "0x17000D01")]
			public float weightValue
			{
				[Token(Token = "0x6006A9B")]
				[Address(RVA = "0x2001880", Offset = "0x2000480", VA = "0x182001880", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06006A9C RID: 27292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A9C")]
			[Address(RVA = "0x2001820", Offset = "0x2000420", VA = "0x182001820")]
			public AutoChessGameTipData()
			{
			}

			// Token: 0x04004964 RID: 18788
			[Token(Token = "0x4004964")]
			[FieldOffset(Offset = "0x10")]
			public string tip;

			// Token: 0x04004965 RID: 18789
			[Token(Token = "0x4004965")]
			[FieldOffset(Offset = "0x18")]
			public int weight;

			// Token: 0x04004966 RID: 18790
			[Token(Token = "0x4004966")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_weightValue;

			// Token: 0x04004967 RID: 18791
			[Token(Token = "0x4004967")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000DD1 RID: 3537
		[Token(Token = "0x2000DD1")]
		public class AutoChessRoundScoreData
		{
			// Token: 0x06006A9D RID: 27293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A9D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessRoundScoreData()
			{
			}

			// Token: 0x04004968 RID: 18792
			[Token(Token = "0x4004968")]
			[FieldOffset(Offset = "0x10")]
			public int round;

			// Token: 0x04004969 RID: 18793
			[Token(Token = "0x4004969")]
			[FieldOffset(Offset = "0x14")]
			public int score;
		}
	}
}
