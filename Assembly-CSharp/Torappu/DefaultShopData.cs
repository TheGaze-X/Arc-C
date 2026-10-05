using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E0C RID: 3596
	[Token(Token = "0x2000E0C")]
	public class DefaultShopData
	{
		// Token: 0x06006ADF RID: 27359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultShopData()
		{
		}

		// Token: 0x04004AED RID: 19181
		[Token(Token = "0x4004AED")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04004AEE RID: 19182
		[Token(Token = "0x4004AEE")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x04004AEF RID: 19183
		[Token(Token = "0x4004AEF")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x04004AF0 RID: 19184
		[Token(Token = "0x4004AF0")]
		[FieldOffset(Offset = "0x20")]
		public int availCount;

		// Token: 0x04004AF1 RID: 19185
		[Token(Token = "0x4004AF1")]
		[FieldOffset(Offset = "0x28")]
		public string overrideName;

		// Token: 0x04004AF2 RID: 19186
		[Token(Token = "0x4004AF2")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;
	}
}
