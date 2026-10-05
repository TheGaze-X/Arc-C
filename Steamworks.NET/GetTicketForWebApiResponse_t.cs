using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[CallbackIdentity(168)]
	public struct GetTicketForWebApiResponse_t
	{
		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		public const int k_iCallback = 168;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x0")]
		public HAuthTicket m_hAuthTicket;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x4")]
		public EResult m_eResult;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x8")]
		public int m_cubTicket;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x10")]
		public byte[] m_rgubTicket;
	}
}
