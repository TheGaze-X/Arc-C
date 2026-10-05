using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	[CallbackIdentity(5304)]
	public struct ChangeNumOpenSlotsCallback_t
	{
		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		public const int k_iCallback = 5304;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
