using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public struct CallbackMsg
	{
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		public int errorCode;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x4")]
		public int flag;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		public string type;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		public string scheme;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		public bool showReddot;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x19")]
		public bool showPopup;
	}
}
