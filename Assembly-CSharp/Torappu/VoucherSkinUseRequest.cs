using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008DF RID: 2271
	[Token(Token = "0x20008DF")]
	public class VoucherSkinUseRequest
	{
		// Token: 0x06006594 RID: 26004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006594")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoucherSkinUseRequest()
		{
		}

		// Token: 0x040032F0 RID: 13040
		[Token(Token = "0x40032F0")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040032F1 RID: 13041
		[Token(Token = "0x40032F1")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x040032F2 RID: 13042
		[Token(Token = "0x40032F2")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x040032F3 RID: 13043
		[Token(Token = "0x40032F3")]
		[FieldOffset(Offset = "0x28")]
		public int instId;
	}
}
