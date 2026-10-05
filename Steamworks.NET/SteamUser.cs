using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public static class SteamUser
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x0000743C File Offset: 0x0000563C
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x4F15970", Offset = "0x4F14570", VA = "0x184F15970")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00007454 File Offset: 0x00005654
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x4F14D80", Offset = "0x4F13980", VA = "0x184F14D80")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000746C File Offset: 0x0000566C
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x4F15BD0", Offset = "0x4F147D0", VA = "0x184F15BD0")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00007484 File Offset: 0x00005684
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x4F16010", Offset = "0x4F14C10", VA = "0x184F16010")]
		public static int InitiateGameConnection_DEPRECATED(byte[] pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			return 0;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x4F165C0", Offset = "0x4F151C0", VA = "0x184F165C0")]
		public static void TerminateGameConnection_DEPRECATED(uint unIPServer, ushort usPortServer)
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x4F16690", Offset = "0x4F15290", VA = "0x184F16690")]
		public static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000749C File Offset: 0x0000569C
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x4F15CC0", Offset = "0x4F148C0", VA = "0x184F15CC0")]
		public static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
		{
			return default(bool);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x4F16460", Offset = "0x4F15060", VA = "0x184F16460")]
		public static void StartVoiceRecording()
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x4F16510", Offset = "0x4F15110", VA = "0x184F16510")]
		public static void StopVoiceRecording()
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000074B4 File Offset: 0x000056B4
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x4F155C0", Offset = "0x4F141C0", VA = "0x184F155C0")]
		public static EVoiceResult GetAvailableVoice(out uint pcbCompressed)
		{
			return EVoiceResult.k_EVoiceResultOK;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000074CC File Offset: 0x000056CC
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x4F15ED0", Offset = "0x4F14AD0", VA = "0x184F15ED0")]
		public static EVoiceResult GetVoice(bool bWantCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten)
		{
			return EVoiceResult.k_EVoiceResultOK;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000074E4 File Offset: 0x000056E4
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x4F150A0", Offset = "0x4F13CA0", VA = "0x184F150A0")]
		public static EVoiceResult DecompressVoice(byte[] pCompressed, uint cbCompressed, byte[] pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			return EVoiceResult.k_EVoiceResultOK;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000074FC File Offset: 0x000056FC
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x4F15E20", Offset = "0x4F14A20", VA = "0x184F15E20")]
		public static uint GetVoiceOptimalSampleRate()
		{
			return 0U;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00007514 File Offset: 0x00005714
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x4F15280", Offset = "0x4F13E80", VA = "0x184F15280")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSteamNetworkingIdentity)
		{
			return default(HAuthTicket);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000752C File Offset: 0x0000572C
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x4F153B0", Offset = "0x4F13FB0", VA = "0x184F153B0")]
		public static HAuthTicket GetAuthTicketForWebApi(string pchIdentity)
		{
			return default(HAuthTicket);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00007544 File Offset: 0x00005744
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x4F14EF0", Offset = "0x4F13AF0", VA = "0x184F14EF0")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return EBeginAuthSessionResult.k_EBeginAuthSessionResultOK;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x4F151C0", Offset = "0x4F13DC0", VA = "0x184F151C0")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x4F14FE0", Offset = "0x4F13BE0", VA = "0x184F14FE0")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000755C File Offset: 0x0000575C
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x4F16880", Offset = "0x4F15480", VA = "0x184F16880")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return EUserHasLicenseForAppResult.k_EUserHasLicenseResultHasLicense;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00007574 File Offset: 0x00005774
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x4F14A10", Offset = "0x4F13610", VA = "0x184F14A10")]
		public static bool BIsBehindNAT()
		{
			return default(bool);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x4F14930", Offset = "0x4F13530", VA = "0x184F14930")]
		public static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000758C File Offset: 0x0000578C
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x4F16130", Offset = "0x4F14D30", VA = "0x184F16130")]
		public static SteamAPICall_t RequestEncryptedAppTicket(byte[] pDataToInclude, int cbDataToInclude)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000075A4 File Offset: 0x000057A4
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x4F157B0", Offset = "0x4F143B0", VA = "0x184F157B0")]
		public static bool GetEncryptedAppTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			return default(bool);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000075BC File Offset: 0x000057BC
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x4F158A0", Offset = "0x4F144A0", VA = "0x184F158A0")]
		public static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			return 0;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000075D4 File Offset: 0x000057D4
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x4F15B20", Offset = "0x4F14720", VA = "0x184F15B20")]
		public static int GetPlayerSteamLevel()
		{
			return 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000075EC File Offset: 0x000057EC
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x4F16240", Offset = "0x4F14E40", VA = "0x184F16240")]
		public static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00007604 File Offset: 0x00005804
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x4F14C20", Offset = "0x4F13820", VA = "0x184F14C20")]
		public static bool BIsPhoneVerified()
		{
			return default(bool);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000761C File Offset: 0x0000581C
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x4F14CD0", Offset = "0x4F138D0", VA = "0x184F14CD0")]
		public static bool BIsTwoFactorEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00007634 File Offset: 0x00005834
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x4F14AC0", Offset = "0x4F136C0", VA = "0x184F14AC0")]
		public static bool BIsPhoneIdentifying()
		{
			return default(bool);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000764C File Offset: 0x0000584C
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x4F14B70", Offset = "0x4F13770", VA = "0x184F14B70")]
		public static bool BIsPhoneRequiringVerification()
		{
			return default(bool);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00007664 File Offset: 0x00005864
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x4F15A30", Offset = "0x4F14630", VA = "0x184F15A30")]
		public static SteamAPICall_t GetMarketEligibility()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000767C File Offset: 0x0000587C
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x4F156C0", Offset = "0x4F142C0", VA = "0x184F156C0")]
		public static SteamAPICall_t GetDurationControl()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00007694 File Offset: 0x00005894
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x4F14E30", Offset = "0x4F13A30", VA = "0x184F14E30")]
		public static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState)
		{
			return default(bool);
		}
	}
}
