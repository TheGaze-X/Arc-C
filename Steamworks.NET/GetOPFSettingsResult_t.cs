using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[CallbackIdentity(4624)]
	public struct GetOPFSettingsResult_t
	{
		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		public const int k_iCallback = 4624;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;
	}
}
