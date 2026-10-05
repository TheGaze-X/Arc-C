using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	public class NormalGachaRequest
	{
		// Token: 0x060063B7 RID: 25527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NormalGachaRequest()
		{
		}

		// Token: 0x04002FBC RID: 12220
		[Token(Token = "0x4002FBC")]
		[FieldOffset(Offset = "0x10")]
		public int slotId;

		// Token: 0x04002FBD RID: 12221
		[Token(Token = "0x4002FBD")]
		[FieldOffset(Offset = "0x18")]
		public int[] tagList;

		// Token: 0x04002FBE RID: 12222
		[Token(Token = "0x4002FBE")]
		[FieldOffset(Offset = "0x20")]
		public int specialTagId;

		// Token: 0x04002FBF RID: 12223
		[Token(Token = "0x4002FBF")]
		[FieldOffset(Offset = "0x28")]
		public long duration;
	}
}
