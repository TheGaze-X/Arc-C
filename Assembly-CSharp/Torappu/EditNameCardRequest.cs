using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	public class EditNameCardRequest
	{
		// Token: 0x060063A6 RID: 25510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063A6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EditNameCardRequest()
		{
		}

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x10")]
		public EditNameCardFlag flag;

		// Token: 0x04002FAF RID: 12207
		[Token(Token = "0x4002FAF")]
		[FieldOffset(Offset = "0x18")]
		public EditNameCardContent content;
	}
}
