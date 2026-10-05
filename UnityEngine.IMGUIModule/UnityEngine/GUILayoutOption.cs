using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public sealed class GUILayoutOption
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		internal GUILayoutOption(GUILayoutOption.Type type, object value)
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		internal GUILayoutOption.Type type;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		internal object value;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		internal enum Type
		{
			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			fixedWidth,
			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			fixedHeight,
			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			minWidth,
			// Token: 0x04000067 RID: 103
			[Token(Token = "0x4000067")]
			maxWidth,
			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4000068")]
			minHeight,
			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			maxHeight,
			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			stretchWidth,
			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400006B")]
			stretchHeight,
			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			alignStart,
			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			alignMiddle,
			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			alignEnd,
			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			alignJustify,
			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			equalSize,
			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			spacing
		}
	}
}
