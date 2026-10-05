using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	[CallbackIdentity(1313)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		public const int k_iCallback = 1313;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
