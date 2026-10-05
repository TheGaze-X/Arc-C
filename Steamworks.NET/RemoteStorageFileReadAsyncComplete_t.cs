using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[CallbackIdentity(1332)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		public const int k_iCallback = 1332;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x0")]
		public SteamAPICall_t m_hFileReadAsync;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xC")]
		public uint m_nOffset;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x10")]
		public uint m_cubRead;
	}
}
