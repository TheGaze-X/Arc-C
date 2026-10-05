using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[CallbackIdentity(1328)]
	public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
	{
		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		public const int k_iCallback = 1328;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x4")]
		public EWorkshopFileAction m_eAction;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x8")]
		public int m_nResultsReturned;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0xC")]
		public int m_nTotalResultCount;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x18")]
		public uint[] m_rgRTimeUpdated;
	}
}
