using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	[Serializable]
	public struct ISteamNetworkingSignalingRecvContext
	{
		// Token: 0x06000AC8 RID: 2760 RVA: 0x000094AC File Offset: 0x000076AC
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x4EE0B10", Offset = "0x4EDF710", VA = "0x184EE0B10")]
		public IntPtr OnConnectRequest(HSteamNetConnection hConn, ref SteamNetworkingIdentity identityPeer, int nLocalVirtualPort)
		{
			return 0;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x4EE0BB0", Offset = "0x4EDF7B0", VA = "0x184EE0BB0")]
		public void SendRejectionSignal(ref SteamNetworkingIdentity identityPeer, IntPtr pMsg, int cbMsg)
		{
		}
	}
}
