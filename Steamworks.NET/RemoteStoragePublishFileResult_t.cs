using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[CallbackIdentity(1309)]
	public struct RemoteStoragePublishFileResult_t
	{
		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		public const int k_iCallback = 1309;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
