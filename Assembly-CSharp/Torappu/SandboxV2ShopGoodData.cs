using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012C7 RID: 4807
	[Token(Token = "0x20012C7")]
	public class SandboxV2ShopGoodData
	{
		// Token: 0x06007240 RID: 29248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007240")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ShopGoodData()
		{
		}

		// Token: 0x04006A33 RID: 27187
		[Token(Token = "0x4006A33")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04006A34 RID: 27188
		[Token(Token = "0x4006A34")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04006A35 RID: 27189
		[Token(Token = "0x4006A35")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04006A36 RID: 27190
		[Token(Token = "0x4006A36")]
		[FieldOffset(Offset = "0x24")]
		public SandboxV2CoinType coinType;

		// Token: 0x04006A37 RID: 27191
		[Token(Token = "0x4006A37")]
		[FieldOffset(Offset = "0x28")]
		public int value;
	}
}
