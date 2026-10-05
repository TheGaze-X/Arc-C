using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	[CallbackIdentity(1320)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		public const int k_iCallback = 1320;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_unPublishedFileId;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x10")]
		public int m_nVotesFor;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x14")]
		public int m_nVotesAgainst;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x18")]
		public int m_nReports;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x1C")]
		public float m_fScore;
	}
}
