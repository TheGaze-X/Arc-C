using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	public class VoucherGachaDetailRequest
	{
		// Token: 0x06006415 RID: 25621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006415")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoucherGachaDetailRequest()
		{
		}

		// Token: 0x04003069 RID: 12393
		[Token(Token = "0x4003069")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x0400306A RID: 12394
		[Token(Token = "0x400306A")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x0400306B RID: 12395
		[Token(Token = "0x400306B")]
		[FieldOffset(Offset = "0x20")]
		public string charId;
	}
}
