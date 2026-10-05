using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[CallbackIdentity(3413)]
	public struct RemoveUGCDependencyResult_t
	{
		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		public const int k_iCallback = 3413;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
