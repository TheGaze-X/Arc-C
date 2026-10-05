using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[CallbackIdentity(1325)]
	public struct RemoteStorageUserVoteDetails_t
	{
		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		public const int k_iCallback = 1325;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x10")]
		public EWorkshopVote m_eVote;
	}
}
