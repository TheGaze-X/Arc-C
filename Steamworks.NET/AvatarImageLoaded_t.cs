using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[CallbackIdentity(334)]
	public struct AvatarImageLoaded_t
	{
		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		public const int k_iCallback = 334;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamID;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x8")]
		public int m_iImage;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xC")]
		public int m_iWide;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		public int m_iTall;
	}
}
