using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[CallbackIdentity(3412)]
	public struct AddUGCDependencyResult_t
	{
		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		public const int k_iCallback = 3412;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
