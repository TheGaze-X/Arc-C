using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AFE RID: 23294
	[Token(Token = "0x2005AFE")]
	public class EPGSViewModel
	{
		// Token: 0x06021D9A RID: 138650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D9A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EPGSViewModel()
		{
		}

		// Token: 0x0402E5D2 RID: 189906
		[Token(Token = "0x402E5D2")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0402E5D3 RID: 189907
		[Token(Token = "0x402E5D3")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x0402E5D4 RID: 189908
		[Token(Token = "0x402E5D4")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x0402E5D5 RID: 189909
		[Token(Token = "0x402E5D5")]
		[FieldOffset(Offset = "0x28")]
		public int availCount;

		// Token: 0x0402E5D6 RID: 189910
		[Token(Token = "0x402E5D6")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;

		// Token: 0x0402E5D7 RID: 189911
		[Token(Token = "0x402E5D7")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x0402E5D8 RID: 189912
		[Token(Token = "0x402E5D8")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;

		// Token: 0x0402E5D9 RID: 189913
		[Token(Token = "0x402E5D9")]
		[FieldOffset(Offset = "0x40")]
		public int buyCount;
	}
}
