using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	[Serializable]
	public struct ISteamNetworkingConnectionSignaling
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00009494 File Offset: 0x00007694
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x4EE0970", Offset = "0x4EDF570", VA = "0x184EE0970")]
		public bool SendSignal(HSteamNetConnection hConn, ref SteamNetConnectionInfo_t info, IntPtr pMsg, int cbMsg)
		{
			return default(bool);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x4EE08F0", Offset = "0x4EDF4F0", VA = "0x184EE08F0")]
		public void Release()
		{
		}
	}
}
