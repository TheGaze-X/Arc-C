using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200125D RID: 4701
	[Token(Token = "0x200125D")]
	public class RoguelikeCommonDevRawTextBuffGroup
	{
		// Token: 0x060071D2 RID: 29138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCommonDevRawTextBuffGroup()
		{
		}

		// Token: 0x040067B6 RID: 26550
		[Token(Token = "0x40067B6")]
		[FieldOffset(Offset = "0x10")]
		public List<string> nodeIdList;

		// Token: 0x040067B7 RID: 26551
		[Token(Token = "0x40067B7")]
		[FieldOffset(Offset = "0x18")]
		public string groupIconId;

		// Token: 0x040067B8 RID: 26552
		[Token(Token = "0x40067B8")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;
	}
}
