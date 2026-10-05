using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[CallbackIdentity(1311)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		public const int k_iCallback = 1311;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
