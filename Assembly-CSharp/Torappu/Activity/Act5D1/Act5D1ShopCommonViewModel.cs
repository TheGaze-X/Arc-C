using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200725D RID: 29277
	[Token(Token = "0x200725D")]
	public class Act5D1ShopCommonViewModel
	{
		// Token: 0x060297D0 RID: 169936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1ShopCommonViewModel()
		{
		}

		// Token: 0x0403B483 RID: 242819
		[Token(Token = "0x403B483")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0403B484 RID: 242820
		[Token(Token = "0x403B484")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle item;

		// Token: 0x0403B485 RID: 242821
		[Token(Token = "0x403B485")]
		[FieldOffset(Offset = "0x20")]
		public string displayName;

		// Token: 0x0403B486 RID: 242822
		[Token(Token = "0x403B486")]
		[FieldOffset(Offset = "0x28")]
		public int price;

		// Token: 0x0403B487 RID: 242823
		[Token(Token = "0x403B487")]
		[FieldOffset(Offset = "0x2C")]
		public int availRemainCount;

		// Token: 0x0403B488 RID: 242824
		[Token(Token = "0x403B488")]
		[FieldOffset(Offset = "0x30")]
		public int buyCount;

		// Token: 0x0403B489 RID: 242825
		[Token(Token = "0x403B489")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> buyHandler;
	}
}
