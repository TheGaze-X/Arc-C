using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[CallbackIdentity(1326)]
	public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
	{
		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		public const int k_iCallback = 1326;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;
	}
}
