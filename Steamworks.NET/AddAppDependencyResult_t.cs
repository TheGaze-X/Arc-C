using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[CallbackIdentity(3414)]
	public struct AddAppDependencyResult_t
	{
		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		public const int k_iCallback = 3414;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;
	}
}
