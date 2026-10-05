using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.CharWord;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using Torappu.UI.Friend;
using Torappu.UI.Home;
using Torappu.UI.Shop;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02001401 RID: 5121
	[Token(Token = "0x2001401")]
	[Hotfix(HotfixFlag.Stateless)]
	[LuaCallCSharp(GenFlag.No)]
	public static class DataConvertUtil
	{
		// Token: 0x060075A3 RID: 30115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A3")]
		[Address(RVA = "0x2322410", Offset = "0x2321010", VA = "0x182322410")]
		public static ListDict<int, CharacterCardViewModel> LoadAllCharCards()
		{
			return null;
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A4")]
		[Address(RVA = "0x231C280", Offset = "0x231AE80", VA = "0x18231C280")]
		public static CharacterCardViewModel CreateFakeCardView(SharedCharData sharedCharData, bool needPotenialRank = false)
		{
			return null;
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A5")]
		[Address(RVA = "0x23226C0", Offset = "0x23212C0", VA = "0x1823226C0")]
		public static HashSet<int> LoadAllCharsInSquads()
		{
			return null;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A6")]
		[Address(RVA = "0x2318DD0", Offset = "0x23179D0", VA = "0x182318DD0")]
		public static CharacterCardViewModel AchieveCharCard(int instId)
		{
			return null;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A7")]
		[Address(RVA = "0x2318F70", Offset = "0x2317B70", VA = "0x182318F70")]
		public static CharacterCardViewModel AchieveCharCard(string instId)
		{
			return null;
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A8")]
		[Address(RVA = "0x2320320", Offset = "0x231EF20", VA = "0x182320320")]
		public static string GetRespawnTimeDesc(int respawnTime)
		{
			return null;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A9")]
		[Address(RVA = "0x231CC00", Offset = "0x231B800", VA = "0x18231CC00")]
		public static string GetAttackSpeedDesc(AttributesData attr)
		{
			return null;
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AA")]
		[Address(RVA = "0x231E6A0", Offset = "0x231D2A0", VA = "0x18231E6A0")]
		public static string GetHandBookStageStatusDesc(CharacterHandbookStageStatus status)
		{
			return null;
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00034C80 File Offset: 0x00032E80
		[Token(Token = "0x60075AB")]
		[Address(RVA = "0x231B850", Offset = "0x231A450", VA = "0x18231B850")]
		public static bool CheckHaveBuyApRemainTimes()
		{
			return default(bool);
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AC")]
		[Address(RVA = "0x2320570", Offset = "0x231F170", VA = "0x182320570")]
		public static string GetSkillIconId(ISkillData skillData)
		{
			return null;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AD")]
		[Address(RVA = "0x2320400", Offset = "0x231F000", VA = "0x182320400")]
		public static SkillData GetSkillData(string skillID, int skillAllLvl, int skillSpecialLvl)
		{
			return null;
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AE")]
		[Address(RVA = "0x2320640", Offset = "0x231F240", VA = "0x182320640")]
		public static CharacterData.MainSkill GetSkillMainData(string skillId, CharacterData charData)
		{
			return null;
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00034C98 File Offset: 0x00032E98
		[Token(Token = "0x60075AF")]
		[Address(RVA = "0x2320270", Offset = "0x231EE70", VA = "0x182320270")]
		public static bool GetREPShopOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B0")]
		[Address(RVA = "0x231D120", Offset = "0x231BD20", VA = "0x18231D120")]
		public static string GetChooseGPPackageIdWithDefault(string optionId, string defaultValue = "")
		{
			return null;
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00034CB0 File Offset: 0x00032EB0
		[Token(Token = "0x60075B1")]
		[Address(RVA = "0x231B9E0", Offset = "0x231A5E0", VA = "0x18231B9E0")]
		public static bool CheckIsGPOption(string optionId, out int buyCount)
		{
			return default(bool);
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0x2326F30", Offset = "0x2325B30", VA = "0x182326F30")]
		public static List<SkillTagViewModel> LoadSkillTags(string skillId, int skillLvl)
		{
			return null;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B3")]
		[Address(RVA = "0x2324410", Offset = "0x2323010", VA = "0x182324410")]
		public static MissionData LoadMissionData(string missionID)
		{
			return null;
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B4")]
		[Address(RVA = "0x23244E0", Offset = "0x23230E0", VA = "0x1823244E0")]
		public static MissionGroup LoadMissionGroup(string missionID)
		{
			return null;
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B5")]
		[Address(RVA = "0x2324340", Offset = "0x2322F40", VA = "0x182324340")]
		public static MissionDailyRewardConf LoadMissionDailyReward(string dailyId)
		{
			return null;
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B6")]
		[Address(RVA = "0x23245B0", Offset = "0x23231B0", VA = "0x1823245B0")]
		public static MissionWeeklyRewardConf LoadMissionWeeklyReward(string weeklyId)
		{
			return null;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00034CC8 File Offset: 0x00032EC8
		[Token(Token = "0x60075B7")]
		[Address(RVA = "0x231EC90", Offset = "0x231D890", VA = "0x18231EC90")]
		public static MissionHoldingState GetMissionState(MissionType type, string missionId)
		{
			return MissionHoldingState.NOT_OPEN;
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x23269C0", Offset = "0x23255C0", VA = "0x1823269C0")]
		public static void LoadSkillTags(string skillId, int skillLvl, ref List<SkillTagViewModel> tagList)
		{
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B9")]
		[Address(RVA = "0x2328DC0", Offset = "0x23279C0", VA = "0x182328DC0")]
		public static string LoadUnlockTextByUnlockCondition(CharacterData.UnlockCondition unlockParam)
		{
			return null;
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075BA")]
		[Address(RVA = "0x2326FB0", Offset = "0x2325BB0", VA = "0x182326FB0")]
		public static string LoadSkillUnlockCondition(CharQuery charQuery, string skillId, int skillLvl)
		{
			return null;
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x00034CE0 File Offset: 0x00032EE0
		[Token(Token = "0x60075BB")]
		[Address(RVA = "0x2327140", Offset = "0x2325D40", VA = "0x182327140")]
		public static EvolvePhase LoadSkillUnlockPhase(CharQuery charQuery, string skillId, int skillLvl)
		{
			return EvolvePhase.PHASE_0;
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x00034CF8 File Offset: 0x00032EF8
		[Token(Token = "0x60075BC")]
		[Address(RVA = "0x2319F70", Offset = "0x2318B70", VA = "0x182319F70")]
		public static long AchieveEvolveRequireGold(RarityRank rarity, EvolvePhase currentPhase)
		{
			return 0L;
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075BD")]
		[Address(RVA = "0x2321A30", Offset = "0x2320630", VA = "0x182321A30")]
		public static string GetTeamIconId(string powerId)
		{
			return null;
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075BE")]
		[Address(RVA = "0x231F500", Offset = "0x231E100", VA = "0x18231F500")]
		public static string GetPowerLogoId(string powerId, bool isOverride = false)
		{
			return null;
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075BF")]
		[Address(RVA = "0x231FAA0", Offset = "0x231E6A0", VA = "0x18231FAA0")]
		public static string GetProfessionIconId(ProfessionCategory profession, bool largeFlag = false, bool isWhite = false)
		{
			return null;
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075C0")]
		[Address(RVA = "0x231FC80", Offset = "0x231E880", VA = "0x18231FC80")]
		public static string GetProfessionName(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075C1")]
		[Address(RVA = "0x2320DE0", Offset = "0x231F9E0", VA = "0x182320DE0")]
		public static string GetSortTypeIconId(CharacterSortType sortType)
		{
			return null;
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075C2")]
		[Address(RVA = "0x231DCE0", Offset = "0x231C8E0", VA = "0x18231DCE0")]
		public static int[][] GetExpMapFromCharData(string charId, CharacterData charData)
		{
			return null;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x00034D10 File Offset: 0x00032F10
		[Token(Token = "0x60075C3")]
		[Address(RVA = "0x231A490", Offset = "0x2319090", VA = "0x18231A490")]
		public static int AchieveUplevelExp(int evolvePhase, int level, string charId, CharacterData charData)
		{
			return 0;
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x00034D28 File Offset: 0x00032F28
		[Token(Token = "0x60075C4")]
		[Address(RVA = "0x231A120", Offset = "0x2318D20", VA = "0x18231A120")]
		public static long AchieveGoldPerLevel(EvolvePhase evolvePhase, int level)
		{
			return 0L;
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x00034D40 File Offset: 0x00032F40
		[Token(Token = "0x60075C5")]
		[Address(RVA = "0x2321E30", Offset = "0x2320A30", VA = "0x182321E30")]
		public static bool HandleExaminResponseBool(ExaminResponse resp)
		{
			return default(bool);
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C6")]
		[Address(RVA = "0x2321CB0", Offset = "0x23208B0", VA = "0x182321CB0")]
		public static void HandleExaminRespone(ExaminResponse resp, Action onSuccess)
		{
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075C7")]
		[Address(RVA = "0x2321F70", Offset = "0x2320B70", VA = "0x182321F70")]
		public static void HandleNickNameExaminRespone(ExaminResponse resp, Action onSuccess)
		{
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00034D58 File Offset: 0x00032F58
		[Token(Token = "0x60075C8")]
		[Address(RVA = "0x231A2E0", Offset = "0x2318EE0", VA = "0x18231A2E0")]
		public static int AchieveMaxLevel(RarityRank rarity, EvolvePhase evolvePhase)
		{
			return 0;
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00034D70 File Offset: 0x00032F70
		[Token(Token = "0x60075C9")]
		[Address(RVA = "0x231A650", Offset = "0x2319250", VA = "0x18231A650")]
		public static int AchieveUplevelExp(EvolvePhase evolvePhase, int curLevel, string charId, CharacterData charData)
		{
			return 0;
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CA")]
		[Address(RVA = "0x2318190", Offset = "0x2316D90", VA = "0x182318190")]
		public static AttributesData AchieveCharAttributes(PlayerCharacter playerChar, int targetLevel)
		{
			return null;
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CB")]
		[Address(RVA = "0x23185C0", Offset = "0x23171C0", VA = "0x1823185C0")]
		public static AttributesData AchieveCharAttributes(CharQuery charQuery, EvolvePhase evolvePhase, int potentialRank, int level, int favorPoint, List<CharacterData.UniqueEquipPair> equipQueries)
		{
			return null;
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CC")]
		[Address(RVA = "0x23189F0", Offset = "0x23175F0", VA = "0x1823189F0")]
		public static AttributesData AchieveCharAttributes(CharacterData charData, string charId, EvolvePhase evolvePhase, int potentialRank, int level, int favorPoint, List<CharacterData.UniqueEquipPair> equipQueries, bool isToken = false)
		{
			return null;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075CD")]
		[Address(RVA = "0x2322E90", Offset = "0x2321A90", VA = "0x182322E90")]
		public static LevelData.PredefinedData LoadComposeHardPredefine(LevelData levelData)
		{
			return null;
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00034D88 File Offset: 0x00032F88
		[Token(Token = "0x60075CE")]
		[Address(RVA = "0x232BC80", Offset = "0x232A880", VA = "0x18232BC80")]
		private static bool _LoadNecessaryDataFromStage(string stageId, out StageData stageData, out LevelData levelData, out bool isPredefinedLevel)
		{
			return default(bool);
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075CF")]
		[Address(RVA = "0x2324A40", Offset = "0x2323640", VA = "0x182324A40")]
		public static void LoadNecessaryDataFromStage(string stageId, out List<CharacterCardViewModel> predefinedSquad, out StageData stageData, out LevelData levelData, out bool isPredefinedLevel)
		{
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075D0")]
		[Address(RVA = "0x2324950", Offset = "0x2323550", VA = "0x182324950")]
		public static void LoadNecessaryDataFromStageWithPlayerCharSquad(string stageId, out List<PlayerCharacter> predefinedSquad, out StageData stageData, out LevelData levelData, out bool isPredefinedLevel)
		{
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075D1")]
		[Address(RVA = "0x23217D0", Offset = "0x23203D0", VA = "0x1823217D0")]
		public static void GetStartButtonTypeByStageData(StageData stageData, bool isPractice, out SquadStartButtonTypeEnum startButtonMode, out string startButtonOverrideId)
		{
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D2")]
		[Address(RVA = "0x232C0A0", Offset = "0x232ACA0", VA = "0x18232C0A0")]
		private static List<PlayerCharacter> _LoadStagePredefinedSquad(LevelData levelData, bool isHard)
		{
			return null;
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D3")]
		[Address(RVA = "0x232C630", Offset = "0x232B230", VA = "0x18232C630")]
		private static List<CharacterCardViewModel> _ParsePredefinedChar(List<PlayerCharacter> predefinedChars)
		{
			return null;
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D4")]
		[Address(RVA = "0x231BD40", Offset = "0x231A940", VA = "0x18231BD40")]
		public static BattlePlayerData CreateBattlePlayerData(BattleStartController.BattleStartOption option)
		{
			return null;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D5")]
		[Address(RVA = "0x232A780", Offset = "0x2329380", VA = "0x18232A780")]
		private static List<AdvancedCharacterInst> _GenBattleSlotsWithLevelData(SquadItemStruct[] squadSlots, LevelData levelData)
		{
			return null;
		}

		// Token: 0x060075D6 RID: 30166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D6")]
		[Address(RVA = "0x232A9D0", Offset = "0x23295D0", VA = "0x18232A9D0")]
		private static List<AdvancedCharacterInst> _GenBattleSlotsWithPlayerData(SquadItemStruct[] squadSlots, PlayerDataModel playerModel, List<BattleLogger.CharInfo> squad, bool isAutoBattle)
		{
			return null;
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D7")]
		[Address(RVA = "0x232B280", Offset = "0x2329E80", VA = "0x18232B280")]
		private static AdvancedCharacterInst _GenCharInstWithSlotData(SquadItemStruct slot)
		{
			return null;
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075D8")]
		[Address(RVA = "0x232ABD0", Offset = "0x23297D0", VA = "0x18232ABD0")]
		private static AdvancedCharacterInst _GenCharInstWithPlayerData(SquadItemStruct slot, PlayerDataModel playerModel, List<BattleLogger.CharInfo> squad, bool isAutoBattle)
		{
			return null;
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x00034DA0 File Offset: 0x00032FA0
		[Token(Token = "0x60075D9")]
		[Address(RVA = "0x232C7F0", Offset = "0x232B3F0", VA = "0x18232C7F0")]
		private static bool _TryGetCharInfo(List<BattleLogger.CharInfo> squad, int chrInstId, out BattleLogger.CharInfo info)
		{
			return default(bool);
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DA")]
		[Address(RVA = "0x231C4E0", Offset = "0x231B0E0", VA = "0x18231C4E0")]
		public static LevelData.PredefinedData.PredefinedCharacter CreatePredefinedTokenInst(Blackboard blackboard, GridPosition position, SharedConsts.Direction direction)
		{
			return null;
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DB")]
		public static T CreateTokenInst<T>(Blackboard blackboard) where T : AdvancedCharacterInst, new()
		{
			return null;
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DC")]
		[Address(RVA = "0x232A250", Offset = "0x2328E50", VA = "0x18232A250")]
		private static ListDict<string, PlayerCharEquipInfo> _AchievePredefinedCardEquipInfo(LevelData.PredefinedData.PredefinedCard card, out string equipId)
		{
			return null;
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00034DB8 File Offset: 0x00032FB8
		[Token(Token = "0x60075DD")]
		[Address(RVA = "0x2319090", Offset = "0x2317C90", VA = "0x182319090")]
		public static AttackRangeDescModel AchieveCharacterAttackRange(AdvancedCharacterInst inst, [Optional] Character inputCharOrNull, bool notLoadFromResource = false, bool isToken = false)
		{
			return default(AttackRangeDescModel);
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075DE")]
		[Address(RVA = "0x232B6C0", Offset = "0x232A2C0", VA = "0x18232B6C0")]
		private static string _GetFirstEquipTalentRangeId(CharacterData.PhaseData phaseData, int level, EvolvePhase phase, int potential, CharacterData.UniqueEquipPair[] queries, bool isToken)
		{
			return null;
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x00034DD0 File Offset: 0x00032FD0
		[Token(Token = "0x60075DF")]
		[Address(RVA = "0x2329200", Offset = "0x2327E00", VA = "0x182329200")]
		public static AttackRangeDescModel TryGetAttackRangeFromRangeId(string rangeId)
		{
			return default(AttackRangeDescModel);
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E0")]
		[Address(RVA = "0x231C940", Offset = "0x231B540", VA = "0x18231C940")]
		public static string FindGachaTagContentById(int tagId)
		{
			return null;
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E1")]
		[Address(RVA = "0x231C710", Offset = "0x231B310", VA = "0x18231C710")]
		public static string FindClassicGachaIdByPickTier(ItemBundle item)
		{
			return null;
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E2")]
		[Address(RVA = "0x23231E0", Offset = "0x2321DE0", VA = "0x1823231E0")]
		public static ItemBundle LoadFesGachaItemIfAvail(ItemBundle item)
		{
			return null;
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E3")]
		[Address(RVA = "0x23250C0", Offset = "0x2323CC0", VA = "0x1823250C0")]
		public static Sprite LoadPlayerCharAvatar(string charId)
		{
			return null;
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E4")]
		[Address(RVA = "0x2323970", Offset = "0x2322570", VA = "0x182323970")]
		public static Sprite LoadHomeBackgroundBlurImg(string bgId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E5")]
		[Address(RVA = "0x231AC40", Offset = "0x2319840", VA = "0x18231AC40")]
		public static Sprite CalcHomeBackgroundBlurImg(string bgId, HomeBackgroundAssetsWrapper assets)
		{
			return null;
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E6")]
		[Address(RVA = "0x231CD90", Offset = "0x231B990", VA = "0x18231CD90")]
		public static string GetBackgroundMusicId(string bgId)
		{
			return null;
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E7")]
		[Address(RVA = "0x231C5B0", Offset = "0x231B1B0", VA = "0x18231C5B0")]
		public static BackgroundFormAssetWrapper FindBgFormWrapper(string displayId, HomeBackgroundAssetsWrapper asset)
		{
			return null;
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E8")]
		[Address(RVA = "0x231D440", Offset = "0x231C040", VA = "0x18231D440")]
		public static string GetCurrentHomeBackgroundId()
		{
			return null;
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075E9")]
		[Address(RVA = "0x231E3E0", Offset = "0x231CFE0", VA = "0x18231E3E0")]
		public static Sprite GetGiftPackageSprite(string spriteId)
		{
			return null;
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EA")]
		[Address(RVA = "0x231E4F0", Offset = "0x231D0F0", VA = "0x18231E4F0")]
		public static Sprite GetGiftPackageSprite(string giftPackageId, bool isBack)
		{
			return null;
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EB")]
		[Address(RVA = "0x231F890", Offset = "0x231E490", VA = "0x18231F890")]
		public static Sprite GetPriceSprite(SpriteHub hub, UIItemViewModel item, bool isWhite)
		{
			return null;
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EC")]
		[Address(RVA = "0x232B9D0", Offset = "0x232A5D0", VA = "0x18232B9D0")]
		private static string _GetPriceTypeSpriteId(string itemIconId, bool isWhite)
		{
			return null;
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075ED")]
		[Address(RVA = "0x231D090", Offset = "0x231BC90", VA = "0x18231D090")]
		public static Sprite GetCashSprite(SpriteHub hub, bool isWhite)
		{
			return null;
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EE")]
		[Address(RVA = "0x231D2C0", Offset = "0x231BEC0", VA = "0x18231D2C0")]
		public static Sprite GetCoinFurnSprite(SpriteHub spriteHub, bool isWhite)
		{
			return null;
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EF")]
		[Address(RVA = "0x231F710", Offset = "0x231E310", VA = "0x18231F710")]
		public static Sprite GetPriceSpriteByItemType(SpriteHub hub, ItemType itemType, bool isWhite)
		{
			return null;
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F0")]
		[Address(RVA = "0x232B8C0", Offset = "0x232A4C0", VA = "0x18232B8C0")]
		private static Sprite _GetPriceSpriteByIconId(SpriteHub hub, string itemIconId, bool isWhite)
		{
			return null;
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F1")]
		[Address(RVA = "0x231D690", Offset = "0x231C290", VA = "0x18231D690")]
		public static Sprite GetEPGSCoinSprite(bool isWhite)
		{
			return null;
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0x231E830", Offset = "0x231D430", VA = "0x18231E830")]
		public static Sprite GetLMTGSCoinSprite()
		{
			return null;
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F3")]
		[Address(RVA = "0x232BEE0", Offset = "0x232AAE0", VA = "0x18232BEE0")]
		private static Sprite _LoadPlayerCharAvatar(PlayerCharacter playerChar, bool isSelf)
		{
			return null;
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0x232BC00", Offset = "0x232A800", VA = "0x18232BC00")]
		private static Sprite _LoadCharacterAvatar(string avatarId)
		{
			return null;
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F5")]
		[Address(RVA = "0x2323170", Offset = "0x2321D70", VA = "0x182323170")]
		public static Sprite LoadEnemyIcon(string enemyId)
		{
			return null;
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F6")]
		[Address(RVA = "0x2322930", Offset = "0x2321530", VA = "0x182322930")]
		public static string LoadAttackTypeName(SourceApplyWay type)
		{
			return null;
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F7")]
		[Address(RVA = "0x2324680", Offset = "0x2323280", VA = "0x182324680")]
		public static string LoadMotionTypeText(MotionMode mode)
		{
			return null;
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F8")]
		[Address(RVA = "0x2322FE0", Offset = "0x2321BE0", VA = "0x182322FE0")]
		public static string LoadDamageTypeName(EnemyHandBookDamageType type)
		{
			return null;
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F9")]
		[Address(RVA = "0x231A810", Offset = "0x2319410", VA = "0x18231A810")]
		public static string BuildAttackDamageText(EnemyHandBookEverViewModel viewModel)
		{
			return null;
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FA")]
		[Address(RVA = "0x23234F0", Offset = "0x23220F0", VA = "0x1823234F0")]
		public static Sprite LoadGachaDetailCharBack(RarityRank rarityRank, bool isSmall = true)
		{
			return null;
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FB")]
		[Address(RVA = "0x2323750", Offset = "0x2322350", VA = "0x182323750")]
		public static Sprite LoadGachaDetailStar(RarityRank rarityRank)
		{
			return null;
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FC")]
		[Address(RVA = "0x2326000", Offset = "0x2324C00", VA = "0x182326000")]
		public static Sprite LoadRarityIcon(RarityRank rarity, bool isBlack = false)
		{
			return null;
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FD")]
		[Address(RVA = "0x2325830", Offset = "0x2324430", VA = "0x182325830")]
		public static Sprite LoadPureBlackRarityIcon(RarityRank rarity, ILoadAsset asset)
		{
			return null;
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FE")]
		[Address(RVA = "0x2325E30", Offset = "0x2324A30", VA = "0x182325E30")]
		public static Sprite LoadRarityIconTight(RarityRank rarity)
		{
			return null;
		}

		// Token: 0x060075FF RID: 30207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FF")]
		[Address(RVA = "0x2323C20", Offset = "0x2322820", VA = "0x182323C20")]
		public static Sprite LoadLeftJustifyRarityIcon(RarityRank rarity)
		{
			return null;
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007600")]
		[Address(RVA = "0x2328F50", Offset = "0x2327B50", VA = "0x182328F50")]
		public static Sprite LoadYellowRarityIcon(RarityRank rarity)
		{
			return null;
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007601")]
		[Address(RVA = "0x23268C0", Offset = "0x23254C0", VA = "0x1823268C0")]
		public static Sprite LoadSkillIcon(string skillId)
		{
			return null;
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007602")]
		[Address(RVA = "0x2326680", Offset = "0x2325280", VA = "0x182326680")]
		public static Sprite LoadSkillIcon(ISkillData skillData)
		{
			return null;
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007603")]
		[Address(RVA = "0x2326550", Offset = "0x2325150", VA = "0x182326550")]
		public static Sprite LoadSkillIconByIconId(string iconId)
		{
			return null;
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007604")]
		[Address(RVA = "0x2325300", Offset = "0x2323F00", VA = "0x182325300")]
		public static Dictionary<int, UIExpBarController.LevelModel> LoadPlayerExpMap()
		{
			return null;
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007605")]
		[Address(RVA = "0x231DC70", Offset = "0x231C870", VA = "0x18231DC70")]
		public static string GetEnemyIconId(string enemyId)
		{
			return null;
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007606")]
		[Address(RVA = "0x231DC00", Offset = "0x231C800", VA = "0x18231DC00")]
		public static string GetEnemyBossHpIconId(string enemyId)
		{
			return null;
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00034DE8 File Offset: 0x00032FE8
		[Token(Token = "0x6007607")]
		[Address(RVA = "0x2325430", Offset = "0x2324030", VA = "0x182325430")]
		public static int LoadPlayerLevelExp(int level)
		{
			return 0;
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00034E00 File Offset: 0x00033000
		[Token(Token = "0x6007608")]
		[Address(RVA = "0x2324020", Offset = "0x2322C20", VA = "0x182324020")]
		public static MailSenderInfo LoadMailSenderInfo(string id, ILoadAsset loader)
		{
			return default(MailSenderInfo);
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x00034E18 File Offset: 0x00033018
		[Token(Token = "0x6007609")]
		[Address(RVA = "0x23254E0", Offset = "0x23240E0", VA = "0x1823254E0")]
		public static int LoadPlayerMaxAp()
		{
			return 0;
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00034E30 File Offset: 0x00033030
		[Token(Token = "0x600760A")]
		[Address(RVA = "0x2325570", Offset = "0x2324170", VA = "0x182325570")]
		public static int LoadPlayerRecoverAp()
		{
			return 0;
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760B")]
		[Address(RVA = "0x23219C0", Offset = "0x23205C0", VA = "0x1823219C0")]
		public static string GetSubProfessionIconId(string subProfessionId)
		{
			return null;
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760C")]
		[Address(RVA = "0x2327D80", Offset = "0x2326980", VA = "0x182327D80")]
		public static Sprite LoadSubProfessionIcon(string subProfessionId)
		{
			return null;
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760D")]
		[Address(RVA = "0x2327C50", Offset = "0x2326850", VA = "0x182327C50")]
		public static Sprite LoadSubProfessionIconByPage(string subProfessionId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760E")]
		[Address(RVA = "0x2328580", Offset = "0x2327180", VA = "0x182328580")]
		public static Sprite LoadUniEquipTypeIcon(string typeId, [Optional] ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760F")]
		[Address(RVA = "0x2327FD0", Offset = "0x2326BD0", VA = "0x182327FD0")]
		public static Sprite LoadUniEquipExtraTypeIcon(string extraTypeName, [Optional] ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007610")]
		[Address(RVA = "0x2322C80", Offset = "0x2321880", VA = "0x182322C80")]
		public static Sprite LoadColorShining(string typeId)
		{
			return null;
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007611")]
		[Address(RVA = "0x2324750", Offset = "0x2323350", VA = "0x182324750")]
		public static NameCardV2SkinStyle LoadNameCardV2SkinStyleAndApplyTmpl(string skinId, int skinTmpl, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007612")]
		[Address(RVA = "0x23280F0", Offset = "0x2326CF0", VA = "0x1823280F0")]
		public static Sprite LoadUniEquipImgPic(string uniEquipId, ILoadAsset page)
		{
			return null;
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007613")]
		[Address(RVA = "0x2328240", Offset = "0x2326E40", VA = "0x182328240")]
		public static Sprite LoadUniEquipSmallImgPic(string uniEquipId, ILoadAsset page)
		{
			return null;
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007614")]
		[Address(RVA = "0x23284D0", Offset = "0x23270D0", VA = "0x1823284D0")]
		public static Sprite LoadUniEquipTypeDirectionIcon(string typeId)
		{
			return null;
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007615")]
		[Address(RVA = "0x2328390", Offset = "0x2326F90", VA = "0x182328390")]
		public static Sprite LoadUniEquipTypeDirectionIcon(string typeId, ILoadAsset page)
		{
			return null;
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007616")]
		[Address(RVA = "0x2322B20", Offset = "0x2321720", VA = "0x182322B20")]
		public static Sprite LoadBrandIcon(string brandId, bool isSmall)
		{
			return null;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007617")]
		[Address(RVA = "0x2322A80", Offset = "0x2321680", VA = "0x182322A80")]
		public static Sprite LoadBrandIconByPage(string brandId, bool isSmall, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007618")]
		[Address(RVA = "0x232BA70", Offset = "0x232A670", VA = "0x18232BA70")]
		private static Sprite _LoadBrandIconImpl(string brandId, bool isSmall, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007619")]
		[Address(RVA = "0x2320750", Offset = "0x231F350", VA = "0x182320750")]
		public static string GetSkinBrandCapitalName(string skinGroupId)
		{
			return null;
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00034E48 File Offset: 0x00033048
		[Token(Token = "0x600761A")]
		[Address(RVA = "0x2329DB0", Offset = "0x23289B0", VA = "0x182329DB0")]
		public static bool TryLoadSkinGroupIcon(string skinGroupId, bool isSmall, out Sprite icon)
		{
			return default(bool);
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761B")]
		[Address(RVA = "0x2323DF0", Offset = "0x23229F0", VA = "0x182323DF0")]
		public static Sprite LoadLogo(string powerId, bool isOverride = false)
		{
			return null;
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00034E60 File Offset: 0x00033060
		[Token(Token = "0x600761C")]
		[Address(RVA = "0x231AB40", Offset = "0x2319740", VA = "0x18231AB40")]
		public static int CalcExpsToTargetLevel(PlayerCharacter playerChar, CharacterData charData, int level)
		{
			return 0;
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761D")]
		[Address(RVA = "0x2327A50", Offset = "0x2326650", VA = "0x182327A50")]
		public static Sprite LoadStageDiffLogo(StageDiffGroup diff)
		{
			return null;
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761E")]
		[Address(RVA = "0x2326200", Offset = "0x2324E00", VA = "0x182326200")]
		public static Sprite LoadRecordRewardDiffLogo(RecordRewardStageDiff diff, string pageName)
		{
			return null;
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761F")]
		[Address(RVA = "0x2327E40", Offset = "0x2326A40", VA = "0x182327E40")]
		public static Sprite LoadTeamIcon(string powerId)
		{
			return null;
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007620")]
		[Address(RVA = "0x231E7C0", Offset = "0x231D3C0", VA = "0x18231E7C0")]
		public static Sprite GetItemVoucherback(string picId)
		{
			return null;
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007621")]
		[Address(RVA = "0x231F250", Offset = "0x231DE50", VA = "0x18231F250")]
		public static Sprite GetOptionalVoucherBgDec(string picId)
		{
			return null;
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007622")]
		[Address(RVA = "0x2321520", Offset = "0x2320120", VA = "0x182321520")]
		public static Sprite GetStartBattleBack(SquadStartButtonTypeEnum buttonEnum, string picId)
		{
			return null;
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007623")]
		[Address(RVA = "0x231D980", Offset = "0x231C580", VA = "0x18231D980")]
		public static Sprite GetElitePic(int eliteId, bool large = false)
		{
			return null;
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007624")]
		[Address(RVA = "0x231D780", Offset = "0x231C380", VA = "0x18231D780")]
		public static Sprite GetEliteCard(int eliteId)
		{
			return null;
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007625")]
		[Address(RVA = "0x2321AA0", Offset = "0x23206A0", VA = "0x182321AA0")]
		public static Sprite GetTinySpecializedPic(int SpecializedId)
		{
			return null;
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007626")]
		[Address(RVA = "0x2321010", Offset = "0x231FC10", VA = "0x182321010")]
		public static Sprite GetSpecializedPic(int specializedId, ILoadAsset loader, bool small = false, bool isGlow = false)
		{
			return null;
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007627")]
		[Address(RVA = "0x231F2C0", Offset = "0x231DEC0", VA = "0x18231F2C0")]
		public static Sprite GetPotentialIcon(int potentialID, bool isSmall)
		{
			return null;
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007628")]
		[Address(RVA = "0x231E980", Offset = "0x231D580", VA = "0x18231E980")]
		public static Sprite GetLargeProfessionPic(ProfessionCategory profession, bool isWhite = false)
		{
			return null;
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007629")]
		[Address(RVA = "0x231E1F0", Offset = "0x231CDF0", VA = "0x18231E1F0")]
		public static Sprite GetFriendAssistProfessionPic(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762A")]
		[Address(RVA = "0x23233D0", Offset = "0x2321FD0", VA = "0x1823233D0")]
		public static FriendAssistTab LoadFriendAssistTabPrefab()
		{
			return null;
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762B")]
		[Address(RVA = "0x2327420", Offset = "0x2326020", VA = "0x182327420")]
		public static SkinShopPerItemView LoadSkinShopItemPrefab(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762C")]
		[Address(RVA = "0x23272D0", Offset = "0x2325ED0", VA = "0x1823272D0")]
		public static SkinShopPerBlindboxItemView LoadSkinShopBlindboxItemPrefab(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762D")]
		[Address(RVA = "0x231EEC0", Offset = "0x231DAC0", VA = "0x18231EEC0")]
		public static Sprite GetNoShadowProfessionPic(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762E")]
		[Address(RVA = "0x231CF60", Offset = "0x231BB60", VA = "0x18231CF60")]
		public static Sprite GetBigWhiteProfessionPic(ProfessionCategory profession, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762F")]
		[Address(RVA = "0x2320060", Offset = "0x231EC60", VA = "0x182320060")]
		public static Sprite GetProfessionPic(ProfessionCategory profession, bool isWhite = false)
		{
			return null;
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007630")]
		[Address(RVA = "0x231FE70", Offset = "0x231EA70", VA = "0x18231FE70")]
		public static Sprite GetProfessionPicV2(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007631")]
		[Address(RVA = "0x2320A90", Offset = "0x231F690", VA = "0x182320A90")]
		public static Sprite GetSortTypeIconByPageName(CharacterSortType sortType, string pageName)
		{
			return null;
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007632")]
		[Address(RVA = "0x2320C00", Offset = "0x231F800", VA = "0x182320C00")]
		public static Sprite GetSortTypeIconByPage(CharacterSortType sortType, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007633")]
		[Address(RVA = "0x231D4F0", Offset = "0x231C0F0", VA = "0x18231D4F0")]
		public static Sprite GetCustomSortTypeIconByPage(CharacterSortType sortType, int customIdx, string pageName)
		{
			return null;
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007634")]
		[Address(RVA = "0x23286A0", Offset = "0x23272A0", VA = "0x1823286A0")]
		public static List<SkillData> LoadUnlockSkillsAtInitialSkillLvl(CharQuery query, EvolvePhase evolve, int level)
		{
			return null;
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007635")]
		[Address(RVA = "0x2328A30", Offset = "0x2327630", VA = "0x182328A30")]
		public static List<TalentData> LoadUnlockTalentsWithEquip(CharQuery charQuery, EvolvePhase evolve, int level, int potential, [Optional] List<CharacterData.UniqueEquipPair> equipQueries)
		{
			return null;
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007636")]
		[Address(RVA = "0x2324D30", Offset = "0x2323930", VA = "0x182324D30")]
		public static List<TalentData> LoadOverrideTalents(EvolvePhase evolve, int level, int potential, CharacterData.UniqueEquipPair equipQuery, bool isToken = false)
		{
			return null;
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00034E78 File Offset: 0x00033078
		[Token(Token = "0x6007637")]
		[Address(RVA = "0x2329AD0", Offset = "0x23286D0", VA = "0x182329AD0")]
		public static bool TryGetValidTalentWithOverride(CharacterData.TalentDataBundle talentDataBundle, int talentIndex, EvolvePhase evolve, int level, int potential, List<TalentData> overrideTalents, out TalentData validTalentData)
		{
			return default(bool);
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00034E90 File Offset: 0x00033090
		[Token(Token = "0x6007638")]
		[Address(RVA = "0x23297F0", Offset = "0x23283F0", VA = "0x1823297F0")]
		public static bool TryGetNextTalentWithOverride(CharacterData.TalentDataBundle talentDataBundle, int talentIndex, EvolvePhase evolve, int level, int potential, List<TalentData> overrideTalents, out TalentData nextTalentData)
		{
			return default(bool);
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00034EA8 File Offset: 0x000330A8
		[Token(Token = "0x6007639")]
		[Address(RVA = "0x231B200", Offset = "0x2319E00", VA = "0x18231B200")]
		public static bool CheckCharWordTextAvailable(CharWordData data)
		{
			return default(bool);
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763A")]
		[Address(RVA = "0x2325A20", Offset = "0x2324620", VA = "0x182325A20")]
		public static CharWordData LoadRandomCharData(VoiceQuery query, CharWordShowType showType, [Optional] CharWordData lastData)
		{
			return null;
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763B")]
		[Address(RVA = "0x2325C70", Offset = "0x2324870", VA = "0x182325C70")]
		public static CharWordData LoadRandomCharData(VoiceQuery query, CharWordShowType showType, DataUnlockType dataUnlockType, [Optional] CharWordData lastData)
		{
			return null;
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00034EC0 File Offset: 0x000330C0
		[Token(Token = "0x600763C")]
		[Address(RVA = "0x231B910", Offset = "0x231A510", VA = "0x18231B910")]
		public static bool CheckIfMailArchiveOpen()
		{
			return default(bool);
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00034ED8 File Offset: 0x000330D8
		[Token(Token = "0x600763D")]
		[Address(RVA = "0x231D3C0", Offset = "0x231BFC0", VA = "0x18231D3C0")]
		public static int GetCrystalToBuyAp()
		{
			return 0;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763E")]
		[Address(RVA = "0x2322DF0", Offset = "0x23219F0", VA = "0x182322DF0")]
		public static CommonSkillRangeButtonView LoadCommonSkillRangeButtonViewWhite(ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763F")]
		[Address(RVA = "0x2322D50", Offset = "0x2321950", VA = "0x182322D50")]
		public static CommonSkillRangeButtonView LoadCommonSkillRangeButtonViewBlack(ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007640")]
		[Address(RVA = "0x231F0B0", Offset = "0x231DCB0", VA = "0x18231F0B0")]
		public static Sprite GetNumberPic(int number, bool hollow = true)
		{
			return null;
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00034EF0 File Offset: 0x000330F0
		[Token(Token = "0x6007641")]
		[Address(RVA = "0x23221F0", Offset = "0x2320DF0", VA = "0x1823221F0")]
		public static bool IsBuildInCharacter(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007642")]
		[Address(RVA = "0x231CB80", Offset = "0x231B780", VA = "0x18231CB80")]
		public static string GetAnnouncementUrl()
		{
			return null;
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007643")]
		[Address(RVA = "0x231F690", Offset = "0x231E290", VA = "0x18231F690")]
		public static string GetPreAnnouncementUrl()
		{
			return null;
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007644")]
		[Address(RVA = "0x231F610", Offset = "0x231E210", VA = "0x18231F610")]
		public static string GetPreAnnouncementConfigUrl()
		{
			return null;
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06007645 RID: 30277 RVA: 0x00034F08 File Offset: 0x00033108
		[Token(Token = "0x17000E4A")]
		public static int advancedGachaCost
		{
			[Token(Token = "0x6007645")]
			[Address(RVA = "0x232C950", Offset = "0x232B550", VA = "0x18232C950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007646")]
		[Address(RVA = "0x23213E0", Offset = "0x231FFE0", VA = "0x1823213E0")]
		public static string GetStageCode(string stageId)
		{
			return null;
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007647")]
		[Address(RVA = "0x2321470", Offset = "0x2320070", VA = "0x182321470")]
		public static string GetStageNameWithCode(string stageId)
		{
			return null;
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00034F20 File Offset: 0x00033120
		[Token(Token = "0x6007648")]
		[Address(RVA = "0x231E030", Offset = "0x231CC30", VA = "0x18231E030")]
		public static int GetFavorPercent(int charInstId)
		{
			return 0;
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00034F38 File Offset: 0x00033138
		[Token(Token = "0x6007649")]
		[Address(RVA = "0x231DE70", Offset = "0x231CA70", VA = "0x18231DE70")]
		public static int GetFavorBattlePhase(int charInstId)
		{
			return 0;
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00034F50 File Offset: 0x00033150
		[Token(Token = "0x600764A")]
		[Address(RVA = "0x23222F0", Offset = "0x2320EF0", VA = "0x1823222F0")]
		public static bool IsNormalRecruitSlotWorking(int recruitSlotId)
		{
			return default(bool);
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00034F68 File Offset: 0x00033168
		[Token(Token = "0x600764B")]
		[Address(RVA = "0x231EB90", Offset = "0x231D790", VA = "0x18231EB90")]
		public static int GetMaxFavorPercent()
		{
			return 0;
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00034F80 File Offset: 0x00033180
		[Token(Token = "0x600764C")]
		[Address(RVA = "0x231AF50", Offset = "0x2319B50", VA = "0x18231AF50")]
		public static int CalcSkillSpecializedState(int charInstId, int skillIndex)
		{
			return 0;
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00034F98 File Offset: 0x00033198
		[Token(Token = "0x600764D")]
		[Address(RVA = "0x231AE30", Offset = "0x2319A30", VA = "0x18231AE30")]
		public static int CalcInstFinTktDiamondAddRequire()
		{
			return 0;
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00034FB0 File Offset: 0x000331B0
		[Token(Token = "0x600764E")]
		[Address(RVA = "0x231B750", Offset = "0x231A350", VA = "0x18231B750")]
		public static bool CheckCompletedHardStage(LevelData.Difficulty difficulty, PlayerBattleRank battleRank)
		{
			return default(bool);
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00034FC8 File Offset: 0x000331C8
		[Token(Token = "0x600764F")]
		[Address(RVA = "0x231B7D0", Offset = "0x231A3D0", VA = "0x18231B7D0")]
		public static bool CheckCompletedSixStarStage(LevelData.Difficulty difficulty, PlayerBattleRank battleRank)
		{
			return default(bool);
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00034FE0 File Offset: 0x000331E0
		[Token(Token = "0x6007650")]
		[Address(RVA = "0x231B6D0", Offset = "0x231A2D0", VA = "0x18231B6D0")]
		public static bool CheckCompletedHardStage(LevelData.Difficulty difficulty, PlayerStageState stageState)
		{
			return default(bool);
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00034FF8 File Offset: 0x000331F8
		[Token(Token = "0x6007651")]
		[Address(RVA = "0x231BCA0", Offset = "0x231A8A0", VA = "0x18231BCA0")]
		public static bool CheckStagePredefine(LevelData.Difficulty difficulty, LevelData levelData)
		{
			return default(bool);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007652")]
		[Address(RVA = "0x231CAD0", Offset = "0x231B6D0", VA = "0x18231CAD0")]
		public static LevelData.PredefinedData.PredefinedCard[] GenPredefinedCardsToInject(LevelData levelData, LevelData.Difficulty difficulty)
		{
			return null;
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00035010 File Offset: 0x00033210
		[Token(Token = "0x6007653")]
		[Address(RVA = "0x231B0C0", Offset = "0x2319CC0", VA = "0x18231B0C0")]
		public static bool CanApBePurchased()
		{
			return default(bool);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00035028 File Offset: 0x00033228
		[Token(Token = "0x6007654")]
		[Address(RVA = "0x231AFF0", Offset = "0x2319BF0", VA = "0x18231AFF0")]
		public static bool CanApBePurchasedWithApItem(int currentAp, int apSupplyItem)
		{
			return default(bool);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00035040 File Offset: 0x00033240
		[Token(Token = "0x6007655")]
		[Address(RVA = "0x231EE40", Offset = "0x231DA40", VA = "0x18231EE40")]
		public static int GetNextBuyApAmount()
		{
			return 0;
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00035058 File Offset: 0x00033258
		[Token(Token = "0x6007656")]
		[Address(RVA = "0x2322120", Offset = "0x2320D20", VA = "0x182322120")]
		public static bool HasFavorBubble(this PlayerBuildingChar playerChar)
		{
			return default(bool);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007657")]
		[Address(RVA = "0x2329120", Offset = "0x2327D20", VA = "0x182329120")]
		public static void ResetDataConvertTestStatus(bool isForceEmpty)
		{
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007658")]
		[Address(RVA = "0x232A600", Offset = "0x2329200", VA = "0x18232A600")]
		private static string _ChangeRandomName(string fieldName, string code1, string code2)
		{
			return null;
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007659")]
		[Address(RVA = "0x2325680", Offset = "0x2324280", VA = "0x182325680")]
		public static SpriteHub LoadProfessionIconHub()
		{
			return null;
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600765A")]
		[Address(RVA = "0x2322BA0", Offset = "0x23217A0", VA = "0x182322BA0")]
		public static SpriteHub LoadCashIconHub()
		{
			return null;
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600765B")]
		[Address(RVA = "0x23257C0", Offset = "0x23243C0", VA = "0x1823257C0")]
		public static SpriteHub LoadProfessionLargeIconHub()
		{
			return null;
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600765C")]
		[Address(RVA = "0x23264D0", Offset = "0x23250D0", VA = "0x1823264D0")]
		public static SpriteHub LoadShopImageHub(string OnShowId)
		{
			return null;
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600765D")]
		[Address(RVA = "0x2323900", Offset = "0x2322500", VA = "0x182323900")]
		public static SpriteHub LoadGiftPackageImageHub()
		{
			return null;
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600765E")]
		[Address(RVA = "0x2324CC0", Offset = "0x23238C0", VA = "0x182324CC0")]
		public static SpriteHub LoadNumberIconHub()
		{
			return null;
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600765F")]
		[Address(RVA = "0x2323BB0", Offset = "0x23227B0", VA = "0x182323BB0")]
		public static SpriteHub LoadItemIconStackHub()
		{
			return null;
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007660")]
		[Address(RVA = "0x2323100", Offset = "0x2321D00", VA = "0x182323100")]
		public static SpriteHub LoadEnemyIconHub()
		{
			return null;
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007661")]
		[Address(RVA = "0x2322C10", Offset = "0x2321810", VA = "0x182322C10")]
		public static SpriteHub LoadClueHub()
		{
			return null;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007662")]
		[Address(RVA = "0x2323470", Offset = "0x2322070", VA = "0x182323470")]
		public static SpriteHub LoadFurnitureGroupDetailHub(string id)
		{
			return null;
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007663")]
		[Address(RVA = "0x23236E0", Offset = "0x23222E0", VA = "0x1823236E0")]
		public static SpriteHub LoadGachaDetailHub()
		{
			return null;
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007664")]
		[Address(RVA = "0x2327900", Offset = "0x2326500", VA = "0x182327900")]
		public static Sprite LoadSpriteFromAutoPackHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007665")]
		[Address(RVA = "0x2327570", Offset = "0x2326170", VA = "0x182327570")]
		public static Sprite LoadSpriteFromAutoPackHubByAct(string spriteId, string hubPath, string actId)
		{
			return null;
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007666")]
		[Address(RVA = "0x2327700", Offset = "0x2326300", VA = "0x182327700")]
		public static Sprite LoadSpriteFromAutoPackHubByPage(string spriteId, string hubPath, string pageName)
		{
			return null;
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007667")]
		[Address(RVA = "0x2327840", Offset = "0x2326440", VA = "0x182327840")]
		public static Sprite LoadSpriteFromAutoPackHubByPage(string spriteId, string hubPath, ILoadAsset loader, bool bMustInHub = true)
		{
			return null;
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007668")]
		private static T _CheckAndLoadAsset<T>(string path, [Optional] string pageName) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x040072C8 RID: 29384
		[Token(Token = "0x40072C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAllCharCards;

		// Token: 0x040072C9 RID: 29385
		[Token(Token = "0x40072C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateFakeCardView;

		// Token: 0x040072CA RID: 29386
		[Token(Token = "0x40072CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadAllCharsInSquads;

		// Token: 0x040072CB RID: 29387
		[Token(Token = "0x40072CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AchieveCharCard;

		// Token: 0x040072CC RID: 29388
		[Token(Token = "0x40072CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_AchieveCharCard;

		// Token: 0x040072CD RID: 29389
		[Token(Token = "0x40072CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetRespawnTimeDesc;

		// Token: 0x040072CE RID: 29390
		[Token(Token = "0x40072CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetAttackSpeedDesc;

		// Token: 0x040072CF RID: 29391
		[Token(Token = "0x40072CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetHandBookStageStatusDesc;

		// Token: 0x040072D0 RID: 29392
		[Token(Token = "0x40072D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckHaveBuyApRemainTimes;

		// Token: 0x040072D1 RID: 29393
		[Token(Token = "0x40072D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSkillIconId;

		// Token: 0x040072D2 RID: 29394
		[Token(Token = "0x40072D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetSkillData;

		// Token: 0x040072D3 RID: 29395
		[Token(Token = "0x40072D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSkillMainData;

		// Token: 0x040072D4 RID: 29396
		[Token(Token = "0x40072D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetREPShopOpenFlag;

		// Token: 0x040072D5 RID: 29397
		[Token(Token = "0x40072D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetChooseGPPackageIdWithDefault;

		// Token: 0x040072D6 RID: 29398
		[Token(Token = "0x40072D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckIsGPOption;

		// Token: 0x040072D7 RID: 29399
		[Token(Token = "0x40072D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadSkillTags;

		// Token: 0x040072D8 RID: 29400
		[Token(Token = "0x40072D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadMissionData;

		// Token: 0x040072D9 RID: 29401
		[Token(Token = "0x40072D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadMissionGroup;

		// Token: 0x040072DA RID: 29402
		[Token(Token = "0x40072DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadMissionDailyReward;

		// Token: 0x040072DB RID: 29403
		[Token(Token = "0x40072DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadMissionWeeklyReward;

		// Token: 0x040072DC RID: 29404
		[Token(Token = "0x40072DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetMissionState;

		// Token: 0x040072DD RID: 29405
		[Token(Token = "0x40072DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix1_LoadSkillTags;

		// Token: 0x040072DE RID: 29406
		[Token(Token = "0x40072DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadUnlockTextByUnlockCondition;

		// Token: 0x040072DF RID: 29407
		[Token(Token = "0x40072DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadSkillUnlockCondition;

		// Token: 0x040072E0 RID: 29408
		[Token(Token = "0x40072E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadSkillUnlockPhase;

		// Token: 0x040072E1 RID: 29409
		[Token(Token = "0x40072E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_AchieveEvolveRequireGold;

		// Token: 0x040072E2 RID: 29410
		[Token(Token = "0x40072E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetTeamIconId;

		// Token: 0x040072E3 RID: 29411
		[Token(Token = "0x40072E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetPowerLogoId;

		// Token: 0x040072E4 RID: 29412
		[Token(Token = "0x40072E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetProfessionIconId;

		// Token: 0x040072E5 RID: 29413
		[Token(Token = "0x40072E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetProfessionName;

		// Token: 0x040072E6 RID: 29414
		[Token(Token = "0x40072E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetSortTypeIconId;

		// Token: 0x040072E7 RID: 29415
		[Token(Token = "0x40072E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetExpMapFromCharData;

		// Token: 0x040072E8 RID: 29416
		[Token(Token = "0x40072E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_AchieveUplevelExp;

		// Token: 0x040072E9 RID: 29417
		[Token(Token = "0x40072E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_AchieveGoldPerLevel;

		// Token: 0x040072EA RID: 29418
		[Token(Token = "0x40072EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_HandleExaminResponseBool;

		// Token: 0x040072EB RID: 29419
		[Token(Token = "0x40072EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_HandleExaminRespone;

		// Token: 0x040072EC RID: 29420
		[Token(Token = "0x40072EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_HandleNickNameExaminRespone;

		// Token: 0x040072ED RID: 29421
		[Token(Token = "0x40072ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_AchieveMaxLevel;

		// Token: 0x040072EE RID: 29422
		[Token(Token = "0x40072EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix1_AchieveUplevelExp;

		// Token: 0x040072EF RID: 29423
		[Token(Token = "0x40072EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_AchieveCharAttributes;

		// Token: 0x040072F0 RID: 29424
		[Token(Token = "0x40072F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix1_AchieveCharAttributes;

		// Token: 0x040072F1 RID: 29425
		[Token(Token = "0x40072F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix2_AchieveCharAttributes;

		// Token: 0x040072F2 RID: 29426
		[Token(Token = "0x40072F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_LoadComposeHardPredefine;

		// Token: 0x040072F3 RID: 29427
		[Token(Token = "0x40072F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__LoadNecessaryDataFromStage;

		// Token: 0x040072F4 RID: 29428
		[Token(Token = "0x40072F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_LoadNecessaryDataFromStage;

		// Token: 0x040072F5 RID: 29429
		[Token(Token = "0x40072F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_LoadNecessaryDataFromStageWithPlayerCharSquad;

		// Token: 0x040072F6 RID: 29430
		[Token(Token = "0x40072F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_GetStartButtonTypeByStageData;

		// Token: 0x040072F7 RID: 29431
		[Token(Token = "0x40072F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__LoadStagePredefinedSquad;

		// Token: 0x040072F8 RID: 29432
		[Token(Token = "0x40072F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__ParsePredefinedChar;

		// Token: 0x040072F9 RID: 29433
		[Token(Token = "0x40072F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_CreateBattlePlayerData;

		// Token: 0x040072FA RID: 29434
		[Token(Token = "0x40072FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__GenBattleSlotsWithLevelData;

		// Token: 0x040072FB RID: 29435
		[Token(Token = "0x40072FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__GenBattleSlotsWithPlayerData;

		// Token: 0x040072FC RID: 29436
		[Token(Token = "0x40072FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__GenCharInstWithSlotData;

		// Token: 0x040072FD RID: 29437
		[Token(Token = "0x40072FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__GenCharInstWithPlayerData;

		// Token: 0x040072FE RID: 29438
		[Token(Token = "0x40072FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__TryGetCharInfo;

		// Token: 0x040072FF RID: 29439
		[Token(Token = "0x40072FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_CreatePredefinedTokenInst;

		// Token: 0x04007300 RID: 29440
		[Token(Token = "0x4007300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_CreateTokenInst;

		// Token: 0x04007301 RID: 29441
		[Token(Token = "0x4007301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__AchievePredefinedCardEquipInfo;

		// Token: 0x04007302 RID: 29442
		[Token(Token = "0x4007302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_AchieveCharacterAttackRange;

		// Token: 0x04007303 RID: 29443
		[Token(Token = "0x4007303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__GetFirstEquipTalentRangeId;

		// Token: 0x04007304 RID: 29444
		[Token(Token = "0x4007304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_TryGetAttackRangeFromRangeId;

		// Token: 0x04007305 RID: 29445
		[Token(Token = "0x4007305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_FindGachaTagContentById;

		// Token: 0x04007306 RID: 29446
		[Token(Token = "0x4007306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_FindClassicGachaIdByPickTier;

		// Token: 0x04007307 RID: 29447
		[Token(Token = "0x4007307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_LoadFesGachaItemIfAvail;

		// Token: 0x04007308 RID: 29448
		[Token(Token = "0x4007308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_LoadPlayerCharAvatar;

		// Token: 0x04007309 RID: 29449
		[Token(Token = "0x4007309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_LoadHomeBackgroundBlurImg;

		// Token: 0x0400730A RID: 29450
		[Token(Token = "0x400730A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_CalcHomeBackgroundBlurImg;

		// Token: 0x0400730B RID: 29451
		[Token(Token = "0x400730B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetBackgroundMusicId;

		// Token: 0x0400730C RID: 29452
		[Token(Token = "0x400730C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_FindBgFormWrapper;

		// Token: 0x0400730D RID: 29453
		[Token(Token = "0x400730D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_GetCurrentHomeBackgroundId;

		// Token: 0x0400730E RID: 29454
		[Token(Token = "0x400730E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetGiftPackageSprite;

		// Token: 0x0400730F RID: 29455
		[Token(Token = "0x400730F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix1_GetGiftPackageSprite;

		// Token: 0x04007310 RID: 29456
		[Token(Token = "0x4007310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetPriceSprite;

		// Token: 0x04007311 RID: 29457
		[Token(Token = "0x4007311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__GetPriceTypeSpriteId;

		// Token: 0x04007312 RID: 29458
		[Token(Token = "0x4007312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_GetCashSprite;

		// Token: 0x04007313 RID: 29459
		[Token(Token = "0x4007313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_GetCoinFurnSprite;

		// Token: 0x04007314 RID: 29460
		[Token(Token = "0x4007314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_GetPriceSpriteByItemType;

		// Token: 0x04007315 RID: 29461
		[Token(Token = "0x4007315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__GetPriceSpriteByIconId;

		// Token: 0x04007316 RID: 29462
		[Token(Token = "0x4007316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_GetEPGSCoinSprite;

		// Token: 0x04007317 RID: 29463
		[Token(Token = "0x4007317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_GetLMTGSCoinSprite;

		// Token: 0x04007318 RID: 29464
		[Token(Token = "0x4007318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__LoadPlayerCharAvatar;

		// Token: 0x04007319 RID: 29465
		[Token(Token = "0x4007319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__LoadCharacterAvatar;

		// Token: 0x0400731A RID: 29466
		[Token(Token = "0x400731A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_LoadEnemyIcon;

		// Token: 0x0400731B RID: 29467
		[Token(Token = "0x400731B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_LoadAttackTypeName;

		// Token: 0x0400731C RID: 29468
		[Token(Token = "0x400731C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_LoadMotionTypeText;

		// Token: 0x0400731D RID: 29469
		[Token(Token = "0x400731D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_LoadDamageTypeName;

		// Token: 0x0400731E RID: 29470
		[Token(Token = "0x400731E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_BuildAttackDamageText;

		// Token: 0x0400731F RID: 29471
		[Token(Token = "0x400731F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_LoadGachaDetailCharBack;

		// Token: 0x04007320 RID: 29472
		[Token(Token = "0x4007320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_LoadGachaDetailStar;

		// Token: 0x04007321 RID: 29473
		[Token(Token = "0x4007321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_LoadRarityIcon;

		// Token: 0x04007322 RID: 29474
		[Token(Token = "0x4007322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_LoadPureBlackRarityIcon;

		// Token: 0x04007323 RID: 29475
		[Token(Token = "0x4007323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_LoadRarityIconTight;

		// Token: 0x04007324 RID: 29476
		[Token(Token = "0x4007324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_LoadLeftJustifyRarityIcon;

		// Token: 0x04007325 RID: 29477
		[Token(Token = "0x4007325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_LoadYellowRarityIcon;

		// Token: 0x04007326 RID: 29478
		[Token(Token = "0x4007326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_LoadSkillIcon;

		// Token: 0x04007327 RID: 29479
		[Token(Token = "0x4007327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix1_LoadSkillIcon;

		// Token: 0x04007328 RID: 29480
		[Token(Token = "0x4007328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_LoadSkillIconByIconId;

		// Token: 0x04007329 RID: 29481
		[Token(Token = "0x4007329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_LoadPlayerExpMap;

		// Token: 0x0400732A RID: 29482
		[Token(Token = "0x400732A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_GetEnemyIconId;

		// Token: 0x0400732B RID: 29483
		[Token(Token = "0x400732B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_GetEnemyBossHpIconId;

		// Token: 0x0400732C RID: 29484
		[Token(Token = "0x400732C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_LoadPlayerLevelExp;

		// Token: 0x0400732D RID: 29485
		[Token(Token = "0x400732D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_LoadMailSenderInfo;

		// Token: 0x0400732E RID: 29486
		[Token(Token = "0x400732E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_LoadPlayerMaxAp;

		// Token: 0x0400732F RID: 29487
		[Token(Token = "0x400732F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_LoadPlayerRecoverAp;

		// Token: 0x04007330 RID: 29488
		[Token(Token = "0x4007330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_GetSubProfessionIconId;

		// Token: 0x04007331 RID: 29489
		[Token(Token = "0x4007331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_LoadSubProfessionIcon;

		// Token: 0x04007332 RID: 29490
		[Token(Token = "0x4007332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_LoadSubProfessionIconByPage;

		// Token: 0x04007333 RID: 29491
		[Token(Token = "0x4007333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_LoadUniEquipTypeIcon;

		// Token: 0x04007334 RID: 29492
		[Token(Token = "0x4007334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_LoadUniEquipExtraTypeIcon;

		// Token: 0x04007335 RID: 29493
		[Token(Token = "0x4007335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_LoadColorShining;

		// Token: 0x04007336 RID: 29494
		[Token(Token = "0x4007336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_LoadNameCardV2SkinStyleAndApplyTmpl;

		// Token: 0x04007337 RID: 29495
		[Token(Token = "0x4007337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_LoadUniEquipImgPic;

		// Token: 0x04007338 RID: 29496
		[Token(Token = "0x4007338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_LoadUniEquipSmallImgPic;

		// Token: 0x04007339 RID: 29497
		[Token(Token = "0x4007339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_LoadUniEquipTypeDirectionIcon;

		// Token: 0x0400733A RID: 29498
		[Token(Token = "0x400733A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix1_LoadUniEquipTypeDirectionIcon;

		// Token: 0x0400733B RID: 29499
		[Token(Token = "0x400733B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_LoadBrandIcon;

		// Token: 0x0400733C RID: 29500
		[Token(Token = "0x400733C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_LoadBrandIconByPage;

		// Token: 0x0400733D RID: 29501
		[Token(Token = "0x400733D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0__LoadBrandIconImpl;

		// Token: 0x0400733E RID: 29502
		[Token(Token = "0x400733E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_GetSkinBrandCapitalName;

		// Token: 0x0400733F RID: 29503
		[Token(Token = "0x400733F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_TryLoadSkinGroupIcon;

		// Token: 0x04007340 RID: 29504
		[Token(Token = "0x4007340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_LoadLogo;

		// Token: 0x04007341 RID: 29505
		[Token(Token = "0x4007341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_CalcExpsToTargetLevel;

		// Token: 0x04007342 RID: 29506
		[Token(Token = "0x4007342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_LoadStageDiffLogo;

		// Token: 0x04007343 RID: 29507
		[Token(Token = "0x4007343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_LoadRecordRewardDiffLogo;

		// Token: 0x04007344 RID: 29508
		[Token(Token = "0x4007344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_LoadTeamIcon;

		// Token: 0x04007345 RID: 29509
		[Token(Token = "0x4007345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_GetItemVoucherback;

		// Token: 0x04007346 RID: 29510
		[Token(Token = "0x4007346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_GetOptionalVoucherBgDec;

		// Token: 0x04007347 RID: 29511
		[Token(Token = "0x4007347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_GetStartBattleBack;

		// Token: 0x04007348 RID: 29512
		[Token(Token = "0x4007348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_GetElitePic;

		// Token: 0x04007349 RID: 29513
		[Token(Token = "0x4007349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_GetEliteCard;

		// Token: 0x0400734A RID: 29514
		[Token(Token = "0x400734A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_GetTinySpecializedPic;

		// Token: 0x0400734B RID: 29515
		[Token(Token = "0x400734B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_GetSpecializedPic;

		// Token: 0x0400734C RID: 29516
		[Token(Token = "0x400734C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_GetPotentialIcon;

		// Token: 0x0400734D RID: 29517
		[Token(Token = "0x400734D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_GetLargeProfessionPic;

		// Token: 0x0400734E RID: 29518
		[Token(Token = "0x400734E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_GetFriendAssistProfessionPic;

		// Token: 0x0400734F RID: 29519
		[Token(Token = "0x400734F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_LoadFriendAssistTabPrefab;

		// Token: 0x04007350 RID: 29520
		[Token(Token = "0x4007350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_LoadSkinShopItemPrefab;

		// Token: 0x04007351 RID: 29521
		[Token(Token = "0x4007351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_LoadSkinShopBlindboxItemPrefab;

		// Token: 0x04007352 RID: 29522
		[Token(Token = "0x4007352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_GetNoShadowProfessionPic;

		// Token: 0x04007353 RID: 29523
		[Token(Token = "0x4007353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_GetBigWhiteProfessionPic;

		// Token: 0x04007354 RID: 29524
		[Token(Token = "0x4007354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_GetProfessionPic;

		// Token: 0x04007355 RID: 29525
		[Token(Token = "0x4007355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_GetProfessionPicV2;

		// Token: 0x04007356 RID: 29526
		[Token(Token = "0x4007356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_GetSortTypeIconByPageName;

		// Token: 0x04007357 RID: 29527
		[Token(Token = "0x4007357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_GetSortTypeIconByPage;

		// Token: 0x04007358 RID: 29528
		[Token(Token = "0x4007358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_GetCustomSortTypeIconByPage;

		// Token: 0x04007359 RID: 29529
		[Token(Token = "0x4007359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_LoadUnlockSkillsAtInitialSkillLvl;

		// Token: 0x0400735A RID: 29530
		[Token(Token = "0x400735A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_LoadUnlockTalentsWithEquip;

		// Token: 0x0400735B RID: 29531
		[Token(Token = "0x400735B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_LoadOverrideTalents;

		// Token: 0x0400735C RID: 29532
		[Token(Token = "0x400735C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_TryGetValidTalentWithOverride;

		// Token: 0x0400735D RID: 29533
		[Token(Token = "0x400735D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_TryGetNextTalentWithOverride;

		// Token: 0x0400735E RID: 29534
		[Token(Token = "0x400735E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_CheckCharWordTextAvailable;

		// Token: 0x0400735F RID: 29535
		[Token(Token = "0x400735F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_LoadRandomCharData;

		// Token: 0x04007360 RID: 29536
		[Token(Token = "0x4007360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix1_LoadRandomCharData;

		// Token: 0x04007361 RID: 29537
		[Token(Token = "0x4007361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0_CheckIfMailArchiveOpen;

		// Token: 0x04007362 RID: 29538
		[Token(Token = "0x4007362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_GetCrystalToBuyAp;

		// Token: 0x04007363 RID: 29539
		[Token(Token = "0x4007363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_LoadCommonSkillRangeButtonViewWhite;

		// Token: 0x04007364 RID: 29540
		[Token(Token = "0x4007364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_LoadCommonSkillRangeButtonViewBlack;

		// Token: 0x04007365 RID: 29541
		[Token(Token = "0x4007365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0_GetNumberPic;

		// Token: 0x04007366 RID: 29542
		[Token(Token = "0x4007366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_IsBuildInCharacter;

		// Token: 0x04007367 RID: 29543
		[Token(Token = "0x4007367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0_GetAnnouncementUrl;

		// Token: 0x04007368 RID: 29544
		[Token(Token = "0x4007368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix0_GetPreAnnouncementUrl;

		// Token: 0x04007369 RID: 29545
		[Token(Token = "0x4007369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_GetPreAnnouncementConfigUrl;

		// Token: 0x0400736A RID: 29546
		[Token(Token = "0x400736A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0_get_advancedGachaCost;

		// Token: 0x0400736B RID: 29547
		[Token(Token = "0x400736B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix0_GetStageCode;

		// Token: 0x0400736C RID: 29548
		[Token(Token = "0x400736C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_GetStageNameWithCode;

		// Token: 0x0400736D RID: 29549
		[Token(Token = "0x400736D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0_GetFavorPercent;

		// Token: 0x0400736E RID: 29550
		[Token(Token = "0x400736E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static DelegateBridge __Hotfix0_GetFavorBattlePhase;

		// Token: 0x0400736F RID: 29551
		[Token(Token = "0x400736F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private static DelegateBridge __Hotfix0_IsNormalRecruitSlotWorking;

		// Token: 0x04007370 RID: 29552
		[Token(Token = "0x4007370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private static DelegateBridge __Hotfix0_GetMaxFavorPercent;

		// Token: 0x04007371 RID: 29553
		[Token(Token = "0x4007371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private static DelegateBridge __Hotfix0_CalcSkillSpecializedState;

		// Token: 0x04007372 RID: 29554
		[Token(Token = "0x4007372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private static DelegateBridge __Hotfix0_CalcInstFinTktDiamondAddRequire;

		// Token: 0x04007373 RID: 29555
		[Token(Token = "0x4007373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private static DelegateBridge __Hotfix0_CheckCompletedHardStage;

		// Token: 0x04007374 RID: 29556
		[Token(Token = "0x4007374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static DelegateBridge __Hotfix0_CheckCompletedSixStarStage;

		// Token: 0x04007375 RID: 29557
		[Token(Token = "0x4007375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private static DelegateBridge __Hotfix1_CheckCompletedHardStage;

		// Token: 0x04007376 RID: 29558
		[Token(Token = "0x4007376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private static DelegateBridge __Hotfix0_CheckStagePredefine;

		// Token: 0x04007377 RID: 29559
		[Token(Token = "0x4007377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private static DelegateBridge __Hotfix0_GenPredefinedCardsToInject;

		// Token: 0x04007378 RID: 29560
		[Token(Token = "0x4007378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private static DelegateBridge __Hotfix0_CanApBePurchased;

		// Token: 0x04007379 RID: 29561
		[Token(Token = "0x4007379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private static DelegateBridge __Hotfix0_CanApBePurchasedWithApItem;

		// Token: 0x0400737A RID: 29562
		[Token(Token = "0x400737A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private static DelegateBridge __Hotfix0_GetNextBuyApAmount;

		// Token: 0x0400737B RID: 29563
		[Token(Token = "0x400737B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private static DelegateBridge __Hotfix0_HasFavorBubble;

		// Token: 0x0400737C RID: 29564
		[Token(Token = "0x400737C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private static DelegateBridge __Hotfix0_ResetDataConvertTestStatus;

		// Token: 0x0400737D RID: 29565
		[Token(Token = "0x400737D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private static DelegateBridge __Hotfix0__ChangeRandomName;

		// Token: 0x0400737E RID: 29566
		[Token(Token = "0x400737E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private static DelegateBridge __Hotfix0_LoadProfessionIconHub;

		// Token: 0x0400737F RID: 29567
		[Token(Token = "0x400737F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private static DelegateBridge __Hotfix0_LoadCashIconHub;

		// Token: 0x04007380 RID: 29568
		[Token(Token = "0x4007380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private static DelegateBridge __Hotfix0_LoadProfessionLargeIconHub;

		// Token: 0x04007381 RID: 29569
		[Token(Token = "0x4007381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private static DelegateBridge __Hotfix0_LoadShopImageHub;

		// Token: 0x04007382 RID: 29570
		[Token(Token = "0x4007382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		private static DelegateBridge __Hotfix0_LoadGiftPackageImageHub;

		// Token: 0x04007383 RID: 29571
		[Token(Token = "0x4007383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private static DelegateBridge __Hotfix0_LoadNumberIconHub;

		// Token: 0x04007384 RID: 29572
		[Token(Token = "0x4007384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		private static DelegateBridge __Hotfix0_LoadItemIconStackHub;

		// Token: 0x04007385 RID: 29573
		[Token(Token = "0x4007385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		private static DelegateBridge __Hotfix0_LoadEnemyIconHub;

		// Token: 0x04007386 RID: 29574
		[Token(Token = "0x4007386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		private static DelegateBridge __Hotfix0_LoadClueHub;

		// Token: 0x04007387 RID: 29575
		[Token(Token = "0x4007387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private static DelegateBridge __Hotfix0_LoadFurnitureGroupDetailHub;

		// Token: 0x04007388 RID: 29576
		[Token(Token = "0x4007388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private static DelegateBridge __Hotfix0_LoadGachaDetailHub;

		// Token: 0x04007389 RID: 29577
		[Token(Token = "0x4007389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHub;

		// Token: 0x0400738A RID: 29578
		[Token(Token = "0x400738A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHubByAct;

		// Token: 0x0400738B RID: 29579
		[Token(Token = "0x400738B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHubByPage;

		// Token: 0x0400738C RID: 29580
		[Token(Token = "0x400738C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private static DelegateBridge __Hotfix1_LoadSpriteFromAutoPackHubByPage;

		// Token: 0x0400738D RID: 29581
		[Token(Token = "0x400738D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private static DelegateBridge __Hotfix0__CheckAndLoadAsset;
	}
}
