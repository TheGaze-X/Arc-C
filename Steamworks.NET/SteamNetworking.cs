using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public static class SteamNetworking
	{
		// Token: 0x06000321 RID: 801 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x4ECDAB0", Offset = "0x4ECC6B0", VA = "0x184ECDAB0")]
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00005BF4 File Offset: 0x00003DF4
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x4ECD810", Offset = "0x4ECC410", VA = "0x184ECD810")]
		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00005C0C File Offset: 0x00003E0C
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x4ECD870", Offset = "0x4ECC470", VA = "0x184ECD870")]
		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			return default(bool);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00005C24 File Offset: 0x00003E24
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x4ECD150", Offset = "0x4ECBD50", VA = "0x184ECD150")]
		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x4ECD250", Offset = "0x4ECBE50", VA = "0x184ECD250")]
		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return default(bool);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x4ECD1F0", Offset = "0x4ECBDF0", VA = "0x184ECD1F0")]
		public static bool CloseP2PChannelWithUser(CSteamID steamIDRemote, int nChannel)
		{
			return default(bool);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4ECD5F0", Offset = "0x4ECC1F0", VA = "0x184ECD5F0")]
		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			return default(bool);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4ECD1A0", Offset = "0x4ECBDA0", VA = "0x184ECD1A0")]
		public static bool AllowP2PPacketRelay(bool bAllow)
		{
			return default(bool);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x4ECD330", Offset = "0x4ECBF30", VA = "0x184ECD330")]
		public static SNetListenSocket_t CreateListenSocket(int nVirtualP2PPort, SteamIPAddress_t nIP, ushort nPort, bool bAllowUseOfPacketRelay)
		{
			return default(SNetListenSocket_t);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x4ECD3D0", Offset = "0x4ECBFD0", VA = "0x184ECD3D0")]
		public static SNetSocket_t CreateP2PConnectionSocket(CSteamID steamIDTarget, int nVirtualPort, int nTimeoutSec, bool bAllowUseOfPacketRelay)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00005CCC File Offset: 0x00003ECC
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x4ECD2A0", Offset = "0x4ECBEA0", VA = "0x184ECD2A0")]
		public static SNetSocket_t CreateConnectionSocket(SteamIPAddress_t nIP, ushort nPort, int nTimeoutSec)
		{
			return default(SNetSocket_t);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x4ECD4C0", Offset = "0x4ECC0C0", VA = "0x184ECD4C0")]
		public static bool DestroySocket(SNetSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00005CFC File Offset: 0x00003EFC
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x4ECD460", Offset = "0x4ECC060", VA = "0x184ECD460")]
		public static bool DestroyListenSocket(SNetListenSocket_t hSocket, bool bNotifyRemoteEnd)
		{
			return default(bool);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00005D14 File Offset: 0x00003F14
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x4ECDA20", Offset = "0x4ECC620", VA = "0x184ECDA20")]
		public static bool SendDataOnSocket(SNetSocket_t hSocket, byte[] pubData, uint cubData, bool bReliable)
		{
			return default(bool);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00005D2C File Offset: 0x00003F2C
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x4ECD730", Offset = "0x4ECC330", VA = "0x184ECD730")]
		public static bool IsDataAvailableOnSocket(SNetSocket_t hSocket, out uint pcubMsgSize)
		{
			return default(bool);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00005D44 File Offset: 0x00003F44
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x4ECD900", Offset = "0x4ECC500", VA = "0x184ECD900")]
		public static bool RetrieveDataFromSocket(SNetSocket_t hSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize)
		{
			return default(bool);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00005D5C File Offset: 0x00003F5C
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x4ECD790", Offset = "0x4ECC390", VA = "0x184ECD790")]
		public static bool IsDataAvailable(SNetListenSocket_t hListenSocket, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00005D74 File Offset: 0x00003F74
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x4ECD990", Offset = "0x4ECC590", VA = "0x184ECD990")]
		public static bool RetrieveData(SNetListenSocket_t hListenSocket, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out SNetSocket_t phSocket)
		{
			return default(bool);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00005D8C File Offset: 0x00003F8C
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4ECD6A0", Offset = "0x4ECC2A0", VA = "0x184ECD6A0")]
		public static bool GetSocketInfo(SNetSocket_t hSocket, out CSteamID pSteamIDRemote, out int peSocketStatus, out SteamIPAddress_t punIPRemote, out ushort punPortRemote)
		{
			return default(bool);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00005DA4 File Offset: 0x00003FA4
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x4ECD520", Offset = "0x4ECC120", VA = "0x184ECD520")]
		public static bool GetListenSocketInfo(SNetListenSocket_t hListenSocket, out SteamIPAddress_t pnIP, out ushort pnPort)
		{
			return default(bool);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00005DBC File Offset: 0x00003FBC
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x4ECD650", Offset = "0x4ECC250", VA = "0x184ECD650")]
		public static ESNetSocketConnectionType GetSocketConnectionType(SNetSocket_t hSocket)
		{
			return ESNetSocketConnectionType.k_ESNetSocketConnectionTypeNotConnected;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x4ECD5A0", Offset = "0x4ECC1A0", VA = "0x184ECD5A0")]
		public static int GetMaxPacketSize(SNetSocket_t hSocket)
		{
			return 0;
		}
	}
}
