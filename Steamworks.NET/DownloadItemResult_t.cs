using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	[CallbackIdentity(3406)]
	public struct DownloadItemResult_t
	{
		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		public const int k_iCallback = 3406;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x10")]
		public EResult m_eResult;
	}
}
