using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Bean
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public class OrderDetailBeen
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OrderDetailBeen()
		{
		}

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x10")]
		public bool Delivered;

		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		[FieldOffset(Offset = "0x11")]
		public bool FirstPurchase;

		// Token: 0x04000D0D RID: 3341
		[Token(Token = "0x4000D0D")]
		[FieldOffset(Offset = "0x18")]
		public string Level;

		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		[FieldOffset(Offset = "0x20")]
		public string Event;
	}
}
