using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public static class SteamGameServerStats
	{
		// Token: 0x06000186 RID: 390 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4EB94C0", Offset = "0x4EB80C0", VA = "0x184EB94C0")]
		public static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4EB9240", Offset = "0x4EB7E40", VA = "0x184EB9240")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			return default(bool);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x4EB9380", Offset = "0x4EB7F80", VA = "0x184EB9380")]
		public static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			return default(bool);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x4EB9100", Offset = "0x4EB7D00", VA = "0x184EB9100")]
		public static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			return default(bool);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003E6C File Offset: 0x0000206C
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4EB97C0", Offset = "0x4EB83C0", VA = "0x184EB97C0")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, int nData)
		{
			return default(bool);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00003E84 File Offset: 0x00002084
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4EB9680", Offset = "0x4EB8280", VA = "0x184EB9680")]
		public static bool SetUserStat(CSteamID steamIDUser, string pchName, float fData)
		{
			return default(bool);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4EB9990", Offset = "0x4EB8590", VA = "0x184EB9990")]
		public static bool UpdateUserAvgRateStat(CSteamID steamIDUser, string pchName, float flCountThisSession, double dSessionLength)
		{
			return default(bool);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4EB9550", Offset = "0x4EB8150", VA = "0x184EB9550")]
		public static bool SetUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4EB8FD0", Offset = "0x4EB7BD0", VA = "0x184EB8FD0")]
		public static bool ClearUserAchievement(CSteamID steamIDUser, string pchName)
		{
			return default(bool);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4EB9900", Offset = "0x4EB8500", VA = "0x184EB9900")]
		public static SteamAPICall_t StoreUserStats(CSteamID steamIDUser)
		{
			return default(SteamAPICall_t);
		}
	}
}
