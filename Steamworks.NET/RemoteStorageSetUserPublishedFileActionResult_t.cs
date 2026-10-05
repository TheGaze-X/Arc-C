using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[CallbackIdentity(1327)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		public const int k_iCallback = 1327;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x10")]
		public EWorkshopFileAction m_eAction;
	}
}
