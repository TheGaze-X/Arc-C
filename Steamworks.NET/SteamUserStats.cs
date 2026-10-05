using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public static class SteamUserStats
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x000076AC File Offset: 0x000058AC
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x4F13AC0", Offset = "0x4F126C0", VA = "0x184F13AC0")]
		public static bool RequestCurrentStats()
		{
			return default(bool);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000076C4 File Offset: 0x000058C4
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x4F12E70", Offset = "0x4F11A70", VA = "0x184F12E70")]
		public static bool GetStat(string pchName, out int pData)
		{
			return default(bool);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000076DC File Offset: 0x000058DC
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x4F12C70", Offset = "0x4F11870", VA = "0x184F12C70")]
		public static bool GetStat(string pchName, out float pData)
		{
			return default(bool);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000076F4 File Offset: 0x000058F4
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x4F14120", Offset = "0x4F12D20", VA = "0x184F14120")]
		public static bool SetStat(string pchName, int nData)
		{
			return default(bool);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000770C File Offset: 0x0000590C
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x4F14320", Offset = "0x4F12F20", VA = "0x184F14320")]
		public static bool SetStat(string pchName, float fData)
		{
			return default(bool);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00007724 File Offset: 0x00005924
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x4F145D0", Offset = "0x4F131D0", VA = "0x184F145D0")]
		public static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000773C File Offset: 0x0000593C
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x4F11970", Offset = "0x4F10570", VA = "0x184F11970")]
		public static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00007754 File Offset: 0x00005954
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x4F13F20", Offset = "0x4F12B20", VA = "0x184F13F20")]
		public static bool SetAchievement(string pchName)
		{
			return default(bool);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000776C File Offset: 0x0000596C
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x4F10300", Offset = "0x4F0EF00", VA = "0x184F10300")]
		public static bool ClearAchievement(string pchName)
		{
			return default(bool);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00007784 File Offset: 0x00005984
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x4F10DA0", Offset = "0x4F0F9A0", VA = "0x184F10DA0")]
		public static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000779C File Offset: 0x0000599C
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x4F14520", Offset = "0x4F13120", VA = "0x184F14520")]
		public static bool StoreStats()
		{
			return default(bool);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000077B4 File Offset: 0x000059B4
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x4F112A0", Offset = "0x4F0FEA0", VA = "0x184F112A0")]
		public static int GetAchievementIcon(string pchName)
		{
			return 0;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x4F10FC0", Offset = "0x4F0FBC0", VA = "0x184F10FC0")]
		public static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			return null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000077CC File Offset: 0x000059CC
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x4F138B0", Offset = "0x4F124B0", VA = "0x184F138B0")]
		public static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			return default(bool);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000077E4 File Offset: 0x000059E4
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x4F12AD0", Offset = "0x4F116D0", VA = "0x184F12AD0")]
		public static uint GetNumAchievements()
		{
			return 0U;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x4F11490", Offset = "0x4F10090", VA = "0x184F11490")]
		public static string GetAchievementName(uint iAchievement)
		{
			return null;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000077FC File Offset: 0x000059FC
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x4F13D60", Offset = "0x4F12960", VA = "0x184F13D60")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00007814 File Offset: 0x00005A14
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4F134B0", Offset = "0x4F120B0", VA = "0x184F134B0")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000782C File Offset: 0x00005A2C
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4F136B0", Offset = "0x4F122B0", VA = "0x184F136B0")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00007844 File Offset: 0x00005A44
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4F13290", Offset = "0x4F11E90", VA = "0x184F13290")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000785C File Offset: 0x00005A5C
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x4F13070", Offset = "0x4F11C70", VA = "0x184F13070")]
		public static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			return default(bool);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00007874 File Offset: 0x00005A74
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x4F13E60", Offset = "0x4F12A60", VA = "0x184F13E60")]
		public static bool ResetAllStats(bool bAchievementsToo)
		{
			return default(bool);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000788C File Offset: 0x00005A8C
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x4F10970", Offset = "0x4F0F570", VA = "0x184F10970")]
		public static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000078A4 File Offset: 0x00005AA4
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x4F10750", Offset = "0x4F0F350", VA = "0x184F10750")]
		public static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x4F12610", Offset = "0x4F11210", VA = "0x184F12610")]
		public static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			return null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000078BC File Offset: 0x00005ABC
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x4F12550", Offset = "0x4F11150", VA = "0x184F12550")]
		public static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			return 0;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000078D4 File Offset: 0x00005AD4
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x4F126E0", Offset = "0x4F112E0", VA = "0x184F126E0")]
		public static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			return ELeaderboardSortMethod.k_ELeaderboardSortMethodNone;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000078EC File Offset: 0x00005AEC
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x4F12490", Offset = "0x4F11090", VA = "0x184F12490")]
		public static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			return ELeaderboardDisplayType.k_ELeaderboardDisplayTypeNone;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00007904 File Offset: 0x00005B04
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x4F10620", Offset = "0x4F0F220", VA = "0x184F10620")]
		public static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000791C File Offset: 0x00005B1C
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x4F10500", Offset = "0x4F0F100", VA = "0x184F10500")]
		public static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, CSteamID[] prgUsers, int cUsers)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00007934 File Offset: 0x00005B34
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x4F11B80", Offset = "0x4F10780", VA = "0x184F11B80")]
		public static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, int[] pDetails, int cDetailsMax)
		{
			return default(bool);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000794C File Offset: 0x00005B4C
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x4F147E0", Offset = "0x4F133E0", VA = "0x184F147E0")]
		public static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, int[] pScoreDetails, int cScoreDetailsCount)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00007964 File Offset: 0x00005B64
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x4F101F0", Offset = "0x4F0EDF0", VA = "0x184F101F0")]
		public static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000797C File Offset: 0x00005B7C
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x4F12B80", Offset = "0x4F11780", VA = "0x184F12B80")]
		public static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00007994 File Offset: 0x00005B94
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x4F13B70", Offset = "0x4F12770", VA = "0x184F13B70")]
		public static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000079AC File Offset: 0x00005BAC
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x4F127A0", Offset = "0x4F113A0", VA = "0x184F127A0")]
		public static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return 0;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000079C4 File Offset: 0x00005BC4
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x4F12930", Offset = "0x4F11530", VA = "0x184F12930")]
		public static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			return 0;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000079DC File Offset: 0x00005BDC
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x4F10BA0", Offset = "0x4F0F7A0", VA = "0x184F10BA0")]
		public static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			return default(bool);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000079F4 File Offset: 0x00005BF4
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x4F13C60", Offset = "0x4F12860", VA = "0x184F13C60")]
		public static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00007A0C File Offset: 0x00005C0C
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x4F12290", Offset = "0x4F10E90", VA = "0x184F12290")]
		public static bool GetGlobalStat(string pchStatName, out long pData)
		{
			return default(bool);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00007A24 File Offset: 0x00005C24
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x4F12090", Offset = "0x4F10C90", VA = "0x184F12090")]
		public static bool GetGlobalStat(string pchStatName, out double pData)
		{
			return default(bool);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00007A3C File Offset: 0x00005C3C
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x4F11C90", Offset = "0x4F10890", VA = "0x184F11C90")]
		public static int GetGlobalStatHistory(string pchStatName, long[] pData, uint cubData)
		{
			return 0;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00007A54 File Offset: 0x00005C54
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x4F11E90", Offset = "0x4F10A90", VA = "0x184F11E90")]
		public static int GetGlobalStatHistory(string pchStatName, double[] pData, uint cubData)
		{
			return 0;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00007A6C File Offset: 0x00005C6C
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x4F11760", Offset = "0x4F10360", VA = "0x184F11760")]
		public static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress)
		{
			return default(bool);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00007A84 File Offset: 0x00005C84
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x4F11550", Offset = "0x4F10150", VA = "0x184F11550")]
		public static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress)
		{
			return default(bool);
		}
	}
}
