using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	[CallbackIdentity(1321)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		public const int k_iCallback = 1321;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}
