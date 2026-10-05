using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013DD RID: 5085
	[Token(Token = "0x20013DD")]
	[Serializable]
	public class VcConfig
	{
		// Token: 0x060073FD RID: 29693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FD")]
		[Address(RVA = "0x2216A40", Offset = "0x2215640", VA = "0x182216A40")]
		public void AddAll(VcConfig other)
		{
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FE")]
		private void _AddRangeSafe<T>(ref List<T> assignTo, List<T> assignFrom)
		{
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073FF")]
		[Address(RVA = "0x2217E60", Offset = "0x2216A60", VA = "0x182217E60")]
		private void _MergeStringConfig(ref string assignTo, string assignFrom)
		{
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007400")]
		[Address(RVA = "0x2217EB0", Offset = "0x2216AB0", VA = "0x182217EB0")]
		public VcConfig()
		{
		}

		// Token: 0x040070D9 RID: 28889
		[Token(Token = "0x40070D9")]
		public const string ACTFUN_COMMON_ID = "actfun";

		// Token: 0x040070DA RID: 28890
		[Token(Token = "0x40070DA")]
		[FieldOffset(Offset = "0x10")]
		public string controlVersion;

		// Token: 0x040070DB RID: 28891
		[Token(Token = "0x40070DB")]
		[FieldOffset(Offset = "0x18")]
		public List<string> bannedCharIds;

		// Token: 0x040070DC RID: 28892
		[Token(Token = "0x40070DC")]
		[FieldOffset(Offset = "0x20")]
		public List<string> bannedStageIds;

		// Token: 0x040070DD RID: 28893
		[Token(Token = "0x40070DD")]
		[FieldOffset(Offset = "0x28")]
		public List<string> bannedItemIds;

		// Token: 0x040070DE RID: 28894
		[Token(Token = "0x40070DE")]
		[FieldOffset(Offset = "0x30")]
		public List<string> bannedSkinIds;

		// Token: 0x040070DF RID: 28895
		[Token(Token = "0x40070DF")]
		[FieldOffset(Offset = "0x38")]
		public List<string> bannedFurnIds;

		// Token: 0x040070E0 RID: 28896
		[Token(Token = "0x40070E0")]
		[FieldOffset(Offset = "0x40")]
		public List<string> bannedFurniSetIds;

		// Token: 0x040070E1 RID: 28897
		[Token(Token = "0x40070E1")]
		[FieldOffset(Offset = "0x48")]
		public List<string> bannedActIds;

		// Token: 0x040070E2 RID: 28898
		[Token(Token = "0x40070E2")]
		[FieldOffset(Offset = "0x50")]
		public List<string> bannedEnemyIds;

		// Token: 0x040070E3 RID: 28899
		[Token(Token = "0x40070E3")]
		[FieldOffset(Offset = "0x58")]
		public List<string> bannedGachaPoolIds;

		// Token: 0x040070E4 RID: 28900
		[Token(Token = "0x40070E4")]
		[FieldOffset(Offset = "0x60")]
		public List<string> bannedShopRecommendTags;

		// Token: 0x040070E5 RID: 28901
		[Token(Token = "0x40070E5")]
		[FieldOffset(Offset = "0x68")]
		public List<string> bannedShopCarousels;

		// Token: 0x040070E6 RID: 28902
		[Token(Token = "0x40070E6")]
		[FieldOffset(Offset = "0x70")]
		public List<string> bannedShopFurnPackages;

		// Token: 0x040070E7 RID: 28903
		[Token(Token = "0x40070E7")]
		[FieldOffset(Offset = "0x78")]
		public List<string> bannedShopFurnPackageIcons;

		// Token: 0x040070E8 RID: 28904
		[Token(Token = "0x40070E8")]
		[FieldOffset(Offset = "0x80")]
		public List<string> bannedShopGiftPackages;

		// Token: 0x040070E9 RID: 28905
		[Token(Token = "0x40070E9")]
		[FieldOffset(Offset = "0x88")]
		public List<string> bannedMonthlySubGroupId;

		// Token: 0x040070EA RID: 28906
		[Token(Token = "0x40070EA")]
		[FieldOffset(Offset = "0x90")]
		public List<string> bannedMainMissionEndImageId;

		// Token: 0x040070EB RID: 28907
		[Token(Token = "0x40070EB")]
		[FieldOffset(Offset = "0x98")]
		public List<string> bannedZoneIds;

		// Token: 0x040070EC RID: 28908
		[Token(Token = "0x40070EC")]
		[FieldOffset(Offset = "0xA0")]
		public List<string> bannedChapterIds;

		// Token: 0x040070ED RID: 28909
		[Token(Token = "0x40070ED")]
		[FieldOffset(Offset = "0xA8")]
		public List<string> bannedCrisisSeasonId;

		// Token: 0x040070EE RID: 28910
		[Token(Token = "0x40070EE")]
		[FieldOffset(Offset = "0xB0")]
		public List<string> bannedCrisisV2SeasonId;

		// Token: 0x040070EF RID: 28911
		[Token(Token = "0x40070EF")]
		[FieldOffset(Offset = "0xB8")]
		public List<string> bannedCrisisV2StageLogoId;

		// Token: 0x040070F0 RID: 28912
		[Token(Token = "0x40070F0")]
		[FieldOffset(Offset = "0xC0")]
		public List<string> bannedCrisisV2MapAreaBkgId;

		// Token: 0x040070F1 RID: 28913
		[Token(Token = "0x40070F1")]
		[FieldOffset(Offset = "0xC8")]
		public List<string> bannedMultiV3SquadEffectIcons;

		// Token: 0x040070F2 RID: 28914
		[Token(Token = "0x40070F2")]
		[FieldOffset(Offset = "0xD0")]
		public List<string> bannedMultiV3ModeIcons;

		// Token: 0x040070F3 RID: 28915
		[Token(Token = "0x40070F3")]
		[FieldOffset(Offset = "0xD8")]
		public List<string> bannedMultiV3StagePreviewIcons;

		// Token: 0x040070F4 RID: 28916
		[Token(Token = "0x40070F4")]
		[FieldOffset(Offset = "0xE0")]
		public List<string> bannedVecBreakV2OffenseBossIcons;

		// Token: 0x040070F5 RID: 28917
		[Token(Token = "0x40070F5")]
		[FieldOffset(Offset = "0xE8")]
		public List<string> bannedVecBreakV2OffenseBossDecos;

		// Token: 0x040070F6 RID: 28918
		[Token(Token = "0x40070F6")]
		[FieldOffset(Offset = "0xF0")]
		public List<string> bannedVecBreakV2HardBossDecos;

		// Token: 0x040070F7 RID: 28919
		[Token(Token = "0x40070F7")]
		[FieldOffset(Offset = "0xF8")]
		public List<string> bannedVecBreakV2DefenseBossIcons;

		// Token: 0x040070F8 RID: 28920
		[Token(Token = "0x40070F8")]
		[FieldOffset(Offset = "0x100")]
		public List<string> bannedVecBreakV2SquadBuffIcons;

		// Token: 0x040070F9 RID: 28921
		[Token(Token = "0x40070F9")]
		[FieldOffset(Offset = "0x108")]
		public List<string> bannedCrisisStageId;

		// Token: 0x040070FA RID: 28922
		[Token(Token = "0x40070FA")]
		[FieldOffset(Offset = "0x110")]
		public List<string> bannedCrisisTrainingRotateId;

		// Token: 0x040070FB RID: 28923
		[Token(Token = "0x40070FB")]
		[FieldOffset(Offset = "0x118")]
		public List<string> bannedMusicFolders;

		// Token: 0x040070FC RID: 28924
		[Token(Token = "0x40070FC")]
		[FieldOffset(Offset = "0x120")]
		public List<string> bannedHandbookTeamIds;

		// Token: 0x040070FD RID: 28925
		[Token(Token = "0x40070FD")]
		[FieldOffset(Offset = "0x128")]
		public List<string> bannedMedalIds;

		// Token: 0x040070FE RID: 28926
		[Token(Token = "0x40070FE")]
		[FieldOffset(Offset = "0x130")]
		public List<string> bannedMedalGroupIds;

		// Token: 0x040070FF RID: 28927
		[Token(Token = "0x40070FF")]
		[FieldOffset(Offset = "0x138")]
		public List<string> bannedStoryReviewIds;

		// Token: 0x04007100 RID: 28928
		[Token(Token = "0x4007100")]
		[FieldOffset(Offset = "0x140")]
		public List<string> bannedMiniActTrialIds;

		// Token: 0x04007101 RID: 28929
		[Token(Token = "0x4007101")]
		[FieldOffset(Offset = "0x148")]
		public List<string> bannedCampaignRegionIds;

		// Token: 0x04007102 RID: 28930
		[Token(Token = "0x4007102")]
		[FieldOffset(Offset = "0x150")]
		public List<string> bannedCampaignRotateGroupIds;

		// Token: 0x04007103 RID: 28931
		[Token(Token = "0x4007103")]
		[FieldOffset(Offset = "0x158")]
		public List<string> bannedCampaignTrainingGroupIds;

		// Token: 0x04007104 RID: 28932
		[Token(Token = "0x4007104")]
		[FieldOffset(Offset = "0x160")]
		public List<string> bannedCampaignTrainingAllOpenGroupIds;

		// Token: 0x04007105 RID: 28933
		[Token(Token = "0x4007105")]
		[FieldOffset(Offset = "0x168")]
		public List<string> bannedHandbookForceIds;

		// Token: 0x04007106 RID: 28934
		[Token(Token = "0x4007106")]
		[FieldOffset(Offset = "0x170")]
		public List<string> bannedBattleMapRes;

		// Token: 0x04007107 RID: 28935
		[Token(Token = "0x4007107")]
		[FieldOffset(Offset = "0x178")]
		public List<string> bannedSpecialEffectPrefix;

		// Token: 0x04007108 RID: 28936
		[Token(Token = "0x4007108")]
		[FieldOffset(Offset = "0x180")]
		public List<string> bannedSpecialPlayerAudio;

		// Token: 0x04007109 RID: 28937
		[Token(Token = "0x4007109")]
		[FieldOffset(Offset = "0x188")]
		public List<string> bannedTileKey;

		// Token: 0x0400710A RID: 28938
		[Token(Token = "0x400710A")]
		[FieldOffset(Offset = "0x190")]
		public List<string> bannedTokenIds;

		// Token: 0x0400710B RID: 28939
		[Token(Token = "0x400710B")]
		[FieldOffset(Offset = "0x198")]
		public List<string> bannedSkinResNames;

		// Token: 0x0400710C RID: 28940
		[Token(Token = "0x400710C")]
		[FieldOffset(Offset = "0x1A0")]
		public List<string> bannedLevelIds;

		// Token: 0x0400710D RID: 28941
		[Token(Token = "0x400710D")]
		[FieldOffset(Offset = "0x1A8")]
		public List<string> bannedLevelReplaceIds;

		// Token: 0x0400710E RID: 28942
		[Token(Token = "0x400710E")]
		[FieldOffset(Offset = "0x1B0")]
		public List<string> bannedVoucherItemPic;

		// Token: 0x0400710F RID: 28943
		[Token(Token = "0x400710F")]
		[FieldOffset(Offset = "0x1B8")]
		public List<string> bannedOptionalVoucherBgDecPic;

		// Token: 0x04007110 RID: 28944
		[Token(Token = "0x4007110")]
		[FieldOffset(Offset = "0x1C0")]
		public List<string> bannedLMGTSBarType;

		// Token: 0x04007111 RID: 28945
		[Token(Token = "0x4007111")]
		[FieldOffset(Offset = "0x1C8")]
		public List<string> bannedBuildingSkillIcons;

		// Token: 0x04007112 RID: 28946
		[Token(Token = "0x4007112")]
		[FieldOffset(Offset = "0x1D0")]
		public List<string> bannedSkinGroupIds;

		// Token: 0x04007113 RID: 28947
		[Token(Token = "0x4007113")]
		[FieldOffset(Offset = "0x1D8")]
		public List<string> bannedBrandIds;

		// Token: 0x04007114 RID: 28948
		[Token(Token = "0x4007114")]
		[FieldOffset(Offset = "0x1E0")]
		public List<string> bannedKVImgIds;

		// Token: 0x04007115 RID: 28949
		[Token(Token = "0x4007115")]
		[FieldOffset(Offset = "0x1E8")]
		public List<string> bannedStoryIds;

		// Token: 0x04007116 RID: 28950
		[Token(Token = "0x4007116")]
		[FieldOffset(Offset = "0x1F0")]
		public List<string> bannedCharLogo;

		// Token: 0x04007117 RID: 28951
		[Token(Token = "0x4007117")]
		[FieldOffset(Offset = "0x1F8")]
		public List<string> bannedRuneIcons;

		// Token: 0x04007118 RID: 28952
		[Token(Token = "0x4007118")]
		[FieldOffset(Offset = "0x200")]
		public List<string> bannedAudioAssets;

		// Token: 0x04007119 RID: 28953
		[Token(Token = "0x4007119")]
		[FieldOffset(Offset = "0x208")]
		public List<string> bannedLoadingPics;

		// Token: 0x0400711A RID: 28954
		[Token(Token = "0x400711A")]
		[FieldOffset(Offset = "0x210")]
		public List<string> bannedCampaignWorldMapIds;

		// Token: 0x0400711B RID: 28955
		[Token(Token = "0x400711B")]
		[FieldOffset(Offset = "0x218")]
		public List<string> bannedHandBookStorySetId;

		// Token: 0x0400711C RID: 28956
		[Token(Token = "0x400711C")]
		[FieldOffset(Offset = "0x220")]
		public List<string> bannedHandBookStageId;

		// Token: 0x0400711D RID: 28957
		[Token(Token = "0x400711D")]
		[FieldOffset(Offset = "0x228")]
		public List<string> bannedRetroIds;

		// Token: 0x0400711E RID: 28958
		[Token(Token = "0x400711E")]
		[FieldOffset(Offset = "0x230")]
		public List<string> bannedRetroTrailIds;

		// Token: 0x0400711F RID: 28959
		[Token(Token = "0x400711F")]
		[FieldOffset(Offset = "0x238")]
		public List<string> bannedTermDescId;

		// Token: 0x04007120 RID: 28960
		[Token(Token = "0x4007120")]
		[FieldOffset(Offset = "0x240")]
		public List<string> bannedArchiveMusicIds;

		// Token: 0x04007121 RID: 28961
		[Token(Token = "0x4007121")]
		[FieldOffset(Offset = "0x248")]
		public List<string> bannedArchivePicIds;

		// Token: 0x04007122 RID: 28962
		[Token(Token = "0x4007122")]
		[FieldOffset(Offset = "0x250")]
		public List<string> bannedArchiveStoryIds;

		// Token: 0x04007123 RID: 28963
		[Token(Token = "0x4007123")]
		[FieldOffset(Offset = "0x258")]
		public List<string> bannedArchiveAvgIds;

		// Token: 0x04007124 RID: 28964
		[Token(Token = "0x4007124")]
		[FieldOffset(Offset = "0x260")]
		public List<string> bannedArchiveNewsIds;

		// Token: 0x04007125 RID: 28965
		[Token(Token = "0x4007125")]
		[FieldOffset(Offset = "0x268")]
		public List<string> bannedActEntryKVIds;

		// Token: 0x04007126 RID: 28966
		[Token(Token = "0x4007126")]
		[FieldOffset(Offset = "0x270")]
		public List<string> bannedDynActEntryIds;

		// Token: 0x04007127 RID: 28967
		[Token(Token = "0x4007127")]
		[FieldOffset(Offset = "0x278")]
		public List<string> bannedRhineCollectionItemIconIds;

		// Token: 0x04007128 RID: 28968
		[Token(Token = "0x4007128")]
		[FieldOffset(Offset = "0x280")]
		public List<string> bannedActMainlineBuffDynImgIds;

		// Token: 0x04007129 RID: 28969
		[Token(Token = "0x4007129")]
		[FieldOffset(Offset = "0x288")]
		public List<string> bannedActMainlineBpDynImgIds;

		// Token: 0x0400712A RID: 28970
		[Token(Token = "0x400712A")]
		[FieldOffset(Offset = "0x290")]
		public List<string> bannedMixStoryArtSprites;

		// Token: 0x0400712B RID: 28971
		[Token(Token = "0x400712B")]
		[FieldOffset(Offset = "0x298")]
		public List<string> bannedCGGalleryThumbnails;

		// Token: 0x0400712C RID: 28972
		[Token(Token = "0x400712C")]
		[FieldOffset(Offset = "0x2A0")]
		public bool isLimitedGachaBanned;

		// Token: 0x0400712D RID: 28973
		[Token(Token = "0x400712D")]
		[FieldOffset(Offset = "0x2A8")]
		public List<string> retroRelatedActIds;

		// Token: 0x0400712E RID: 28974
		[Token(Token = "0x400712E")]
		[FieldOffset(Offset = "0x2B0")]
		public List<string> sharedLevelActIds;

		// Token: 0x0400712F RID: 28975
		[Token(Token = "0x400712F")]
		[FieldOffset(Offset = "0x2B8")]
		public List<string> bannedSubProfIcon;

		// Token: 0x04007130 RID: 28976
		[Token(Token = "0x4007130")]
		[FieldOffset(Offset = "0x2C0")]
		public List<string> bannedSubProfType;

		// Token: 0x04007131 RID: 28977
		[Token(Token = "0x4007131")]
		[FieldOffset(Offset = "0x2C8")]
		public List<string> bannedUniEquipId;

		// Token: 0x04007132 RID: 28978
		[Token(Token = "0x4007132")]
		[FieldOffset(Offset = "0x2D0")]
		public List<string> bannedVoiceLangJP;

		// Token: 0x04007133 RID: 28979
		[Token(Token = "0x4007133")]
		[FieldOffset(Offset = "0x2D8")]
		public List<string> bannedVoiceLangCN;

		// Token: 0x04007134 RID: 28980
		[Token(Token = "0x4007134")]
		[FieldOffset(Offset = "0x2E0")]
		public List<string> bannedVoiceLangEN;

		// Token: 0x04007135 RID: 28981
		[Token(Token = "0x4007135")]
		[FieldOffset(Offset = "0x2E8")]
		public List<string> bannedVoiceLangKR;

		// Token: 0x04007136 RID: 28982
		[Token(Token = "0x4007136")]
		[FieldOffset(Offset = "0x2F0")]
		public List<string> bannedVoiceLangCustom;

		// Token: 0x04007137 RID: 28983
		[Token(Token = "0x4007137")]
		[FieldOffset(Offset = "0x2F8")]
		public List<string> bannedTimelyDropInfo;

		// Token: 0x04007138 RID: 28984
		[Token(Token = "0x4007138")]
		[FieldOffset(Offset = "0x300")]
		public List<string> bannedHomeBackground;

		// Token: 0x04007139 RID: 28985
		[Token(Token = "0x4007139")]
		[FieldOffset(Offset = "0x308")]
		public List<string> bannedHomeBackgroundPreviewIds;

		// Token: 0x0400713A RID: 28986
		[Token(Token = "0x400713A")]
		[FieldOffset(Offset = "0x310")]
		public List<string> bannedHomeBackgroundLimit;

		// Token: 0x0400713B RID: 28987
		[Token(Token = "0x400713B")]
		[FieldOffset(Offset = "0x318")]
		public List<string> bannedHomeThemeId;

		// Token: 0x0400713C RID: 28988
		[Token(Token = "0x400713C")]
		[FieldOffset(Offset = "0x320")]
		public List<string> bannedHomeThemePreviewIds;

		// Token: 0x0400713D RID: 28989
		[Token(Token = "0x400713D")]
		[FieldOffset(Offset = "0x328")]
		public List<string> bannedWSBonusIcon;

		// Token: 0x0400713E RID: 28990
		[Token(Token = "0x400713E")]
		[FieldOffset(Offset = "0x330")]
		public List<string> bannedReturnV2MissionGroupImage;

		// Token: 0x0400713F RID: 28991
		[Token(Token = "0x400713F")]
		[FieldOffset(Offset = "0x338")]
		public List<string> bannedReturnV2MissionGroupIcon;

		// Token: 0x04007140 RID: 28992
		[Token(Token = "0x4007140")]
		[FieldOffset(Offset = "0x340")]
		public List<string> bannedReturnNewsItemImage;

		// Token: 0x04007141 RID: 28993
		[Token(Token = "0x4007141")]
		[FieldOffset(Offset = "0x348")]
		public List<string> bannedReturnNewsMainBkg;

		// Token: 0x04007142 RID: 28994
		[Token(Token = "0x4007142")]
		[FieldOffset(Offset = "0x350")]
		public List<string> bannedReturnNewsMainTitle;

		// Token: 0x04007143 RID: 28995
		[Token(Token = "0x4007143")]
		[FieldOffset(Offset = "0x358")]
		public List<string> bannedReturnGiftPackagePic;

		// Token: 0x04007144 RID: 28996
		[Token(Token = "0x4007144")]
		[FieldOffset(Offset = "0x360")]
		public List<string> bannedMailSenderAvatarIcon;

		// Token: 0x04007145 RID: 28997
		[Token(Token = "0x4007145")]
		[FieldOffset(Offset = "0x368")]
		public bool isSiracusaMapBanned;

		// Token: 0x04007146 RID: 28998
		[Token(Token = "0x4007146")]
		[FieldOffset(Offset = "0x369")]
		public bool isVecBreakV2Banned;

		// Token: 0x04007147 RID: 28999
		[Token(Token = "0x4007147")]
		[FieldOffset(Offset = "0x36A")]
		public bool isActMultiV3Banned;

		// Token: 0x04007148 RID: 29000
		[Token(Token = "0x4007148")]
		[FieldOffset(Offset = "0x36B")]
		public bool isEnemyDuelBanned;

		// Token: 0x04007149 RID: 29001
		[Token(Token = "0x4007149")]
		[FieldOffset(Offset = "0x36C")]
		public bool isRoguelikeTopicBanned;

		// Token: 0x0400714A RID: 29002
		[Token(Token = "0x400714A")]
		[FieldOffset(Offset = "0x36D")]
		public bool isRoguelikeTopicChallengeModeBanned;

		// Token: 0x0400714B RID: 29003
		[Token(Token = "0x400714B")]
		[FieldOffset(Offset = "0x370")]
		public List<string> bannedRoguelikeItemIcon;

		// Token: 0x0400714C RID: 29004
		[Token(Token = "0x400714C")]
		[FieldOffset(Offset = "0x378")]
		public List<string> bannedRoguelikeRecruitGroup;

		// Token: 0x0400714D RID: 29005
		[Token(Token = "0x400714D")]
		[FieldOffset(Offset = "0x380")]
		public List<string> bannedRoguelikeMonthSquadRecord;

		// Token: 0x0400714E RID: 29006
		[Token(Token = "0x400714E")]
		[FieldOffset(Offset = "0x388")]
		public List<string> bannedRoguelikeInitRelicIcon;

		// Token: 0x0400714F RID: 29007
		[Token(Token = "0x400714F")]
		[FieldOffset(Offset = "0x390")]
		public List<string> bannedRoguelikeCapsuleIcon;

		// Token: 0x04007150 RID: 29008
		[Token(Token = "0x4007150")]
		[FieldOffset(Offset = "0x398")]
		public List<string> bannedRoguelikeTopicVariation;

		// Token: 0x04007151 RID: 29009
		[Token(Token = "0x4007151")]
		[FieldOffset(Offset = "0x3A0")]
		public List<string> bannedRoguelikeTopicCharBuffIcon;

		// Token: 0x04007152 RID: 29010
		[Token(Token = "0x4007152")]
		[FieldOffset(Offset = "0x3A8")]
		public List<string> bannedRoguelikeChallenge;

		// Token: 0x04007153 RID: 29011
		[Token(Token = "0x4007153")]
		[FieldOffset(Offset = "0x3B0")]
		public List<string> bannedRoguelikeChallengeModeTopic;

		// Token: 0x04007154 RID: 29012
		[Token(Token = "0x4007154")]
		[FieldOffset(Offset = "0x3B8")]
		public List<string> bannedRoguelikeHomeEntry;

		// Token: 0x04007155 RID: 29013
		[Token(Token = "0x4007155")]
		[FieldOffset(Offset = "0x3C0")]
		public List<string> bannedRoguelikeTopic;

		// Token: 0x04007156 RID: 29014
		[Token(Token = "0x4007156")]
		[FieldOffset(Offset = "0x3C8")]
		public List<string> bannedRoguelikeBPRewardPic;

		// Token: 0x04007157 RID: 29015
		[Token(Token = "0x4007157")]
		[FieldOffset(Offset = "0x3D0")]
		public List<string> bannedRoguelikeArchivePicKV;

		// Token: 0x04007158 RID: 29016
		[Token(Token = "0x4007158")]
		[FieldOffset(Offset = "0x3D8")]
		public List<string> bannedRoguelikeArchiveAvgIllust;

		// Token: 0x04007159 RID: 29017
		[Token(Token = "0x4007159")]
		[FieldOffset(Offset = "0x3E0")]
		public List<string> bannedRoguelikeArchiveEndbookBgBlur;

		// Token: 0x0400715A RID: 29018
		[Token(Token = "0x400715A")]
		[FieldOffset(Offset = "0x3E8")]
		public List<string> bannedRoguelikeArchiveEndbookCard;

		// Token: 0x0400715B RID: 29019
		[Token(Token = "0x400715B")]
		[FieldOffset(Offset = "0x3F0")]
		public List<string> bannedRoguelikeArchiveMusicIcon;

		// Token: 0x0400715C RID: 29020
		[Token(Token = "0x400715C")]
		[FieldOffset(Offset = "0x3F8")]
		public List<string> bannedRoguelikeMenuDifficultyIcon;

		// Token: 0x0400715D RID: 29021
		[Token(Token = "0x400715D")]
		[FieldOffset(Offset = "0x400")]
		public List<string> bannedRoguelikeEndingStatsIcon;

		// Token: 0x0400715E RID: 29022
		[Token(Token = "0x400715E")]
		[FieldOffset(Offset = "0x408")]
		public List<string> bannedRoguelikeZone;

		// Token: 0x0400715F RID: 29023
		[Token(Token = "0x400715F")]
		[FieldOffset(Offset = "0x410")]
		public List<string> bannedRoguelikeBossNodeIcon;

		// Token: 0x04007160 RID: 29024
		[Token(Token = "0x4007160")]
		[FieldOffset(Offset = "0x418")]
		public List<string> bannedRoguelikeBandEndingCompletetionIcon;

		// Token: 0x04007161 RID: 29025
		[Token(Token = "0x4007161")]
		[FieldOffset(Offset = "0x420")]
		public List<string> bannedRoguelikeGameEndBg;

		// Token: 0x04007162 RID: 29026
		[Token(Token = "0x4007162")]
		[FieldOffset(Offset = "0x428")]
		public List<string> bannedRoguelikeLevelBgPic;

		// Token: 0x04007163 RID: 29027
		[Token(Token = "0x4007163")]
		[FieldOffset(Offset = "0x430")]
		public List<string> bannedRoguelikeScrollReportIcon;

		// Token: 0x04007164 RID: 29028
		[Token(Token = "0x4007164")]
		[FieldOffset(Offset = "0x438")]
		public List<string> bannedRoguelikeZoneImage;

		// Token: 0x04007165 RID: 29029
		[Token(Token = "0x4007165")]
		[FieldOffset(Offset = "0x440")]
		public List<string> bannedRoguelikeZoneTransitionBg;

		// Token: 0x04007166 RID: 29030
		[Token(Token = "0x4007166")]
		[FieldOffset(Offset = "0x448")]
		public List<string> bannedRoguelikeCommonOuterBuffIcons;

		// Token: 0x04007167 RID: 29031
		[Token(Token = "0x4007167")]
		[FieldOffset(Offset = "0x450")]
		public List<string> bannedRoguelikeCommonOuterBuffDeco;

		// Token: 0x04007168 RID: 29032
		[Token(Token = "0x4007168")]
		[FieldOffset(Offset = "0x458")]
		public List<string> bannedRoguelikeCommonOuterBuffLight;

		// Token: 0x04007169 RID: 29033
		[Token(Token = "0x4007169")]
		[FieldOffset(Offset = "0x460")]
		public List<string> bannedRoguelikeCopperGild;

		// Token: 0x0400716A RID: 29034
		[Token(Token = "0x400716A")]
		[FieldOffset(Offset = "0x468")]
		public List<string> bannedRoguelikeWrathGroup;

		// Token: 0x0400716B RID: 29035
		[Token(Token = "0x400716B")]
		[FieldOffset(Offset = "0x470")]
		public List<string> bannedRoguelikeActivity;

		// Token: 0x0400716C RID: 29036
		[Token(Token = "0x400716C")]
		[FieldOffset(Offset = "0x478")]
		public List<string> bannedSpecialOperatorBgIdList;

		// Token: 0x0400716D RID: 29037
		[Token(Token = "0x400716D")]
		[FieldOffset(Offset = "0x480")]
		public List<string> bannedSpecialOperatorBgEffectIdList;

		// Token: 0x0400716E RID: 29038
		[Token(Token = "0x400716E")]
		[FieldOffset(Offset = "0x488")]
		public List<string> bannedSpecialOperatorCharEffectIdList;

		// Token: 0x0400716F RID: 29039
		[Token(Token = "0x400716F")]
		[FieldOffset(Offset = "0x490")]
		public List<string> bannedSpecialOperatorTypeIconIdList;

		// Token: 0x04007170 RID: 29040
		[Token(Token = "0x4007170")]
		[FieldOffset(Offset = "0x498")]
		public bool isSandboxPermBanned;

		// Token: 0x04007171 RID: 29041
		[Token(Token = "0x4007171")]
		[FieldOffset(Offset = "0x499")]
		public bool isSandboxV2Banned;

		// Token: 0x04007172 RID: 29042
		[Token(Token = "0x4007172")]
		[FieldOffset(Offset = "0x4A0")]
		public List<string> bannedSandboxItemList;

		// Token: 0x04007173 RID: 29043
		[Token(Token = "0x4007173")]
		[FieldOffset(Offset = "0x4A8")]
		public List<string> bannedSandboxEntryList;

		// Token: 0x04007174 RID: 29044
		[Token(Token = "0x4007174")]
		[FieldOffset(Offset = "0x4B0")]
		public List<string> bannedSandboxV2List;

		// Token: 0x04007175 RID: 29045
		[Token(Token = "0x4007175")]
		[FieldOffset(Offset = "0x4B8")]
		public List<string> bannedAVGCGs;

		// Token: 0x04007176 RID: 29046
		[Token(Token = "0x4007176")]
		[FieldOffset(Offset = "0x4C0")]
		public List<string> bannedDynamicOnlySkin;

		// Token: 0x04007177 RID: 29047
		[Token(Token = "0x4007177")]
		[FieldOffset(Offset = "0x4C8")]
		public List<string> bannedTowerIds;

		// Token: 0x04007178 RID: 29048
		[Token(Token = "0x4007178")]
		[FieldOffset(Offset = "0x4D0")]
		public List<string> bannedTowerSeasonIds;

		// Token: 0x04007179 RID: 29049
		[Token(Token = "0x4007179")]
		[FieldOffset(Offset = "0x4D8")]
		public List<string> bannedTowerGodCardIds;

		// Token: 0x0400717A RID: 29050
		[Token(Token = "0x400717A")]
		[FieldOffset(Offset = "0x4E0")]
		public List<string> bannedGuidebooks;

		// Token: 0x0400717B RID: 29051
		[Token(Token = "0x400717B")]
		[FieldOffset(Offset = "0x4E8")]
		public List<string> bannedPlayerAvatarIds;

		// Token: 0x0400717C RID: 29052
		[Token(Token = "0x400717C")]
		[FieldOffset(Offset = "0x4F0")]
		public List<string> bannedPlayerAvatarLimit;

		// Token: 0x0400717D RID: 29053
		[Token(Token = "0x400717D")]
		[FieldOffset(Offset = "0x4F8")]
		public bool isDeepSeaRPBanned;

		// Token: 0x0400717E RID: 29054
		[Token(Token = "0x400717E")]
		[FieldOffset(Offset = "0x500")]
		public List<string> bannedDeepSeaRPPic;

		// Token: 0x0400717F RID: 29055
		[Token(Token = "0x400717F")]
		[FieldOffset(Offset = "0x508")]
		public List<string> bannedDeepSeaRPSpecialPic;

		// Token: 0x04007180 RID: 29056
		[Token(Token = "0x4007180")]
		[FieldOffset(Offset = "0x510")]
		public List<string> voiceBasicChars;

		// Token: 0x04007181 RID: 29057
		[Token(Token = "0x4007181")]
		[FieldOffset(Offset = "0x518")]
		public List<string> validActfunActs;

		// Token: 0x04007182 RID: 29058
		[Token(Token = "0x4007182")]
		[FieldOffset(Offset = "0x520")]
		public bool isCampSweepBanned;

		// Token: 0x04007183 RID: 29059
		[Token(Token = "0x4007183")]
		[FieldOffset(Offset = "0x521")]
		public bool isClassicGachaBanned;

		// Token: 0x04007184 RID: 29060
		[Token(Token = "0x4007184")]
		[FieldOffset(Offset = "0x522")]
		public bool isSpecialGachaBanned;

		// Token: 0x04007185 RID: 29061
		[Token(Token = "0x4007185")]
		[FieldOffset(Offset = "0x523")]
		public bool isGachaLogEntryBanned;

		// Token: 0x04007186 RID: 29062
		[Token(Token = "0x4007186")]
		[FieldOffset(Offset = "0x524")]
		public bool isRhineAreaResearchBanned;

		// Token: 0x04007187 RID: 29063
		[Token(Token = "0x4007187")]
		[FieldOffset(Offset = "0x525")]
		public bool isGroceryBanned;

		// Token: 0x04007188 RID: 29064
		[Token(Token = "0x4007188")]
		[FieldOffset(Offset = "0x526")]
		public bool isTuningBanned;

		// Token: 0x04007189 RID: 29065
		[Token(Token = "0x4007189")]
		[FieldOffset(Offset = "0x527")]
		public bool isCrisisV2Banned;

		// Token: 0x0400718A RID: 29066
		[Token(Token = "0x400718A")]
		[FieldOffset(Offset = "0x528")]
		public bool isRecalRuneBanned;

		// Token: 0x0400718B RID: 29067
		[Token(Token = "0x400718B")]
		[FieldOffset(Offset = "0x530")]
		public List<string> bannedRecalRuneRuneIcons;

		// Token: 0x0400718C RID: 29068
		[Token(Token = "0x400718C")]
		[FieldOffset(Offset = "0x538")]
		public List<string> bannedRecalRuneCampLogos;

		// Token: 0x0400718D RID: 29069
		[Token(Token = "0x400718D")]
		[FieldOffset(Offset = "0x540")]
		public List<string> bannedRecalRuneSeasons;

		// Token: 0x0400718E RID: 29070
		[Token(Token = "0x400718E")]
		[FieldOffset(Offset = "0x548")]
		public bool isSpecialOperatorBanned;

		// Token: 0x0400718F RID: 29071
		[Token(Token = "0x400718F")]
		[FieldOffset(Offset = "0x550")]
		public List<string> bannedNameCardSkinIds;

		// Token: 0x04007190 RID: 29072
		[Token(Token = "0x4007190")]
		[FieldOffset(Offset = "0x558")]
		public List<string> bannedNameCardModuleIds;

		// Token: 0x04007191 RID: 29073
		[Token(Token = "0x4007191")]
		[FieldOffset(Offset = "0x560")]
		public List<string> bannedEmoticonThemeIds;

		// Token: 0x04007192 RID: 29074
		[Token(Token = "0x4007192")]
		[FieldOffset(Offset = "0x568")]
		public List<string> bannedEmoticonEmojiPicIds;

		// Token: 0x04007193 RID: 29075
		[Token(Token = "0x4007193")]
		[FieldOffset(Offset = "0x570")]
		public List<string> bannedMissionArchiveTopics;

		// Token: 0x04007194 RID: 29076
		[Token(Token = "0x4007194")]
		[FieldOffset(Offset = "0x578")]
		public List<string> bannedTrainingCampStageIconIds;

		// Token: 0x04007195 RID: 29077
		[Token(Token = "0x4007195")]
		[FieldOffset(Offset = "0x580")]
		public bool isCarvingBanned;

		// Token: 0x04007196 RID: 29078
		[Token(Token = "0x4007196")]
		[FieldOffset(Offset = "0x581")]
		public bool isFireworkBanned;

		// Token: 0x04007197 RID: 29079
		[Token(Token = "0x4007197")]
		[FieldOffset(Offset = "0x582")]
		public bool isGunTaskBanned;

		// Token: 0x04007198 RID: 29080
		[Token(Token = "0x4007198")]
		[FieldOffset(Offset = "0x588")]
		public List<string> bannedShopGPTabIds;

		// Token: 0x04007199 RID: 29081
		[Token(Token = "0x4007199")]
		[FieldOffset(Offset = "0x590")]
		public List<string> bannedShopGPTabIconIds;

		// Token: 0x0400719A RID: 29082
		[Token(Token = "0x400719A")]
		[FieldOffset(Offset = "0x598")]
		public List<string> bannedShopGPTabMarkerIds;

		// Token: 0x0400719B RID: 29083
		[Token(Token = "0x400719B")]
		[FieldOffset(Offset = "0x5A0")]
		public List<string> InUseHotUpdateMetaVideoIds;

		// Token: 0x0400719C RID: 29084
		[Token(Token = "0x400719C")]
		[FieldOffset(Offset = "0x5A8")]
		public List<string> bannedHotUpdateMetaVideoIds;

		// Token: 0x0400719D RID: 29085
		[Token(Token = "0x400719D")]
		[FieldOffset(Offset = "0x5B0")]
		public List<string> bannedHotUpdateMetaPicIds;

		// Token: 0x0400719E RID: 29086
		[Token(Token = "0x400719E")]
		[FieldOffset(Offset = "0x5B8")]
		public List<string> bannedHotUpdateMetaPicIconIds;

		// Token: 0x0400719F RID: 29087
		[Token(Token = "0x400719F")]
		[FieldOffset(Offset = "0x5C0")]
		public List<string> bannedBuildingEmojiIds;

		// Token: 0x040071A0 RID: 29088
		[Token(Token = "0x40071A0")]
		[FieldOffset(Offset = "0x5C8")]
		public List<string> bannedMetaUIIds;

		// Token: 0x040071A1 RID: 29089
		[Token(Token = "0x40071A1")]
		[FieldOffset(Offset = "0x5D0")]
		public List<string> bannedLongTermCheckInImgIds;

		// Token: 0x040071A2 RID: 29090
		[Token(Token = "0x40071A2")]
		[FieldOffset(Offset = "0x5D8")]
		public List<string> bannedLipSyncBakedData;

		// Token: 0x040071A3 RID: 29091
		[Token(Token = "0x40071A3")]
		[FieldOffset(Offset = "0x5E0")]
		public List<string> bannedTemplateTrapDomainData;

		// Token: 0x040071A4 RID: 29092
		[Token(Token = "0x40071A4")]
		[FieldOffset(Offset = "0x5E8")]
		public bool isAutoChessSeasonBanned;

		// Token: 0x040071A5 RID: 29093
		[Token(Token = "0x40071A5")]
		[FieldOffset(Offset = "0x5F0")]
		public List<string> bannedAutoChessBandIconIds;

		// Token: 0x040071A6 RID: 29094
		[Token(Token = "0x40071A6")]
		[FieldOffset(Offset = "0x5F8")]
		public string targetPreMainMovie;

		// Token: 0x040071A7 RID: 29095
		[Token(Token = "0x40071A7")]
		[FieldOffset(Offset = "0x600")]
		public bool isDynAvatarBanned;

		// Token: 0x040071A8 RID: 29096
		[Token(Token = "0x40071A8")]
		[FieldOffset(Offset = "0x608")]
		public List<string> bannedDynAvatarIds;

		// Token: 0x040071A9 RID: 29097
		[Token(Token = "0x40071A9")]
		[FieldOffset(Offset = "0x610")]
		public bool isSoCharMissionBanned;

		// Token: 0x040071AA RID: 29098
		[Token(Token = "0x40071AA")]
		[FieldOffset(Offset = "0x611")]
		public bool isInformantBanned;

		// Token: 0x040071AB RID: 29099
		[Token(Token = "0x40071AB")]
		[FieldOffset(Offset = "0x612")]
		public bool isMonopolyBanned;

		// Token: 0x040071AC RID: 29100
		[Token(Token = "0x40071AC")]
		[FieldOffset(Offset = "0x618")]
		public List<string> bannedArtGalleryCollectSetPics;

		// Token: 0x040071AD RID: 29101
		[Token(Token = "0x40071AD")]
		[FieldOffset(Offset = "0x620")]
		public List<string> bannedArtGalleryCollectTypePics;

		// Token: 0x040071AE RID: 29102
		[Token(Token = "0x40071AE")]
		[FieldOffset(Offset = "0x628")]
		public List<string> bannedExtraHomeThemePreviewPics;

		// Token: 0x040071AF RID: 29103
		[Token(Token = "0x40071AF")]
		[FieldOffset(Offset = "0x630")]
		public List<string> bannedExtraHomeBgPreviewPics;

		// Token: 0x040071B0 RID: 29104
		[Token(Token = "0x40071B0")]
		[FieldOffset(Offset = "0x638")]
		public List<string> bannedArtMagazineStickerIds;

		// Token: 0x040071B1 RID: 29105
		[Token(Token = "0x40071B1")]
		[FieldOffset(Offset = "0x640")]
		public List<string> bannedArtMagazineLeafIds;

		// Token: 0x040071B2 RID: 29106
		[Token(Token = "0x40071B2")]
		[FieldOffset(Offset = "0x648")]
		public List<string> bannedArtMagazineLeafTypeIcons;

		// Token: 0x040071B3 RID: 29107
		[Token(Token = "0x40071B3")]
		[FieldOffset(Offset = "0x650")]
		public List<string> bannedHomeBackgroundDecorIds;

		// Token: 0x040071B4 RID: 29108
		[Token(Token = "0x40071B4")]
		[FieldOffset(Offset = "0x658")]
		public List<string> bannedHomeThemeDecorIds;

		// Token: 0x040071B5 RID: 29109
		[Token(Token = "0x40071B5")]
		[FieldOffset(Offset = "0x660")]
		public List<string> bannedNameCardSkinDecorIds;
	}
}
