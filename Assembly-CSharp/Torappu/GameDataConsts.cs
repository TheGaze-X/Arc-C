using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200107E RID: 4222
	[Token(Token = "0x200107E")]
	[Serializable]
	public class GameDataConsts
	{
		// Token: 0x06006E0E RID: 28174 RVA: 0x00031F20 File Offset: 0x00030120
		[Token(Token = "0x6006E0E")]
		[Address(RVA = "0x2105250", Offset = "0x2103E50", VA = "0x182105250")]
		public bool ShouldSerializeisDynIllustStartEnabled()
		{
			return default(bool);
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E0F")]
		[Address(RVA = "0x2105260", Offset = "0x2103E60", VA = "0x182105260")]
		public GameDataConsts()
		{
		}

		// Token: 0x040059C0 RID: 22976
		[Token(Token = "0x40059C0")]
		[FieldOffset(Offset = "0x10")]
		public int maxPlayerLevel;

		// Token: 0x040059C1 RID: 22977
		[Token(Token = "0x40059C1")]
		[FieldOffset(Offset = "0x18")]
		public int[] playerExpMap;

		// Token: 0x040059C2 RID: 22978
		[Token(Token = "0x40059C2")]
		[FieldOffset(Offset = "0x20")]
		public int[] playerApMap;

		// Token: 0x040059C3 RID: 22979
		[Token(Token = "0x40059C3")]
		[FieldOffset(Offset = "0x28")]
		public int[][] maxLevel;

		// Token: 0x040059C4 RID: 22980
		[Token(Token = "0x40059C4")]
		[FieldOffset(Offset = "0x30")]
		public int[][] characterExpMap;

		// Token: 0x040059C5 RID: 22981
		[Token(Token = "0x40059C5")]
		[FieldOffset(Offset = "0x38")]
		public int[][] characterUpgradeCostMap;

		// Token: 0x040059C6 RID: 22982
		[Token(Token = "0x40059C6")]
		[FieldOffset(Offset = "0x40")]
		public int[][] evolveGoldCost;

		// Token: 0x040059C7 RID: 22983
		[Token(Token = "0x40059C7")]
		[FieldOffset(Offset = "0x48")]
		public float completeGainBonus;

		// Token: 0x040059C8 RID: 22984
		[Token(Token = "0x40059C8")]
		[FieldOffset(Offset = "0x4C")]
		public int playerApRegenSpeed;

		// Token: 0x040059C9 RID: 22985
		[Token(Token = "0x40059C9")]
		[FieldOffset(Offset = "0x50")]
		public int maxPracticeTicket;

		// Token: 0x040059CA RID: 22986
		[Token(Token = "0x40059CA")]
		[FieldOffset(Offset = "0x54")]
		public int advancedGachaCrystalCost;

		// Token: 0x040059CB RID: 22987
		[Token(Token = "0x40059CB")]
		[FieldOffset(Offset = "0x58")]
		public int completeCrystalBonus;

		// Token: 0x040059CC RID: 22988
		[Token(Token = "0x40059CC")]
		[FieldOffset(Offset = "0x5C")]
		public int initPlayerGold;

		// Token: 0x040059CD RID: 22989
		[Token(Token = "0x40059CD")]
		[FieldOffset(Offset = "0x60")]
		public int initPlayerDiamondShard;

		// Token: 0x040059CE RID: 22990
		[Token(Token = "0x40059CE")]
		[FieldOffset(Offset = "0x64")]
		public int initCampaignTotalFee;

		// Token: 0x040059CF RID: 22991
		[Token(Token = "0x40059CF")]
		[FieldOffset(Offset = "0x68")]
		public int[] initRecruitTagList;

		// Token: 0x040059D0 RID: 22992
		[Token(Token = "0x40059D0")]
		[FieldOffset(Offset = "0x70")]
		public string[] initCharIdList;

		// Token: 0x040059D1 RID: 22993
		[Token(Token = "0x40059D1")]
		[FieldOffset(Offset = "0x78")]
		public float attackMax;

		// Token: 0x040059D2 RID: 22994
		[Token(Token = "0x40059D2")]
		[FieldOffset(Offset = "0x7C")]
		public float defMax;

		// Token: 0x040059D3 RID: 22995
		[Token(Token = "0x40059D3")]
		[FieldOffset(Offset = "0x80")]
		public float hpMax;

		// Token: 0x040059D4 RID: 22996
		[Token(Token = "0x40059D4")]
		[FieldOffset(Offset = "0x84")]
		public float reMax;

		// Token: 0x040059D5 RID: 22997
		[Token(Token = "0x40059D5")]
		[FieldOffset(Offset = "0x88")]
		public int diamondToShdRate;

		// Token: 0x040059D6 RID: 22998
		[Token(Token = "0x40059D6")]
		[FieldOffset(Offset = "0x8C")]
		public int requestSameFriendCD;

		// Token: 0x040059D7 RID: 22999
		[Token(Token = "0x40059D7")]
		[FieldOffset(Offset = "0x90")]
		public int baseMaxFriendNum;

		// Token: 0x040059D8 RID: 23000
		[Token(Token = "0x40059D8")]
		[FieldOffset(Offset = "0x94")]
		public int maxStarFriendNum;

		// Token: 0x040059D9 RID: 23001
		[Token(Token = "0x40059D9")]
		[FieldOffset(Offset = "0x98")]
		public int maxSquadAssistDisplayNum;

		// Token: 0x040059DA RID: 23002
		[Token(Token = "0x40059DA")]
		[FieldOffset(Offset = "0xA0")]
		public long friendStarEditTrackTs;

		// Token: 0x040059DB RID: 23003
		[Token(Token = "0x40059DB")]
		[FieldOffset(Offset = "0xA8")]
		public int hardDiamondDrop;

		// Token: 0x040059DC RID: 23004
		[Token(Token = "0x40059DC")]
		[FieldOffset(Offset = "0xAC")]
		public int instFinDmdShdCost;

		// Token: 0x040059DD RID: 23005
		[Token(Token = "0x40059DD")]
		[FieldOffset(Offset = "0xB0")]
		public int easyCrystalBonus;

		// Token: 0x040059DE RID: 23006
		[Token(Token = "0x40059DE")]
		[FieldOffset(Offset = "0xB4")]
		public int diamondMaterialToShardExchangeRatio;

		// Token: 0x040059DF RID: 23007
		[Token(Token = "0x40059DF")]
		[FieldOffset(Offset = "0xB8")]
		public int diamondHandbookStageGain;

		// Token: 0x040059E0 RID: 23008
		[Token(Token = "0x40059E0")]
		[FieldOffset(Offset = "0xBC")]
		public int apBuyCost;

		// Token: 0x040059E1 RID: 23009
		[Token(Token = "0x40059E1")]
		[FieldOffset(Offset = "0xC0")]
		public int apBuyThreshold;

		// Token: 0x040059E2 RID: 23010
		[Token(Token = "0x40059E2")]
		[FieldOffset(Offset = "0xC4")]
		public int creditLimit;

		// Token: 0x040059E3 RID: 23011
		[Token(Token = "0x40059E3")]
		[FieldOffset(Offset = "0xC8")]
		public int monthlySubRemainTimeLimitDays;

		// Token: 0x040059E4 RID: 23012
		[Token(Token = "0x40059E4")]
		[FieldOffset(Offset = "0xD0")]
		public List<int> friendAssistRarityLimit;

		// Token: 0x040059E5 RID: 23013
		[Token(Token = "0x40059E5")]
		[FieldOffset(Offset = "0xD8")]
		public string mainlineCompatibleDesc;

		// Token: 0x040059E6 RID: 23014
		[Token(Token = "0x40059E6")]
		[FieldOffset(Offset = "0xE0")]
		public string mainlineToughDesc;

		// Token: 0x040059E7 RID: 23015
		[Token(Token = "0x40059E7")]
		[FieldOffset(Offset = "0xE8")]
		public string mainlineEasyDesc;

		// Token: 0x040059E8 RID: 23016
		[Token(Token = "0x40059E8")]
		[FieldOffset(Offset = "0xF0")]
		public string mainlineNormalDesc;

		// Token: 0x040059E9 RID: 23017
		[Token(Token = "0x40059E9")]
		[FieldOffset(Offset = "0xF8")]
		public long rejectSpCharMission;

		// Token: 0x040059EA RID: 23018
		[Token(Token = "0x40059EA")]
		[FieldOffset(Offset = "0x100")]
		public string addedRewardDisplayZone;

		// Token: 0x040059EB RID: 23019
		[Token(Token = "0x40059EB")]
		[FieldOffset(Offset = "0x108")]
		public int oneDiamondAp;

		// Token: 0x040059EC RID: 23020
		[Token(Token = "0x40059EC")]
		[FieldOffset(Offset = "0x10C")]
		public int charRotationPresetMaxCnt;

		// Token: 0x040059ED RID: 23021
		[Token(Token = "0x40059ED")]
		[FieldOffset(Offset = "0x110")]
		public int charRotationSkinListMaxCnt;

		// Token: 0x040059EE RID: 23022
		[Token(Token = "0x40059EE")]
		[FieldOffset(Offset = "0x118")]
		public string defaultCRPresetCharId;

		// Token: 0x040059EF RID: 23023
		[Token(Token = "0x40059EF")]
		[FieldOffset(Offset = "0x120")]
		public string defaultCRPresetCharSkinId;

		// Token: 0x040059F0 RID: 23024
		[Token(Token = "0x40059F0")]
		[FieldOffset(Offset = "0x128")]
		public string defaultCRPresetBGId;

		// Token: 0x040059F1 RID: 23025
		[Token(Token = "0x40059F1")]
		[FieldOffset(Offset = "0x130")]
		public string defaultCRPresetThemeId;

		// Token: 0x040059F2 RID: 23026
		[Token(Token = "0x40059F2")]
		[FieldOffset(Offset = "0x138")]
		public string defaultCRPresetName;

		// Token: 0x040059F3 RID: 23027
		[Token(Token = "0x40059F3")]
		[FieldOffset(Offset = "0x140")]
		public long charRotationPresetTrackTs;

		// Token: 0x040059F4 RID: 23028
		[Token(Token = "0x40059F4")]
		[FieldOffset(Offset = "0x148")]
		public long uniequipArchiveSysTrackTs;

		// Token: 0x040059F5 RID: 23029
		[Token(Token = "0x40059F5")]
		[FieldOffset(Offset = "0x150")]
		public int manufactPromptTime;

		// Token: 0x040059F6 RID: 23030
		[Token(Token = "0x40059F6")]
		[FieldOffset(Offset = "0x158")]
		public string mainGuideActivedStageId;

		// Token: 0x040059F7 RID: 23031
		[Token(Token = "0x40059F7")]
		[FieldOffset(Offset = "0x160")]
		public Dictionary<string, string> richTextStyles;

		// Token: 0x040059F8 RID: 23032
		[Token(Token = "0x40059F8")]
		[FieldOffset(Offset = "0x168")]
		public List<GameDataConsts.CharAssistRefreshTimeState> charAssistRefreshTime;

		// Token: 0x040059F9 RID: 23033
		[Token(Token = "0x40059F9")]
		[FieldOffset(Offset = "0x170")]
		public List<string> normalRecruitLockedString;

		// Token: 0x040059FA RID: 23034
		[Token(Token = "0x40059FA")]
		[FieldOffset(Offset = "0x178")]
		public int commonPotentialLvlUpCount;

		// Token: 0x040059FB RID: 23035
		[Token(Token = "0x40059FB")]
		[FieldOffset(Offset = "0x180")]
		public string weeklyOverrideDesc;

		// Token: 0x040059FC RID: 23036
		[Token(Token = "0x40059FC")]
		[FieldOffset(Offset = "0x188")]
		public int voucherDiv;

		// Token: 0x040059FD RID: 23037
		[Token(Token = "0x40059FD")]
		[FieldOffset(Offset = "0x18C")]
		public int recruitPoolVersion;

		// Token: 0x040059FE RID: 23038
		[Token(Token = "0x40059FE")]
		[FieldOffset(Offset = "0x190")]
		public long v006RecruitTimeStep1Refresh;

		// Token: 0x040059FF RID: 23039
		[Token(Token = "0x40059FF")]
		[FieldOffset(Offset = "0x198")]
		public long v006RecruitTimeStep2Check;

		// Token: 0x04005A00 RID: 23040
		[Token(Token = "0x4005A00")]
		[FieldOffset(Offset = "0x1A0")]
		public long v006RecruitTimeStep2Flush;

		// Token: 0x04005A01 RID: 23041
		[Token(Token = "0x4005A01")]
		[FieldOffset(Offset = "0x1A8")]
		public bool buyApTimeNoLimitFlag;

		// Token: 0x04005A02 RID: 23042
		[Token(Token = "0x4005A02")]
		[FieldOffset(Offset = "0x1A9")]
		public bool isLMGTSEnabled;

		// Token: 0x04005A03 RID: 23043
		[Token(Token = "0x4005A03")]
		[FieldOffset(Offset = "0x1B0")]
		public long legacyTime;

		// Token: 0x04005A04 RID: 23044
		[Token(Token = "0x4005A04")]
		[FieldOffset(Offset = "0x1B8")]
		public ItemBundle[] legacyItemList;

		// Token: 0x04005A05 RID: 23045
		[Token(Token = "0x4005A05")]
		[FieldOffset(Offset = "0x1C0")]
		public int useAssistSocialPt;

		// Token: 0x04005A06 RID: 23046
		[Token(Token = "0x4005A06")]
		[FieldOffset(Offset = "0x1C4")]
		public int useAssistSocialPtMaxCount;

		// Token: 0x04005A07 RID: 23047
		[Token(Token = "0x4005A07")]
		[FieldOffset(Offset = "0x1C8")]
		public ListDict<int, int> assistBeUsedSocialPt;

		// Token: 0x04005A08 RID: 23048
		[Token(Token = "0x4005A08")]
		[FieldOffset(Offset = "0x1D0")]
		public float[] pushForces;

		// Token: 0x04005A09 RID: 23049
		[Token(Token = "0x4005A09")]
		[FieldOffset(Offset = "0x1D8")]
		public int pushForceZeroIndex;

		// Token: 0x04005A0A RID: 23050
		[Token(Token = "0x4005A0A")]
		[FieldOffset(Offset = "0x1E0")]
		public int[] normalGachaUnlockPrice;

		// Token: 0x04005A0B RID: 23051
		[Token(Token = "0x4005A0B")]
		[FieldOffset(Offset = "0x1E8")]
		public float[] pullForces;

		// Token: 0x04005A0C RID: 23052
		[Token(Token = "0x4005A0C")]
		[FieldOffset(Offset = "0x1F0")]
		public int pullForceZeroIndex;

		// Token: 0x04005A0D RID: 23053
		[Token(Token = "0x4005A0D")]
		[FieldOffset(Offset = "0x1F8")]
		public string[] multiInComeByRank;

		// Token: 0x04005A0E RID: 23054
		[Token(Token = "0x4005A0E")]
		[FieldOffset(Offset = "0x200")]
		public int LMTGSToEPGSRatio;

		// Token: 0x04005A0F RID: 23055
		[Token(Token = "0x4005A0F")]
		[FieldOffset(Offset = "0x204")]
		public int newBeeGiftEPGS;

		// Token: 0x04005A10 RID: 23056
		[Token(Token = "0x4005A10")]
		[FieldOffset(Offset = "0x208")]
		public string lMTGSDescConstOne;

		// Token: 0x04005A11 RID: 23057
		[Token(Token = "0x4005A11")]
		[FieldOffset(Offset = "0x210")]
		public string lMTGSDescConstTwo;

		// Token: 0x04005A12 RID: 23058
		[Token(Token = "0x4005A12")]
		[FieldOffset(Offset = "0x218")]
		public string defCDPrimColor;

		// Token: 0x04005A13 RID: 23059
		[Token(Token = "0x4005A13")]
		[FieldOffset(Offset = "0x220")]
		public string defCDSecColor;

		// Token: 0x04005A14 RID: 23060
		[Token(Token = "0x4005A14")]
		[FieldOffset(Offset = "0x228")]
		public List<string> mailBannerType;

		// Token: 0x04005A15 RID: 23061
		[Token(Token = "0x4005A15")]
		[FieldOffset(Offset = "0x230")]
		public long monthlySubWarningTime;

		// Token: 0x04005A16 RID: 23062
		[Token(Token = "0x4005A16")]
		[FieldOffset(Offset = "0x238")]
		public long UnlimitSkinOutOfTime;

		// Token: 0x04005A17 RID: 23063
		[Token(Token = "0x4005A17")]
		[FieldOffset(Offset = "0x240")]
		public long replicateShopStartTime;

		// Token: 0x04005A18 RID: 23064
		[Token(Token = "0x4005A18")]
		[FieldOffset(Offset = "0x248")]
		[JsonProperty(PropertyName = "TSO")]
		public long operatorRecordsStartTime;

		// Token: 0x04005A19 RID: 23065
		[Token(Token = "0x4005A19")]
		[FieldOffset(Offset = "0x250")]
		public bool isDynIllustEnabled;

		// Token: 0x04005A1A RID: 23066
		[Token(Token = "0x4005A1A")]
		[FieldOffset(Offset = "0x251")]
		public bool isDynIllustStartEnabled;

		// Token: 0x04005A1B RID: 23067
		[Token(Token = "0x4005A1B")]
		[FieldOffset(Offset = "0x252")]
		public bool isClassicQCShopEnabled;

		// Token: 0x04005A1C RID: 23068
		[Token(Token = "0x4005A1C")]
		[FieldOffset(Offset = "0x253")]
		public bool isRoguelikeTopicFuncEnabled;

		// Token: 0x04005A1D RID: 23069
		[Token(Token = "0x4005A1D")]
		[FieldOffset(Offset = "0x254")]
		public bool isSandboxPermFuncEnabled;

		// Token: 0x04005A1E RID: 23070
		[Token(Token = "0x4005A1E")]
		[FieldOffset(Offset = "0x255")]
		public bool isRoguelikeAvgAchieveFuncEnabled;

		// Token: 0x04005A1F RID: 23071
		[Token(Token = "0x4005A1F")]
		[FieldOffset(Offset = "0x256")]
		public bool isClassicPotentialItemFuncEnabled;

		// Token: 0x04005A20 RID: 23072
		[Token(Token = "0x4005A20")]
		[FieldOffset(Offset = "0x257")]
		public bool isClassicGachaPoolFuncEnabled;

		// Token: 0x04005A21 RID: 23073
		[Token(Token = "0x4005A21")]
		[FieldOffset(Offset = "0x258")]
		public bool isSpecialGachaPoolFuncEnabled;

		// Token: 0x04005A22 RID: 23074
		[Token(Token = "0x4005A22")]
		[FieldOffset(Offset = "0x259")]
		public bool isVoucherClassicItemDistinguishable;

		// Token: 0x04005A23 RID: 23075
		[Token(Token = "0x4005A23")]
		[FieldOffset(Offset = "0x25A")]
		public bool isRecalRuneFuncEnabled;

		// Token: 0x04005A24 RID: 23076
		[Token(Token = "0x4005A24")]
		[FieldOffset(Offset = "0x25C")]
		public int voucherSkinRedeem;

		// Token: 0x04005A25 RID: 23077
		[Token(Token = "0x4005A25")]
		[FieldOffset(Offset = "0x260")]
		public string voucherSkinDesc;

		// Token: 0x04005A26 RID: 23078
		[Token(Token = "0x4005A26")]
		[FieldOffset(Offset = "0x268")]
		public int charmEquipCount;

		// Token: 0x04005A27 RID: 23079
		[Token(Token = "0x4005A27")]
		[FieldOffset(Offset = "0x270")]
		public Dictionary<string, TermDescriptionData> termDescriptionDict;

		// Token: 0x04005A28 RID: 23080
		[Token(Token = "0x4005A28")]
		[FieldOffset(Offset = "0x278")]
		public string storyReviewUnlockItemLackTip;

		// Token: 0x04005A29 RID: 23081
		[Token(Token = "0x4005A29")]
		[FieldOffset(Offset = "0x280")]
		public string dataVersion;

		// Token: 0x04005A2A RID: 23082
		[Token(Token = "0x4005A2A")]
		[FieldOffset(Offset = "0x288")]
		public string resPrefVersion;

		// Token: 0x04005A2B RID: 23083
		[Token(Token = "0x4005A2B")]
		[FieldOffset(Offset = "0x290")]
		public string announceWebBusType;

		// Token: 0x04005A2C RID: 23084
		[Token(Token = "0x4005A2C")]
		[FieldOffset(Offset = "0x298")]
		public string videoPlayerWebBusType;

		// Token: 0x04005A2D RID: 23085
		[Token(Token = "0x4005A2D")]
		[FieldOffset(Offset = "0x2A0")]
		public string gachaLogBusType;

		// Token: 0x04005A2E RID: 23086
		[Token(Token = "0x4005A2E")]
		[FieldOffset(Offset = "0x2A8")]
		public int defaultMinMultipleBattleTimes;

		// Token: 0x04005A2F RID: 23087
		[Token(Token = "0x4005A2F")]
		[FieldOffset(Offset = "0x2AC")]
		public int defaultMaxMultipleBattleTimes;

		// Token: 0x04005A30 RID: 23088
		[Token(Token = "0x4005A30")]
		[FieldOffset(Offset = "0x2B0")]
		public bool multipleActionOpen;

		// Token: 0x04005A31 RID: 23089
		[Token(Token = "0x4005A31")]
		[FieldOffset(Offset = "0x2B8")]
		public Dictionary<string, SubProfessionAttackType> subProfessionDamageTypePairs;

		// Token: 0x04005A32 RID: 23090
		[Token(Token = "0x4005A32")]
		[FieldOffset(Offset = "0x2C0")]
		public List<string> classicProtectChar;

		// Token: 0x04005A33 RID: 23091
		[Token(Token = "0x4005A33")]
		[FieldOffset(Offset = "0x2C8")]
		public GameDataConsts.FeverGameData feverGameData;

		// Token: 0x04005A34 RID: 23092
		[Token(Token = "0x4005A34")]
		[FieldOffset(Offset = "0x2D0")]
		public string birthdaySettingDesc;

		// Token: 0x04005A35 RID: 23093
		[Token(Token = "0x4005A35")]
		[FieldOffset(Offset = "0x2D8")]
		public string birthdaySettingConfirmDesc;

		// Token: 0x04005A36 RID: 23094
		[Token(Token = "0x4005A36")]
		[FieldOffset(Offset = "0x2E0")]
		public string birthdaySettingLeapConfirmDesc;

		// Token: 0x04005A37 RID: 23095
		[Token(Token = "0x4005A37")]
		[FieldOffset(Offset = "0x2E8")]
		public int leapBirthdayRewardMonth;

		// Token: 0x04005A38 RID: 23096
		[Token(Token = "0x4005A38")]
		[FieldOffset(Offset = "0x2EC")]
		public int leapBirthdayRewardDay;

		// Token: 0x04005A39 RID: 23097
		[Token(Token = "0x4005A39")]
		[FieldOffset(Offset = "0x2F0")]
		public string birthdaySettingShowStageId;

		// Token: 0x04005A3A RID: 23098
		[Token(Token = "0x4005A3A")]
		[FieldOffset(Offset = "0x2F8")]
		public bool isBirthdayFuncEnabled;

		// Token: 0x04005A3B RID: 23099
		[Token(Token = "0x4005A3B")]
		[FieldOffset(Offset = "0x2F9")]
		public bool isSoCharEnabled;

		// Token: 0x04005A3C RID: 23100
		[Token(Token = "0x4005A3C")]
		[FieldOffset(Offset = "0x300")]
		public GameDataConsts.AVGReaderModeDefaultSetting avgReaderModeDefaultSetting;

		// Token: 0x0200107F RID: 4223
		[Token(Token = "0x200107F")]
		[Serializable]
		public struct CharAssistRefreshTimeState
		{
			// Token: 0x04005A3D RID: 23101
			[Token(Token = "0x4005A3D")]
			[FieldOffset(Offset = "0x0")]
			public int Hour;

			// Token: 0x04005A3E RID: 23102
			[Token(Token = "0x4005A3E")]
			[FieldOffset(Offset = "0x4")]
			public int Minute;
		}

		// Token: 0x02001080 RID: 4224
		[Token(Token = "0x2001080")]
		[Serializable]
		public class FeverGameData
		{
			// Token: 0x06006E10 RID: 28176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E10")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FeverGameData()
			{
			}

			// Token: 0x04005A3F RID: 23103
			[Token(Token = "0x4005A3F")]
			[FieldOffset(Offset = "0x10")]
			public float feverDuration;

			// Token: 0x04005A40 RID: 23104
			[Token(Token = "0x4005A40")]
			[FieldOffset(Offset = "0x14")]
			public float feverNeed;
		}

		// Token: 0x02001081 RID: 4225
		[Token(Token = "0x2001081")]
		public class AVGReaderModeDefaultSetting
		{
			// Token: 0x06006E11 RID: 28177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E11")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AVGReaderModeDefaultSetting()
			{
			}

			// Token: 0x04005A41 RID: 23105
			[Token(Token = "0x4005A41")]
			[FieldOffset(Offset = "0x10")]
			public int defaultReaderFontsize;

			// Token: 0x04005A42 RID: 23106
			[Token(Token = "0x4005A42")]
			[FieldOffset(Offset = "0x14")]
			public int defaultReaderLinespace;

			// Token: 0x04005A43 RID: 23107
			[Token(Token = "0x4005A43")]
			[FieldOffset(Offset = "0x18")]
			public int defaultReaderBackgroundAlpha;
		}
	}
}
