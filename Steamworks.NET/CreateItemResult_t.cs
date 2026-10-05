using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	[CallbackIdentity(3403)]
	public struct CreateItemResult_t
	{
		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		public const int k_iCallback = 3403;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
