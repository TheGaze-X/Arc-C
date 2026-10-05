using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	internal ref struct DTSubString
	{
		// Token: 0x17000093 RID: 147
		[Token(Token = "0x17000093")]
		internal char this[int relativeIndex]
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x4CC54D0", Offset = "0x4CC40D0", VA = "0x184CC54D0")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x0")]
		internal System.ReadOnlySpan<char> s;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x10")]
		internal int index;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x14")]
		internal int length;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x18")]
		internal DTSubStringType type;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x1C")]
		internal int value;
	}
}
