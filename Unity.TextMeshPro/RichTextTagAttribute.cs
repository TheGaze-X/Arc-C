using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public struct RichTextTagAttribute
	{
		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x0")]
		public int nameHashCode;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x4")]
		public int valueHashCode;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x8")]
		public TagValueType valueType;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xC")]
		public int valueStartIndex;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x10")]
		public int valueLength;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x14")]
		public TagUnitType unitType;
	}
}
