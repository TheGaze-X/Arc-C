using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	[CallbackIdentity(1222)]
	public struct SteamNetAuthenticationStatus_t
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x1700000A")]
		public string m_debugMsg
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x4EDDA70", Offset = "0x4EDC670", VA = "0x184EDDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x4EDDB50", Offset = "0x4EDC750", VA = "0x184EDDB50")]
			set
			{
			}
		}

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		public const int k_iCallback = 1222;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingAvailability m_eAvail;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_debugMsg_;
	}
}
