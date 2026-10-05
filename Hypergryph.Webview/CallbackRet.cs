using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public struct CallbackRet
	{
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CallbackRet EMPTY;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x0")]
		public int code;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x8")]
		public CallbackMsg msg;
	}
}
