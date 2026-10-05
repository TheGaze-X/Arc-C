using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[CallbackIdentity(1322)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		public const int k_iCallback = 1322;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}
