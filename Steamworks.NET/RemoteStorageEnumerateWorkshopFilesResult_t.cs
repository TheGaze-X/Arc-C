using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[CallbackIdentity(1319)]
	public struct RemoteStorageEnumerateWorkshopFilesResult_t
	{
		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		public const int k_iCallback = 1319;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x4")]
		public int m_nResultsReturned;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x8")]
		public int m_nTotalResultCount;

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x10")]
		public PublishedFileId_t[] m_rgPublishedFileId;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x18")]
		public float[] m_rgScore;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x20")]
		public AppId_t m_nAppId;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x24")]
		public uint m_unStartIndex;
	}
}
