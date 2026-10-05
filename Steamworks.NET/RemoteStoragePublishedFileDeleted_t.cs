using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[CallbackIdentity(1323)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		public const int k_iCallback = 1323;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}
