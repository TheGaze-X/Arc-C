using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	[CallbackIdentity(510)]
	public struct LobbyMatchList_t
	{
		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		public const int k_iCallback = 510;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x0")]
		public uint m_nLobbiesMatching;
	}
}
