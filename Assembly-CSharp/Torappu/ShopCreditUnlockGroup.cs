using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001317 RID: 4887
	[Token(Token = "0x2001317")]
	public class ShopCreditUnlockGroup
	{
		// Token: 0x06007294 RID: 29332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007294")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopCreditUnlockGroup()
		{
		}

		// Token: 0x04006C4D RID: 27725
		[Token(Token = "0x4006C4D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006C4E RID: 27726
		[Token(Token = "0x4006C4E")]
		[FieldOffset(Offset = "0x18")]
		public string index;

		// Token: 0x04006C4F RID: 27727
		[Token(Token = "0x4006C4F")]
		[FieldOffset(Offset = "0x20")]
		public long startDateTime;

		// Token: 0x04006C50 RID: 27728
		[Token(Token = "0x4006C50")]
		[FieldOffset(Offset = "0x28")]
		public List<ShopCreditUnlockItem> charDict;
	}
}
