using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class UseMaterialVoucherResponse : PlayerDeltaResponse
	{
		// Token: 0x0600641C RID: 25628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public UseMaterialVoucherResponse()
		{
		}

		// Token: 0x04003074 RID: 12404
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> itemGet;
	}
}
