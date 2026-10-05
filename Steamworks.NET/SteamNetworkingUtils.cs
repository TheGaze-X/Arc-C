using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public static class SteamNetworkingUtils
	{
		// Token: 0x0600036C RID: 876 RVA: 0x0000626C File Offset: 0x0000446C
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x4ECC2F0", Offset = "0x4ECAEF0", VA = "0x184ECC2F0")]
		public static IntPtr AllocateMessage(int cbAllocateBuffer)
		{
			return 0;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x4ECC990", Offset = "0x4ECB590", VA = "0x184ECC990")]
		public static void InitRelayNetworkAccess()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00006284 File Offset: 0x00004484
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x4ECC930", Offset = "0x4ECB530", VA = "0x184ECC930")]
		public static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000629C File Offset: 0x0000449C
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x4ECC700", Offset = "0x4ECB300", VA = "0x184ECC700")]
		public static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
		{
			return 0f;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000062B4 File Offset: 0x000044B4
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x4ECC480", Offset = "0x4ECB080", VA = "0x184ECC480")]
		public static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2)
		{
			return 0;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000062CC File Offset: 0x000044CC
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x4ECC4E0", Offset = "0x4ECB0E0", VA = "0x184ECC4E0")]
		public static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
		{
			return 0;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x4ECC3A0", Offset = "0x4ECAFA0", VA = "0x184ECC3A0")]
		public static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000062E4 File Offset: 0x000044E4
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x4ECCA90", Offset = "0x4ECB690", VA = "0x184ECCA90")]
		public static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result)
		{
			return default(bool);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000062FC File Offset: 0x000044FC
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4ECC340", Offset = "0x4ECAF40", VA = "0x184ECC340")]
		public static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			return default(bool);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00006314 File Offset: 0x00004514
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x4ECC870", Offset = "0x4ECB470", VA = "0x184ECC870")]
		public static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP)
		{
			return 0;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000632C File Offset: 0x0000452C
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x4ECC660", Offset = "0x4ECB260", VA = "0x184ECC660")]
		public static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			return 0;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00006344 File Offset: 0x00004544
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4ECC7C0", Offset = "0x4ECB3C0", VA = "0x184ECC7C0")]
		public static int GetPOPCount()
		{
			return 0;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000635C File Offset: 0x0000455C
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x4ECC810", Offset = "0x4ECB410", VA = "0x184ECC810")]
		public static int GetPOPList(out SteamNetworkingPOPID list, int nListSz)
		{
			return 0;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00006374 File Offset: 0x00004574
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x4ECC760", Offset = "0x4ECB360", VA = "0x184ECC760")]
		public static SteamNetworkingMicroseconds GetLocalTimestamp()
		{
			return default(SteamNetworkingMicroseconds);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x4ECCC50", Offset = "0x4ECB850", VA = "0x184ECCC50")]
		public static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000638C File Offset: 0x0000458C
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x4ECC9E0", Offset = "0x4ECB5E0", VA = "0x184ECC9E0")]
		public static bool IsFakeIPv4(uint nIPv4)
		{
			return default(bool);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000063A4 File Offset: 0x000045A4
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x4ECC6B0", Offset = "0x4ECB2B0", VA = "0x184ECC6B0")]
		public static ESteamNetworkingFakeIPType GetIPv4FakeIPType(uint nIPv4)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000063BC File Offset: 0x000045BC
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x4ECC8D0", Offset = "0x4ECB4D0", VA = "0x184ECC8D0")]
		public static EResult GetRealIdentityForFakeIP(ref SteamNetworkingIPAddr fakeIP, out SteamNetworkingIdentity pOutRealIdentity)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000063D4 File Offset: 0x000045D4
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x4ECCBC0", Offset = "0x4ECB7C0", VA = "0x184ECCBC0")]
		public static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg)
		{
			return default(bool);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000063EC File Offset: 0x000045EC
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x4ECC5C0", Offset = "0x4ECB1C0", VA = "0x184ECC5C0")]
		public static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, ref ulong cbResult)
		{
			return (ESteamNetworkingGetConfigValueResult)0;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x4ECC540", Offset = "0x4ECB140", VA = "0x184ECC540")]
		public static string GetConfigValueInfo(ESteamNetworkingConfigValue eValue, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope)
		{
			return null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00006404 File Offset: 0x00004604
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x4ECCA30", Offset = "0x4ECB630", VA = "0x184ECCA30")]
		public static ESteamNetworkingConfigValue IterateGenericEditableConfigValues(ESteamNetworkingConfigValue eCurrent, bool bEnumerateDevVars)
		{
			return ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_Invalid;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x4ECCE40", Offset = "0x4ECBA40", VA = "0x184ECCE40")]
		public static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000641C File Offset: 0x0000461C
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x4ECCD10", Offset = "0x4ECB910", VA = "0x184ECCD10")]
		public static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr)
		{
			return default(bool);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00006434 File Offset: 0x00004634
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x4ECCCB0", Offset = "0x4ECB8B0", VA = "0x184ECCCB0")]
		public static ESteamNetworkingFakeIPType SteamNetworkingIPAddr_GetFakeIPType(ref SteamNetworkingIPAddr addr)
		{
			return ESteamNetworkingFakeIPType.k_ESteamNetworkingFakeIPType_Invalid;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4ECD070", Offset = "0x4ECBC70", VA = "0x184ECD070")]
		public static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000644C File Offset: 0x0000464C
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x4ECCF40", Offset = "0x4ECBB40", VA = "0x184ECCF40")]
		public static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr)
		{
			return default(bool);
		}
	}
}
