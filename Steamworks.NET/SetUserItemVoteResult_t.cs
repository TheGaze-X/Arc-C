using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[CallbackIdentity(3408)]
	public struct SetUserItemVoteResult_t
	{
		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		public const int k_iCallback = 3408;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bVoteUp;
	}
}
