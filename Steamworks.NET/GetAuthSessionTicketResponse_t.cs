using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[CallbackIdentity(163)]
	public struct GetAuthSessionTicketResponse_t
	{
		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		public const int k_iCallback = 163;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_eResult;
	}
}
