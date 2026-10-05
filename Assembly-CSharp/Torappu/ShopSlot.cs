using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000861 RID: 2145
	[Token(Token = "0x2000861")]
	public class ShopSlot
	{
		// Token: 0x060064F7 RID: 25847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopSlot()
		{
		}

		// Token: 0x04003174 RID: 12660
		[Token(Token = "0x4003174")]
		[FieldOffset(Offset = "0x10")]
		public int price;

		// Token: 0x04003175 RID: 12661
		[Token(Token = "0x4003175")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04003176 RID: 12662
		[Token(Token = "0x4003176")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;
	}
}
