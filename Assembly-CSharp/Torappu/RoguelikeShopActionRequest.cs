using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	public class RoguelikeShopActionRequest
	{
		// Token: 0x06006479 RID: 25721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006479")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeShopActionRequest()
		{
		}

		// Token: 0x0400310B RID: 12555
		[Token(Token = "0x400310B")]
		[FieldOffset(Offset = "0x10")]
		public List<string> buy;

		// Token: 0x0400310C RID: 12556
		[Token(Token = "0x400310C")]
		[FieldOffset(Offset = "0x18")]
		public List<string> recycle;

		// Token: 0x0400310D RID: 12557
		[Token(Token = "0x400310D")]
		[FieldOffset(Offset = "0x20")]
		public int leave;
	}
}
