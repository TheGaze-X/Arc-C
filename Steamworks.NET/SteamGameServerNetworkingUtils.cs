using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public static class SteamGameServerNetworkingUtils
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00003C14 File Offset: 0x00001E14
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x4EB77D0", Offset = "0x4EB63D0", VA = "0x184EB77D0")]
		public static IntPtr AllocateMessage(int cbAllocateBuffer)
		{
			return 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x4EB7E30", Offset = "0x4EB6A30", VA = "0x184EB7E30")]
		public static void InitRelayNetworkAccess()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00003C2C File Offset: 0x00001E2C
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x4EB7DE0", Offset = "0x4EB69E0", VA = "0x184EB7DE0")]
		public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x4EB7BD0", Offset = "0x4EB67D0", VA = "0x184EB7BD0")]
		public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
		{
			return 0f;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x4EB7960", Offset = "0x4EB6560", VA = "0x184EB7960")]
		public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2)
		{
			return 0;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00003C74 File Offset: 0x00001E74
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x4EB79C0", Offset = "0x4EB65C0", VA = "0x184EB79C0")]
		public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
		{
			return 0;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4EB7880", Offset = "0x4EB6480", VA = "0x184EB7880")]
		public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00003C8C File Offset: 0x00001E8C
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x4EB7F30", Offset = "0x4EB6B30", VA = "0x184EB7F30")]
		public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result)
		{
			return default(bool);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4EB7820", Offset = "0x4EB6420", VA = "0x184EB7820")]
		public static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00003CBC File Offset: 0x00001EBC
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4EB7D20", Offset = "0x4EB6920", VA = "0x184EB7D20")]
		public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP)
		{
			return 0;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x4EB7B30", Offset = "0x4EB6730", VA = "0x184EB7B30")]
		public static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			return 0;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00003CEC File Offset: 0x00001EEC
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4EB7C70", Offset = "0x4EB6870", VA = "0x184EB7C70")]
		public static int GetPOPCount()
		{
			return 0;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00003D04 File Offset: 0x00001F04
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x4EB7CC0", Offset = "0x4EB68C0", VA = "0x184EB7CC0")]
		public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz)
		{
			return 0;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00003D1C File Offset: 0x00001F1C
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4EB7C20", Offset = "0x4EB6820", VA = "0x184EB7C20")]
		public static SteamNetworkingMicroseconds GetLocalTimestamp()
		{
			return default(SteamNetworkingMicroseconds);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4EB80F0", Offset = "0x4EB6CF0", VA = "0x184EB80F0")]
		public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003D34 File Offset: 0x00001F34
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4EB7E80", Offset = "0x4EB6A80", VA = "0x184EB7E80")]
		public static bool IsFakeIPv4(uint nIPv4)
		{
			return default(bool);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4EB7B80", Offset = "0x4EB6780", VA = "0x184EB7B80")]
		public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00003D64 File Offset: 0x00001F64
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4EB7D80", Offset = "0x4EB6980", VA = "0x184EB7D80")]
		public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00003D7C File Offset: 0x00001F7C
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4EB8060", Offset = "0x4EB6C60", VA = "0x184EB8060")]
		public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg)
		{
			return default(bool);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003D94 File Offset: 0x00001F94
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4EB7A90", Offset = "0x4EB6690", VA = "0x184EB7A90")]
		public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult)
		{
			return (ESteamNetworkingGetConfigValueResult)0;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4EB7A10", Offset = "0x4EB6610", VA = "0x184EB7A10")]
		public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00003DAC File Offset: 0x00001FAC
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4EB7ED0", Offset = "0x4EB6AD0", VA = "0x184EB7ED0")]
		public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars)
		{
			return ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Invalid;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4EB82D0", Offset = "0x4EB6ED0", VA = "0x184EB82D0")]
		public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x4EB81A0", Offset = "0x4EB6DA0", VA = "0x184EB81A0")]
		public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr)
		{
			return default(bool);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003DDC File Offset: 0x00001FDC
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4EB8150", Offset = "0x4EB6D50", VA = "0x184EB8150")]
		public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4EB8500", Offset = "0x4EB7100", VA = "0x184EB8500")]
		public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003DF4 File Offset: 0x00001FF4
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4EB83D0", Offset = "0x4EB6FD0", VA = "0x184EB83D0")]
		public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr)
		{
			return default(bool);
		}
	}
}
