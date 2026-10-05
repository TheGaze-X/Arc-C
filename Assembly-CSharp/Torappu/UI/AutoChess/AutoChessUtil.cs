using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity.AutoChess;
using Torappu.Battle;
using Torappu.Battle.AutoChess;
using Torappu.UI.AutoChess.Server;
using Torappu.UI.CommonInviteDialog;
using Torappu.UI.Friend;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006285 RID: 25221
	[Token(Token = "0x2006285")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class AutoChessUtil
	{
		// Token: 0x060245A7 RID: 148903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245A7")]
		[Address(RVA = "0x1F30450", Offset = "0x1F2F050", VA = "0x181F30450")]
		public static ActAutoChessData GetActAutoChessData(string actId)
		{
			return null;
		}

		// Token: 0x060245A8 RID: 148904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245A8")]
		[Address(RVA = "0x1F30530", Offset = "0x1F2F130", VA = "0x181F30530")]
		public static PlayerActivity.PlayerActAutoChessActivity GetActAutoChessPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x060245A9 RID: 148905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245A9")]
		[Address(RVA = "0x1F318D0", Offset = "0x1F304D0", VA = "0x181F318D0")]
		public static string GetTrainingModeId(string actId)
		{
			return null;
		}

		// Token: 0x060245AA RID: 148906 RVA: 0x000C3EA0 File Offset: 0x000C20A0
		[Token(Token = "0x60245AA")]
		[Address(RVA = "0x1F32610", Offset = "0x1F31210", VA = "0x181F32610")]
		public static bool IsTrainingModeFinished(string actId)
		{
			return default(bool);
		}

		// Token: 0x060245AB RID: 148907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245AB")]
		[Address(RVA = "0x1F30B70", Offset = "0x1F2F770", VA = "0x181F30B70")]
		public static ActAutoChessData.ActAutoChessCharShopChessData GetCharShopChessDataByChessId(ActAutoChessData gameData, string chessId)
		{
			return null;
		}

		// Token: 0x060245AC RID: 148908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245AC")]
		[Address(RVA = "0x1F319F0", Offset = "0x1F305F0", VA = "0x181F319F0")]
		public static ActAutoChessData.ActAutoChessTrapShopChessData GetTrapShopChessDataByChessId(ActAutoChessData gameData, string chessId)
		{
			return null;
		}

		// Token: 0x060245AD RID: 148909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245AD")]
		[Address(RVA = "0x1F31950", Offset = "0x1F30550", VA = "0x181F31950")]
		public static ActAutoChessData.ActAutoChessTrapChessData GetTrapChessDataByChessId(ActAutoChessData actData, string chessId)
		{
			return null;
		}

		// Token: 0x060245AE RID: 148910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245AE")]
		[Address(RVA = "0x1F34370", Offset = "0x1F32F70", VA = "0x181F34370")]
		public static IEnumerable<ActAutoChessData.ActAutoChessBondInfo> TraverseCharBasicBond(string actId, CharQuery charQuery)
		{
			return null;
		}

		// Token: 0x060245AF RID: 148911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245AF")]
		[Address(RVA = "0x1F34F60", Offset = "0x1F33B60", VA = "0x181F34F60")]
		private static ActAutoChessData.ActAutoChessBondInfo _FindPowerBond(Dictionary<string, ActAutoChessData.ActAutoChessBondInfo> bondInfoDict, string powerId)
		{
			return null;
		}

		// Token: 0x060245B0 RID: 148912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B0")]
		[Address(RVA = "0x1F33820", Offset = "0x1F32420", VA = "0x181F33820")]
		public static ActAutoChessData.ActAutoChessBondInfo LoadSeasonFallbackBond(string actId)
		{
			return null;
		}

		// Token: 0x060245B1 RID: 148913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B1")]
		[Address(RVA = "0x1F30970", Offset = "0x1F2F570", VA = "0x181F30970")]
		public static CharacterData GetCharDataOfTrapChess(ActAutoChessData actData, string chessId)
		{
			return null;
		}

		// Token: 0x060245B2 RID: 148914 RVA: 0x000C3EB8 File Offset: 0x000C20B8
		[Token(Token = "0x60245B2")]
		[Address(RVA = "0x1F31700", Offset = "0x1F30300", VA = "0x181F31700")]
		public static int GetShopCharSkillOnlyIndex(AutoChessShopCharChessCardViewModel charCardViewModel, ActAutoChessData.ActAutoChessCharShopChessData chessShopData)
		{
			return 0;
		}

		// Token: 0x060245B3 RID: 148915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B3")]
		[Address(RVA = "0x1F315F0", Offset = "0x1F301F0", VA = "0x181F315F0")]
		public static string GetShopCharLimitEquipStr(AutoChessShopCharChessCardViewModel charCardViewModel, ActAutoChessData.ActAutoChessCharShopChessData chessShopData)
		{
			return null;
		}

		// Token: 0x060245B4 RID: 148916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B4")]
		[Address(RVA = "0x1F31AF0", Offset = "0x1F306F0", VA = "0x181F31AF0")]
		public static SkillData GetTrapSkillDataByChessId(ActAutoChessData actData, string chessId)
		{
			return null;
		}

		// Token: 0x060245B5 RID: 148917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B5")]
		[Address(RVA = "0x1F32AC0", Offset = "0x1F316C0", VA = "0x181F32AC0")]
		public static Sprite LoadBondIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245B6 RID: 148918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B6")]
		[Address(RVA = "0x1F32930", Offset = "0x1F31530", VA = "0x181F32930")]
		public static Sprite LoadBondBoardIcon(int activeCount, int requireCount, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245B7 RID: 148919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B7")]
		[Address(RVA = "0x1F33320", Offset = "0x1F31F20", VA = "0x181F33320")]
		public static Sprite LoadEnemyTypeIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245B8 RID: 148920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B8")]
		[Address(RVA = "0x1F33420", Offset = "0x1F32020", VA = "0x181F33420")]
		public static Sprite LoadGarrisonTypeIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245B9 RID: 148921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245B9")]
		[Address(RVA = "0x1F32830", Offset = "0x1F31430", VA = "0x181F32830")]
		public static Sprite LoadBandIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245BA RID: 148922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245BA")]
		[Address(RVA = "0x1F33620", Offset = "0x1F32220", VA = "0x181F33620")]
		public static Sprite LoadModeIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245BB RID: 148923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245BB")]
		[Address(RVA = "0x1F32D00", Offset = "0x1F31900", VA = "0x181F32D00")]
		public static Sprite LoadCharEliteSprite(bool isGold, EvolvePhase evolvePhase, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245BC RID: 148924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245BC")]
		[Address(RVA = "0x1F32E80", Offset = "0x1F31A80", VA = "0x181F32E80")]
		public static Sprite LoadCharEliteSprite(string evolveIconId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x060245BD RID: 148925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245BD")]
		[Address(RVA = "0x1F32BC0", Offset = "0x1F317C0", VA = "0x181F32BC0")]
		public static Sprite LoadCharDetailEliteIconSprite(EvolvePhase evolvePhase, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245BE RID: 148926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245BE")]
		[Address(RVA = "0x1F32F80", Offset = "0x1F31B80", VA = "0x181F32F80")]
		public static Sprite LoadCharRankRaritySprite(RarityRank rarity, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245BF RID: 148927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245BF")]
		[Address(RVA = "0x1F331F0", Offset = "0x1F31DF0", VA = "0x181F331F0")]
		public static Sprite LoadChessLevelIcon(int level, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C0 RID: 148928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C0")]
		[Address(RVA = "0x1F330C0", Offset = "0x1F31CC0", VA = "0x181F330C0")]
		public static Sprite LoadChessLevelDetailIconSprite(int level, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C1 RID: 148929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C1")]
		[Address(RVA = "0x1F33A10", Offset = "0x1F32610", VA = "0x181F33A10")]
		public static Sprite LoadShopLevelIcon(int level, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C2 RID: 148930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C2")]
		[Address(RVA = "0x1F33B40", Offset = "0x1F32740", VA = "0x181F33B40")]
		public static Sprite LoadShopLevelTag(int level, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C3 RID: 148931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C3")]
		[Address(RVA = "0x1F33910", Offset = "0x1F32510", VA = "0x181F33910")]
		public static Sprite LoadShopItemIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C4 RID: 148932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C4")]
		[Address(RVA = "0x1F33520", Offset = "0x1F32120", VA = "0x181F33520")]
		public static Sprite LoadMedalIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C5 RID: 148933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C5")]
		[Address(RVA = "0x1F33720", Offset = "0x1F32320", VA = "0x181F33720")]
		public static Sprite LoadPlayerTitleIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060245C6 RID: 148934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245C6")]
		[Address(RVA = "0x1F32780", Offset = "0x1F31380", VA = "0x181F32780")]
		public static Sprite LoadActSeasonLogo(string logoId, string actId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060245C7 RID: 148935 RVA: 0x000C3ED0 File Offset: 0x000C20D0
		[Token(Token = "0x60245C7")]
		[Address(RVA = "0x1F2F8C0", Offset = "0x1F2E4C0", VA = "0x181F2F8C0")]
		public static bool CheckBandTrack(string bandId)
		{
			return default(bool);
		}

		// Token: 0x060245C8 RID: 148936 RVA: 0x000C3EE8 File Offset: 0x000C20E8
		[Token(Token = "0x60245C8")]
		[Address(RVA = "0x1F2F830", Offset = "0x1F2E430", VA = "0x181F2F830")]
		public static bool CheckAllBandTrack()
		{
			return default(bool);
		}

		// Token: 0x060245C9 RID: 148937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245C9")]
		[Address(RVA = "0x1F30090", Offset = "0x1F2EC90", VA = "0x181F30090")]
		public static void ConsumeBandTrack(string bandId)
		{
		}

		// Token: 0x060245CA RID: 148938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245CA")]
		[Address(RVA = "0x1F33F20", Offset = "0x1F32B20", VA = "0x181F33F20")]
		public static void RecordModeUnlockTrigger(string actId, string newlyUnlockedMode)
		{
		}

		// Token: 0x060245CB RID: 148939 RVA: 0x000C3F00 File Offset: 0x000C2100
		[Token(Token = "0x60245CB")]
		[Address(RVA = "0x1F2FD20", Offset = "0x1F2E920", VA = "0x181F2FD20")]
		public static bool CheckModeTrackPoint(string actId, string modeId)
		{
			return default(bool);
		}

		// Token: 0x060245CC RID: 148940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245CC")]
		[Address(RVA = "0x1F30230", Offset = "0x1F2EE30", VA = "0x181F30230")]
		public static void ConsumeModeTrackPoint(string actId, string modeId)
		{
		}

		// Token: 0x060245CD RID: 148941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245CD")]
		[Address(RVA = "0x1F34470", Offset = "0x1F33070", VA = "0x181F34470")]
		private static void _ConsumeModeTrackPointImpl(string actId, ActAutoChessData.ActAutoChessModeData modeData)
		{
		}

		// Token: 0x060245CE RID: 148942 RVA: 0x000C3F18 File Offset: 0x000C2118
		[Token(Token = "0x60245CE")]
		[Address(RVA = "0x1F2FEA0", Offset = "0x1F2EAA0", VA = "0x181F2FEA0")]
		public static bool CheckModeTypeTrackPoint(string actId, ActAutoChessModeType modeType)
		{
			return default(bool);
		}

		// Token: 0x060245CF RID: 148943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245CF")]
		[Address(RVA = "0x1F35530", Offset = "0x1F34130", VA = "0x181F35530")]
		private static string _GetTriggerTypeWithActId(string actId, ActAutoChessModeType type)
		{
			return null;
		}

		// Token: 0x060245D0 RID: 148944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245D0")]
		[Address(RVA = "0x1F35670", Offset = "0x1F34270", VA = "0x181F35670")]
		private static void _RecordChessPoolCharTrackPoint(string activityId, IList<string> chessIdList)
		{
		}

		// Token: 0x060245D1 RID: 148945 RVA: 0x000C3F30 File Offset: 0x000C2130
		[Token(Token = "0x60245D1")]
		[Address(RVA = "0x1F2FA50", Offset = "0x1F2E650", VA = "0x181F2FA50")]
		public static bool CheckChessPoolCharTrackPoint(string activityId, string chessId)
		{
			return default(bool);
		}

		// Token: 0x060245D2 RID: 148946 RVA: 0x000C3F48 File Offset: 0x000C2148
		[Token(Token = "0x60245D2")]
		[Address(RVA = "0x1F2F9B0", Offset = "0x1F2E5B0", VA = "0x181F2F9B0")]
		public static bool CheckCheckPoolCharGroupTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x060245D3 RID: 148947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245D3")]
		[Address(RVA = "0x1F30180", Offset = "0x1F2ED80", VA = "0x181F30180")]
		public static void ConsumeChessPoolCharTrackPoint(string activityId, string chessId)
		{
		}

		// Token: 0x060245D4 RID: 148948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245D4")]
		[Address(RVA = "0x1F35490", Offset = "0x1F34090", VA = "0x181F35490")]
		private static string _GetChessCharTrackType(string actId)
		{
			return null;
		}

		// Token: 0x060245D5 RID: 148949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245D5")]
		[Address(RVA = "0x1F30D00", Offset = "0x1F2F900", VA = "0x181F30D00")]
		public static AutoChessData.AutoChessEnterStepData GetEnterStepData(AutoChessPrepareStepType stepType)
		{
			return null;
		}

		// Token: 0x060245D6 RID: 148950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245D6")]
		[Address(RVA = "0x1F31E20", Offset = "0x1F30A20", VA = "0x181F31E20")]
		public static string GetValidSelectedModeId(string actId, ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType)
		{
			return null;
		}

		// Token: 0x060245D7 RID: 148951 RVA: 0x000C3F60 File Offset: 0x000C2160
		[Token(Token = "0x60245D7")]
		[Address(RVA = "0x1F31D30", Offset = "0x1F30930", VA = "0x181F31D30")]
		public static bool GetValidMultiMatchRange(string actId, ActAutoChessMultiModeSubType multiModeSubType)
		{
			return default(bool);
		}

		// Token: 0x060245D8 RID: 148952 RVA: 0x000C3F78 File Offset: 0x000C2178
		[Token(Token = "0x60245D8")]
		[Address(RVA = "0x1F31C50", Offset = "0x1F30850", VA = "0x181F31C50")]
		public static bool GetValidMatchFlag(string actId, ActAutoChessMultiModeSubType multiModeSubType)
		{
			return default(bool);
		}

		// Token: 0x060245D9 RID: 148953 RVA: 0x000C3F90 File Offset: 0x000C2190
		[Token(Token = "0x60245D9")]
		[Address(RVA = "0x1F30C70", Offset = "0x1F2F870", VA = "0x181F30C70")]
		public static AutoChessPrepareStepType GetEnterPrepareStep(AutoChessTeamState teamState)
		{
			return AutoChessPrepareStepType.NONE;
		}

		// Token: 0x060245DA RID: 148954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245DA")]
		[Address(RVA = "0x1F30F30", Offset = "0x1F2FB30", VA = "0x181F30F30")]
		public static ActAutoChessData.ActAutoChessModeData GetModeData(string actId, string modeId)
		{
			return null;
		}

		// Token: 0x060245DB RID: 148955 RVA: 0x000C3FA8 File Offset: 0x000C21A8
		[Token(Token = "0x60245DB")]
		[Address(RVA = "0x1F2FB00", Offset = "0x1F2E700", VA = "0x181F2FB00")]
		public static bool CheckIfBandEnable(string actId, string bandId, ActAutoChessModeType currMode)
		{
			return default(bool);
		}

		// Token: 0x060245DC RID: 148956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245DC")]
		[Address(RVA = "0x1F30760", Offset = "0x1F2F360", VA = "0x181F30760")]
		public static ActAutoChessData.ActAutoChessShopCharChessInfoData GetCharChessInfo(int chessLevel, bool isGold, ActAutoChessData actData)
		{
			return null;
		}

		// Token: 0x060245DD RID: 148957 RVA: 0x000C3FC0 File Offset: 0x000C21C0
		[Token(Token = "0x60245DD")]
		[Address(RVA = "0x1F30EB0", Offset = "0x1F2FAB0", VA = "0x181F30EB0")]
		public static long GetMatchBannedTs(string actId)
		{
			return 0L;
		}

		// Token: 0x060245DE RID: 148958 RVA: 0x000C3FD8 File Offset: 0x000C21D8
		[Token(Token = "0x60245DE")]
		[Address(RVA = "0x1F2F260", Offset = "0x1F2DE60", VA = "0x181F2F260")]
		public static bool BuildInviteDialog(UICompDialogMgr dialogMgr, string actId, bool showInvited, Dictionary<string, long> invitedCache, string[] excludedPlayers, out int instId)
		{
			return default(bool);
		}

		// Token: 0x060245DF RID: 148959 RVA: 0x000C3FF0 File Offset: 0x000C21F0
		[Token(Token = "0x60245DF")]
		[Address(RVA = "0x1F2F000", Offset = "0x1F2DC00", VA = "0x181F2F000")]
		public static bool BuildConfirmDialogInPage(UICompDialogMgr dialogMgr, AutoChessConfirmDialogConfig config, out int instId)
		{
			return default(bool);
		}

		// Token: 0x060245E0 RID: 148960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245E0")]
		[Address(RVA = "0x1F34050", Offset = "0x1F32C50", VA = "0x181F34050")]
		public static void ShowTextToast(ILoadAsset assetLoader, string toastStr, bool useDeduplicate = true)
		{
		}

		// Token: 0x060245E1 RID: 148961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245E1")]
		[Address(RVA = "0x1F342B0", Offset = "0x1F32EB0", VA = "0x181F342B0")]
		public static void StartBattle(AutoChessUtil.StartBattleParam param)
		{
		}

		// Token: 0x060245E2 RID: 148962 RVA: 0x000C4008 File Offset: 0x000C2208
		[Token(Token = "0x60245E2")]
		[Address(RVA = "0x1F358E0", Offset = "0x1F344E0", VA = "0x181F358E0")]
		private static bool _StartBattle(AutoChessUtil.StartBattleParam param)
		{
			return default(bool);
		}

		// Token: 0x060245E3 RID: 148963 RVA: 0x000C4020 File Offset: 0x000C2220
		[Token(Token = "0x60245E3")]
		[Address(RVA = "0x1F34600", Offset = "0x1F33200", VA = "0x181F34600")]
		private static bool _DoBattleStart(StageData stageData, BattleStageInfo overrideStageInfo, GameModeMeta gameModeMeta, AutoChessUtil.StartBattleParam inParam)
		{
			return default(bool);
		}

		// Token: 0x060245E4 RID: 148964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245E4")]
		[Address(RVA = "0x1F35260", Offset = "0x1F33E60", VA = "0x181F35260")]
		private static DataBundle _GeneRecoverPageDataBundleForBattle(string actId, ActAutoChessModeType modeType, ActAutoChessMultiModeSubType multiModeSubType)
		{
			return null;
		}

		// Token: 0x060245E5 RID: 148965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245E5")]
		[Address(RVA = "0x1F30FE0", Offset = "0x1F2FBE0", VA = "0x181F30FE0")]
		public static UIPageControllerParam GetSceneParam(DataBundle dataBundle)
		{
			return null;
		}

		// Token: 0x060245E6 RID: 148966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245E6")]
		[Address(RVA = "0x1F34530", Offset = "0x1F33130", VA = "0x181F34530")]
		private static AutoChessPreparePage.Params _CreatePreaparePageParamFromDataBundle(DataBundle dataBundle, AutoChessOutput actMeta)
		{
			return null;
		}

		// Token: 0x060245E7 RID: 148967 RVA: 0x000C4038 File Offset: 0x000C2238
		[Token(Token = "0x60245E7")]
		[Address(RVA = "0x1F35600", Offset = "0x1F34200", VA = "0x181F35600")]
		private static bool _IsMultiServiceMode(ActAutoChessModeType modeType)
		{
			return default(bool);
		}

		// Token: 0x060245E8 RID: 148968 RVA: 0x000C4050 File Offset: 0x000C2250
		[Token(Token = "0x60245E8")]
		[Address(RVA = "0x1F324E0", Offset = "0x1F310E0", VA = "0x181F324E0")]
		public static bool HasBattleNeedToSettle(ActAutoChessSyncInfoBattleInfo battleInfo)
		{
			return default(bool);
		}

		// Token: 0x060245E9 RID: 148969 RVA: 0x000C4068 File Offset: 0x000C2268
		[Token(Token = "0x60245E9")]
		[Address(RVA = "0x1F32440", Offset = "0x1F31040", VA = "0x181F32440")]
		public static bool HasBattleNeedToReconnect(ActAutoChessSyncInfoBattleInfo battleInfo)
		{
			return default(bool);
		}

		// Token: 0x060245EA RID: 148970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245EA")]
		[Address(RVA = "0x1F32300", Offset = "0x1F30F00", VA = "0x181F32300")]
		public static AutoChessServiceTeamInfo GetValidServiceTeamInfo()
		{
			return null;
		}

		// Token: 0x060245EB RID: 148971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245EB")]
		[Address(RVA = "0x1F323C0", Offset = "0x1F30FC0", VA = "0x181F323C0")]
		public static void HandleSyncInfo(string actId, ActAutoChessSyncInfoResponse response)
		{
		}

		// Token: 0x060245EC RID: 148972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245EC")]
		[Address(RVA = "0x1F2F4A0", Offset = "0x1F2E0A0", VA = "0x181F2F4A0")]
		public static List<string> CalculateBannedChessIdList(string actId, List<string> bannedBondId)
		{
			return null;
		}

		// Token: 0x060245ED RID: 148973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245ED")]
		[Address(RVA = "0x1F317E0", Offset = "0x1F303E0", VA = "0x181F317E0")]
		public static string GetTeamIdFromFormatByInputTxt(string inputTxt)
		{
			return null;
		}

		// Token: 0x060245EE RID: 148974 RVA: 0x000C4080 File Offset: 0x000C2280
		[Token(Token = "0x60245EE")]
		[Address(RVA = "0x1F2FC40", Offset = "0x1F2E840", VA = "0x181F2FC40")]
		public static bool CheckIsTeamIdLegal(string teamId)
		{
			return default(bool);
		}

		// Token: 0x060245EF RID: 148975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245EF")]
		[Address(RVA = "0x1F33C70", Offset = "0x1F32870", VA = "0x181F33C70")]
		public static string LookUpMedalIconId(int medalCnt)
		{
			return null;
		}

		// Token: 0x060245F0 RID: 148976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60245F0")]
		[Address(RVA = "0x1F30620", Offset = "0x1F2F220", VA = "0x181F30620")]
		public static string GetBattleSceneIdInBattle()
		{
			return null;
		}

		// Token: 0x040328FA RID: 207098
		[Token(Token = "0x40328FA")]
		private const string CHAR_ELITE_BASE_FORMAT = "char_elite_base_{0}";

		// Token: 0x040328FB RID: 207099
		[Token(Token = "0x40328FB")]
		private const string CHAR_ELITE_GOLD_FORMAT = "char_elite_gold_{0}";

		// Token: 0x040328FC RID: 207100
		[Token(Token = "0x40328FC")]
		private const string CHAR_ELITE_DETAIL_FORMAT = "char_elite_detail_{0}";

		// Token: 0x040328FD RID: 207101
		[Token(Token = "0x40328FD")]
		private const string CHAR_RARITY_RES_FORMAT = "rarity_{0}";

		// Token: 0x040328FE RID: 207102
		[Token(Token = "0x40328FE")]
		private const string CHESS_LEVEL_ICON_FORMAT = "chess_level_icon_{0}";

		// Token: 0x040328FF RID: 207103
		[Token(Token = "0x40328FF")]
		private const string CHESS_LEVEL_DETAIL_ICON_FORMAT = "chess_level_detail_{0}";

		// Token: 0x04032900 RID: 207104
		[Token(Token = "0x4032900")]
		private const string SHOP_LEVEL_ICON_FORMAT = "shop_level_icon_{0}";

		// Token: 0x04032901 RID: 207105
		[Token(Token = "0x4032901")]
		private const string SHOP_LEVEL_TAG_FORMAT = "shop_level_tag_{0}";

		// Token: 0x04032902 RID: 207106
		[Token(Token = "0x4032902")]
		private const char TEAM_ID_FORMAT_PREFIX = '[';

		// Token: 0x04032903 RID: 207107
		[Token(Token = "0x4032903")]
		private const char TEAM_ID_FORMAT_SUFFIX = ']';

		// Token: 0x04032904 RID: 207108
		[Token(Token = "0x4032904")]
		private const int TEAM_ID_DIGITS_LENGTH = 14;

		// Token: 0x04032905 RID: 207109
		[Token(Token = "0x4032905")]
		private const char TEAM_ID_NUMBER_FROM = '0';

		// Token: 0x04032906 RID: 207110
		[Token(Token = "0x4032906")]
		private const char TEAM_ID_NUMBER_TO = '9';

		// Token: 0x04032907 RID: 207111
		[Token(Token = "0x4032907")]
		private const char TEAM_ID_CHARACTER_FROM = 'a';

		// Token: 0x04032908 RID: 207112
		[Token(Token = "0x4032908")]
		private const char TEAM_ID_CHARACTER_TO = 'n';

		// Token: 0x04032909 RID: 207113
		[Token(Token = "0x4032909")]
		public const string KEY_BATTLE_META_MODE_ID = "mode_id";

		// Token: 0x0403290A RID: 207114
		[Token(Token = "0x403290A")]
		public const string KEY_BATTLE_META_IS_TRAINING = "is_training";

		// Token: 0x0403290B RID: 207115
		[Token(Token = "0x403290B")]
		public const int MAX_CHESS_LEVEL = 6;

		// Token: 0x0403290C RID: 207116
		[Token(Token = "0x403290C")]
		public const int TUTORIAL_FIVE_GROUP_LEVEL = 5;

		// Token: 0x0403290D RID: 207117
		[Token(Token = "0x403290D")]
		public const string AUTO_CHESS_BAND_UNLOCK_TRACK_FORMAT = "AUTO_CHESS_BAND_UNLOCK_{0}";

		// Token: 0x0403290E RID: 207118
		[Token(Token = "0x403290E")]
		private const string AUTO_CHESS_MODE_UNLOCK_TRACK_FORMAT = "{0}_MODE_{1}";

		// Token: 0x0403290F RID: 207119
		[Token(Token = "0x403290F")]
		private const string CHESS_POOL_CHAR_TRACK_FORMAT = "{0}_chess_pool_char";

		// Token: 0x04032910 RID: 207120
		[Token(Token = "0x4032910")]
		public const int MAX_PLAYER_COUNT = 4;

		// Token: 0x04032911 RID: 207121
		[Token(Token = "0x4032911")]
		private const string BOND_BOARD_ICON_FORMAT = "{0}_{1}";

		// Token: 0x04032912 RID: 207122
		[Token(Token = "0x4032912")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActAutoChessData;

		// Token: 0x04032913 RID: 207123
		[Token(Token = "0x4032913")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActAutoChessPlayerData;

		// Token: 0x04032914 RID: 207124
		[Token(Token = "0x4032914")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTrainingModeId;

		// Token: 0x04032915 RID: 207125
		[Token(Token = "0x4032915")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTrainingModeFinished;

		// Token: 0x04032916 RID: 207126
		[Token(Token = "0x4032916")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCharShopChessDataByChessId;

		// Token: 0x04032917 RID: 207127
		[Token(Token = "0x4032917")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetTrapShopChessDataByChessId;

		// Token: 0x04032918 RID: 207128
		[Token(Token = "0x4032918")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTrapChessDataByChessId;

		// Token: 0x04032919 RID: 207129
		[Token(Token = "0x4032919")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TraverseCharBasicBond;

		// Token: 0x0403291A RID: 207130
		[Token(Token = "0x403291A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FindPowerBond;

		// Token: 0x0403291B RID: 207131
		[Token(Token = "0x403291B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadSeasonFallbackBond;

		// Token: 0x0403291C RID: 207132
		[Token(Token = "0x403291C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCharDataOfTrapChess;

		// Token: 0x0403291D RID: 207133
		[Token(Token = "0x403291D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetShopCharSkillOnlyIndex;

		// Token: 0x0403291E RID: 207134
		[Token(Token = "0x403291E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetShopCharLimitEquipStr;

		// Token: 0x0403291F RID: 207135
		[Token(Token = "0x403291F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTrapSkillDataByChessId;

		// Token: 0x04032920 RID: 207136
		[Token(Token = "0x4032920")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadBondIcon;

		// Token: 0x04032921 RID: 207137
		[Token(Token = "0x4032921")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadBondBoardIcon;

		// Token: 0x04032922 RID: 207138
		[Token(Token = "0x4032922")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadEnemyTypeIcon;

		// Token: 0x04032923 RID: 207139
		[Token(Token = "0x4032923")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadGarrisonTypeIcon;

		// Token: 0x04032924 RID: 207140
		[Token(Token = "0x4032924")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadBandIcon;

		// Token: 0x04032925 RID: 207141
		[Token(Token = "0x4032925")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadModeIcon;

		// Token: 0x04032926 RID: 207142
		[Token(Token = "0x4032926")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadCharEliteSprite;

		// Token: 0x04032927 RID: 207143
		[Token(Token = "0x4032927")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix1_LoadCharEliteSprite;

		// Token: 0x04032928 RID: 207144
		[Token(Token = "0x4032928")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadCharDetailEliteIconSprite;

		// Token: 0x04032929 RID: 207145
		[Token(Token = "0x4032929")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadCharRankRaritySprite;

		// Token: 0x0403292A RID: 207146
		[Token(Token = "0x403292A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadChessLevelIcon;

		// Token: 0x0403292B RID: 207147
		[Token(Token = "0x403292B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadChessLevelDetailIconSprite;

		// Token: 0x0403292C RID: 207148
		[Token(Token = "0x403292C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadShopLevelIcon;

		// Token: 0x0403292D RID: 207149
		[Token(Token = "0x403292D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_LoadShopLevelTag;

		// Token: 0x0403292E RID: 207150
		[Token(Token = "0x403292E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_LoadShopItemIcon;

		// Token: 0x0403292F RID: 207151
		[Token(Token = "0x403292F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_LoadMedalIcon;

		// Token: 0x04032930 RID: 207152
		[Token(Token = "0x4032930")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadPlayerTitleIcon;

		// Token: 0x04032931 RID: 207153
		[Token(Token = "0x4032931")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadActSeasonLogo;

		// Token: 0x04032932 RID: 207154
		[Token(Token = "0x4032932")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckBandTrack;

		// Token: 0x04032933 RID: 207155
		[Token(Token = "0x4032933")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckAllBandTrack;

		// Token: 0x04032934 RID: 207156
		[Token(Token = "0x4032934")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ConsumeBandTrack;

		// Token: 0x04032935 RID: 207157
		[Token(Token = "0x4032935")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_RecordModeUnlockTrigger;

		// Token: 0x04032936 RID: 207158
		[Token(Token = "0x4032936")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckModeTrackPoint;

		// Token: 0x04032937 RID: 207159
		[Token(Token = "0x4032937")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ConsumeModeTrackPoint;

		// Token: 0x04032938 RID: 207160
		[Token(Token = "0x4032938")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__ConsumeModeTrackPointImpl;

		// Token: 0x04032939 RID: 207161
		[Token(Token = "0x4032939")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckModeTypeTrackPoint;

		// Token: 0x0403293A RID: 207162
		[Token(Token = "0x403293A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__GetTriggerTypeWithActId;

		// Token: 0x0403293B RID: 207163
		[Token(Token = "0x403293B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__RecordChessPoolCharTrackPoint;

		// Token: 0x0403293C RID: 207164
		[Token(Token = "0x403293C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CheckChessPoolCharTrackPoint;

		// Token: 0x0403293D RID: 207165
		[Token(Token = "0x403293D")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_CheckCheckPoolCharGroupTrack;

		// Token: 0x0403293E RID: 207166
		[Token(Token = "0x403293E")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ConsumeChessPoolCharTrackPoint;

		// Token: 0x0403293F RID: 207167
		[Token(Token = "0x403293F")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GetChessCharTrackType;

		// Token: 0x04032940 RID: 207168
		[Token(Token = "0x4032940")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_GetEnterStepData;

		// Token: 0x04032941 RID: 207169
		[Token(Token = "0x4032941")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_GetValidSelectedModeId;

		// Token: 0x04032942 RID: 207170
		[Token(Token = "0x4032942")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_GetValidMultiMatchRange;

		// Token: 0x04032943 RID: 207171
		[Token(Token = "0x4032943")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetValidMatchFlag;

		// Token: 0x04032944 RID: 207172
		[Token(Token = "0x4032944")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GetEnterPrepareStep;

		// Token: 0x04032945 RID: 207173
		[Token(Token = "0x4032945")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_GetModeData;

		// Token: 0x04032946 RID: 207174
		[Token(Token = "0x4032946")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_CheckIfBandEnable;

		// Token: 0x04032947 RID: 207175
		[Token(Token = "0x4032947")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_GetCharChessInfo;

		// Token: 0x04032948 RID: 207176
		[Token(Token = "0x4032948")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_GetMatchBannedTs;

		// Token: 0x04032949 RID: 207177
		[Token(Token = "0x4032949")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_BuildInviteDialog;

		// Token: 0x0403294A RID: 207178
		[Token(Token = "0x403294A")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_BuildConfirmDialogInPage;

		// Token: 0x0403294B RID: 207179
		[Token(Token = "0x403294B")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_ShowTextToast;

		// Token: 0x0403294C RID: 207180
		[Token(Token = "0x403294C")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x0403294D RID: 207181
		[Token(Token = "0x403294D")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__StartBattle;

		// Token: 0x0403294E RID: 207182
		[Token(Token = "0x403294E")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__DoBattleStart;

		// Token: 0x0403294F RID: 207183
		[Token(Token = "0x403294F")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__GeneRecoverPageDataBundleForBattle;

		// Token: 0x04032950 RID: 207184
		[Token(Token = "0x4032950")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GetSceneParam;

		// Token: 0x04032951 RID: 207185
		[Token(Token = "0x4032951")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__CreatePreaparePageParamFromDataBundle;

		// Token: 0x04032952 RID: 207186
		[Token(Token = "0x4032952")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__IsMultiServiceMode;

		// Token: 0x04032953 RID: 207187
		[Token(Token = "0x4032953")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_HasBattleNeedToSettle;

		// Token: 0x04032954 RID: 207188
		[Token(Token = "0x4032954")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_HasBattleNeedToReconnect;

		// Token: 0x04032955 RID: 207189
		[Token(Token = "0x4032955")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetValidServiceTeamInfo;

		// Token: 0x04032956 RID: 207190
		[Token(Token = "0x4032956")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_HandleSyncInfo;

		// Token: 0x04032957 RID: 207191
		[Token(Token = "0x4032957")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_CalculateBannedChessIdList;

		// Token: 0x04032958 RID: 207192
		[Token(Token = "0x4032958")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetTeamIdFromFormatByInputTxt;

		// Token: 0x04032959 RID: 207193
		[Token(Token = "0x4032959")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_CheckIsTeamIdLegal;

		// Token: 0x0403295A RID: 207194
		[Token(Token = "0x403295A")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_LookUpMedalIconId;

		// Token: 0x0403295B RID: 207195
		[Token(Token = "0x403295B")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_GetBattleSceneIdInBattle;

		// Token: 0x02006286 RID: 25222
		[Token(Token = "0x2006286")]
		private class ActAutoChessInvitePlugin : CommonInviteDialog.Plugin
		{
			// Token: 0x060245F1 RID: 148977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60245F1")]
			[Address(RVA = "0x1F22250", Offset = "0x1F20E50", VA = "0x181F22250", Slot = "4")]
			protected override void OnInit()
			{
			}

			// Token: 0x060245F2 RID: 148978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60245F2")]
			[Address(RVA = "0x1F21D00", Offset = "0x1F20900", VA = "0x181F21D00", Slot = "8")]
			public override List<string> DefineFriendSortInfoKeys()
			{
				return null;
			}

			// Token: 0x060245F3 RID: 148979 RVA: 0x000C4098 File Offset: 0x000C2298
			[Token(Token = "0x60245F3")]
			[Address(RVA = "0x1F22040", Offset = "0x1F20C40", VA = "0x181F22040", Slot = "5")]
			public override CommonInviteSortInfo.CustomImpl HandleFriendCustomSortInfo(FriendSortViewModel respModel)
			{
				return default(CommonInviteSortInfo.CustomImpl);
			}

			// Token: 0x060245F4 RID: 148980 RVA: 0x000C40B0 File Offset: 0x000C22B0
			[Token(Token = "0x60245F4")]
			[Address(RVA = "0x1F221A0", Offset = "0x1F20DA0", VA = "0x181F221A0", Slot = "6")]
			public override CommonInviteSortInfo.CustomImpl HandleInviteCustomSortInfo(PlayerInviteInfo inviteInfo)
			{
				return default(CommonInviteSortInfo.CustomImpl);
			}

			// Token: 0x060245F5 RID: 148981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60245F5")]
			[Address(RVA = "0x1F21D80", Offset = "0x1F20980", VA = "0x181F21D80", Slot = "7")]
			public override Comparison<CommonInviteSortInfo> DefineSortInfoComparison()
			{
				return null;
			}

			// Token: 0x060245F6 RID: 148982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60245F6")]
			[Address(RVA = "0x1F223F0", Offset = "0x1F20FF0", VA = "0x181F223F0")]
			public ActAutoChessInvitePlugin()
			{
			}

			// Token: 0x060245F7 RID: 148983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60245F7")]
			[Address(RVA = "0x1F223E0", Offset = "0x1F20FE0", VA = "0x181F223E0")]
			private void <>xLuaBaseProxy_OnInit()
			{
			}

			// Token: 0x060245F8 RID: 148984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60245F8")]
			[Address(RVA = "0x1F223C0", Offset = "0x1F20FC0", VA = "0x181F223C0")]
			private List<string> <>xLuaBaseProxy_DefineFriendSortInfoKeys()
			{
				return null;
			}

			// Token: 0x060245F9 RID: 148985 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60245F9")]
			[Address(RVA = "0x1F223D0", Offset = "0x1F20FD0", VA = "0x181F223D0")]
			private Comparison<CommonInviteSortInfo> <>xLuaBaseProxy_DefineSortInfoComparison()
			{
				return null;
			}

			// Token: 0x0403295C RID: 207196
			[Token(Token = "0x403295C")]
			private const string FIELD_IN_BATTLE = "inBattle";

			// Token: 0x0403295D RID: 207197
			[Token(Token = "0x403295D")]
			private const string FIELD_BATTLE_EXPIRE = "battleExpire";

			// Token: 0x0403295E RID: 207198
			[Token(Token = "0x403295E")]
			[FieldOffset(Offset = "0x28")]
			private string m_actId;

			// Token: 0x0403295F RID: 207199
			[Token(Token = "0x403295F")]
			[FieldOffset(Offset = "0x30")]
			private string m_actType;

			// Token: 0x04032960 RID: 207200
			[Token(Token = "0x4032960")]
			[FieldOffset(Offset = "0x38")]
			private ListSet<string> m_lastMates;

			// Token: 0x04032961 RID: 207201
			[Token(Token = "0x4032961")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x04032962 RID: 207202
			[Token(Token = "0x4032962")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DefineFriendSortInfoKeys;

			// Token: 0x04032963 RID: 207203
			[Token(Token = "0x4032963")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HandleFriendCustomSortInfo;

			// Token: 0x04032964 RID: 207204
			[Token(Token = "0x4032964")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HandleInviteCustomSortInfo;

			// Token: 0x04032965 RID: 207205
			[Token(Token = "0x4032965")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DefineSortInfoComparison;

			// Token: 0x04032966 RID: 207206
			[Token(Token = "0x4032966")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006287 RID: 25223
		[Token(Token = "0x2006287")]
		public struct StartBattleParam
		{
			// Token: 0x04032967 RID: 207207
			[Token(Token = "0x4032967")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x04032968 RID: 207208
			[Token(Token = "0x4032968")]
			[FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x04032969 RID: 207209
			[Token(Token = "0x4032969")]
			[FieldOffset(Offset = "0x10")]
			public string sceneId;

			// Token: 0x0403296A RID: 207210
			[Token(Token = "0x403296A")]
			[FieldOffset(Offset = "0x18")]
			public string modeId;

			// Token: 0x0403296B RID: 207211
			[Token(Token = "0x403296B")]
			[FieldOffset(Offset = "0x20")]
			public string stageName;

			// Token: 0x0403296C RID: 207212
			[Token(Token = "0x403296C")]
			[FieldOffset(Offset = "0x28")]
			public string stageCode;

			// Token: 0x0403296D RID: 207213
			[Token(Token = "0x403296D")]
			[FieldOffset(Offset = "0x30")]
			public string loadingPicId;

			// Token: 0x0403296E RID: 207214
			[Token(Token = "0x403296E")]
			[FieldOffset(Offset = "0x38")]
			public ActAutoChessModeType modeType;

			// Token: 0x0403296F RID: 207215
			[Token(Token = "0x403296F")]
			[FieldOffset(Offset = "0x3C")]
			public ActAutoChessMultiModeSubType multiModeSubType;
		}
	}
}
