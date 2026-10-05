using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	public class VoucherGachaDetailResponse : PlayerDeltaResponse
	{
		// Token: 0x06006416 RID: 25622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006416")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public VoucherGachaDetailResponse()
		{
		}

		// Token: 0x0400306C RID: 12396
		[Token(Token = "0x400306C")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
