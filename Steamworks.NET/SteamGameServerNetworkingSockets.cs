using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public static class SteamGameServerNetworkingSockets
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4EB6560", Offset = "0x4EB5160", VA = "0x184EB6560")]
		public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x4EB6160", Offset = "0x4EB4D60", VA = "0x184EB6160")]
		public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x4EB66C0", Offset = "0x4EB52C0", VA = "0x184EB66C0")]
		public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x4EB62E0", Offset = "0x4EB4EE0", VA = "0x184EB62E0")]
		public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x4EB5E90", Offset = "0x4EB4A90", VA = "0x184EB5E90")]
		public static EResult AcceptConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x4EB5F30", Offset = "0x4EB4B30", VA = "0x184EB5F30")]
		public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			return default(bool);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x4EB6080", Offset = "0x4EB4C80", VA = "0x184EB6080")]
		public static bool CloseListenSocket(HSteamListenSocket hSocket)
		{
			return default(bool);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x4EB7770", Offset = "0x4EB6370", VA = "0x184EB7770")]
		public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData)
		{
			return default(bool);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4EB6C90", Offset = "0x4EB5890", VA = "0x184EB6C90")]
		public static long GetConnectionUserData(HSteamNetConnection hPeer)
		{
			return 0L;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4EB75F0", Offset = "0x4EB61F0", VA = "0x184EB75F0")]
		public static void SetConnectionName(HSteamNetConnection hPeer, string pszName)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4EB6AF0", Offset = "0x4EB56F0", VA = "0x184EB6AF0")]
		public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen)
		{
			return default(bool);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00003914 File Offset: 0x00001B14
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4EB7460", Offset = "0x4EB6060", VA = "0x184EB7460")]
		public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4EB74F0", Offset = "0x4EB60F0", VA = "0x184EB74F0")]
		public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000392C File Offset: 0x00001B2C
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4EB6970", Offset = "0x4EB5570", VA = "0x184EB6970")]
		public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4EB7120", Offset = "0x4EB5D20", VA = "0x184EB7120")]
		public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x4EB6A90", Offset = "0x4EB5690", VA = "0x184EB6A90")]
		public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo)
		{
			return default(bool);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4EB6C00", Offset = "0x4EB5800", VA = "0x184EB6C00")]
		public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4EB6CE0", Offset = "0x4EB58E0", VA = "0x184EB6CE0")]
		public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf)
		{
			return 0;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4EB7010", Offset = "0x4EB5C10", VA = "0x184EB7010")]
		public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address)
		{
			return default(bool);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4EB6800", Offset = "0x4EB5400", VA = "0x184EB6800")]
		public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2)
		{
			return default(bool);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000039D4 File Offset: 0x00001BD4
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4EB60D0", Offset = "0x4EB4CD0", VA = "0x184EB60D0")]
		public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4EB6FC0", Offset = "0x4EB5BC0", VA = "0x184EB6FC0")]
		public static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
		{
			return default(bool);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4EB70D0", Offset = "0x4EB5CD0", VA = "0x184EB70D0")]
		public static ESteamNetworkingAvailability InitAuthentication()
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4EB69C0", Offset = "0x4EB55C0", VA = "0x184EB69C0")]
		public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4EB6770", Offset = "0x4EB5370", VA = "0x184EB6770")]
		public static HSteamNetPollGroup CreatePollGroup()
		{
			return default(HSteamNetPollGroup);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4EB68A0", Offset = "0x4EB54A0", VA = "0x184EB68A0")]
		public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4EB7710", Offset = "0x4EB6310", VA = "0x184EB7710")]
		public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4EB71F0", Offset = "0x4EB5DF0", VA = "0x184EB71F0")]
		public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4EB7340", Offset = "0x4EB5F40", VA = "0x184EB7340")]
		public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return default(bool);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4EB68F0", Offset = "0x4EB54F0", VA = "0x184EB68F0")]
		public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return 0;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4EB63A0", Offset = "0x4EB4FA0", VA = "0x184EB63A0")]
		public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4EB6F70", Offset = "0x4EB5B70", VA = "0x184EB6F70")]
		public static ushort GetHostedDedicatedServerPort()
		{
			return 0;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4EB6F20", Offset = "0x4EB5B20", VA = "0x184EB6F20")]
		public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			return default(SteamNetworkingPOPID);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x4EB6ED0", Offset = "0x4EB5AD0", VA = "0x184EB6ED0")]
		public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4EB64B0", Offset = "0x4EB50B0", VA = "0x184EB64B0")]
		public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4EB6E50", Offset = "0x4EB5A50", VA = "0x184EB6E50")]
		public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00003B54 File Offset: 0x00001D54
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4EB6210", Offset = "0x4EB4E10", VA = "0x184EB6210")]
		public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003B6C File Offset: 0x00001D6C
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4EB72C0", Offset = "0x4EB5EC0", VA = "0x184EB72C0")]
		public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext)
		{
			return default(bool);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00003B84 File Offset: 0x00001D84
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4EB6A10", Offset = "0x4EB5610", VA = "0x184EB6A10")]
		public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003B9C File Offset: 0x00001D9C
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4EB7570", Offset = "0x4EB6170", VA = "0x184EB7570")]
		public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4EB73C0", Offset = "0x4EB5FC0", VA = "0x184EB73C0")]
		public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4EB7410", Offset = "0x4EB6010", VA = "0x184EB7410")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4EB5EE0", Offset = "0x4EB4AE0", VA = "0x184EB5EE0")]
		public static bool BeginAsyncRequestFakeIP(int nNumPorts)
		{
			return default(bool);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4EB6DF0", Offset = "0x4EB59F0", VA = "0x184EB6DF0")]
		public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00003BCC File Offset: 0x00001DCC
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4EB6610", Offset = "0x4EB5210", VA = "0x184EB6610")]
		public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x4EB7070", Offset = "0x4EB5C70", VA = "0x184EB7070")]
		public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00003BFC File Offset: 0x00001DFC
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4EB6460", Offset = "0x4EB5060", VA = "0x184EB6460")]
		public static IntPtr CreateFakeUDPPort(int idxFakeServerPort)
		{
			return 0;
		}
	}
}
