using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	[CallbackIdentity(5213)]
	public struct RequestPlayersForGameFinalResultCallback_t
	{
		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		public const int k_iCallback = 5213;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ullSearchID;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ullUniqueGameID;
	}
}
