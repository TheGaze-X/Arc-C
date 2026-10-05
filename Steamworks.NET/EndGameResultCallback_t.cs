using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	[CallbackIdentity(5215)]
	public struct EndGameResultCallback_t
	{
		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		public const int k_iCallback = 5215;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x8")]
		public ulong ullUniqueGameID;
	}
}
