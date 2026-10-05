using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000870 RID: 2160
	[Token(Token = "0x2000870")]
	public class CashShopObject
	{
		// Token: 0x06006509 RID: 25865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006509")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CashShopObject()
		{
		}

		// Token: 0x040031DA RID: 12762
		[Token(Token = "0x40031DA")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040031DB RID: 12763
		[Token(Token = "0x40031DB")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x040031DC RID: 12764
		[Token(Token = "0x40031DC")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x040031DD RID: 12765
		[Token(Token = "0x40031DD")]
		[FieldOffset(Offset = "0x20")]
		public int doubleCount;

		// Token: 0x040031DE RID: 12766
		[Token(Token = "0x40031DE")]
		[FieldOffset(Offset = "0x24")]
		public int diamondNum;

		// Token: 0x040031DF RID: 12767
		[Token(Token = "0x40031DF")]
		[FieldOffset(Offset = "0x28")]
		public int plusNum;

		// Token: 0x040031E0 RID: 12768
		[Token(Token = "0x40031E0")]
		[FieldOffset(Offset = "0x30")]
		public string desc;
	}
}
