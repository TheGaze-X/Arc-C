using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	[CallbackIdentity(1316)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		public const int k_iCallback = 1316;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
