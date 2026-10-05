using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class SkuDetailRet
	{
		// Token: 0x06000245 RID: 581 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SkuDetailRet()
		{
		}

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x10")]
		public int R_CODE;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x18")]
		public string R_MSG;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x20")]
		public List<SKU> SKUS;
	}
}
