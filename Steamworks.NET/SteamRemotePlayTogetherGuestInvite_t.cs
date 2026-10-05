using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[CallbackIdentity(5703)]
	public struct SteamRemotePlayTogetherGuestInvite_t
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700000C")]
		public string m_szConnectURL
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x4EDDB70", Offset = "0x4EDC770", VA = "0x184EDDB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x4F0C7D0", Offset = "0x4F0B3D0", VA = "0x184F0C7D0")]
			set
			{
			}
		}

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		public const int k_iCallback = 5703;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_szConnectURL_;
	}
}
