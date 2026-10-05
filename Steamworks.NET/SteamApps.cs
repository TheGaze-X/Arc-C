using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public static class SteamApps
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4EA9EF0", Offset = "0x4EA8AF0", VA = "0x184EA9EF0")]
		public static bool BIsSubscribed()
		{
			return default(bool);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4EA9DB0", Offset = "0x4EA89B0", VA = "0x184EA9DB0")]
		public static bool BIsLowViolence()
		{
			return default(bool);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4EA9D10", Offset = "0x4EA8910", VA = "0x184EA9D10")]
		public static bool BIsCybercafe()
		{
			return default(bool);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4EA9FA0", Offset = "0x4EA8BA0", VA = "0x184EA9FA0")]
		public static bool BIsVACBanned()
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4EAA4B0", Offset = "0x4EA90B0", VA = "0x184EAA4B0")]
		public static string GetCurrentGameLanguage()
		{
			return null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4EAA1E0", Offset = "0x4EA8DE0", VA = "0x184EAA1E0")]
		public static string GetAvailableGameLanguages()
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4EA9E00", Offset = "0x4EA8A00", VA = "0x184EA9E00")]
		public static bool BIsSubscribedApp(AppId_t appID)
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4EA9D60", Offset = "0x4EA8960", VA = "0x184EA9D60")]
		public static bool BIsDlcInstalled(AppId_t appID)
		{
			return default(bool);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4EAA5D0", Offset = "0x4EA91D0", VA = "0x184EAA5D0")]
		public static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			return 0U;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4EA9EA0", Offset = "0x4EA8AA0", VA = "0x184EA9EA0")]
		public static bool BIsSubscribedFromFreeWeekend()
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4EAA500", Offset = "0x4EA9100", VA = "0x184EAA500")]
		public static int GetDLCCount()
		{
			return 0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4EA9B90", Offset = "0x4EA8790", VA = "0x184EA9B90")]
		public static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4EAAA70", Offset = "0x4EA9670", VA = "0x184EAAA70")]
		public static void InstallDLC(AppId_t nAppID)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4EAAD20", Offset = "0x4EA9920", VA = "0x184EAAD20")]
		public static void UninstallDLC(AppId_t nAppID)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4EAAB60", Offset = "0x4EA9760", VA = "0x184EAAB60")]
		public static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4EAA3C0", Offset = "0x4EA8FC0", VA = "0x184EAA3C0")]
		public static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4EAAAC0", Offset = "0x4EA96C0", VA = "0x184EAAAC0")]
		public static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4EAA770", Offset = "0x4EA9370", VA = "0x184EAA770")]
		public static uint GetInstalledDepots(AppId_t appID, DepotId_t[] pvecDepots, uint cMaxDepots)
		{
			return 0U;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4EAA040", Offset = "0x4EA8C40", VA = "0x184EAA040")]
		public static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			return 0U;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4EA9CC0", Offset = "0x4EA88C0", VA = "0x184EA9CC0")]
		public static bool BIsAppInstalled(AppId_t appID)
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4EAA150", Offset = "0x4EA8D50", VA = "0x184EAA150")]
		public static CSteamID GetAppOwner()
		{
			return default(CSteamID);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4EAA8E0", Offset = "0x4EA94E0", VA = "0x184EAA8E0")]
		public static string GetLaunchQueryParam(string pchKey)
		{
			return null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4EAA550", Offset = "0x4EA9150", VA = "0x184EAA550")]
		public static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4EA9FF0", Offset = "0x4EA8BF0", VA = "0x184EA9FF0")]
		public static int GetAppBuildId()
		{
			return 0;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4EAAB10", Offset = "0x4EA9710", VA = "0x184EAAB10")]
		public static void RequestAllProofOfPurchaseKeys()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4EAA620", Offset = "0x4EA9220", VA = "0x184EAA620")]
		public static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4EAA7F0", Offset = "0x4EA93F0", VA = "0x184EAA7F0")]
		public static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine)
		{
			return 0;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4EA9E50", Offset = "0x4EA8A50", VA = "0x184EA9E50")]
		public static bool BIsSubscribedFromFamilySharing()
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4EA9F40", Offset = "0x4EA8B40", VA = "0x184EA9F40")]
		public static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed)
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4EAACD0", Offset = "0x4EA98D0", VA = "0x184EAACD0")]
		public static bool SetDlcContext(AppId_t nAppID)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4EAAA10", Offset = "0x4EA9610", VA = "0x184EAAA10")]
		public static int GetNumBetas(out int pnAvailable, out int pnPrivate)
		{
			return 0;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4EAA230", Offset = "0x4EA8E30", VA = "0x184EAA230")]
		public static bool GetBetaInfo(int iBetaIndex, out uint punFlags, out uint punBuildID, out string pchBetaName, int cchBetaName, out string pchDescription, int cchDescription)
		{
			return default(bool);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4EAABB0", Offset = "0x4EA97B0", VA = "0x184EAABB0")]
		public static bool SetActiveBeta(string pchBetaName)
		{
			return default(bool);
		}
	}
}
