using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[CallbackIdentity(1324)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		public const int k_iCallback = 1324;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
