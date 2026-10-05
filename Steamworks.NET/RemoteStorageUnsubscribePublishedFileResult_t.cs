using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	[CallbackIdentity(1315)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		public const int k_iCallback = 1315;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
