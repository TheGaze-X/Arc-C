using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[CallbackIdentity(103)]
	public struct SteamServersDisconnected_t
	{
		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		public const int k_iCallback = 103;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
