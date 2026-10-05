using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[CallbackIdentity(5211)]
	public struct RequestPlayersForGameProgressCallback_t
	{
		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		public const int k_iCallback = 5211;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ullSearchID;
	}
}
