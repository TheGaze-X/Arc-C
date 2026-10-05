using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[CallbackIdentity(335)]
	public struct ClanOfficerListResponse_t
	{
		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		public const int k_iCallback = 335;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClan;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x8")]
		public int m_cOfficers;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xC")]
		public byte m_bSuccess;
	}
}
