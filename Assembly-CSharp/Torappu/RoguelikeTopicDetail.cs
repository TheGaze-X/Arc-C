using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011D9 RID: 4569
	[Token(Token = "0x20011D9")]
	public class RoguelikeTopicDetail
	{
		// Token: 0x06006FBD RID: 28605 RVA: 0x00032838 File Offset: 0x00030A38
		[Token(Token = "0x6006FBD")]
		[Address(RVA = "0x2112FE0", Offset = "0x2111BE0", VA = "0x182112FE0")]
		public bool ShouldSerializestyles()
		{
			return default(bool);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00032850 File Offset: 0x00030A50
		[Token(Token = "0x6006FBE")]
		[Address(RVA = "0x2112FD0", Offset = "0x2111BD0", VA = "0x182112FD0")]
		public bool ShouldSerializestyleConfig()
		{
			return default(bool);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x00032868 File Offset: 0x00030A68
		[Token(Token = "0x6006FBF")]
		[Address(RVA = "0x2112F30", Offset = "0x2111B30", VA = "0x182112F30")]
		public bool ShouldSerializeexploreTools()
		{
			return default(bool);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x00032880 File Offset: 0x00030A80
		[Token(Token = "0x6006FC0")]
		[Address(RVA = "0x2112F80", Offset = "0x2111B80", VA = "0x182112F80")]
		public bool ShouldSerializerelicTipsData()
		{
			return default(bool);
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC1")]
		[Address(RVA = "0x2113030", Offset = "0x2111C30", VA = "0x182113030")]
		public RoguelikeTopicDetail()
		{
		}

		// Token: 0x040061E3 RID: 25059
		[Token(Token = "0x40061E3")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicUpdate> updates;

		// Token: 0x040061E4 RID: 25060
		[Token(Token = "0x40061E4")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeTopicEnroll> enrolls;

		// Token: 0x040061E5 RID: 25061
		[Token(Token = "0x40061E5")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeTopicBP> milestones;

		// Token: 0x040061E6 RID: 25062
		[Token(Token = "0x40061E6")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikeTopicMilestoneUpdateData> milestoneUpdates;

		// Token: 0x040061E7 RID: 25063
		[Token(Token = "0x40061E7")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeTopicBPGrandPrize> grandPrizes;

		// Token: 0x040061E8 RID: 25064
		[Token(Token = "0x40061E8")]
		[FieldOffset(Offset = "0x38")]
		public List<RoguelikeTopicMonthMission> monthMission;

		// Token: 0x040061E9 RID: 25065
		[Token(Token = "0x40061E9")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, RoguelikeTopicMonthSquad> monthSquad;

		// Token: 0x040061EA RID: 25066
		[Token(Token = "0x40061EA")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, RoguelikeTopicChallenge> challenges;

		// Token: 0x040061EB RID: 25067
		[Token(Token = "0x40061EB")]
		[FieldOffset(Offset = "0x50")]
		public List<RoguelikeTopicDifficulty> difficulties;

		// Token: 0x040061EC RID: 25068
		[Token(Token = "0x40061EC")]
		[FieldOffset(Offset = "0x58")]
		public List<RoguelikeTopicBankReward> bankRewards;

		// Token: 0x040061ED RID: 25069
		[Token(Token = "0x40061ED")]
		[FieldOffset(Offset = "0x60")]
		public RoguelikeArchiveComponentData archiveComp;

		// Token: 0x040061EE RID: 25070
		[Token(Token = "0x40061EE")]
		[FieldOffset(Offset = "0x68")]
		public RoguelikeArchiveUnlockCondData archiveUnlockCond;

		// Token: 0x040061EF RID: 25071
		[Token(Token = "0x40061EF")]
		[FieldOffset(Offset = "0x70")]
		public RoguelikeTopicDetailConst detailConst;

		// Token: 0x040061F0 RID: 25072
		[Token(Token = "0x40061F0")]
		[FieldOffset(Offset = "0x78")]
		public List<RoguelikeGameInitData> init;

		// Token: 0x040061F1 RID: 25073
		[Token(Token = "0x40061F1")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, RoguelikeGameStageData> stages;

		// Token: 0x040061F2 RID: 25074
		[Token(Token = "0x40061F2")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, RoguelikeGameZoneData> zones;

		// Token: 0x040061F3 RID: 25075
		[Token(Token = "0x40061F3")]
		[FieldOffset(Offset = "0x90")]
		public Dictionary<string, RoguelikeZoneVariationData> variation;

		// Token: 0x040061F4 RID: 25076
		[Token(Token = "0x40061F4")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, RoguelikeGameTrapData> traps;

		// Token: 0x040061F5 RID: 25077
		[Token(Token = "0x40061F5")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<string, RoguelikeGameRecruitTicketData> recruitTickets;

		// Token: 0x040061F6 RID: 25078
		[Token(Token = "0x40061F6")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, RoguelikeGameUpgradeTicketData> upgradeTickets;

		// Token: 0x040061F7 RID: 25079
		[Token(Token = "0x40061F7")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, RoguelikeGameCustomTicketData> customTickets;

		// Token: 0x040061F8 RID: 25080
		[Token(Token = "0x40061F8")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, RoguelikeGameStashableTicketData> stashableTickets;

		// Token: 0x040061F9 RID: 25081
		[Token(Token = "0x40061F9")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, RoguelikeGameRelicData> relics;

		// Token: 0x040061FA RID: 25082
		[Token(Token = "0x40061FA")]
		[FieldOffset(Offset = "0xC8")]
		public Dictionary<string, RoguelikeGameRelicParamData> relicParams;

		// Token: 0x040061FB RID: 25083
		[Token(Token = "0x40061FB")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<string, RoguelikeGameRecruitGrpData> recruitGrps;

		// Token: 0x040061FC RID: 25084
		[Token(Token = "0x40061FC")]
		[FieldOffset(Offset = "0xD8")]
		public Dictionary<string, RoguelikeGameChoiceData> choices;

		// Token: 0x040061FD RID: 25085
		[Token(Token = "0x40061FD")]
		[FieldOffset(Offset = "0xE0")]
		public Dictionary<string, RoguelikeGameChoiceSceneData> choiceScenes;

		// Token: 0x040061FE RID: 25086
		[Token(Token = "0x40061FE")]
		[FieldOffset(Offset = "0xE8")]
		public Dictionary<RoguelikeEventType, RoguelikeGameNodeTypeData> nodeTypeData;

		// Token: 0x040061FF RID: 25087
		[Token(Token = "0x40061FF")]
		[FieldOffset(Offset = "0xF0")]
		public List<RoguelikeGameNodeSubTypeData> subTypeData;

		// Token: 0x04006200 RID: 25088
		[Token(Token = "0x4006200")]
		[FieldOffset(Offset = "0xF8")]
		public Dictionary<string, RoguelikeGameVariationData> variationData;

		// Token: 0x04006201 RID: 25089
		[Token(Token = "0x4006201")]
		[FieldOffset(Offset = "0x100")]
		public Dictionary<string, RoguelikeGameFusionData> fusionData;

		// Token: 0x04006202 RID: 25090
		[Token(Token = "0x4006202")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<string, RoguelikeGameCharBuffData> charBuffData;

		// Token: 0x04006203 RID: 25091
		[Token(Token = "0x4006203")]
		[FieldOffset(Offset = "0x110")]
		public Dictionary<string, RoguelikeGameSquadBuffData> squadBuffData;

		// Token: 0x04006204 RID: 25092
		[Token(Token = "0x4006204")]
		[FieldOffset(Offset = "0x118")]
		public Dictionary<string, RoguelikeTaskData> taskData;

		// Token: 0x04006205 RID: 25093
		[Token(Token = "0x4006205")]
		[FieldOffset(Offset = "0x120")]
		public RoguelikeGameConst gameConst;

		// Token: 0x04006206 RID: 25094
		[Token(Token = "0x4006206")]
		[FieldOffset(Offset = "0x128")]
		public RoguelikeGameShopDialogData shopDialogData;

		// Token: 0x04006207 RID: 25095
		[Token(Token = "0x4006207")]
		[FieldOffset(Offset = "0x130")]
		public Dictionary<string, RoguelikeTopicCapsule> capsuleDict;

		// Token: 0x04006208 RID: 25096
		[Token(Token = "0x4006208")]
		[FieldOffset(Offset = "0x138")]
		public Dictionary<string, RoguelikeGameEndingData> endings;

		// Token: 0x04006209 RID: 25097
		[Token(Token = "0x4006209")]
		[FieldOffset(Offset = "0x140")]
		public Dictionary<string, RoguelikeGameFailEndingData> failEndings;

		// Token: 0x0400620A RID: 25098
		[Token(Token = "0x400620A")]
		[FieldOffset(Offset = "0x148")]
		public Dictionary<RoguelikeTopicMode, RoguelikeBattleSummeryDescriptionData> battleSummeryDescriptions;

		// Token: 0x0400620B RID: 25099
		[Token(Token = "0x400620B")]
		[FieldOffset(Offset = "0x150")]
		public List<TipData> battleLoadingTips;

		// Token: 0x0400620C RID: 25100
		[Token(Token = "0x400620C")]
		[FieldOffset(Offset = "0x158")]
		public Dictionary<string, RoguelikeGameItemData> items;

		// Token: 0x0400620D RID: 25101
		[Token(Token = "0x400620D")]
		[FieldOffset(Offset = "0x160")]
		public Dictionary<string, RoguelikeBandRefData> bandRef;

		// Token: 0x0400620E RID: 25102
		[Token(Token = "0x400620E")]
		[FieldOffset(Offset = "0x168")]
		public List<RoguelikeEndingDetailText> endingDetailList;

		// Token: 0x0400620F RID: 25103
		[Token(Token = "0x400620F")]
		[FieldOffset(Offset = "0x170")]
		public List<RoguelikeEndingRelicDetailText> endingRelicDetailList;

		// Token: 0x04006210 RID: 25104
		[Token(Token = "0x4006210")]
		[FieldOffset(Offset = "0x178")]
		public Dictionary<string, List<RoguelikeGameTreasureData>> treasures;

		// Token: 0x04006211 RID: 25105
		[Token(Token = "0x4006211")]
		[FieldOffset(Offset = "0x180")]
		public Dictionary<string, RoguelikeDifficultyUpgradeRelicGroupData> difficultyUpgradeRelicGroups;

		// Token: 0x04006212 RID: 25106
		[Token(Token = "0x4006212")]
		[FieldOffset(Offset = "0x188")]
		public Dictionary<string, RoguelikePredefinedStyleData> styles;

		// Token: 0x04006213 RID: 25107
		[Token(Token = "0x4006213")]
		[FieldOffset(Offset = "0x190")]
		public RoguelikePredefinedConstStyleData styleConfig;

		// Token: 0x04006214 RID: 25108
		[Token(Token = "0x4006214")]
		[FieldOffset(Offset = "0x198")]
		public Dictionary<string, RoguelikeGameExploreToolData> exploreTools;

		// Token: 0x04006215 RID: 25109
		[Token(Token = "0x4006215")]
		[FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, RoguelikeRollNodeData> rollNodeData;

		// Token: 0x04006216 RID: 25110
		[Token(Token = "0x4006216")]
		[FieldOffset(Offset = "0x1A8")]
		public Dictionary<string, RoguelikeRelicTipsData> relicTipsData;

		// Token: 0x04006217 RID: 25111
		[Token(Token = "0x4006217")]
		[FieldOffset(Offset = "0x1B0")]
		public RoguelikeActivityData activity;
	}
}
