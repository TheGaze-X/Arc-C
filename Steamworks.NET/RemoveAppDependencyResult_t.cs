using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[CallbackIdentity(3415)]
	public struct RemoveAppDependencyResult_t
	{
		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		public const int k_iCallback = 3415;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t m_nAppID;
	}
}
