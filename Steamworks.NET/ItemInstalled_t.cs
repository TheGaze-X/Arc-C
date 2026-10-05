using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[CallbackIdentity(3405)]
	public struct ItemInstalled_t
	{
		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		public const int k_iCallback = 3405;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x10")]
		public UGCHandle_t m_hLegacyContent;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x18")]
		public ulong m_unManifestID;
	}
}
