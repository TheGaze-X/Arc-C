using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[CallbackIdentity(3409)]
	public struct GetUserItemVoteResult_t
	{
		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		public const int k_iCallback = 3409;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bVotedUp;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0xD")]
		public bool m_bVotedDown;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0xE")]
		public bool m_bVoteSkipped;
	}
}
