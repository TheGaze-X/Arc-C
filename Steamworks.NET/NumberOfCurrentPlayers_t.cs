using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	[CallbackIdentity(1107)]
	public struct NumberOfCurrentPlayers_t
	{
		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		public const int k_iCallback = 1107;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x4")]
		public int m_cPlayers;
	}
}
