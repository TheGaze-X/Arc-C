using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001316 RID: 4886
	[Token(Token = "0x2001316")]
	public class ShopCreditUnlockItem
	{
		// Token: 0x06007293 RID: 29331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007293")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopCreditUnlockItem()
		{
		}

		// Token: 0x04006C4A RID: 27722
		[Token(Token = "0x4006C4A")]
		[FieldOffset(Offset = "0x10")]
		public int sortId;

		// Token: 0x04006C4B RID: 27723
		[Token(Token = "0x4006C4B")]
		[FieldOffset(Offset = "0x14")]
		public int unlockNum;

		// Token: 0x04006C4C RID: 27724
		[Token(Token = "0x4006C4C")]
		[FieldOffset(Offset = "0x18")]
		public string charId;
	}
}
