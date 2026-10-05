using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public static class SteamNetworkingSockets
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00005E7C File Offset: 0x0000407C
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x4ECB030", Offset = "0x4EC9C30", VA = "0x184ECB030")]
		public static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x4ECAC00", Offset = "0x4EC9800", VA = "0x184ECAC00")]
		public static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00005EAC File Offset: 0x000040AC
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x4ECB1A0", Offset = "0x4EC9DA0", VA = "0x184ECB1A0")]
		public static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00005EC4 File Offset: 0x000040C4
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x4ECAD90", Offset = "0x4EC9990", VA = "0x184ECAD90")]
		public static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x4ECA930", Offset = "0x4EC9530", VA = "0x184ECA930")]
		public static EResult AcceptConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00005EF4 File Offset: 0x000040F4
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x4ECA9D0", Offset = "0x4EC95D0", VA = "0x184ECA9D0")]
		public static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			return default(bool);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x4ECAB20", Offset = "0x4EC9720", VA = "0x184ECAB20")]
		public static bool CloseListenSocket(HSteamListenSocket hSocket)
		{
			return default(bool);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00005F24 File Offset: 0x00004124
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x4ECC290", Offset = "0x4ECAE90", VA = "0x184ECC290")]
		public static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData)
		{
			return default(bool);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00005F3C File Offset: 0x0000413C
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x4ECB780", Offset = "0x4ECA380", VA = "0x184ECB780")]
		public static long GetConnectionUserData(HSteamNetConnection hPeer)
		{
			return 0L;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x4ECC110", Offset = "0x4ECAD10", VA = "0x184ECC110")]
		public static void SetConnectionName(HSteamNetConnection hPeer, string pszName)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x4ECB5E0", Offset = "0x4ECA1E0", VA = "0x184ECB5E0")]
		public static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen)
		{
			return default(bool);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00005F6C File Offset: 0x0000416C
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x4ECBF80", Offset = "0x4ECAB80", VA = "0x184ECBF80")]
		public static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x4ECC010", Offset = "0x4ECAC10", VA = "0x184ECC010")]
		public static void SendMessages(int nMessages, IntPtr[] pMessages, long[] pOutMessageNumberOrResult)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x4ECB450", Offset = "0x4ECA050", VA = "0x184ECB450")]
		public static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x4ECBC30", Offset = "0x4ECA830", VA = "0x184ECBC30")]
		public static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00005FB4 File Offset: 0x000041B4
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x4ECB580", Offset = "0x4ECA180", VA = "0x184ECB580")]
		public static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo)
		{
			return default(bool);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00005FCC File Offset: 0x000041CC
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x4ECB6F0", Offset = "0x4ECA2F0", VA = "0x184ECB6F0")]
		public static EResult GetConnectionRealTimeStatus(HSteamNetConnection hConn, ref SteamNetConnectionRealTimeStatus_t pStatus, int nLanes, ref SteamNetConnectionRealTimeLaneStatus_t pLanes)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x4ECB7D0", Offset = "0x4ECA3D0", VA = "0x184ECB7D0")]
		public static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf)
		{
			return 0;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00005FFC File Offset: 0x000041FC
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x4ECBB20", Offset = "0x4ECA720", VA = "0x184ECBB20")]
		public static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address)
		{
			return default(bool);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00006014 File Offset: 0x00004214
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4ECB2E0", Offset = "0x4EC9EE0", VA = "0x184ECB2E0")]
		public static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2)
		{
			return default(bool);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000602C File Offset: 0x0000422C
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x4ECAB70", Offset = "0x4EC9770", VA = "0x184ECAB70")]
		public static EResult ConfigureConnectionLanes(HSteamNetConnection hConn, int nNumLanes, int[] pLanePriorities, ushort[] pLaneWeights)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00006044 File Offset: 0x00004244
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x4ECBAC0", Offset = "0x4ECA6C0", VA = "0x184ECBAC0")]
		public static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
		{
			return default(bool);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000605C File Offset: 0x0000425C
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x4ECBBE0", Offset = "0x4ECA7E0", VA = "0x184ECBBE0")]
		public static ESteamNetworkingAvailability InitAuthentication()
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00006074 File Offset: 0x00004274
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x4ECB4A0", Offset = "0x4ECA0A0", VA = "0x184ECB4A0")]
		public static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
		{
			return ESteamNetworkingAvailability.k_ESteamNetworkingAvailability_Unknown;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000608C File Offset: 0x0000428C
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x4ECB250", Offset = "0x4EC9E50", VA = "0x184ECB250")]
		public static HSteamNetPollGroup CreatePollGroup()
		{
			return default(HSteamNetPollGroup);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000060A4 File Offset: 0x000042A4
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x4ECB380", Offset = "0x4EC9F80", VA = "0x184ECB380")]
		public static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000060BC File Offset: 0x000042BC
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x4ECC230", Offset = "0x4ECAE30", VA = "0x184ECC230")]
		public static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup)
		{
			return default(bool);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000060D4 File Offset: 0x000042D4
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x4ECBD00", Offset = "0x4ECA900", VA = "0x184ECBD00")]
		public static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000060EC File Offset: 0x000042EC
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4ECBE50", Offset = "0x4ECAA50", VA = "0x184ECBE50")]
		public static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return default(bool);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00006104 File Offset: 0x00004304
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x4ECB3D0", Offset = "0x4EC9FD0", VA = "0x184ECB3D0")]
		public static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			return 0;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000611C File Offset: 0x0000431C
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x4ECAE60", Offset = "0x4EC9A60", VA = "0x184ECAE60")]
		public static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00006134 File Offset: 0x00004334
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x4ECBA70", Offset = "0x4ECA670", VA = "0x184ECBA70")]
		public static ushort GetHostedDedicatedServerPort()
		{
			return 0;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000614C File Offset: 0x0000434C
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x4ECBA20", Offset = "0x4ECA620", VA = "0x184ECBA20")]
		public static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			return default(SteamNetworkingPOPID);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00006164 File Offset: 0x00004364
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x4ECB9C0", Offset = "0x4ECA5C0", VA = "0x184ECB9C0")]
		public static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000617C File Offset: 0x0000437C
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x4ECAF80", Offset = "0x4EC9B80", VA = "0x184ECAF80")]
		public static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00006194 File Offset: 0x00004394
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4ECB940", Offset = "0x4ECA540", VA = "0x184ECB940")]
		public static EResult GetGameCoordinatorServerLogin(IntPtr pLoginInfo, out int pcbSignedBlob, IntPtr pBlob)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000061AC File Offset: 0x000043AC
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x4ECACC0", Offset = "0x4EC98C0", VA = "0x184ECACC0")]
		public static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamNetConnection);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000061C4 File Offset: 0x000043C4
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x4ECBDD0", Offset = "0x4ECA9D0", VA = "0x184ECBDD0")]
		public static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingSignalingRecvContext pContext)
		{
			return default(bool);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000061DC File Offset: 0x000043DC
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x4ECB500", Offset = "0x4ECA100", VA = "0x184ECB500")]
		public static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000061F4 File Offset: 0x000043F4
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x4ECC090", Offset = "0x4ECAC90", VA = "0x184ECC090")]
		public static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg)
		{
			return default(bool);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x4ECBED0", Offset = "0x4ECAAD0", VA = "0x184ECBED0")]
		public static void ResetIdentity(ref SteamNetworkingIdentity pIdentity)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x4ECBF30", Offset = "0x4ECAB30", VA = "0x184ECBF30")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000620C File Offset: 0x0000440C
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x4ECA980", Offset = "0x4EC9580", VA = "0x184ECA980")]
		public static bool BeginAsyncRequestFakeIP(int nNumPorts)
		{
			return default(bool);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x4ECB8E0", Offset = "0x4ECA4E0", VA = "0x184ECB8E0")]
		public static void GetFakeIP(int idxFirstPort, out SteamNetworkingFakeIPResult_t pInfo)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00006224 File Offset: 0x00004424
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x4ECB0F0", Offset = "0x4EC9CF0", VA = "0x184ECB0F0")]
		public static HSteamListenSocket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, SteamNetworkingConfigValue_t[] pOptions)
		{
			return default(HSteamListenSocket);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000623C File Offset: 0x0000443C
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x4ECBB80", Offset = "0x4ECA780", VA = "0x184ECBB80")]
		public static EResult GetRemoteFakeIPForConnection(HSteamNetConnection hConn, out SteamNetworkingIPAddr pOutAddr)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00006254 File Offset: 0x00004454
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x4ECAF30", Offset = "0x4EC9B30", VA = "0x184ECAF30")]
		public static IntPtr CreateFakeUDPPort(int idxFakeServerPort)
		{
			return 0;
		}
	}
}
