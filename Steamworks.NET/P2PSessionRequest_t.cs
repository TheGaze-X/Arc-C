using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		public const int k_iCallback = 1202;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;
	}
}
