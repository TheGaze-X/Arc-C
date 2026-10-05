using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public static class SteamGameServer
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4EC0910", Offset = "0x4EBF510", VA = "0x184EC0910")]
		public static void SetProduct(string pszProduct)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4EC0280", Offset = "0x4EBEE80", VA = "0x184EC0280")]
		public static void SetGameDescription(string pszGameDescription)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4EC07B0", Offset = "0x4EBF3B0", VA = "0x184EC07B0")]
		public static void SetModDir(string pszModDir)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4EC0120", Offset = "0x4EBED20", VA = "0x184EC0120")]
		public static void SetDedicatedServer(bool bDedicated)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4EBFE30", Offset = "0x4EBEA30", VA = "0x184EBFE30")]
		public static void LogOn(string pszToken)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4EBFDE0", Offset = "0x4EBE9E0", VA = "0x184EBFDE0")]
		public static void LogOnAnonymous()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4EBFD90", Offset = "0x4EBE990", VA = "0x184EBFD90")]
		public static void LogOff()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4EBF570", Offset = "0x4EBE170", VA = "0x184EBF570")]
		public static bool BLoggedOn()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4EBF5C0", Offset = "0x4EBE1C0", VA = "0x184EBF5C0")]
		public static bool BSecure()
		{
			return default(bool);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4EBFC70", Offset = "0x4EBE870", VA = "0x184EBFC70")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4EC0E00", Offset = "0x4EBFA00", VA = "0x184EC0E00")]
		public static bool WasRestartRequested()
		{
			return default(bool);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4EC0760", Offset = "0x4EBF360", VA = "0x184EC0760")]
		public static void SetMaxPlayerCount(int cPlayersMax)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4EC00D0", Offset = "0x4EBECD0", VA = "0x184EC00D0")]
		public static void SetBotPlayerCount(int cBotplayers)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4EC0B30", Offset = "0x4EBF730", VA = "0x184EC0B30")]
		public static void SetServerName(string pszServerName)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4EC0650", Offset = "0x4EBF250", VA = "0x184EC0650")]
		public static void SetMapName(string pszMapName)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4EC08C0", Offset = "0x4EBF4C0", VA = "0x184EC08C0")]
		public static void SetPasswordProtected(bool bPasswordProtected)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4EC0C40", Offset = "0x4EBF840", VA = "0x184EC0C40")]
		public static void SetSpectatorPort(ushort unSpectatorPort)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4EC0C90", Offset = "0x4EBF890", VA = "0x184EC0C90")]
		public static void SetSpectatorServerName(string pszSpectatorServerName)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x4EBF820", Offset = "0x4EBE420", VA = "0x184EBF820")]
		public static void ClearAllKeyValues()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4EC04A0", Offset = "0x4EBF0A0", VA = "0x184EC04A0")]
		public static void SetKeyValue(string pKey, string pValue)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4EC0390", Offset = "0x4EBEF90", VA = "0x184EC0390")]
		public static void SetGameTags(string pchGameTags)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4EC0170", Offset = "0x4EBED70", VA = "0x184EC0170")]
		public static void SetGameData(string pchGameData)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4EC0A20", Offset = "0x4EBF620", VA = "0x184EC0A20")]
		public static void SetRegion(string pszRegion)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4EC0080", Offset = "0x4EBEC80", VA = "0x184EC0080")]
		public static void SetAdvertiseServerActive(bool bActive)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4EBF9E0", Offset = "0x4EBE5E0", VA = "0x184EBF9E0")]
		public static HAuthTicket GetAuthSessionTicket(byte[] pTicket, int cbMaxTicket, out uint pcbTicket, ref SteamNetworkingIdentity pSnid)
		{
			return default(HAuthTicket);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4EBF750", Offset = "0x4EBE350", VA = "0x184EBF750")]
		public static EBeginAuthSessionResult BeginAuthSession(byte[] pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			return EBeginAuthSessionResult.k_EBeginAuthSessionResultOK;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4EBF990", Offset = "0x4EBE590", VA = "0x184EBF990")]
		public static void EndAuthSession(CSteamID steamID)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4EBF7D0", Offset = "0x4EBE3D0", VA = "0x184EBF7D0")]
		public static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4EC0DA0", Offset = "0x4EBF9A0", VA = "0x184EC0DA0")]
		public static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			return EUserHasLicenseForAppResult.k_EUserHasLicenseResultHasLicense;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4EBFF40", Offset = "0x4EBEB40", VA = "0x184EBFF40")]
		public static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			return default(bool);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4EBFAA0", Offset = "0x4EBE6A0", VA = "0x184EBFAA0")]
		public static void GetGameplayStats()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4EBFBE0", Offset = "0x4EBE7E0", VA = "0x184EBFBE0")]
		public static SteamAPICall_t GetServerReputation()
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4EBFB80", Offset = "0x4EBE780", VA = "0x184EBFB80")]
		public static SteamIPAddress_t GetPublicIP()
		{
			return default(SteamIPAddress_t);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4EBFD00", Offset = "0x4EBE900", VA = "0x184EBFD00")]
		public static bool HandleIncomingPacket(byte[] pData, int cbData, uint srcIP, ushort srcPort)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x4EBFAF0", Offset = "0x4EBE6F0", VA = "0x184EBFAF0")]
		public static int GetNextOutgoingPacket(byte[] pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			return 0;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4EBF4E0", Offset = "0x4EBE0E0", VA = "0x184EBF4E0")]
		public static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4EBF870", Offset = "0x4EBE470", VA = "0x184EBF870")]
		public static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4EBFFA0", Offset = "0x4EBEBA0", VA = "0x184EBFFA0")]
		public static bool SendUserConnectAndAuthenticate_DEPRECATED(uint unIPClient, byte[] pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			return default(bool);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4EBF900", Offset = "0x4EBE500", VA = "0x184EBF900")]
		public static CSteamID CreateUnauthenticatedUserConnection()
		{
			return default(CSteamID);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4EC0030", Offset = "0x4EBEC30", VA = "0x184EC0030")]
		public static void SendUserDisconnect_DEPRECATED(CSteamID steamIDUser)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4EBF610", Offset = "0x4EBE210", VA = "0x184EBF610")]
		public static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			return default(bool);
		}
	}
}
