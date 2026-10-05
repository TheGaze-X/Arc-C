using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	[CallbackIdentity(1223)]
	public struct SteamNetworkingFakeIPResult_t
	{
		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		public const int k_iCallback = 1223;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x4")]
		public SteamNetworkingIdentity m_identity;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x8C")]
		public uint m_unIP;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x90")]
		public ushort[] m_unPorts;
	}
}
