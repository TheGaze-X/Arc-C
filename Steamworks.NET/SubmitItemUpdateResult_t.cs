using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	[CallbackIdentity(3404)]
	public struct SubmitItemUpdateResult_t
	{
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		public const int k_iCallback = 3404;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x4")]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
