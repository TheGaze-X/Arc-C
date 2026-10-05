using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public static class SteamGameServerNetworkingMessages
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4EB5E00", Offset = "0x4EB4A00", VA = "0x184EB5E00")]
		public static EResult SendMessageToUser(ref SteamNetworkingIdentity identityRemote, IntPtr pubData, uint cubData, int nSendFlags, int nRemoteChannel)
		{
			return EResult.k_EResultNone;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4EB5D30", Offset = "0x4EB4930", VA = "0x184EB5D30")]
		public static int ReceiveMessagesOnChannel(int nLocalChannel, IntPtr[] ppOutMessages, int nMaxMessages)
		{
			return 0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4EB5BB0", Offset = "0x4EB47B0", VA = "0x184EB5BB0")]
		public static bool AcceptSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			return default(bool);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4EB5C60", Offset = "0x4EB4860", VA = "0x184EB5C60")]
		public static bool CloseSessionWithUser(ref SteamNetworkingIdentity identityRemote)
		{
			return default(bool);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4EB5C00", Offset = "0x4EB4800", VA = "0x184EB5C00")]
		public static bool CloseChannelWithUser(ref SteamNetworkingIdentity identityRemote, int nLocalChannel)
		{
			return default(bool);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4EB5CB0", Offset = "0x4EB48B0", VA = "0x184EB5CB0")]
		public static ESteamNetworkingConnectionState GetSessionConnectionInfo(ref SteamNetworkingIdentity identityRemote, out SteamNetConnectionInfo_t pConnectionInfo, out SteamNetConnectionRealTimeStatus_t pQuickStatus)
		{
			return ESteamNetworkingConnectionState.k_ESteamNetworkingConnectionState_None;
		}
	}
}
