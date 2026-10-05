using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[CallbackIdentity(5214)]
	public struct SubmitPlayerResultResultCallback_t
	{
		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		public const int k_iCallback = 5214;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x8")]
		public ulong ullUniqueGameID;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID steamIDPlayer;
	}
}
