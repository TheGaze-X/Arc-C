using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200721D RID: 29213
	[Token(Token = "0x200721D")]
	public class Act5D1ProgressGoodItem
	{
		// Token: 0x06029698 RID: 169624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029698")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5D1ProgressGoodItem()
		{
		}

		// Token: 0x0403B240 RID: 242240
		[Token(Token = "0x403B240")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x0403B241 RID: 242241
		[Token(Token = "0x403B241")]
		[FieldOffset(Offset = "0x14")]
		public int price;

		// Token: 0x0403B242 RID: 242242
		[Token(Token = "0x403B242")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x0403B243 RID: 242243
		[Token(Token = "0x403B243")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;
	}
}
