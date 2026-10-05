using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public static class SteamNetworkingMessages
	{
		// Token: 0x06000337 RID: 823 RVA: 0x00005DEC File Offset: 0x00003FEC
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x4ECA8A0", Offset = "0x4EC94A0", VA = "0x184ECA8A0")]
		public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00005E04 File Offset: 0x00004004
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x4ECA7D0", Offset = "0x4EC93D0", VA = "0x184ECA7D0")]
		public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00005E1C File Offset: 0x0000401C
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x4ECA630", Offset = "0x4EC9230", VA = "0x184ECA630")]
		public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			return default(bool);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x4ECA6F0", Offset = "0x4EC92F0", VA = "0x184ECA6F0")]
		public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			return default(bool);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00005E4C File Offset: 0x0000404C
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x4ECA690", Offset = "0x4EC9290", VA = "0x184ECA690")]
		public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel)
		{
			return default(bool);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x4ECA750", Offset = "0x4EC9350", VA = "0x184ECA750")]
		public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus)
		{
			return ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_None;
		}
	}
}
