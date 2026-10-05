using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[CallbackIdentity(3416)]
	public struct GetAppDependenciesResult_t
	{
		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		public const int k_iCallback = 3416;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x8")]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x10")]
		public AppId_t[] m_rgAppIDs;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x18")]
		public uint m_nNumAppDependencies;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_nTotalNumAppDependencies;
	}
}
