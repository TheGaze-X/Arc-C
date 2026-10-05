using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[CallbackIdentity(143)]
	public struct ValidateAuthTicketResponse_t
	{
		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		public const int k_iCallback = 143;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x8")]
		public EAuthSessionResponse m_eAuthSessionResponse;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xC")]
		public CSteamID m_OwnerSteamID;
	}
}
