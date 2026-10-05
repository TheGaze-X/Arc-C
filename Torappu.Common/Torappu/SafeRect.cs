using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Serializable]
	public struct SafeRect
	{
		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SafeRect EMPTY;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		public int left;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x4")]
		public int right;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x8")]
		public int top;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC")]
		public int bottom;
	}
}
