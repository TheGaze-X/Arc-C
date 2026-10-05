using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[CallbackIdentity(3417)]
	public struct DeleteItemResult_t
	{
		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		public const int k_iCallback = 3417;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
