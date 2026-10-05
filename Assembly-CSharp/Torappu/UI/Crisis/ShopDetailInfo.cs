using System;
using Il2CppDummyDll;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A10 RID: 23056
	[Token(Token = "0x2005A10")]
	public class ShopDetailInfo
	{
		// Token: 0x06021975 RID: 137589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021975")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopDetailInfo()
		{
		}

		// Token: 0x0402DE98 RID: 188056
		[Token(Token = "0x402DE98")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle item;

		// Token: 0x0402DE99 RID: 188057
		[Token(Token = "0x402DE99")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x0402DE9A RID: 188058
		[Token(Token = "0x402DE9A")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x0402DE9B RID: 188059
		[Token(Token = "0x402DE9B")]
		[FieldOffset(Offset = "0x20")]
		public bool isTimeLimit;
	}
}
