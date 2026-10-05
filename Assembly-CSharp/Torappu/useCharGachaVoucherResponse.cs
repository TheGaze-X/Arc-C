using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public class useCharGachaVoucherResponse : PlayerDeltaResponse
	{
		// Token: 0x0600641E RID: 25630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public useCharGachaVoucherResponse()
		{
		}

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x28")]
		public List<GachaResult> charGet;
	}
}
