using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[CallbackIdentity(3407)]
	public struct UserFavoriteItemsListChanged_t
	{
		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		public const int k_iCallback = 3407;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bWasAddRequest;
	}
}
