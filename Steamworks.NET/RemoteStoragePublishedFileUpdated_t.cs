using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[CallbackIdentity(1330)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		public const int k_iCallback = 1330;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulUnused;
	}
}
