using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	internal struct LinkInfo
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x59F29B0", Offset = "0x59F15B0", VA = "0x1859F29B0")]
		internal void SetLinkId(char[] text, int startIndex, int length)
		{
		}

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x0")]
		public int hashCode;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x4")]
		public int linkIdFirstCharacterIndex;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x8")]
		public int linkIdLength;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xC")]
		public int linkTextfirstCharacterIndex;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		public int linkTextLength;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		internal char[] linkId;
	}
}
