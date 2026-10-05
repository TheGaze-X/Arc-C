using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[CallbackIdentity(1023)]
	public struct FileDetailsResult_t
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		public const int k_iCallback = 1023;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulFileSize;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		public byte[] m_FileSHA;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public uint m_unFlags;
	}
}
