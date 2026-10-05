using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000794 RID: 1940
	[Token(Token = "0x2000794")]
	public class UseOptionalVoucherResponse : PlayerDeltaResponse
	{
		// Token: 0x06006414 RID: 25620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006414")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public UseOptionalVoucherResponse()
		{
		}

		// Token: 0x04003068 RID: 12392
		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> itemGet;
	}
}
